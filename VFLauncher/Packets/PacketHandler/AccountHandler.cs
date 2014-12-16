using System;
using System.Collections.Generic;
using Configuration;
using Data.NetMessage;
using Network;
using Cryptography;
using VFLauncher;
using System.Threading;

namespace VFLauncher.Packets.PacketHandler
{
    public class AccountHandler
    {
        enum RegisterResult
        {
            CREATE_FAIL = 0,
            CREATE_SUCCESS = 1,
        }

        [Opcode(ServerMessage.SV_ACCOUNT_CREATE, "0001")]
        public static void HandleAccountCreate(ref PacketReader packet, NetClient session)
        {
            int rr = packet.ReadInt32();
            int messl = packet.ReadInt32();
            string mess = session.GetString(packet.ReadBytes(messl));
            switch(rr)
            {
                case 0:
                    session.registerForm.IsWaiting = false;
                    session.registerForm.ShowInfo(mess);
                    break;
                case 1:
                    session.registerForm.ShowInfo(mess);
                    //Thread.Sleep(1000);
                    session.registerForm.Hide();
                    session.loginForm.Show();
                    session.loginForm.ShowInfo("Created a new account! Please login!");
                    break;
            }
        }

        [Opcode(ServerMessage.SV_ACCOUNT_ACTIVATE, "0001")]
        public static void HandleAccountActivate(ref PacketReader packet, NetClient session)
        {
            int result = packet.ReadInt32();
            if(result == 0)
            {
                int messLength = packet.ReadInt32();
                string mess0 = NetClient.Instance.GetString(packet.ReadBytes(messLength));
                NetClient.Instance.mainForm.confirmForm.ShowInfo(mess0);
                return;
            }

            int GameID = packet.ReadInt32();
            switch(GameID)
            {
                case 1:
                    string mess1 = "Your WoW account activated!";
                    NetClient.Instance.mainForm.confirmForm.ShowInfo(mess1);
                    NetClient.Instance.Account.IsWoWActive = true;
                    Thread.Sleep(300);
                    NetClient.Instance.mainForm.LoadBtn();
                    NetClient.Instance.mainForm.confirmForm.Hide();
                    break;
                case 2:
                    string mess2 = "Your Aion account activated!";
                    NetClient.Instance.mainForm.confirmForm.ShowInfo(mess2);
                    NetClient.Instance.Account.IsAionActive = true;
                    Thread.Sleep(300);
                    NetClient.Instance.mainForm.LoadBtn();
                    NetClient.Instance.mainForm.confirmForm.Hide();
                    break;
                default:
                    break;
            }
        }
    }
}
