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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSpecUDTErrorEnumCaseV0
    {
        public string doc
        {
            get => _doc;
            set
            {
                if (System.Text.Encoding.UTF8.GetByteCount(value) > Constants.SC_SPEC_DOC_LIMIT)
                	throw new ArgumentException($"String exceeds Constants.SC_SPEC_DOC_LIMIT bytes when UTF8 encoded");
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

        public uint32 value
        {
            get => _value;
            set
            {
                _value = value;
            }
        }
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
