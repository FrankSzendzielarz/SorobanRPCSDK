// Generated code - do not modify
// Source:

// struct SCSpecTypeResult
// {
//     SCSpecTypeDef okType;
//     SCSpecTypeDef errorType;
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
    public partial class SCSpecTypeResult
    {
        public SCSpecTypeDef okType
        {
            get => _okType;
            set
            {
                _okType = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Ok Type")]
        #endif
        private SCSpecTypeDef _okType;

        public SCSpecTypeDef errorType
        {
            get => _errorType;
            set
            {
                _errorType = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Error Type")]
        #endif
        private SCSpecTypeDef _errorType;

        public SCSpecTypeResult()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCSpecTypeResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecTypeResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecTypeResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecTypeResult value)
        {
            value.Validate();
            SCSpecTypeDefXdr.Encode(stream, value.okType);
            SCSpecTypeDefXdr.Encode(stream, value.errorType);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecTypeResult Decode(XdrReader stream)
        {
            var result = new SCSpecTypeResult();
            result.okType = SCSpecTypeDefXdr.Decode(stream);
            result.errorType = SCSpecTypeDefXdr.Decode(stream);
            return result;
        }
    }
}
