// Generated code - do not modify
// Source:

// typedef string SCString<>;


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCString
    {
        private string _innerValue;
        public string InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }

        public SCString() { }

        public SCString(string value)
        {
            InnerValue = value;
        }
        public static implicit operator string(SCString _scstring) => _scstring.InnerValue;
        public static implicit operator SCString(string value) => new SCString(value);
    }
    public static partial class SCStringXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCString value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCStringXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, SCString value)
        {
            stream.WriteString(value.InnerValue);
        }
        public static SCString Decode(XdrReader stream)
        {
            var result = new SCString();
            result.InnerValue = stream.ReadString();
            return result;
        }
    }
}
