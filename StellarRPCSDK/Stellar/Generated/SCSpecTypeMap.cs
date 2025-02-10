// Generated code - do not modify
// Source:

// struct SCSpecTypeMap
// {
//     SCSpecTypeDef keyType;
//     SCSpecTypeDef valueType;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSpecTypeMap
    {
        public SCSpecTypeDef keyType
        {
            get => _keyType;
            set
            {
                _keyType = value;
            }
        }
        private SCSpecTypeDef _keyType;

        public SCSpecTypeDef valueType
        {
            get => _valueType;
            set
            {
                _valueType = value;
            }
        }
        private SCSpecTypeDef _valueType;

        public SCSpecTypeMap()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCSpecTypeMapXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecTypeMap value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecTypeMapXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecTypeMap value)
        {
            value.Validate();
            SCSpecTypeDefXdr.Encode(stream, value.keyType);
            SCSpecTypeDefXdr.Encode(stream, value.valueType);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecTypeMap Decode(XdrReader stream)
        {
            var result = new SCSpecTypeMap();
            result.keyType = SCSpecTypeDefXdr.Decode(stream);
            result.valueType = SCSpecTypeDefXdr.Decode(stream);
            return result;
        }
    }
}
