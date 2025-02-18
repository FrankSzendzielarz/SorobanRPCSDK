// Generated code - do not modify
// Source:

// struct SCSpecTypeVec
// {
//     SCSpecTypeDef elementType;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class SCSpecTypeVec
    {
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
