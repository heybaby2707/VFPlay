using System;
using System.Collections.Generic;
using Configuration;
using Data.NetMessage;
using Network;
using Cryptography;
using VFLauncher;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Forms;

namespace Packets.PacketHandler
{
    public class AuthenticationHandler
    {
        /*
        [Opcode(ClientMessage.QueryRealmName, "18019")]
        public static void HandleQueryRealmName(ref PacketReader packet, WarClass session)
        {
            Character pChar = session.Character;

            uint realmId = packet.Read<uint>();

            SQLResult result = DB.Realms.Select("SELECT name FROM realms WHERE id = ?", WorldConfig.RealmId);
            string realmName = result.Read<string>(0, "Name");

            PacketWriter realmQueryResponse = new PacketWriter(ServerMessage.RealmQueryResponse);
            BitPack BitPack = new BitPack(realmQueryResponse);

            realmQueryResponse.WriteUInt32(realmId);
            realmQueryResponse.WriteUInt8(0);

            BitPack.Write(realmName.Length, 8);
            BitPack.Write(1);
            BitPack.Write(realmName.Length, 8);

            BitPack.Flush();

            realmQueryResponse.WriteString(realmName);
            realmQueryResponse.WriteString(realmName);

            session.Send(ref realmQueryResponse);
        }
        */
        [Opcode(ServerMessage.SV_TRANSFER_INIT, "0001")]
        public static void HandleTransferInit(ref PacketReader packet, NetClient session)
        {
            Cryptor.GenerateKeys(NetClient.Instance.keySize, out NetClient.Instance.publicKeyC, out NetClient.Instance.privateKeyC);
            PacketWriter RequestOnline = new PacketWriter(ClientMessage.CL_REQUEST_ONLINE);
            RequestOnline.WriteString(NetClient.Instance.publicKeyC);
            NetClient.Instance.Send(ref RequestOnline);
            NetClient.Instance.IsConnected = true;
        }

        [Opcode(ServerMessage.SV_REQUEST_ONLINE, "0001")]
        public static void HandleRequestOnline(ref PacketReader packet, NetClient session)
        {
            session.publicKeyS = packet.ReadString(160);
            Thread.Sleep(500);
            session.loginForm.ShowInfo("Master Server Online!");
            //Log.Message(LogType.Normal, "{0}", session.publicKeyC);
            //Cryptor.GenerateKeys(session.keyLength, out session.publicKeyS, out session.privateKeyS);
            //PacketWriter RequestOnline = new PacketWriter(ServerMessage.SV_REQUEST_ONLINE);
            //RequestOnline.WriteString(session.publicKeyS);
            //session.Send(ref RequestOnline);
        }

        [Opcode(ServerMessage.SV_AUTH_LOGIN, "0001")]
        public static void HandleAuthLogin(ref PacketReader packet, NetClient session)
        {
            int result = packet.ReadInt32();
            switch(result)
            {
                case 0:
                    session.loginForm.ShowInfo("Login success ...");

                    int k1l = packet.ReadInt32();
                    string key1 = NetClient.Instance.GetString(packet.ReadBytes(k1l));
                    int k2l = packet.ReadInt32();
                    string key2 = NetClient.Instance.GetString(packet.ReadBytes(k2l));
                    NetClient.Instance.Account.SessionKey = Cryptor.DecryptText(key1, NetClient.Instance.keySize, NetClient.Instance.privateKeyC)
                        + Cryptor.DecryptText(key2, NetClient.Instance.keySize, NetClient.Instance.privateKeyC);

                    string K = NetClient.Instance.Account.SessionKey;
                    byte[] kBytes = new byte[K.Length / 2];
                    for (int i = 0; i < K.Length; i += 2)
                        kBytes[i / 2] = Convert.ToByte(K.Substring(i, 2), 16);
                    NetClient.Instance.Crypt.Initialize(kBytes);

                    Thread.Sleep(500);
                    session.loginForm.ShowInfo("Requesting Information ...");
                    PacketWriter GetAccountInfo = new PacketWriter(ClientMessage.CL_GET_ACCOUNT_INFO);
                    //GetAccountInfo.WriteString("123");
                    NetClient.Instance.Send(ref GetAccountInfo);
                    break;
                case 1:
                    session.loginForm.IsWaiting = false;
                    session.loginForm.ShowInfo("Account online. Try again late!");
                    Thread.Sleep(1000);
                    Application.Exit();
                    break;
                case 2:
                    session.loginForm.IsWaiting = false;
                    session.loginForm.ShowInfo("Invalid username or password.");
                    break;
                case 3:
                    session.loginForm.IsWaiting = false;
                    session.loginForm.ShowInfo("This IP Address logged in Master Server!");
                    Thread.Sleep(1000);
                    Application.Exit();
                    break;
            }
        }

        [Opcode(ServerMessage.SV_GET_ACCOUNT_INFO, "0001")]
        public static void HandleGetAccountInfo(ref PacketReader packet, NetClient session)
        {
            session.loginForm.ShowInfo("Loading Information ...");
            
            NetClient.Instance.Account.Id = packet.ReadInt32();
            int userLength = packet.ReadInt32();
            NetClient.Instance.Account.Name = NetClient.Instance.GetString(packet.ReadBytes(userLength));
            int emailLength = packet.ReadInt32();
            NetClient.Instance.Account.Email = NetClient.Instance.GetString(packet.ReadBytes(emailLength));
            int ipLength = packet.ReadInt32();
            NetClient.Instance.Account.IP = NetClient.Instance.GetString(packet.ReadBytes(ipLength));
            NetClient.Instance.Account.GMLevel = packet.ReadInt32();
            NetClient.Instance.Account.IsActive = packet.ReadInt32();
            NetClient.Instance.Account.Locked = Convert.ToBoolean(packet.ReadInt32());
            NetClient.Instance.Account.DonatePoint = packet.ReadInt32();
            NetClient.Instance.Account.IsWoWActive = Convert.ToBoolean(packet.ReadInt32());
            NetClient.Instance.Account.IsAionActive = Convert.ToBoolean(packet.ReadInt32());
            NetClient.Instance.Account.BindClient = packet.ReadInt32();
            NetClient.Instance.Account.WoWClient = packet.ReadInt32();
            NetClient.Instance.Account.AionClient = packet.ReadInt32();

            session.IsPing = true;
            session.Ping();

            //Thread.Sleep(10000);
            session.loginForm.Hide();

            session.mainForm.LoadInfo();
            session.mainForm.LoadBtn();
            session.mainForm.Show();

            ChatChannel WoWChannel = new ChatChannel();
            WoWChannel.ChannelName = "WoW Channel";
            WoWChannel.ChannelInfo = "VFire World of Warcraft chat channel.";
            WoWChannel.LoadInfo();
            NetClient.Instance.WoWChannel = WoWChannel;

            ChatChannel AionChannel = new ChatChannel();
            AionChannel.ChannelName = "Aion Channel";
            AionChannel.ChannelInfo = "VFire Aion chat channel.";
            AionChannel.LoadInfo();
            NetClient.Instance.AionChannel = AionChannel;
        }

        [Opcode(ServerMessage.DisconnectFromServer, "0001")]
        public static void HandleDisconnectFromServer(ref PacketReader packet, NetClient session)
        {
            int result = packet.ReadInt32();
            switch(result)
            {
                case 1:
                    MessageBox.Show("Disconnect to Master Server because other people login with this account! Please contact to Admin or GM to receive support!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    session.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
