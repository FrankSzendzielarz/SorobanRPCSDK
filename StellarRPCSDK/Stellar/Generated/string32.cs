// Generated code - do not modify
// Source:

// typedef string string32<32>;


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class string32
    {
        [MaxLength(32)]
        public string InnerValue
        {
            get => _innerValue;
            set
            {
                if (System.Text.Encoding.ASCII.GetByteCount(value) > 32)
                	throw new ArgumentException($"String exceeds 32 bytes when ASCII encoded");
                _innerValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inner Value")]
        #endif
        private string _innerValue;

        public string32() { }

        public string32(string value)
        {
            InnerValue = value;
        }
        public static implicit operator string(string32 _string32) => _string32.InnerValue;
        public static implicit operator string32(string value) => new string32(value);
    }
    public static partial class string32Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(string32 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                string32Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
