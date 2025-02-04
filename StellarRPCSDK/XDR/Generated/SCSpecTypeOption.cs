// Generated code - do not modify
// Source:

// struct SCSpecTypeOption
// {
//     SCSpecTypeDef valueType;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSpecTypeOption
    {
        private SCSpecTypeDef _valueType;
        public SCSpecTypeDef valueType
        {
            get => _valueType;
            set
            {
                _valueType = value;
            }
        }

        public SCSpecTypeOption()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCSpecTypeOptionXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecTypeOption value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecTypeOptionXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecTypeOption value)
        {
            value.Validate();
            SCSpecTypeDefXdr.Encode(stream, value.valueType);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecTypeOption Decode(XdrReader stream)
        {
            var result = new SCSpecTypeOption();
            result.valueType = SCSpecTypeDefXdr.Decode(stream);
            return result;
        }
    }
}
