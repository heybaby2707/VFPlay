using Data.NetMessage;
using Utilities;
using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace Network
{
    public class PacketReader : BinaryReader
    {
        public ServerMessage Opcode { get; set; }
        public ushort Size { get; set; }
        public byte[] Storage { get; set; }

        public PacketReader(byte[] data, bool worldPacket = true)
            : base(new MemoryStream(data))
        {
            if (worldPacket)
            {
                ushort size = this.Read<ushort>();
                Opcode = (ServerMessage)this.ReadUInt16();

                if (Opcode == ServerMessage.TransferInitiate)
                    Size = (ushort)((size % 0x100) + (size / 0x100));
                else
                    Size = size;

                Storage = new byte[Size];
                Buffer.BlockCopy(data, 4, Storage, 0, Size);
            }
        }

        public T Read<T>()
        {
            return Extensions.Read<T>(this);
        }

        public string ReadCString()
        {
            StringBuilder tmpString = new StringBuilder();
            char tmpChar = base.ReadChar();
            char tmpEndChar = Convert.ToChar(Encoding.UTF8.GetString(new byte[] { 0 }), CultureInfo.InvariantCulture);

            while (tmpChar != tmpEndChar)
            {
                tmpString.Append(tmpChar);
                tmpChar = base.ReadChar();
            }

            return tmpString.ToString();
        }

        public string ReadString(uint count)
        {
            byte[] stringArray = ReadBytes(count);
            return Encoding.UTF8.GetString(stringArray);
        }

        public byte[] ReadBytes(uint count)
        {
            return base.ReadBytes((int)count);
        }

        public string ReadStringFromBytes(uint count)
        {
            byte[] stringArray = ReadBytes(count);
            Array.Reverse(stringArray);

            return UTF8Encoding.UTF8.GetString(stringArray);
        }

        public string ReadIPAddress()
        {
            byte[] ip = new byte[4];

            for (int i = 0; i < 4; ++i)
                ip[i] = this.Read<byte>();

            return ip[0] + "." + ip[1] + "." + ip[2] + "." + ip[3];
        }

        public string ReadAccountName()
        {
            StringBuilder nameBuilder = new StringBuilder();

            byte nameLength = this.Read<byte>();
            char[] name = new char[nameLength];

            for (int i = 0; i < nameLength; i++)
            {
                name[i] = base.ReadChar();
                nameBuilder.Append(name[i]);
            }

            return nameBuilder.ToString().ToUpper(CultureInfo.InvariantCulture);
        }

        public void Skip(int count)
        {
            base.BaseStream.Position += count;
        }
    }
}