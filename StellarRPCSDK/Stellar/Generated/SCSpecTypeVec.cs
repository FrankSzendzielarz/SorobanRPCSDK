// Generated code - do not modify
// Source:

// struct SCSpecTypeVec
// {
//     SCSpecTypeDef elementType;
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
    public partial class SCSpecTypeVec
    {
        [ProtoMember(1)]
        public SCSpecTypeDef elementType
        {
            get => _elementType;
            set
            {
                _elementType = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Element Type")]
        #endif
        private SCSpecTypeDef _elementType;

        public SCSpecTypeVec()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCSpecTypeVecXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecTypeVec value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecTypeVecXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SCSpecTypeVec DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SCSpecTypeVecXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecTypeVec value)
        {
            value.Validate();
            SCSpecTypeDefXdr.Encode(stream, value.elementType);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecTypeVec Decode(XdrReader stream)
        {
            var result = new SCSpecTypeVec();
            result.elementType = SCSpecTypeDefXdr.Decode(stream);
            return result;
        }
    }
}
