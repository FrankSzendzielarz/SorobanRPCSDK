// Generated code - do not modify
// Source:

// struct SCSpecTypeVec
// {
//     SCSpecTypeDef elementType;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSpecTypeVec
    {
        private SCSpecTypeDef _elementType;
        public SCSpecTypeDef elementType
        {
            get => _elementType;
            set
            {
                _elementType = value;
            }
        }

        public SCSpecTypeVec()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCSpecTypeVecXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecTypeVec value)
        {
            value.Validate();
            SCSpecTypeDefXdr.Encode(stream, value.elementType);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecTypeVec Decode(XdrReader stream)
        {
            var result = new SCSpecTypeVec();
            result.elementType = SCSpecTypeDefXdr.Decode(stream);
            return result;
        }
    }
}
