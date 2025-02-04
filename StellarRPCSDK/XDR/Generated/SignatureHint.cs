// Generated code - do not modify
// Source:

// typedef opaque SignatureHint[4];


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SignatureHint
    {
        private byte[] _innerValue = new byte[4];
        public byte[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length != 4)
                	throw new ArgumentException($"Must be exactly 4 bytes");
                _innerValue = value;
            }
        }

        public SignatureHint() { }

        public SignatureHint(byte[] value)
        {
            InnerValue = value;
        }
        public static implicit operator byte[](SignatureHint _signaturehint) => _signaturehint.InnerValue;
        public static implicit operator SignatureHint(byte[] value) => new SignatureHint(value);
    }
    public static partial class SignatureHintXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SignatureHint value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SignatureHintXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, SignatureHint value)
        {
            stream.WriteFixedOpaque(value.InnerValue);
        }
        public static SignatureHint Decode(XdrReader stream)
        {
            var result = new SignatureHint();
            stream.ReadFixedOpaque(result.InnerValue);
            return result;
        }
    }
}
