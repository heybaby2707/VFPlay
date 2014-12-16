using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using Data.Interfaces;
using Configuration;
using Cryptography;
using System.Collections;
using Data.NetMessage;
using VFLauncher;
using System.Windows.Forms;
using Network;
using Packets;
using Data;

namespace Network
{
    public class NetClient
    {
        public static TcpClient tcpClient;
        public static NetClient Instance;
        public Queue PacketQueue;
        public PacketCrypt Crypt;
        public Account Account;

        public byte[] DataBuffer;
        protected object SendLock = new object();
        protected List<byte[]> SendData = new List<byte[]>();
        protected int SendDataSize;

        public int keySize = 512;
        public string publicKeyC;
        public string privateKeyC;
        public string publicKeyS;

        public bool IsConnected = false;
        public bool IsPing = false;
        private int PingDelay = 60; // second

        public LoginForm loginForm;
        public RegisterForm registerForm;
        public MainForm mainForm;
        public ChatForm chatForm;
        public ChatChannel WoWChannel;
        public ChatChannel AionChannel;
        private Thread pingThread;

        public NetClient()
        {
            Instance = this;
            PacketManager.DefineOpcodeHandler();
            DataBuffer = new byte[8120];
            PacketQueue = new Queue();
            Crypt = new PacketCrypt();
            Account = new Account();
        }

        public void SetupNetwork()
        {
            Thread.Sleep(500);
            try
            {
                string address = Dns.GetHostAddresses(ClientConfig.BindIP)[0].ToString();
                tcpClient = new TcpClient(address, ClientConfig.BindPort);
                //tcpClient.Client.BeginReceive(DataBuffer, 0, DataBuffer.Length, SocketFlags.None, Receive, null);
                tcpClient.Client.BeginReceive(DataBuffer, 0, DataBuffer.Length, SocketFlags.None, new AsyncCallback(Receive), null); 
                Cryptor.GenerateKeys(keySize, out publicKeyC, out privateKeyC);
                PacketWriter RequestOnline = new PacketWriter(ClientMessage.CL_REQUEST_ONLINE);
                RequestOnline.WriteString(publicKeyC);
                Send(ref RequestOnline);
                IsConnected = true;
            }
            catch(Exception e)
            {
                //
                //SetupNetwork();
                MessageBox.Show("Can't connect to Master Server! Please contact to Admin or GM to receive support!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Receive(IAsyncResult result)
        {
            try
            {
               // var recievedBytes = tcpClient.Client.EndReceive(result);
                var recievedBytes = tcpClient.GetStream().EndRead(result);
                if (recievedBytes != 0)
                {
                    if (Crypt.IsInitialized)
                    {
                        //loginForm.ShowInfo("Recv Encrypt");
                        while (recievedBytes > 0)
                        {
                            Decode(ref DataBuffer);

                            var length = BitConverter.ToUInt16(DataBuffer, 0) + 4;

                            var packetData = new byte[length];
                            Buffer.BlockCopy(DataBuffer, 0, packetData, 0, length);

                            PacketReader packet = new PacketReader(packetData);
                            PacketQueue.Enqueue(packet);

                            recievedBytes -= length;
                            Buffer.BlockCopy(DataBuffer, length, DataBuffer, 0, recievedBytes);

                            OnData();
                        }
                    }
                    else
                    {
                        OnData();
                        //loginForm.ShowInfo("Recv Nocrypt");
                    }
                    //tcpClient.GetStream().BeginRead(DataBuffer, 0, DataBuffer.Length, new AsyncCallback(Receive), null);
                    tcpClient.Client.BeginReceive(DataBuffer, 0, DataBuffer.Length, SocketFlags.None, new AsyncCallback(Receive), null); 
                    //tcpClient.Client.BeginReceive(DataBuffer, 0, DataBuffer.Length, SocketFlags.None, Receive, null);
                    //loginForm.ShowInfo("Begin Receive ...");
                }
            }
            catch (Exception ex)
            {
                //Debug.Log(ex.Message);
                MessageBox.Show("You're disconnected from master server!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Exit();
            }
        }

        public void OnData()
        {
            PacketReader packet = null;
            if (PacketQueue.Count > 0)
                packet = (PacketReader)PacketQueue.Dequeue();
            else
                packet = new PacketReader(DataBuffer);
            
            PacketManager.InvokeHandler(ref packet, this);
            //MessageBox.Show(packet.Opcode.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Send(ref PacketWriter packet)
        {
            if (packet.Opcode == 0)
                return;
            var buffer = packet.ReadDataToSend();
            try
            {
                if (Crypt.IsInitialized)
                {
                    //loginForm.ShowInfo("Send Encrypt");
                    uint totalLength = (uint)packet.Size - 2;
                    totalLength <<= 13;
                    totalLength |= ((uint)packet.Opcode & 0x1FFF);

                    var header = BitConverter.GetBytes(totalLength);

                    Crypt.Encrypt(header);

                    buffer[0] = header[0];
                    buffer[1] = header[1];
                    buffer[2] = header[2];
                    buffer[3] = header[3];
                }

                tcpClient.Client.Send(buffer, 0, buffer.Length, SocketFlags.None);
                packet.Flush();
            }
            catch (Exception ex)
            {
                //Debug.Log(ex.Message);
            }
        }

        void Decode(ref byte[] data)
        {
            Crypt.Decrypt(data);

            var header = BitConverter.ToUInt32(data, 0);
            ushort size = (ushort)(header >> 13);
            ushort opcode = (ushort)(header & 0x1FFF);

            data[0] = (byte)(0xFF & size);
            data[1] = (byte)(0xFF & (size >> 8));
            data[2] = (byte)(0xFF & opcode);
            data[3] = (byte)(0xFF & (opcode >> 8));
        }

        public void Exit()
        {
            if(pingThread != null)
                pingThread.Abort();
            Application.Exit();
        }

        public void Ping()
        {
            pingThread = new Thread(DoPing);
            pingThread.Start();
        }

        private void DoPing()
        {
            while(IsPing == true)
            {
                PacketWriter DoPing = new PacketWriter(ClientMessage.DoPing);
                Send(ref DoPing);
                Thread.Sleep(PingDelay * 1000);
            }
        }

        public byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        public string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
    }
}
