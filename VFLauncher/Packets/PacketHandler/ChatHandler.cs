using System;
using System.Collections.Generic;
using Configuration;
using Data.NetMessage;
using Network;
using Cryptography;
using VFLauncher;
using System.Threading;

namespace Packets.PacketHandler
{
    public class ChatHandler
    {
        [Opcode(ServerMessage.SV_CHANNEL_JOIN, "0001")]
        public static void HandleChannelJoin(ref PacketReader packet, NetClient session)
        {
            //MainForm.Instance.chatForm.WoWChannel.Show();
            /*
            int channel = packet.ReadInt32();
            //string channelName = NetClient.Instance.GetString(packet.ReadBytes(channelLength));
            if (LoginForm.Instance.WindowState == FormWindowState.Normal)
                LoginForm.Instance.ShowInfo("Channel join!");
            Thread.Sleep(500);
            if (channel == 1)
            {
                MainForm.Instance.chatForm.WoWChannel.Show();
            }
            else if (channel == 2)
            {
                MainForm.Instance.chatForm.AionChannel.Show();
            }
            */
        }

        [Opcode(ServerMessage.SV_CHANNEL_MESSAGE, "0001")]
        public static void HandleChannelMessage(ref PacketReader packet, NetClient session)
        {
            int channelLength = packet.ReadInt32();
            string channelName = NetClient.Instance.GetString(packet.ReadBytes(channelLength));
            double time = packet.ReadDouble();
            int nameLength = packet.ReadInt32();
            string name = NetClient.Instance.GetString(packet.ReadBytes(nameLength));
            int gmlevel = packet.ReadInt32();
            int messLength = packet.ReadInt32();
            string mess = NetClient.Instance.GetString(packet.ReadBytes(messLength));
            if (channelName == "WoW Channel")
            {
                session.WoWChannel.SendMessage(time, name, gmlevel, mess);
            }
            else if (channelName == "Aion Channel")
            {
                session.AionChannel.SendMessage(time, name, gmlevel, mess);
            }
        }

        [Opcode(ServerMessage.DoPing, "0001")]
        public static void HandleDoPing(ref PacketReader packet, NetClient session)
        {
            session.IsPing = true;
        }
    }
}
