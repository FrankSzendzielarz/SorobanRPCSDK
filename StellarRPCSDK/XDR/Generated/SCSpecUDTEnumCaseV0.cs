// Generated code - do not modify
// Source:

// struct SCSpecUDTEnumCaseV0
// {
//     string doc<SC_SPEC_DOC_LIMIT>;
//     string name<60>;
//     uint32 value;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSpecUDTEnumCaseV0
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

        private uint32 _value;
        public uint32 value
        {
            get => _value;
            set
            {
                _value = value;
            }
        }

        public SCSpecUDTEnumCaseV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCSpecUDTEnumCaseV0Xdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecUDTEnumCaseV0 value)
        {
            value.Validate();
            stream.WriteString(value.doc);
            stream.WriteString(value.name);
            uint32Xdr.Encode(stream, value.value);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecUDTEnumCaseV0 Decode(XdrReader stream)
        {
            var result = new SCSpecUDTEnumCaseV0();
            result.doc = stream.ReadString();
            result.name = stream.ReadString();
            result.value = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
