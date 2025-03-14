// Generated code - do not modify
// Source:

// typedef string SCString<>;


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class SCString
    {
        [ProtoMember(1)]
        public string InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inner Value")]
        #endif
        private string _innerValue;

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
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SCString DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SCStringXdr.Decode(reader);
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
