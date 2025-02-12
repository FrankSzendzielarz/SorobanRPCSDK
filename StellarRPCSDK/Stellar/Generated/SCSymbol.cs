// Generated code - do not modify
// Source:

// typedef string SCSymbol<SCSYMBOL_LIMIT>;


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class SCSymbol
    {
        [MaxLength(32)]
        public string InnerValue
        {
            get => _innerValue;
            set
            {
                if (System.Text.Encoding.ASCII.GetByteCount(value) > Constants.SCSYMBOL_LIMIT)
                	throw new ArgumentException($"String exceeds Constants.SCSYMBOL_LIMIT bytes when ASCII encoded");
                _innerValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inner Value")]
        #endif
        private string _innerValue;

        public SCSymbol() { }

        public SCSymbol(string value)
        {
            InnerValue = value;
        }
        public static implicit operator string(SCSymbol _scsymbol) => _scsymbol.InnerValue;
        public static implicit operator SCSymbol(string value) => new SCSymbol(value);
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
