using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using Network;
using Data.NetMessage;

namespace VFLauncher
{
    public partial class ChatForm : Form
    { 
        #region SettingForm
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        //Point mousePos;
        #endregion SettingForm

        #region SettingWindow
        public bool IsWoWChannel = false;
        public bool IsAionChannel = false;
        #endregion SettingWindow

        public ChatForm()
        {
            InitializeComponent();
            NetClient.Instance.chatForm = this;
            //user_list.BackColor = Color.FromArgb(29, 34, 44);
        }

        public void LoadInfo()
        {
            lb_username.Text = NetClient.Instance.Account.Name + " # " + NetClient.Instance.Account.Id;
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

        private void btn_addfriend_Click(object sender, EventArgs e)
        {

        }

        private void btn_addfriend_Hover(object sender, EventArgs e)
        {
            btn_addfriend.BackgroundImage = Properties.Resources.AddFriend_Hover;
        }

        private void btn_addfriend_Leave(object sender, EventArgs e)
        {
            btn_addfriend.BackgroundImage = Properties.Resources.AddFriend_Nomal;
        }

        private void btn_channel_wow_Click(object sender, EventArgs e)
        {
            NetClient.Instance.WoWChannel.Show();
            NetClient.Instance.WoWChannel.ReceiveMessage();
            /*
            if (IsWoWChannel == false)
            {
                ChatChannel WoWChannel = new ChatChannel();
                WoWChannel.ChannelName = "WoW Channel";
                WoWChannel.ChannelInfo = "VFire World of Warcraft chat channel.";
                WoWChannel.LoadInfo();
                NetClient.Instance.WoWChannel = WoWChannel;
                IsWoWChannel = true;
            }
            else
            {
                NetClient.Instance.WoWChannel.Show();
            }
            */
        }

        private void btn_channel_wow_Hover(object sender, EventArgs e)
        {
            btn_channel_wow.BackgroundImage = Properties.Resources.WoW_Channel_Hover;
        }

        private void btn_channel_wow_Leave(object sender, EventArgs e)
        {
            btn_channel_wow.BackgroundImage = Properties.Resources.WoW_Channel_Nomal;
        }

        private void btn_channel_aion_Click(object sender, EventArgs e)
        {
            NetClient.Instance.AionChannel.Show();
            NetClient.Instance.AionChannel.ReceiveMessage();
            /*
            if(IsAionChannel == false)
            {
                ChatChannel AionChannel = new ChatChannel();
                AionChannel.ChannelName = "Aion Channel";
                AionChannel.ChannelInfo = "VFire Aion chat channel.";
                AionChannel.LoadInfo();
                NetClient.Instance.AionChannel = AionChannel;
                IsAionChannel = true;
            }
            else
            {
                NetClient.Instance.AionChannel.Show();
            }
            */
        }

        private void btn_channel_aion_Hover(object sender, EventArgs e)
        {
            btn_channel_aion.BackgroundImage = Properties.Resources.Aion_Channel_Hover;
        }

        private void btn_channel_aion_Leave(object sender, EventArgs e)
        {
            btn_channel_aion.BackgroundImage = Properties.Resources.Aion_Channel_Nomal;
        }
    }
}
