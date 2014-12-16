using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using Data;
using Network;
using Packets;
using Configuration;
using Utilities;
using Ionic.Zip;

namespace VFLauncher
{
    public partial class MainForm : Form
    {
        #region SettingForm
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        Point mousePos;
        #endregion SettingForm

        #region ButtonMgr
        public bool Btn_WoW_Select = true;
        public bool Btn_Aion_Select = false;
        #endregion ButtonMgr

        #region WindowSetting
        public ChatForm chatForm;
        public ConfirmForm confirmForm;
        public InfoForm infoForm;
        private bool confirmCreate = false;
        private bool IsChatFormOpen = false;
        private bool IsInfoFormOpen = false;
        #endregion WindowSetting

        Thread wowThread;
        Thread aionThread;
        Stopwatch sw = new Stopwatch();
        private bool IsOnline = false;

        #region GameSetting
        private string PATH = Application.StartupPath;
        private bool GameStarted = false;
        private int ClientVersion = 0;
        private string RunWoW = "./Wow.exe";
        private string RunWoWCheck = "./Data/enGB/realmlist.wtf";
        private string RunAion = "./bin32/aion.bin";
        private string RunAionCheck = "./SystemOptionGraphics.cfg";
        private string AionCommand = String.Empty;
        private string UpdateAddress = "http://vfire-core.com/update/";
        private int currID = 0;
        private string SumFile = String.Empty;
        private List<DataType> MD5Sum;
        private int IsNeedUpdate = 0;
        private Thread checkThread;
        #endregion GameSetting

        public MainForm()
        {
            InitializeComponent();
        }

        public void DebugInfo(string str)
        {
            lb_username.Text = str;
        }

        private void MyExtract(string FUnzip)
        {
            string zipToUnpack = PATH + "\\" + FUnzip;
            string unpackDirectory = PATH;
            using (ZipFile zip1 = ZipFile.Read(zipToUnpack))
            {
                foreach (ZipEntry e in zip1)
                {
                    e.Extract(unpackDirectory, ExtractExistingFileAction.OverwriteSilently);
                }
            }
        }

        public void LoadInfo()
        {
            lb_username.Text = NetClient.Instance.Account.Name + " # " + NetClient.Instance.Account.Id;
            lb_gold_info.Text = NetClient.Instance.Account.DonatePoint + " VFCoin";
            lb_ip_info.Text = NetClient.Instance.Account.IP;
            if (NetClient.Instance.Account.GMLevel == 0)
            {
                lb_managerank.ForeColor = Color.White;
                lb_managerank.Text = "Member";
            }
            else if (NetClient.Instance.Account.GMLevel == 1)
            {
                lb_managerank.ForeColor = Color.Green;
                lb_managerank.Text = "Supporter";
            }
            else if (NetClient.Instance.Account.GMLevel == 2)
            {
                lb_managerank.ForeColor = Color.DodgerBlue;
                lb_managerank.Text = "Game Master";
            }
            else if (NetClient.Instance.Account.GMLevel == 3)
            {
                lb_managerank.ForeColor = Color.Red;
                lb_managerank.Text = "Administrator";
            }
            // Show Email Address
            lb_emailaddress.Text = NetClient.Instance.Account.Email;
        }

        public void LoadBtn()
        {
            GameStarted = false;
            if(Btn_WoW_Select == true)
            {
                
                btn_wow.BackgroundImage = Properties.Resources.WoWIcon_01_Click;
                btn_aion.BackgroundImage = Properties.Resources.AionIcon_01_Nomal;
                this.BackgroundImage = Properties.Resources.WoWBG_01;
                if (NetClient.Instance.Account.IsWoWActive == true)
                {
                    btn_activatenow.Visible = false;
                    lb_activegame.Visible = true;
                    lb_activegame.Text = "Activated";
                } else {
                    lb_activegame.Visible = false;
                    btn_activatenow.Visible = true;
                }
                    
                lb_serverstatus.ForeColor = Color.Gray;
                lb_serverstatus.Text = "Checking...";
                
                if(aionThread != null)
                {
                    aionThread.Abort();
                }
                wowThread = new Thread(CheckWoWStatus);
                wowThread.Start();
                // Button Start Game / Update
                IsNeedUpdate = 0;
                lb_download.Text = "";
                ShowUpdate("Checking update...");
                pb_update.Value = 0;
                if(Directory.Exists("./Data/enUS") == true)
                {
                    RunWoWCheck = "./Data/enUS/realmlist.wtf";
                    ClientVersion = 1;
                }
                if(File.Exists(RunWoWCheck))
                {
                    if(ClientVersion == 0)
                        SumFile = "CheckSumWoW.ini";
                    else if(ClientVersion == 1)
                        SumFile = "CheckSumWoWUS.ini";
                    currID = 0;
                    checkThread = new Thread(CheckSum);
                    checkThread.Start();
                }
                else
                {
                    ShowUpdate("Can't find Game Path!");
                    pb_update.Value = 0;
                    btn_start.BackgroundImage = Properties.Resources.Btn_Start_Normal;
                }
            }
            else if(Btn_Aion_Select == true)
            {
                btn_wow.BackgroundImage = Properties.Resources.WoWIcon_01_Nomal;
                btn_aion.BackgroundImage = Properties.Resources.AionIcon_01_Click;
                this.BackgroundImage = Properties.Resources.AionBG_01;
                if (NetClient.Instance.Account.IsAionActive == true)
                {
                    btn_activatenow.Visible = false;
                    lb_activegame.Visible = true;
                    lb_activegame.Text = "Activated";
                } else {
                    lb_activegame.Visible = false;
                    btn_activatenow.Visible = true;
                }
                lb_serverstatus.ForeColor = Color.Gray;
                lb_serverstatus.Text = "Checking...";
                
                if(wowThread != null)
                {
                    wowThread.Abort();
                }
                aionThread = new Thread(CheckAionStatus);
                aionThread.Start();
                // Button Start Game / Update
                IsNeedUpdate = 0;
                lb_download.Text = "";
                ShowUpdate("Checking update...");
                pb_update.Value = 0;
                if (File.Exists(RunAionCheck))
                {
                    SumFile = "CheckSumAion.ini";
                    currID = 0;
                    checkThread = new Thread(CheckSum);
                    checkThread.Start();
                }
                else
                {
                    ShowUpdate("Can't find Game Path!");
                    pb_update.Value = 0;
                    btn_start.BackgroundImage = Properties.Resources.Btn_Start_Normal;
                }
            }
        }

        private void CheckWoWRun()
        {
            if (!File.Exists(RunWoW))
            {
                ShowUpdate("Can't find Game Path!");
                pb_update.Value = 0;
                btn_start.BackgroundImage = Properties.Resources.Btn_Start_Normal;
            }
        }

        private void CheckAionRun()
        {
            if(!File.Exists(RunAion))
            {
                ShowUpdate("Can't find Game Path!");
                pb_update.Value = 0;
                btn_start.BackgroundImage = Properties.Resources.Btn_Start_Normal;
            }
        }

        private void CheckSum()
        {
            string SumRequest = UpdateAddress + SumFile;
            MD5Sum = new List<DataType>();
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
                    string fpath = "./" + MD5Sum[i].Path;
                    if (MD5Sum[i].MD5 == "MKDIR")
                    {
                        string mkdir = @"" + PATH + "\\" + MD5Sum[i].Path;
                        if (!Directory.Exists(mkdir))
                        {
                            IsNeedUpdate = 1;
                            ChangeNeedUpdate();
                            return;
                        }
                        else
                        { }
                    }
                    else if (MD5Sum[i].MD5 == "DELDIR")
                    {
                        string deldir = @"" + PATH + "\\" + MD5Sum[i].Path;
                        if (Directory.Exists(deldir))
                        {
                            IsNeedUpdate = 1;
                            ChangeNeedUpdate();
                            return;
                        }
                        else
                        { }
                    }
                    else if (MD5Sum[i].MD5 == "DELFILE")
                    {
                        string delfile = @"" + PATH + "\\" + MD5Sum[i].Path;
                        if (File.Exists(delfile))
                        {
                            IsNeedUpdate = 1;
                            ChangeNeedUpdate();
                            return;
                        }
                        else
                        { }
                    }
                    else
                    {
                        if (MD5Sum[i].Path.Contains(".") == true && MD5Sum[i].MD5 != "DELFILE")
                        {
                            if (!File.Exists(fpath))
                            {
                                IsNeedUpdate = 1;
                                ChangeNeedUpdate();
                                return;
                            }
                            else
                            {
                                using (var md5 = MD5.Create())
                                {
                                    using (var stream = File.OpenRead(fpath))
                                    {
                                        string localstr = Convert.ToBase64String(md5.ComputeHash(stream));
                                        if (localstr != MD5Sum[i].MD5)
                                        {
                                            IsNeedUpdate = 1;
                                            ChangeNeedUpdate();
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                ChangeNeedUpdate();
            }
            catch
            {
                ShowUpdate("Checking update failed. Contact to Admin!");
            }
        }

        private void ChangeNeedUpdate()
        {
            if (IsNeedUpdate == 1)
            {
                ShowUpdate("You're have some update packet!");
                pb_update.Value = 0;
                btn_start.BackgroundImage = Properties.Resources.Btn_Update_Normal;
            }
            else
            {
                IsNeedUpdate = 2;
                if (Btn_WoW_Select == true)
                    ShowUpdate("WoW Client has up to date!");
                else if (Btn_Aion_Select == true)
                    ShowUpdate("Aion Client has up to date!");
                pb_update.Value = 100;
                btn_start.BackgroundImage = Properties.Resources.Btn_Start_Normal;
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
                IsNeedUpdate = 2;
                if (Btn_WoW_Select == true)
                {
                    ShowUpdate("WoW Client has up to date!");
                    CheckWoWRun();
                }
                else if (Btn_Aion_Select == true)
                {
                    ShowUpdate("Aion Client has up to date!");
                    CheckAionRun();
                }
                pb_update.Value = 100;
                btn_start.BackgroundImage = Properties.Resources.Btn_Start_Normal;
            }
        }

        public void DownloadMD5File(string fpath)
        {
            using (WebClient wcDownload = new WebClient())
            {
                try
                {

                    string fdown = String.Empty;
                    if(Btn_WoW_Select == true)
                    {
                        if(ClientVersion == 0)
                            fdown = UpdateAddress + "/wow/" + fpath;
                        else if (ClientVersion == 1)
                            fdown = UpdateAddress + "/wowUS/" + fpath;
                    }
                    else if(Btn_Aion_Select == true)
                        fdown = UpdateAddress + "/aion/" + fpath;
                    Uri uri = new Uri(fdown);
                    //ShowInfo("Downloading " + fpath);
                    wcDownload.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFileCompletedCallback);
                    wcDownload.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCallback);
                    wcDownload.DownloadFileAsync(uri, "./" + fpath);
                }
                catch
                {
                    ShowUpdate("Download update failed. Contact to Admin!");
                }
            }
        }

        private void CheckWoWStatus()
        {
            IsOnline = false;
            try
            {
                TcpClient tcpClient = new TcpClientWithTimeout(ClientConfig.WoWIP, ClientConfig.WoWPort, 800).Connect();
                if (tcpClient.Connected)
                    IsOnline = true;
            } catch { }
            if (IsOnline == true){
                lb_serverstatus.ForeColor = Color.GreenYellow;
                lb_serverstatus.Text = "[ONLINE]";
            } else {
                lb_serverstatus.ForeColor = Color.Red;
                lb_serverstatus.Text = "[OFFLINE]";
            }
        }

        private void CheckAionStatus()
        {
            IsOnline = false;
            try
            {
                TcpClient tcpClient = new TcpClientWithTimeout(ClientConfig.AionIP, ClientConfig.AionPort, 800).Connect();
                if (tcpClient.Connected == true)
                    IsOnline = true;
            } catch { }
            if (IsOnline == true){
                lb_serverstatus.ForeColor = Color.GreenYellow;
                lb_serverstatus.Text = "[ONLINE]";
            } else {
                lb_serverstatus.ForeColor = Color.Red;
                lb_serverstatus.Text = "[OFFLINE]";
            }
        }

        public void ShowUpdate(string str)
        {
            lb_update.Text = str;
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

        private void btn_wow_Click(object sender, EventArgs e)
        {
            Btn_WoW_Select = true;
            Btn_Aion_Select = false;
            LoadBtn();
            if (confirmForm != null && confirmForm.Visible == true)
                confirmForm.Hide();
            if (infoForm != null && infoForm.Visible == true)
                infoForm.Hide();
        }

        private void btn_wow_HoverStart(object sender, EventArgs e)
        {
            if(Btn_WoW_Select == false)
                btn_wow.BackgroundImage = Properties.Resources.WoWIcon_01_Hover;
        }

        private void btn_wow_HoverEnd(object sender, EventArgs e)
        {
            if (Btn_WoW_Select == false)
                btn_wow.BackgroundImage = Properties.Resources.WoWIcon_01_Nomal;
        }

        private void btn_aion_Click(object sender, EventArgs e)
        {
            Btn_WoW_Select = false;
            Btn_Aion_Select = true;
            LoadBtn();
            if (confirmForm != null && confirmForm.Visible == true)
                confirmForm.Hide();
            if (infoForm != null && infoForm.Visible == true)
                infoForm.Hide();
        }

        private void btn_aion_HoverStart(object sender, EventArgs e)
        {
            if (Btn_Aion_Select == false)
                btn_aion.BackgroundImage = Properties.Resources.AionIcon_01_Hover;
        }

        private void btn_aion_HoverEnd(object sender, EventArgs e)
        {
            if (Btn_Aion_Select == false)
                btn_aion.BackgroundImage = Properties.Resources.AionIcon_01_Nomal;
        }

        private void btn_click(object sender, EventArgs e)
        {
            //btn_wow.BackgroundImage = Properties.Resources.WoWIcon_01_Nomal;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            NetClient.Instance.Exit();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            //btn_min.BackgroundImage = Properties.Resources.Btn_Min;
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos = e.Location;
        }

        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                this.Location = new Point(this.Left + dx, this.Top + dy);
            }
        }

        private void btn_chat_Click(object sender, EventArgs e)
        {
            if(IsInfoFormOpen == false)
            {
                infoForm = new InfoForm();
                infoForm.Show();
                IsInfoFormOpen = true;
            }
            else
            {
                infoForm.Show();
            }

            if(Btn_WoW_Select == true)
            {
                infoForm.ShowInfo("Chat server is in development. Please join http://wowforum.vfire-core.com/ to communicate with other player!");
            }
            else if(Btn_Aion_Select == true)
            {
                infoForm.ShowInfo("Chat server is in development. Please join http://aionforum.vfire-core.com/ to communicate with other player!");
            }
            // unlock
            /*
            if (IsChatFormOpen == false)
            {
                chatForm = new ChatForm();
                chatForm.Show();
                Point loc = this.Location;
                loc.X += 768;
                loc.Y -= 32;
                chatForm.Location = loc;
                IsChatFormOpen = true;
                chatForm.LoadInfo();
            }
            else
            {
                chatForm.Show();
            }
            */
        }

        private void btn_chat_HoverStart(object sender, EventArgs e)
        {
            btn_chat.BackgroundImage = Properties.Resources.Btn_Chat_Hover;
        }

        private void btn_chat_HoverEnd(object sender, EventArgs e)
        {
            btn_chat.BackgroundImage = Properties.Resources.Btn_Chat_Nomal;
        }

        private void btn_activatenow_Click(object sender, EventArgs e)
        {
            if(confirmCreate == false){
                confirmCreate = true;
                confirmForm = new ConfirmForm();
                if (Btn_WoW_Select == true)
                    confirmForm.GameID = 1;
                else
                    confirmForm.GameID = 2;
                confirmForm.ShowGameInfo();
                confirmForm.Show();
            } else {
                if (Btn_WoW_Select == true)
                    confirmForm.GameID = 1;
                else
                    confirmForm.GameID = 2;
                confirmForm.ShowGameInfo();
                confirmForm.Show();
            }
        }

        private void btn_activatenow_MouseDown(object sender, EventArgs e)
        {
            btn_activatenow.BackgroundImage = Properties.Resources.Btn_Active_Click;
        }

        private void btn_activatenow_MouseUp(object sender, EventArgs e)
        {
            btn_activatenow.BackgroundImage = Properties.Resources.Btn_Active_Hover;
        }

        private void btn_activatenow_Hover(object sender, EventArgs e)
        {
            btn_activatenow.BackgroundImage = Properties.Resources.Btn_Active_Hover;
        }

        private void btn_activatenow_Leave(object sender, EventArgs e)
        {
            btn_activatenow.BackgroundImage = Properties.Resources.Btn_Active_Nomal;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (Btn_WoW_Select == true && File.Exists(RunWoWCheck))
            {
                if (IsNeedUpdate == 2)
                {
                    if (GameStarted == false)
                    {
                        GameStarted = true;
                        Process.Start("Wow.exe");
                    }
                }
                else
                {
                    StartUpdate();
                }
            }
            else if (Btn_Aion_Select == true && File.Exists(RunAionCheck))
            {
                if (IsNeedUpdate == 2)
                {
                    if (GameStarted == false)
                    {
                        GameStarted = true;
                        IPAddress[] HostIP = Dns.GetHostAddresses(ClientConfig.AionIP);
                        foreach (IPAddress theaddress in HostIP)
                        {
                            try
                            {
                                AionCommand = "start bin32\\aion.bin -ip:" + theaddress.ToString() + " -port:2106 -cc:1 -lang:enu -noweb -nokicks -ncg -noauthgg -ls -charnamemenu -nowebshop -ingameshop";
                                StartAionClient();
                            }
                            catch (Exception ex)
                            {
                                ShowUpdate(ex.Message.ToString());
                            }
                        }
                    }
                }
                else
                {
                    StartUpdate();
                }
            }
            else
                return;
        }

        public void StartAionClient()
        {
            int exitCode;
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + AionCommand);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;
            process = Process.Start(processInfo);
            Thread.Sleep(1000);
            exitCode = process.ExitCode;
            process.Close();
        }

        private void btn_start_MouseDown(object sender, EventArgs e)
        {
            if (Btn_WoW_Select == true && File.Exists(RunWoWCheck))
            {
                if (IsNeedUpdate == 2)
                    btn_start.BackgroundImage = Properties.Resources.Btn_Start_Click;
                else
                    btn_start.BackgroundImage = Properties.Resources.Btn_Update_Click;
            }
            else if (Btn_Aion_Select == true && File.Exists(RunAionCheck))
            {
                if (IsNeedUpdate == 2)
                    btn_start.BackgroundImage = Properties.Resources.Btn_Start_Click;
                else
                    btn_start.BackgroundImage = Properties.Resources.Btn_Update_Click;
            }
        }

        private void btn_start_MouseUp(object sender, EventArgs e)
        {
            if (Btn_WoW_Select == true && File.Exists(RunWoWCheck))
            {
                if (IsNeedUpdate == 2)
                    btn_start.BackgroundImage = Properties.Resources.Btn_Start_Hover;
                else
                    btn_start.BackgroundImage = Properties.Resources.Btn_Update_Hover;
            }
            else if (Btn_Aion_Select == true && File.Exists(RunAionCheck))
            {
                if (IsNeedUpdate == 2)
                    btn_start.BackgroundImage = Properties.Resources.Btn_Start_Hover;
                else
                    btn_start.BackgroundImage = Properties.Resources.Btn_Update_Hover;
            }
            else
                return;
        }

        private void btn_start_Hover(object sender, EventArgs e)
        {
            if (Btn_WoW_Select == true && File.Exists(RunWoWCheck))
            {
                if (IsNeedUpdate == 2)
                    btn_start.BackgroundImage = Properties.Resources.Btn_Start_Hover;
                else
                    btn_start.BackgroundImage = Properties.Resources.Btn_Update_Hover;
            }
            else if (Btn_Aion_Select == true && File.Exists(RunAionCheck))
            {
                if (IsNeedUpdate == 2)
                    btn_start.BackgroundImage = Properties.Resources.Btn_Start_Hover;
                else
                    btn_start.BackgroundImage = Properties.Resources.Btn_Update_Hover;
            }
            else
                return;
        }

        private void btn_start_Leave(object sender, EventArgs e)
        {
            if (Btn_WoW_Select == true && File.Exists(RunWoWCheck))
            {
                if (IsNeedUpdate == 2)
                    btn_start.BackgroundImage = Properties.Resources.Btn_Start_Normal;
                else
                    btn_start.BackgroundImage = Properties.Resources.Btn_Update_Normal;
            }
            else if (Btn_Aion_Select == true && File.Exists(RunAionCheck))
            {
                if (IsNeedUpdate == 2)
                    btn_start.BackgroundImage = Properties.Resources.Btn_Start_Normal;
                else
                    btn_start.BackgroundImage = Properties.Resources.Btn_Update_Normal;
            }
            else
                return;
        }

        private void StartUpdate() //(int gameid)
        {
            currID = 0;
            CheckSumFunction();
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());

            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString()); //stays at -1
            lb_download.Text = Convert.ToString(totalBytes / 1024) + " KB";

            double percentage = bytesIn / totalBytes * 100;

            pb_update.Value = int.Parse(Math.Truncate(percentage).ToString());
        }

        private void DownloadProgressCallback(object sender, DownloadProgressChangedEventArgs e)
        {
            string str = ((float)((float)e.BytesReceived / 1024.0f)).ToString("0.0") + "/" + ((float)((float)e.TotalBytesToReceive / 1024.0f)).ToString("0.0") + " KB";
            lb_download.Text = str;
            pb_update.Value = e.ProgressPercentage;
        }

        private void DownloadFileCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            currID += 1;
            if (currID < MD5Sum.Count)
            {
                CheckSumFunction();
            }
            else
            {
                IsNeedUpdate = 2;
                if (Btn_WoW_Select == true)
                    ShowUpdate("WoW Client has up to date!");
                else if (Btn_Aion_Select == true)
                    ShowUpdate("Aion Client has up to date!");
                pb_update.Value = 100;
                btn_start.BackgroundImage = Properties.Resources.Btn_Start_Normal;
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
            else if (MD5Sum[currID].MD5 == "DELDIR")
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
