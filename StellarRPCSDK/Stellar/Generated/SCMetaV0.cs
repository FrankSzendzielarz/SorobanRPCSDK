// Generated code - do not modify
// Source:

// struct SCMetaV0
// {
//     string key<>;
//     string val<>;
// };


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
    public partial class SCMetaV0
    {
        [ProtoMember(1)]
        public string key
        {
            get => _key;
            set
            {
                _key = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Key")]
        #endif
        private string _key;

        [ProtoMember(2)]
        public string val
        {
            get => _val;
            set
            {
                _val = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Val")]
        #endif
        private string _val;

        public SCMetaV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCMetaV0Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCMetaV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCMetaV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SCMetaV0 DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SCMetaV0Xdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCMetaV0 value)
        {
            value.Validate();
            stream.WriteString(value.key);
            stream.WriteString(value.val);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCMetaV0 Decode(XdrReader stream)
        {
            var result = new SCMetaV0();
            result.key = stream.ReadString();
            result.val = stream.ReadString();
            return result;
        }
    }
}
