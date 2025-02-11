// Generated code - do not modify
// Source:

// struct SCSpecUDTErrorEnumCaseV0
// {
//     string doc<SC_SPEC_DOC_LIMIT>;
//     string name<60>;
//     uint32 value;
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
    public partial class SCSpecUDTErrorEnumCaseV0
    {
        [MaxLength(1024)]
        public string doc
        {
            get => _doc;
            set
            {
                if (System.Text.Encoding.ASCII.GetByteCount(value) > Constants.SC_SPEC_DOC_LIMIT)
                	throw new ArgumentException($"String exceeds Constants.SC_SPEC_DOC_LIMIT bytes when ASCII encoded");
                _doc = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Doc")]
        #endif
        private string _doc;

        [MaxLength(60)]
        public string name
        {
            get => _name;
            set
            {
                if (System.Text.Encoding.ASCII.GetByteCount(value) > 60)
                	throw new ArgumentException($"String exceeds 60 bytes when ASCII encoded");
                _name = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Name")]
        #endif
        private string _name;

        public uint32 value
        {
            get => _value;
            set
            {
                _value = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Value")]
        #endif
        private uint32 _value;

        public SCSpecUDTErrorEnumCaseV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCSpecUDTErrorEnumCaseV0Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecUDTErrorEnumCaseV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecUDTErrorEnumCaseV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecUDTErrorEnumCaseV0 value)
        {
            value.Validate();
            stream.WriteString(value.doc);
            stream.WriteString(value.name);
            uint32Xdr.Encode(stream, value.value);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecUDTErrorEnumCaseV0 Decode(XdrReader stream)
        {
            var result = new SCSpecUDTErrorEnumCaseV0();
            result.doc = stream.ReadString();
            result.name = stream.ReadString();
            result.value = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
