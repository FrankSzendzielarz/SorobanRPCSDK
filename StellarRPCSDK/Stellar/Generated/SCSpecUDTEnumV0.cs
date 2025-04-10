// Generated code - do not modify
// Source:

// struct SCSpecUDTEnumV0
// {
//     string doc<SC_SPEC_DOC_LIMIT>;
//     string lib<80>;
//     string name<60>;
//     SCSpecUDTEnumCaseV0 cases<50>;
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
    public partial class SCSpecUDTEnumV0
    {
        [ProtoMember(1)]
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

        [ProtoMember(2)]
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

        [ProtoMember(3)]
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

        [ProtoMember(4, OverwriteList = true)]
        [MaxLength(50)]
        public SCSpecUDTEnumCaseV0[] cases
        {
            get => _cases;
            set
            {
                if (value.Length > 50)
                	throw new ArgumentException($"Cannot exceed 50 in length");
                _cases = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Cases")]
        #endif
        private SCSpecUDTEnumCaseV0[] _cases;

        public SCSpecUDTEnumV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (cases.Length > 50)
            	throw new InvalidOperationException($"cases cannot exceed 50 elements");
        }
    }
    public static partial class SCSpecUDTEnumV0Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecUDTEnumV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecUDTEnumV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SCSpecUDTEnumV0 DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SCSpecUDTEnumV0Xdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecUDTEnumV0 value)
        {
            value.Validate();
            stream.WriteString(value.doc);
            stream.WriteString(value.lib);
            stream.WriteString(value.name);
            stream.WriteInt(value.cases.Length);
            foreach (var item in value.cases)
            {
                    SCSpecUDTEnumCaseV0Xdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecUDTEnumV0 Decode(XdrReader stream)
        {
            var result = new SCSpecUDTEnumV0();
            result.doc = stream.ReadString();
            result.lib = stream.ReadString();
            result.name = stream.ReadString();
            {
                var length = stream.ReadInt();
                result.cases = new SCSpecUDTEnumCaseV0[length];
                for (var i = 0; i < length; i++)
                {
                    result.cases[i] = SCSpecUDTEnumCaseV0Xdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
