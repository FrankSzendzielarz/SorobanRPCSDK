// Generated code - do not modify
// Source:

// struct SCSpecUDTUnionV0
// {
//     string doc<SC_SPEC_DOC_LIMIT>;
//     string lib<80>;
//     string name<60>;
//     SCSpecUDTUnionCaseV0 cases<50>;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSpecUDTUnionV0
    {
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
        private string _doc;

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
        private string _lib;

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
        private string _name;

        [MaxLength(50)]
        public SCSpecUDTUnionCaseV0[] cases
        {
            get => _cases;
            set
            {
                if (value.Length > 50)
                	throw new ArgumentException($"Cannot exceed 50 in length");
                _cases = value;
            }
        }
        private SCSpecUDTUnionCaseV0[] _cases;

        public SCSpecUDTUnionV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (cases.Length > 50)
            	throw new InvalidOperationException($"cases cannot exceed 50 elements");
        }
    }
    public static partial class SCSpecUDTUnionV0Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecUDTUnionV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecUDTUnionV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecUDTUnionV0 value)
        {
            value.Validate();
            stream.WriteString(value.doc);
            stream.WriteString(value.lib);
            stream.WriteString(value.name);
            stream.WriteInt(value.cases.Length);
            foreach (var item in value.cases)
            {
                    SCSpecUDTUnionCaseV0Xdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecUDTUnionV0 Decode(XdrReader stream)
        {
            var result = new SCSpecUDTUnionV0();
            result.doc = stream.ReadString();
            result.lib = stream.ReadString();
            result.name = stream.ReadString();
            {
                var length = stream.ReadInt();
                result.cases = new SCSpecUDTUnionCaseV0[length];
                for (var i = 0; i < length; i++)
                {
                    result.cases[i] = SCSpecUDTUnionCaseV0Xdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
