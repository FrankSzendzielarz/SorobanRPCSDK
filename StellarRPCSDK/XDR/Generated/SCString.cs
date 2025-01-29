// Generated code - do not modify
// Source:

// typedef string SCString<>;


using System;

namespace stellar {

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
    }
    public static partial class SCStringXdr
    {
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
