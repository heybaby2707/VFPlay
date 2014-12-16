using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Network;
using Packets;

namespace VFLauncher
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            
            
            NetClient netClient = new NetClient();
            netClient.SetupNetwork();
            netClient.loginForm = new LoginForm();
            netClient.registerForm = new RegisterForm();
            netClient.mainForm = new MainForm();
            netClient.mainForm.Show();
            netClient.mainForm.Hide();

            if (netClient.IsConnected == true)
            {
                netClient.loginForm.Show();
                Application.Run();
            }
            else
                Application.Exit();
        }
    }
}
