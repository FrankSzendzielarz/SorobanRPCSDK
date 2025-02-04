// Generated code - do not modify
// Source:

// struct SCSpecFunctionInputV0
// {
//     string doc<SC_SPEC_DOC_LIMIT>;
//     string name<30>;
//     SCSpecTypeDef type;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSpecFunctionInputV0
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
                if (System.Text.Encoding.UTF8.GetByteCount(value) > 30)
                	throw new ArgumentException($"String exceeds 30 bytes when UTF8 encoded");
                _name = value;
            }
        }

        private SCSpecTypeDef _type;
        public SCSpecTypeDef type
        {
            get => _type;
            set
            {
                _type = value;
            }
        }

        public SCSpecFunctionInputV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCSpecFunctionInputV0Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecFunctionInputV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecFunctionInputV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecFunctionInputV0 value)
        {
            value.Validate();
            stream.WriteString(value.doc);
            stream.WriteString(value.name);
            SCSpecTypeDefXdr.Encode(stream, value.type);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecFunctionInputV0 Decode(XdrReader stream)
        {
            var result = new SCSpecFunctionInputV0();
            result.doc = stream.ReadString();
            result.name = stream.ReadString();
            result.type = SCSpecTypeDefXdr.Decode(stream);
            return result;
        }
    }
}
