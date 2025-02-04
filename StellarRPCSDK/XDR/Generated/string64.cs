// Generated code - do not modify
// Source:

// typedef string string64<64>;


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class string64
    {
        private string _innerValue;
        public string InnerValue
        {
            get => _innerValue;
            set
            {
                if (System.Text.Encoding.UTF8.GetByteCount(value) > 64)
                	throw new ArgumentException($"String exceeds 64 bytes when UTF8 encoded");
                _innerValue = value;
            }
        }

        public string64() { }

        public string64(string value)
        {
            InnerValue = value;
        }
        public static implicit operator string(string64 _string64) => _string64.InnerValue;
        public static implicit operator string64(string value) => new string64(value);
    }
    public static partial class string64Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(string64 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                string64Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, string64 value)
        {
            stream.WriteString(value.InnerValue);
        }
        public static string64 Decode(XdrReader stream)
        {
            var result = new string64();
            result.InnerValue = stream.ReadString();
            return result;
        }
    }
}
