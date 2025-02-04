// Generated code - do not modify
// Source:

// typedef opaque SCBytes<>;


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCBytes
    {
        private byte[] _innerValue;
        public byte[] InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }

        public SCBytes() { }

        public SCBytes(byte[] value)
        {
            InnerValue = value;
        }
        public static implicit operator byte[](SCBytes _scbytes) => _scbytes.InnerValue;
        public static implicit operator SCBytes(byte[] value) => new SCBytes(value);
    }
    public static partial class SCBytesXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCBytes value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCBytesXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, SCBytes value)
        {
            stream.WriteOpaque(value.InnerValue);
        }
        public static SCBytes Decode(XdrReader stream)
        {
            var result = new SCBytes();
            result.InnerValue = stream.ReadOpaque();
            return result;
        }
    }
}
