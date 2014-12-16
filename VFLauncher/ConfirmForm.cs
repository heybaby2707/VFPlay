using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Network;
using Data.NetMessage;

namespace VFLauncher
{
    public partial class ConfirmForm : Form
    {
        #region SettingForm
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        Point mousePos;
        #endregion SettingForm

        public int GameID = 0;

        public ConfirmForm()
        {
            InitializeComponent();
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

        public void ShowInfo(string str)
        {
            lb_activegame.Text = str;
        }

        public void ShowGameInfo()
        {
            switch(GameID)
            {
                case 0:
                    ShowInfo("Have some problem. Contact to Admin to receive support!");
                    break;
                case 1:
                    ShowInfo("Retype your password to activate VFire WoW account!");
                    break;
                case 2:
                    ShowInfo("Retype your password to activate VFire Aion account!");
                    break;
                default:
                    break;
            }
            btn_activate.Visible = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_activate_Click(object sender, EventArgs e)
        {
            if(tb_password.Text != NetClient.Instance.Account.Pass)
            {
                ShowInfo("Incorrect Password!");
                return;
            }

            PacketWriter ActivateGame = new PacketWriter(ClientMessage.CL_ACCOUNT_ACTIVATE);
            ActivateGame.WriteInt32(GameID);
            NetClient.Instance.Send(ref ActivateGame);

            btn_activate.Visible = false;
            ShowInfo("Activating ...");
        }

        private void btn_activate_MouseDown(object sender, EventArgs e)
        {
            btn_activate.BackgroundImage = Properties.Resources.Btn_MActive_Click;
        }

        private void btn_activate_MouseUp(object sender, EventArgs e)
        {
            btn_activate.BackgroundImage = Properties.Resources.Btn_MActive_Hover;
        }

        private void btn_activate_Hover(object sender, EventArgs e)
        {
            btn_activate.BackgroundImage = Properties.Resources.Btn_MActive_Hover;
        }

        private void btn_activate_Leave(object sender, EventArgs e)
        {
            btn_activate.BackgroundImage = Properties.Resources.Btn_MActive_Nomal;
        }
    }
}
