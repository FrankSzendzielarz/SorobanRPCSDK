// Generated code - do not modify
// Source:

// typedef string SCSymbol<SCSYMBOL_LIMIT>;


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSymbol
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

        public SCSymbol() { }

        public SCSymbol(string value)
        {
            InnerValue = value;
        }
    }
    public static partial class SCSymbolXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSymbol value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSymbolXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
