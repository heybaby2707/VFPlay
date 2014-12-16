using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Data.NetMessage;
using Network;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace VFLauncher
{
    public partial class ChatChannel : Form
    {
        private bool IsLoadMessage = false;
        public string ChannelName;
        public string ChannelInfo;
        private string PATH = Application.StartupPath;

        #region SettingForm
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        #endregion SettingForm

        public ChatChannel()
        {
            InitializeComponent();
            CreateEmotions();
        }

        public void LoadInfo()
        {
            lb_channel_name.Text = ChannelName;
            lb_channel_info.Text = ChannelInfo;
            if(ChannelName == "WoW Channel")
            {
                pb_channel.BackgroundImage = Properties.Resources.WoWIcon_01_Hover;
            }
            else
            {
                pb_channel.BackgroundImage = Properties.Resources.AionIcon_01_Hover;
            }
            //tb_chat_info.BackColor = Color.FromArgb(29, 34, 44);
            //tb_chat_send.BackColor = Color.FromArgb(20, 25, 34);

            PacketWriter ChannelJoin = new PacketWriter(ClientMessage.CL_CHANNEL_JOIN);
            byte[] channel = NetClient.Instance.GetBytes(ChannelName);
            ChannelJoin.WriteInt32(channel.Length);
            ChannelJoin.WriteBytes(channel, channel.Length);
            NetClient.Instance.Send(ref ChannelJoin);
        }

        public void ReceiveMessage()
        {
            if (IsLoadMessage == false)
            {
                //Thread.Sleep(1500);
                PacketWriter ChannelOpen = new PacketWriter(ClientMessage.CL_CHANNEL_OPEN);
                byte[] channel = NetClient.Instance.GetBytes(ChannelName);
                ChannelOpen.WriteInt32(channel.Length);
                ChannelOpen.WriteBytes(channel, channel.Length);
                NetClient.Instance.Send(ref ChannelOpen);
                IsLoadMessage = true;
            }
            
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

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void AppendText(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }

        public void SendMessage(double time, string username, int gmlevel, string message)
        {
            // Time
            if (gmlevel == 6)
            {
                // Do something here
            }
            else
                AppendText(tb_chat_info, "[" + UTimeToDTime(time).ToShortTimeString() + "] ", Color.Gray);
            // Username
            if(gmlevel == 0) {
                AppendText(tb_chat_info, username + " : ", Color.White);
            } else if(gmlevel == 1) {
                AppendText(tb_chat_info, username + " : ", Color.Green);
            } else if (gmlevel == 2) {
                AppendText(tb_chat_info, username + " : ", Color.DodgerBlue);
            } else if (gmlevel == 6) {
                AppendText(tb_chat_info, username + " - ", Color.Red);
            }
            // Message
            if(gmlevel == 6){
                AppendText(tb_chat_info, message + "\r\n", Color.Gray);
            } else
                AppendText(tb_chat_info, message + "\r\n", Color.White);
            tb_chat_info.ScrollToCaret();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (tb_chat_send.Text == "")
                return;

            //SendMessage(DTimeToUTime(DateTime.Now), NetClient.Instance.Account.Name, NetClient.Instance.Account.GMLevel, tb_chat_send.Text);
            PacketWriter ChannelMessage = new PacketWriter(ClientMessage.CL_CHANNEL_MESSAGE);
            byte[] channel = NetClient.Instance.GetBytes(ChannelName);
            ChannelMessage.WriteInt32(channel.Length);
            ChannelMessage.WriteBytes(channel, channel.Length);
            ChannelMessage.WriteDouble(DTimeToUTime(DateTime.Now));
            byte[] name = NetClient.Instance.GetBytes(NetClient.Instance.Account.Name);
            ChannelMessage.WriteInt32(name.Length);
            ChannelMessage.WriteBytes(name, name.Length);
            ChannelMessage.WriteInt32(NetClient.Instance.Account.GMLevel);
            byte[] mess = NetClient.Instance.GetBytes(tb_chat_send.Text);
            ChannelMessage.WriteInt32(mess.Length);
            ChannelMessage.WriteBytes(mess, mess.Length);
            NetClient.Instance.Send(ref ChannelMessage);
            
            tb_chat_send.Text = "";
        }

        public DateTime UTimeToDTime(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return origin.AddSeconds(timestamp);
        }

        public double DTimeToUTime(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan diff = date - origin;
            return Math.Floor(diff.TotalSeconds);
        }

        Hashtable emotions;
        private void CreateEmotions()
        {
            emotions = new Hashtable(2);
            emotions.Add(":-)", "./Emoticons/emo_big_smile.png");
            emotions.Add(":))", "./Emoticons/emo_big_smile.png"); 
            //emotions.Add(":-)", Properties.Resources.emo_big_smile);
            //emotions.Add(":))", Properties.Resources.emo_big_smile);
        }

        private void AddEmotions()
        {
            foreach (string emote in emotions.Keys)
            {
                while (tb_chat_info.Text.Contains(emote))
                {
                    tb_chat_info.ReadOnly = false;
                    //string emoFile = "<html><body><img src=\"" + PATH + "\\emoticon\\" + emotions[emote].ToString() + "\" alt=\"Smiley face\" height=\"32\" width=\"32\"></body></html>";
                    string emoFile = emotions[emote].ToString();
                    //Image image = (Image)emotions[emote];
                    int ind = tb_chat_info.Text.IndexOf(emote);
                    tb_chat_info.Select(ind, emote.Length);
                    /*
                    var webBrowser = new WebBrowser();
                    webBrowser.CreateControl();
                    webBrowser.DocumentText = emoFile;
                    NetClient.Instance.mainForm.ShowUpdate(emoFile);
                    while (webBrowser.DocumentText != emoFile)
                    {
                        Application.DoEvents();
                        webBrowser.Document.ExecCommand("SelectAll", false, null);
                        webBrowser.Document.ExecCommand("Copy", false, null);
                        tb_chat_info.Paste();
                    }
                    */
                    //PictureBox pictureBox = new PictureBox();
                    //pictureBox.BackgroundImage = Image.FromFile(@emoFile);
                    //pictureBox.Height = 32;
                    //pictureBox.Width = 32;
                    //pictureBox.BackColor = Color.Transparent;

                    //Image img = Image.FromFile(@emoFile);
                    //img = ChangeImageOpacity(img, 1);
                    Bitmap myBitmap = new Bitmap(emoFile);
                    myBitmap.MakeTransparent();
                    //myBitmap.MakeTransparent((myBitmap).GetPixel(1, 1));
                    //myBitmap.MakeTransparent(myBitmap.GetPixel(1, 1));
                    //image = (Image)myBitmap;
                    //DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
                    // Image emo = (Image)emotions[emote];
                    Clipboard.Clear();
                    Clipboard.SetDataObject(myBitmap);
                    //Clipboard.SetImage(image);
                    //HtmlRenderer html = HtmlRenderer.Render(Graphics g, string html, RectangleF area, bool clip) 
                    //Clipboard.SetText(emoFile);
                    tb_chat_info.Paste();
                    //tb_chat_info.Paste();
                    //Clipboard.SetImage(emo);
                    //if (tb_chat_info.CanPaste(myFormat))
                    //{
                    //    tb_chat_info.Paste(myFormat);
                    //}
                    myBitmap.Dispose();
                    //img.Dispose();
                    //pictureBox.Dispose();
                    tb_chat_info.ReadOnly = true;
                }
            }
        }

        private void tb_chat_info_TextChanged(object sender, EventArgs e)
        {
            AddEmotions();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var bmp = GetImageFromClipboard())
            {
                if (bmp != null) e.Graphics.DrawImage(bmp, 0, 0);
            }
        }

        private Image GetImageFromClipboard()
        {
            if (Clipboard.GetDataObject() == null) return null;
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Dib))
            {
                var dib = ((System.IO.MemoryStream)Clipboard.GetData(DataFormats.Dib)).ToArray();
                var width = BitConverter.ToInt32(dib, 4);
                var height = BitConverter.ToInt32(dib, 8);
                var bpp = BitConverter.ToInt16(dib, 14);
                if (bpp == 32)
                {
                    var gch = GCHandle.Alloc(dib, GCHandleType.Pinned);
                    Bitmap bmp = null;
                    try
                    {
                        var ptr = new IntPtr((long)gch.AddrOfPinnedObject() + 40);
                        bmp = new Bitmap(width, height, width * 4, System.Drawing.Imaging.PixelFormat.Format32bppArgb, ptr);
                        return new Bitmap(bmp);
                    }
                    finally
                    {
                        gch.Free();
                        if (bmp != null) bmp.Dispose();
                    }
                }
            }
            return Clipboard.ContainsImage() ? Clipboard.GetImage() : null;
        }
    }
}
