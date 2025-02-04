// Generated code - do not modify
// Source:

// typedef opaque EncryptedBody<64000>;


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class EncryptedBody
    {
        private byte[] _innerValue;
        public byte[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length > 64000)
                	throw new ArgumentException($"Cannot exceed 64000 bytes");
                _innerValue = value;
            }
        }

        public EncryptedBody() { }

        public EncryptedBody(byte[] value)
        {
            InnerValue = value;
        }
    }
    public static partial class EncryptedBodyXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(EncryptedBody value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                EncryptedBodyXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, EncryptedBody value)
        {
            stream.WriteOpaque(value.InnerValue);
        }
        public static EncryptedBody Decode(XdrReader stream)
        {
            var result = new EncryptedBody();
            result.InnerValue = stream.ReadOpaque();
            return result;
        }
    }
}
