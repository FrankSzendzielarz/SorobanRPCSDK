// Generated code - do not modify
// Source:

// typedef opaque Signature<64>;


using System;
using System.IO;

namespace Stellar.XDR {

    /// <summary>
    /// variable size as the size depends on the signature scheme used
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class Signature
    {
        public byte[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length > 64)
                	throw new ArgumentException($"Cannot exceed 64 bytes");
                _innerValue = value;
            }
        }
        private byte[] _innerValue;

        public Signature() { }

        public Signature(byte[] value)
        {
            InnerValue = value;
        }
        public static implicit operator byte[](Signature _signature) => _signature.InnerValue;
        public static implicit operator Signature(byte[] value) => new Signature(value);
    }
    public static partial class SignatureXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(Signature value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SignatureXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, Signature value)
        {
            stream.WriteOpaque(value.InnerValue);
        }
        public static Signature Decode(XdrReader stream)
        {
            var result = new Signature();
            result.InnerValue = stream.ReadOpaque();
            return result;
        }
    }
}
