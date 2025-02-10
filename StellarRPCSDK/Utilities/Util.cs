using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Stellar.Utilities
{
    public static class Util
    {
        /// <summary>
        /// Convert to BigEndian if the platform is little endian.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] ToBigEndian(this byte[] data)
        {
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(data);
            }
            return data;
        }

        /// <summary>
        /// Computes the SHA-256 hash of the input data.
        /// </summary>
        /// <param name="data">The data to hash. Must not be null.</param>
        /// <returns>The SHA-256 hash of the input data.</returns>
        /// <exception cref="ArgumentNullException">Thrown when data is null.</exception>
        public static byte[] Hash(byte[] data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(data);
            }
        }

    }
}
