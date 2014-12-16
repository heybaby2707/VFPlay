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
using Cryptography;

namespace VFLauncher
{
    public partial class LoginForm : Form
    {
        public bool IsWaiting = false;
        public bool IsRemember = false;

        #region SettingForm
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        #endregion SettingForm

        public LoginForm()
        {
            InitializeComponent();
            //Instance = this;
            //NetClient.Instance.loginForm = this;
            tb_username.BackColor = Color.FromArgb(18, 22, 28);
            tb_password.BackColor = Color.FromArgb(18, 22, 28);
        }

        public void ShowInfo(string info)
        {
            lb_info.Text = info;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left){
                this.Capture = false;
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
            base.OnMouseDown(e);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            AuthLogin();
        }

        private void login_Hover(object sender, EventArgs e)
        {
            lb_login.ForeColor = Color.Black;
        }

        private void login_Leave(object sender, EventArgs e)
        {
            lb_login.ForeColor = Color.White;
        }

        private void btn_cantlogin_Click(object sender, EventArgs e)
        {

        }

        private void cantlogin_Hover(object sender, EventArgs e)
        {
            lb_cantlogin.ForeColor = Color.White;
        }

        private void cantlogin_Leave(object sender, EventArgs e)
        {
            lb_cantlogin.ForeColor = Color.DodgerBlue;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            NetClient.Instance.registerForm.Show();
            NetClient.Instance.registerForm.RandomAntiBot();
            this.Hide();
        }

        private void createaccount_Leave(object sender, EventArgs e)
        {
            lb_createaccount.ForeColor = Color.DodgerBlue;
        }

        private void createaccount_Hover(object sender, EventArgs e)
        {
            lb_createaccount.ForeColor = Color.White;
        }

        private void checkbox_Click(object sender, EventArgs e)
        {
            IsRemember = !IsRemember;
            if(IsRemember == true){
                checkbox.BackgroundImage = Properties.Resources.cb_checked;
            } else {
                checkbox.BackgroundImage = Properties.Resources.cb_nomal;
            }
        }

        private void checkbox_Hover(object sender, EventArgs e)
        {
            if (IsRemember == true){
                checkbox.BackgroundImage = Properties.Resources.cb_checked_hover;
            } else {
                checkbox.BackgroundImage = Properties.Resources.cb_nomal_hover;
            }
        }

        private void checkbox_Leave(object sender, EventArgs e)
        {
            if (IsRemember == true){
                checkbox.BackgroundImage = Properties.Resources.cb_checked;
            } else {
                checkbox.BackgroundImage = Properties.Resources.cb_nomal;
            }
        }

        public byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        private void AuthLogin()
        {
            if (IsWaiting == false)
            {
                if (tb_username.Text == "" || tb_password.Text == "")
                {
                    ShowInfo("Missing infomation!");
                }

                if (tb_username.Text != "" && tb_password.Text != "")
                {
                    PacketWriter AuthLogin = new PacketWriter(ClientMessage.CL_AUTH_LOGIN);
                    string un = Cryptor.EncryptText(tb_username.Text, NetClient.Instance.keySize, NetClient.Instance.publicKeyS);
                    string pw = Cryptor.EncryptText(tb_password.Text, NetClient.Instance.keySize, NetClient.Instance.publicKeyS);
                    byte[] username = NetClient.Instance.GetBytes(un);
                    byte[] password = NetClient.Instance.GetBytes(pw);
                    AuthLogin.WriteInt32(username.Length);
                    AuthLogin.WriteBytes(username, username.Length);
                    AuthLogin.WriteInt32(password.Length);
                    AuthLogin.WriteBytes(password, password.Length);
                    NetClient.Instance.Send(ref AuthLogin);
                    NetClient.Instance.Account.Pass = tb_password.Text;
                }
            }
        }
    }
}
