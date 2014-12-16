﻿using System;
using System.Security.Cryptography;

namespace Cryptography
{
    public sealed class PacketCrypt : IDisposable
    {
        public bool IsInitialized { get; set; }

        static readonly byte[] ServerDecryptionKey = { 0x08, 0xF1, 0x95, 0x9F, 0x47, 0xE5, 0xD2, 0xDB, 0xA1, 0x3D, 0x77, 0x8F, 0x3F, 0x3E, 0xE7, 0x00 };
        static readonly byte[] ServerEncryptionKey = { 0x40, 0xAA, 0xD3, 0x92, 0x26, 0x71, 0x43, 0x47, 0x3A, 0x31, 0x08, 0xA6, 0xE7, 0xDC, 0x98, 0x2A };

        SARC4 SARC4Encrypt, SARC4Decrypt;
        HMACSHA1 DecryptSHA1, EncryptSHA1;

        public PacketCrypt()
        {
            IsInitialized = false;
        }

        public void Initialize(byte[] sessionKey)
        {
            if (IsInitialized)
                throw new InvalidOperationException("PacketCrypt already initialized!");

            SARC4Encrypt = new SARC4();
            SARC4Decrypt = new SARC4();

            DecryptSHA1 = new HMACSHA1(ServerDecryptionKey);
            EncryptSHA1 = new HMACSHA1(ServerEncryptionKey);

            SARC4Encrypt.PrepareKey(EncryptSHA1.ComputeHash(sessionKey));
            SARC4Decrypt.PrepareKey(DecryptSHA1.ComputeHash(sessionKey));

            byte[] PacketEncryptionDummy = new byte[0x400];
            byte[] PacketDecryptionDummy = new byte[0x400];

            SARC4Encrypt.ProcessBuffer(PacketEncryptionDummy, PacketEncryptionDummy.Length);
            SARC4Decrypt.ProcessBuffer(PacketDecryptionDummy, PacketDecryptionDummy.Length);

            IsInitialized = true;
        }

        public void Encrypt(byte[] data)
        {
            if (!IsInitialized)
                throw new InvalidOperationException("PacketCrypt not initialized!");

            SARC4Encrypt.ProcessBuffer(data, 4);
        }

        public void Decrypt(byte[] data)
        {
            if (!IsInitialized)
                throw new InvalidOperationException("PacketCrypt not initialized!");

            SARC4Decrypt.ProcessBuffer(data, 4);
        }

        public void Dispose()
        {
            //DecryptSHA1.Dispose();
            //EncryptSHA1.Dispose();

            IsInitialized = false;
        }
    }
}
