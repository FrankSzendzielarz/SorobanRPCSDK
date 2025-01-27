// Generated code - do not modify
// Source:

// typedef string SCSymbol<SCSYMBOL_LIMIT>;


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSymbol
    {
        private string[] _innerValue;
        public string[] InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }

        public SCSymbol() { }

        public SCSymbol(string[] value)
        {
            InnerValue = value;
        }
    }
    public static partial class SCSymbolXdr
    {
            public static void Encode(XdrWriter stream, SCSymbol value)
        {
            stream.WriteString(value.InnerValue);
        }
        public static SCSymbol Decode(XdrReader stream)
        {
            var result = new SCSymbol();
            result.InnerValue = stream.ReadString();
            return result;
        }
    }
}
