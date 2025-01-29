// Generated code - do not modify
// Source:

// struct SCSpecUDTUnionCaseVoidV0
// {
//     string doc<SC_SPEC_DOC_LIMIT>;
//     string name<60>;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSpecUDTUnionCaseVoidV0
    {
        private string _doc;
        public string doc
        {
            get => _doc;
            set
            {
                _doc = value;
            }
        }

        private string _name;
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
