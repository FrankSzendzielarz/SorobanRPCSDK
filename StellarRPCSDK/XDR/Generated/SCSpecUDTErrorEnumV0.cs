// Generated code - do not modify
// Source:

// struct SCSpecUDTErrorEnumV0
// {
//     string doc<SC_SPEC_DOC_LIMIT>;
//     string lib<80>;
//     string name<60>;
//     SCSpecUDTErrorEnumCaseV0 cases<50>;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSpecUDTErrorEnumV0
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

        public string lib
        {
            get => _lib;
            set
            {
                if (System.Text.Encoding.UTF8.GetByteCount(value) > 80)
                	throw new ArgumentException($"String exceeds 80 bytes when UTF8 encoded");
                _lib = value;
            }
        }
        private string _lib;

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

        public SCSpecUDTErrorEnumCaseV0[] cases
        {
            get => _cases;
            set
            {
                if (value.Length > 50)
                	throw new ArgumentException($"Cannot exceed 50 bytes");
                _cases = value;
            }
        }
        private SCSpecUDTErrorEnumCaseV0[] _cases;

        public SCSpecUDTErrorEnumV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (cases.Length > 50)
            	throw new InvalidOperationException($"cases cannot exceed 50 elements");
        }
    }
    public static partial class SCSpecUDTErrorEnumV0Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecUDTErrorEnumV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecUDTErrorEnumV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecUDTErrorEnumV0 value)
        {
            value.Validate();
            stream.WriteString(value.doc);
            stream.WriteString(value.lib);
            stream.WriteString(value.name);
            stream.WriteInt(value.cases.Length);
            foreach (var item in value.cases)
            {
                    SCSpecUDTErrorEnumCaseV0Xdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecUDTErrorEnumV0 Decode(XdrReader stream)
        {
            var result = new SCSpecUDTErrorEnumV0();
            result.doc = stream.ReadString();
            result.lib = stream.ReadString();
            result.name = stream.ReadString();
            {
                var length = stream.ReadInt();
                result.cases = new SCSpecUDTErrorEnumCaseV0[length];
                for (var i = 0; i < length; i++)
                {
                    result.cases[i] = SCSpecUDTErrorEnumCaseV0Xdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
