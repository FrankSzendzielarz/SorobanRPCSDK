// Generated code - do not modify
// Source:

// typedef opaque Hash[32];


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class Hash
    {
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
        private byte[] _innerValue = new byte[32];

        public Hash() { }

        public Hash(byte[] value)
        {
            InnerValue = value;
        }
        public static implicit operator byte[](Hash _hash) => _hash.InnerValue;
        public static implicit operator Hash(byte[] value) => new Hash(value);
    }
    public static partial class HashXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(Hash value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                HashXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, Hash value)
        {
            stream.WriteFixedOpaque(value.InnerValue);
        }
        public static Hash Decode(XdrReader stream)
        {
            var result = new Hash();
            stream.ReadFixedOpaque(result.InnerValue);
            return result;
        }
    }
}
