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
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSpecFunctionInputV0
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

        public string name
        {
            get => _name;
            set
            {
                if (System.Text.Encoding.ASCII.GetByteCount(value) > 30)
                	throw new ArgumentException($"String exceeds 30 bytes when ASCII encoded");
                _name = value;
            }
        }
        private string _name;

        public SCSpecTypeDef type
        {
            get => _type;
            set
            {
                _type = value;
            }
        }
        private SCSpecTypeDef _type;

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
