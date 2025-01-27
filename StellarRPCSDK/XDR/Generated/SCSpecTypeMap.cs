// Generated code - do not modify
// Source:

// struct SCSpecTypeMap
// {
//     SCSpecTypeDef keyType;
//     SCSpecTypeDef valueType;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSpecTypeMap
    {
        private SCSpecTypeDef _keyType;
        public SCSpecTypeDef keyType
        {
            get => _keyType;
            set
            {
                _keyType = value;
            }
        }

        private SCSpecTypeDef _valueType;
        public SCSpecTypeDef valueType
        {
            get => _valueType;
            set
            {
                _valueType = value;
            }
        }

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
