using System;
using System.Collections.Generic;
using System.Text;

namespace Stellar.Utilities
{
    public static class Util
    {
        public static byte[] ToBigEndian(this byte[] data)
        {
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(data);
            }
            return data;
        }
    }
}
