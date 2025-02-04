// Generated code - do not modify
// Source:

// struct SCSpecUDTUnionCaseTupleV0
// {
//     string doc<SC_SPEC_DOC_LIMIT>;
//     string name<60>;
//     SCSpecTypeDef type<12>;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSpecUDTUnionCaseTupleV0
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

        public SCSpecTypeDef[] type
        {
            get => _type;
            set
            {
                if (value.Length > 12)
                	throw new ArgumentException($"Cannot exceed 12 bytes");
                _type = value;
            }
        }
        private SCSpecTypeDef[] _type;

        public SCSpecUDTUnionCaseTupleV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (type.Length > 12)
            	throw new InvalidOperationException($"type cannot exceed 12 elements");
        }
    }
    public static partial class SCSpecUDTUnionCaseTupleV0Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecUDTUnionCaseTupleV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecUDTUnionCaseTupleV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecUDTUnionCaseTupleV0 value)
        {
            value.Validate();
            stream.WriteString(value.doc);
            stream.WriteString(value.name);
            stream.WriteInt(value.type.Length);
            foreach (var item in value.type)
            {
                    SCSpecTypeDefXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecUDTUnionCaseTupleV0 Decode(XdrReader stream)
        {
            var result = new SCSpecUDTUnionCaseTupleV0();
            result.doc = stream.ReadString();
            result.name = stream.ReadString();
            {
                var length = stream.ReadInt();
                result.type = new SCSpecTypeDef[length];
                for (var i = 0; i < length; i++)
                {
                    result.type[i] = SCSpecTypeDefXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
