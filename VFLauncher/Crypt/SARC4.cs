using System;

namespace Cryptography
{
    public sealed class SARC4
    {
        internal byte[] S;
        byte tmp, tmp2;

        public SARC4()
        {
            S = new byte[0x100];
            tmp = 0;
            tmp2 = 0;
        }

        public void PrepareKey(byte[] key)
        {
            for (int i = 0; i < 0x100; i++)
                S[i] = (byte)i;

            var i2 = 0;

            for (int i = 0; i < 0x100; i++)
            {
                i2 = (byte)((i2 + S[i] + key[i % key.Length]) % 0x100);

                var tempS = S[i];

                S[i] = S[i2];
                S[i2] = tempS;
            }
        }

        public void ProcessBuffer(byte[] data, int len)
        {
            for (int i = 0; i < len; i++)
            {
                tmp = (byte)((tmp + 1) % 0x100);
                tmp2 = (byte)((tmp2 + S[tmp]) % 0x100);

                var sTemp = S[tmp];

                S[tmp] = S[tmp2];
                S[tmp2] = sTemp;

                data[i] = (byte)(S[(S[tmp] + S[tmp2]) % 0x100] ^ data[i]);
            }
        }
    }
}
