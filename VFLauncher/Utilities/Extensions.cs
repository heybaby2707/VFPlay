using System;
using System.Collections.Generic;
using System.IO;
using Network;

namespace Utilities
{
    public static class Extensions
    {
        public static Dictionary<Type, Func<BinaryReader, object>> ReadValue = new Dictionary<Type, Func<BinaryReader, object>>()
        {
            {typeof(bool),   br => br.ReadBoolean()},
            {typeof(sbyte),  br => br.ReadSByte()},
            {typeof(byte),   br => br.ReadByte()},
            {typeof(short),  br => br.ReadInt16()},
            {typeof(ushort), br => br.ReadUInt16()},
            {typeof(int),    br => br.ReadInt32()},
            {typeof(uint),   br => br.ReadUInt32()},
            {typeof(float),  br => br.ReadSingle()},
            {typeof(long),   br => br.ReadInt64()},
            {typeof(ulong),  br => br.ReadUInt64()},
            {typeof(double), br => br.ReadDouble()},
        };

        public static T Read<T>(this BinaryReader br)
        {
            return (T)ReadValue[typeof(T)](br);
        }

        public static T Read<T>(PacketReader br)
        {
            return (T)ReadValue[typeof(T)](br);
        }

        public static byte[] Combine(this byte[] data, byte[] data2)
        {
            var combined = new byte[data.Length + data2.Length];

            Buffer.BlockCopy(data, 0, combined, 0, data.Length);
            Buffer.BlockCopy(data2, 0, combined, data.Length, data2.Length);

            return combined;
        }
    }
}