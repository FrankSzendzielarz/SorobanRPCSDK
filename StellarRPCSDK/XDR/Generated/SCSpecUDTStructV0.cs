// Generated code - do not modify
// Source:

// struct SCSpecUDTStructV0
// {
//     string doc<SC_SPEC_DOC_LIMIT>;
//     string lib<80>;
//     string name<60>;
//     SCSpecUDTStructFieldV0 fields<40>;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSpecUDTStructV0
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

        private string _lib;
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

        private SCSpecUDTStructFieldV0[] _fields;
        public SCSpecUDTStructFieldV0[] fields
        {
            get => _fields;
            set
            {
                if (value.Length > 40)
                	throw new ArgumentException($"Cannot exceed 40 bytes");
                _fields = value;
            }
        }

        public SCSpecUDTStructV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (fields.Length > 40)
            	throw new InvalidOperationException($"fields cannot exceed 40 elements");
        }
    }
    public static partial class SCSpecUDTStructV0Xdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecUDTStructV0 value)
        {
            value.Validate();
            stream.WriteString(value.doc);
            stream.WriteString(value.lib);
            stream.WriteString(value.name);
            stream.WriteInt(value.fields.Length);
            foreach (var item in value.fields)
            {
                    SCSpecUDTStructFieldV0Xdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecUDTStructV0 Decode(XdrReader stream)
        {
            var result = new SCSpecUDTStructV0();
            result.doc = stream.ReadString();
            result.lib = stream.ReadString();
            result.name = stream.ReadString();
            {
                var length = stream.ReadInt();
                result.fields = new SCSpecUDTStructFieldV0[length];
                for (var i = 0; i < length; i++)
                {
                    result.fields[i] = SCSpecUDTStructFieldV0Xdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
