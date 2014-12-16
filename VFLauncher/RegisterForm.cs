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
    public partial class RegisterForm : Form
    {
        public bool IsWaiting = false;
        int a = 0;
        int b = 0;

        #region SettingForm
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        #endregion SettingForm

        public RegisterForm()
        {
            InitializeComponent();
            tb_username.BackColor = Color.FromArgb(18, 22, 28);
            tb_password.BackColor = Color.FromArgb(18, 22, 28);
            tb_retype.BackColor = Color.FromArgb(18, 22, 28);
            tb_email.BackColor = Color.FromArgb(18, 22, 28);
            tb_secureid.BackColor = Color.FromArgb(18, 22, 28);
            tb_antibot.BackColor = Color.FromArgb(18, 22, 28);
        }

        public void ShowInfo(string info)
        {
            lb_info.Text = info;
        }

        public void RandomAntiBot()
        {
            Random random = new Random();
            a = random.Next(1, 99);
            b = random.Next(1, 99);
            lb_antibot.Text = a.ToString() + " + " + b.ToString();
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
            NetClient.Instance.loginForm.Show();
            this.Hide();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (IsWaiting == false)
            {
                if (tb_username.Text == "" || tb_password.Text == "" || tb_retype.Text == "" || tb_email.Text == "" || tb_secureid.Text == "" || tb_antibot.Text == "")
                {
                    ShowInfo("Missing require field!");
                    return;
                }

                if (tb_username.Text.Length < 8 || tb_username.Text.Length > 32)
                {
                    ShowInfo("Username must have 8 - 32 character.");
                    return;
                }

                if (tb_password.Text.Length < 8 || tb_password.Text.Length > 32)
                {
                    ShowInfo("Password must have 8 - 32 character.");
                    return;
                }

                if (tb_password.Text != tb_retype.Text)
                {
                    ShowInfo("Retype password not match!");
                    return;
                }

                if (!tb_email.Text.Contains("@"))
                {
                    ShowInfo("Please correct your email!");
                    return;
                }

                if (tb_secureid.Text.Length != 6)
                {
                    ShowInfo("Secure ID need insert 6 number.");
                    return;
                }

                if (int.Parse(tb_antibot.Text, System.Globalization.NumberStyles.Integer) != (a + b))
                {
                    ShowInfo("AntiBot field incorrect!");
                    return;
                }

                string user = Cryptor.EncryptText(tb_username.Text, NetClient.Instance.keySize, NetClient.Instance.publicKeyS);
                string pass = Cryptor.EncryptText(tb_password.Text, NetClient.Instance.keySize, NetClient.Instance.publicKeyS);
                byte[] userbyte = NetClient.Instance.GetBytes(user);
                byte[] passbyte = NetClient.Instance.GetBytes(pass);
                byte[] ebyte = NetClient.Instance.GetBytes(tb_email.Text);
                byte[] scbyte = NetClient.Instance.GetBytes(tb_secureid.Text);

                PacketWriter AccountCreate = new PacketWriter(ClientMessage.CL_ACCOUNT_CREATE);
                AccountCreate.WriteInt32(userbyte.Length);
                AccountCreate.WriteBytes(userbyte, userbyte.Length);
                AccountCreate.WriteInt32(passbyte.Length);
                AccountCreate.WriteBytes(passbyte, passbyte.Length);
                AccountCreate.WriteInt32(ebyte.Length);
                AccountCreate.WriteBytes(ebyte, ebyte.Length);
                AccountCreate.WriteInt32(scbyte.Length);
                AccountCreate.WriteBytes(scbyte, scbyte.Length);
                NetClient.Instance.Send(ref AccountCreate);
                IsWaiting = true;
            }
        }

        private void createaccount_Leave(object sender, EventArgs e)
        {
            lb_createaccount.ForeColor = Color.DodgerBlue;
        }

        private void createaccount_Hover(object sender, EventArgs e)
        {
            lb_createaccount.ForeColor = Color.White;
        }

        public byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        private void tb_secureid_TextChanged(object sender, EventArgs e)
        {
            string actualdata = string.Empty;
            char[] entereddata = tb_secureid.Text.ToCharArray();
            foreach (char aChar in entereddata.AsEnumerable())
            {
                if (Char.IsDigit(aChar))
                {
                    actualdata = actualdata + aChar;
                    // MessageBox.Show(aChar.ToString());
                }
                else
                {
                    //MessageBox.Show(aChar + " is not numeric");
                    actualdata.Replace(aChar, ' ');
                    actualdata.Trim();
                }
            }
            tb_secureid.Text = actualdata;
        }
    }
}
