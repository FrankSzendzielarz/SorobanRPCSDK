// Generated code - do not modify
// Source:

// struct SCSpecUDTUnionCaseVoidV0
// {
//     string doc<SC_SPEC_DOC_LIMIT>;
//     string name<60>;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSpecUDTUnionCaseVoidV0
    {
        public string doc
        {
            get => _doc;
            set
            {
                _doc = value;
            }
        }
        private string _doc;

        public string name
        {
            get => _name;
            set
            {
                if (System.Text.Encoding.UTF8.GetByteCount(value) > 60)
                	throw new ArgumentException($"String exceeds 60 bytes when UTF8 encoded");
                _name = value;
            }
        }
        private string _name;

        public SCSpecUDTUnionCaseVoidV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCSpecUDTUnionCaseVoidV0Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecUDTUnionCaseVoidV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecUDTUnionCaseVoidV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecUDTUnionCaseVoidV0 value)
        {
            value.Validate();
            stream.WriteString(value.doc);
            stream.WriteString(value.name);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecUDTUnionCaseVoidV0 Decode(XdrReader stream)
        {
            var result = new SCSpecUDTUnionCaseVoidV0();
            result.doc = stream.ReadString();
            result.name = stream.ReadString();
            return result;
        }
    }
}
