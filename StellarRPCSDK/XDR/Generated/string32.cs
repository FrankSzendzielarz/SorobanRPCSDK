// Generated code - do not modify
// Source:

// typedef string string32<32>;


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class string32
    {
        private string _innerValue;
        public string InnerValue
        {
            get => _innerValue;
            set
            {
                if (System.Text.Encoding.UTF8.GetByteCount(value) > 32)
                	throw new ArgumentException($"String exceeds 32 bytes when UTF8 encoded");
                _innerValue = value;
            }
        }

        public string32() { }

        public string32(string value)
        {
            InnerValue = value;
        }
    }
    public static partial class string32Xdr
    {
        public static void Encode(XdrWriter stream, string32 value)
        {
            stream.WriteString(value.InnerValue);
        }
        public static string32 Decode(XdrReader stream)
        {
            var result = new string32();
            result.InnerValue = stream.ReadString();
            return result;
        }
    }
}
