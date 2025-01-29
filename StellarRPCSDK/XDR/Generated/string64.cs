// Generated code - do not modify
// Source:

// typedef string string64<64>;


using System;

namespace stellar {

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
    }
    public static partial class string64Xdr
    {
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
