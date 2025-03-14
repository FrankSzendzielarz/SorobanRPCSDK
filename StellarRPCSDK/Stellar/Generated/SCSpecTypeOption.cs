// Generated code - do not modify
// Source:

// struct SCSpecTypeOption
// {
//     SCSpecTypeDef valueType;
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
    public partial class SCSpecTypeOption
    {
        [ProtoMember(1)]
        public SCSpecTypeDef valueType
        {
            get => _valueType;
            set
            {
                _valueType = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Value Type")]
        #endif
        private SCSpecTypeDef _valueType;

        public SCSpecTypeOption()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCSpecTypeOptionXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecTypeOption value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecTypeOptionXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SCSpecTypeOption DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SCSpecTypeOptionXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecTypeOption value)
        {
            value.Validate();
            SCSpecTypeDefXdr.Encode(stream, value.valueType);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecTypeOption Decode(XdrReader stream)
        {
            var result = new SCSpecTypeOption();
            result.valueType = SCSpecTypeDefXdr.Decode(stream);
            return result;
        }
    }
}
