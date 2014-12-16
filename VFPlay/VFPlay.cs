using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Configuration;
using System.Threading;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace VFPlay
{
    public partial class VFPlay : Form
    {
        #region SettingForm
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        #endregion SettingForm

        private string DownloadUrl = "http://vfire-core.com/update/";
        private int startID = 0;
        private int endID = 0;
        private int currID = 0;
        private string PATH = Application.StartupPath;
        private string Command = String.Empty;
        Thread checkThread;
        List<DataType> MD5Sum = new List<DataType>();
        private string extractPath;
        private bool IsNeedExtract = false;

        public VFPlay()
        {
            InitializeComponent();
            ShowInfo("Checking update ... ");
            //checkThread = new Thread(CheckBindVersion);
            checkThread = new Thread(CheckMD5Version);
            checkThread.Start();
        }

        private void Exit()
        {
            if(checkThread != null)
                checkThread.Abort();
            Application.Exit();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
            base.OnMouseDown(e);
        }

        private void ShowInfo(string str)
        {
            lb_showinfo.Text = str;
        }

        public void CheckMD5Version()
        {
            using (WebClient wcDownload = new WebClient())
            {
                try
                {
                    string BSRequest = DownloadUrl + "BindSetting.ini";
                    string BSVer = wcDownload.DownloadString(BSRequest);
                    if (Convert.ToInt32(BSVer) == 1)
                    {
                        ClientConfig.BindIP = "vfire-sys.myvnc.com";
                        ClientConfig.WoWIP = "vfire-wow.myvnc.com";
                        ClientConfig.AionIP = "vfire-aion.myvnc.com";
                        ClientConfig.WriteClientConfig();
                    }
                    else if (Convert.ToInt32(BSVer) == 2)
                    {
                        ClientConfig.BindIP = "vfire-bsys.myvnc.com";
                        ClientConfig.WoWIP = "vfire-bwow.myvnc.com";
                        ClientConfig.AionIP = "vfire-baion.myvnc.com";
                        ClientConfig.WriteClientConfig();
                    }
                }
                catch
                {
                    ShowInfo("Update Error! Please contact to Admin.");
                    Thread.Sleep(2000);
                    Application.Exit();
                }
            }

            string SumRequest = DownloadUrl + "CheckSum.ini";
            try
            {
                StreamReader reader = new StreamReader(WebRequest.Create(SumRequest).GetResponse().GetResponseStream());
                string line;
                int linenum = 0;
                int fcount = 0;
                int scount = 0;
                DataType data = new DataType();
                while ((line = reader.ReadLine()) != null)
                {
                    linenum += 1;
                    if (linenum % 2 == 1)
                    {
                        data.Path = line;
                    }
                    else if (linenum % 2 == 0)
                    {
                        data.MD5 = line;
                        scount += 1;
                    }
                    if (scount != fcount)
                    {
                        fcount = scount;
                        MD5Sum.Add(data);
                        data = new DataType();
                    }
                }

                for(int i = 0; i < MD5Sum.Count; i++)
                {
                    string lin = "C : " + i.ToString() + " || " + MD5Sum[i].Path + " || " + MD5Sum[i].MD5;
                    Console.WriteLine(lin);
                }

                if (currID < MD5Sum.Count)
                {
                    CheckSumFunction();
                }
            }
            catch(Exception e)
            {
                ShowInfo("Update Error! Please contact to Admin.");
                //ShowInfo(e.Message);
                Thread.Sleep(2000);
                Application.Exit();
            }
        }

        public void CheckNextFile()
        {
            currID += 1;
            if (currID < MD5Sum.Count)
            {
                CheckSumFunction();
            }
            else
            {
                StartLauncher();
            }
        }

        public void DownloadMD5File(string fpath)
        {
            using (WebClient wcDownload = new WebClient())
            {
                try
                {
                    string fdown = DownloadUrl + "base/" + fpath;
                    Uri uri = new Uri(fdown);
                    ShowInfo("Downloading " + fpath);
                    wcDownload.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFileCompletedCallback);
                    wcDownload.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCallback);
                    wcDownload.DownloadFileAsync(uri, "./" + fpath);
                }
                catch
                {
                    ShowInfo("Update Error! Please contact to Admin.");
                    Thread.Sleep(2000);
                    Application.Exit();
                }
            }
        }
        
        private void btn_close_Click(object sender, EventArgs e)
        {
            Exit();
        }
        
        public void StartLauncher()
        {
            if(File.Exists("./VFLauncher.dat"))
            {
                ShowInfo("Check update successful!");
                Command = "start VFLauncher.dat";
                int exitCode;
                ProcessStartInfo processInfo;
                Process process;

                processInfo = new ProcessStartInfo("cmd.exe", "/c " + Command);
                processInfo.CreateNoWindow = true;
                processInfo.UseShellExecute = false;
                processInfo.RedirectStandardError = true;
                processInfo.RedirectStandardOutput = true;
                process = Process.Start(processInfo);
                Thread.Sleep(1000);
                exitCode = process.ExitCode;
                process.Close();
                Thread.Sleep(200);
                Application.Exit();
            }
            else
            {
                ShowInfo("Error: Missing VFLauncher.bin!");
                Thread.Sleep(3000);
                Application.Exit();
            }
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());

            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString()); //stays at -1
            lb_download.Text = Convert.ToString(totalBytes / 1024) + " KB";

            double percentage = bytesIn / totalBytes * 100;

            pb_bindupdate.Value = int.Parse(Math.Truncate(percentage).ToString());
        }
		
		private void DownloadProgressCallback(object sender, DownloadProgressChangedEventArgs e)
		{
            string str = ((float)((float)e.BytesReceived / 1024.0f)).ToString("0.0") + "/" + ((float)((float)e.TotalBytesToReceive / 1024.0f)).ToString("0.0") + " KB";
            lb_download.Text = str;
            pb_bindupdate.Value = e.ProgressPercentage;
		}

        private void DownloadFileCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            currID += 1;
            if(currID < MD5Sum.Count)
            {
                CheckSumFunction();
            }
            else
            {
                StartLauncher();
            }
        }

        private void CheckSumFunction()
        {
            string fpath = "./" + MD5Sum[currID].Path;
            Console.WriteLine(fpath);
            if (MD5Sum[currID].MD5 == "MKDIR")
            {
                string mkdir = @"" + PATH + "\\" + MD5Sum[currID].Path;
                if (!Directory.Exists(mkdir))
                {
                    DirectoryInfo dir = Directory.CreateDirectory(mkdir);
                    CheckNextFile();
                }
                else
                    CheckNextFile();
            }
            else if(MD5Sum[currID].MD5 == "DELDIR")
            {
                string deldir = @"" + PATH + "\\" + MD5Sum[currID].Path;
                if (Directory.Exists(deldir))
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(deldir);
                    foreach (FileInfo file in dirInfo.GetFiles())
                    {
                        file.Delete();
                    }
                    foreach (DirectoryInfo dir in dirInfo.GetDirectories())
                    {
                        dir.Delete(true);
                    }
                    Directory.Delete(deldir);
                    CheckNextFile();
                }
                else
                    CheckNextFile();
            }
            else if (MD5Sum[currID].MD5 == "DELFILE")
            {
                string delfile = @"" + PATH + "\\" + MD5Sum[currID].Path;
                if (File.Exists(delfile))
                {
                    File.Delete(delfile);
                    CheckNextFile();
                }
                else
                    CheckNextFile();
            }
            else
            {
                if (!File.Exists(fpath))
                    DownloadMD5File(MD5Sum[currID].Path);
                else
                {
                    using (var md5 = MD5.Create())
                    {
                        string localstr = String.Empty;
                        using (var stream = File.OpenRead(fpath))
                        {
                            localstr = Convert.ToBase64String(md5.ComputeHash(stream));
                        }
                        if (localstr != MD5Sum[currID].MD5)
                        {
                            Console.WriteLine("Del " + fpath);
                            File.Delete(fpath);
                            DownloadMD5File(MD5Sum[currID].Path);
                        }
                        else
                            CheckNextFile();
                    }
                }
            }
        }

    }
}
