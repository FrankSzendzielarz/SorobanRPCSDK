// Generated code - do not modify
// Source:

// struct SCSpecUDTStructV0
// {
//     string doc<SC_SPEC_DOC_LIMIT>;
//     string lib<80>;
//     string name<60>;
//     SCSpecUDTStructFieldV0 fields<40>;
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
    public partial class SCSpecUDTStructV0
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
        	[SerializeReference]
        	[InspectorName(@"Doc")]
        #endif
        private string _doc;

        [MaxLength(80)]
        public string lib
        {
            get => _lib;
            set
            {
                if (System.Text.Encoding.ASCII.GetByteCount(value) > 80)
                	throw new ArgumentException($"String exceeds 80 bytes when ASCII encoded");
                _lib = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Lib")]
        #endif
        private string _lib;

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
        	[SerializeReference]
        	[InspectorName(@"Name")]
        #endif
        private string _name;

        [MaxLength(40)]
        public SCSpecUDTStructFieldV0[] fields
        {
            get => _fields;
            set
            {
                if (value.Length > 40)
                	throw new ArgumentException($"Cannot exceed 40 in length");
                _fields = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Fields")]
        #endif
        private SCSpecUDTStructFieldV0[] _fields;

        public SCSpecUDTStructV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (fields.Length > 40)
            	throw new InvalidOperationException($"fields cannot exceed 40 elements");
        }
    }
    public static partial class SCSpecUDTStructV0Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecUDTStructV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecUDTStructV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecUDTStructV0 value)
        {
            value.Validate();
            stream.WriteString(value.doc);
            stream.WriteString(value.lib);
            stream.WriteString(value.name);
            stream.WriteInt(value.fields.Length);
            foreach (var item in value.fields)
            {
                    SCSpecUDTStructFieldV0Xdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecUDTStructV0 Decode(XdrReader stream)
        {
            var result = new SCSpecUDTStructV0();
            result.doc = stream.ReadString();
            result.lib = stream.ReadString();
            result.name = stream.ReadString();
            {
                var length = stream.ReadInt();
                result.fields = new SCSpecUDTStructFieldV0[length];
                for (var i = 0; i < length; i++)
                {
                    result.fields[i] = SCSpecUDTStructFieldV0Xdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
