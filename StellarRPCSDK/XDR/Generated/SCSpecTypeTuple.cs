// Generated code - do not modify
// Source:

// struct SCSpecTypeTuple
// {
//     SCSpecTypeDef valueTypes<12>;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSpecTypeTuple
    {
        public SCSpecTypeDef[] valueTypes
        {
            get => _valueTypes;
            set
            {
                if (value.Length > 12)
                	throw new ArgumentException($"Cannot exceed 12 bytes");
                _valueTypes = value;
            }
        }
        private SCSpecTypeDef[] _valueTypes;

        public SCSpecTypeTuple()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (valueTypes.Length > 12)
            	throw new InvalidOperationException($"valueTypes cannot exceed 12 elements");
        }
    }
    public static partial class SCSpecTypeTupleXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecTypeTuple value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecTypeTupleXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecTypeTuple value)
        {
            value.Validate();
            stream.WriteInt(value.valueTypes.Length);
            foreach (var item in value.valueTypes)
            {
                    SCSpecTypeDefXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecTypeTuple Decode(XdrReader stream)
        {
            var result = new SCSpecTypeTuple();
            {
                var length = stream.ReadInt();
                result.valueTypes = new SCSpecTypeDef[length];
                for (var i = 0; i < length; i++)
                {
                    result.valueTypes[i] = SCSpecTypeDefXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
