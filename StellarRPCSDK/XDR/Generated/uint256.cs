// Generated code - do not modify
// Source:

// typedef opaque uint256[32];


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class uint256
    {
        private byte[] _innerValue = new byte[32];
        public byte[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length != 32)
                	throw new ArgumentException($"Must be exactly 32 bytes");
                _innerValue = value;
            }
        }

        public uint256() { }

        public uint256(byte[] value)
        {
            InnerValue = value;
        }
    }
    public static partial class uint256Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(uint256 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                uint256Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, uint256 value)
        {
            stream.WriteFixedOpaque(value.InnerValue);
        }
        public static uint256 Decode(XdrReader stream)
        {
            var result = new uint256();
            stream.ReadFixedOpaque(result.InnerValue);
            return result;
        }
    }
}
