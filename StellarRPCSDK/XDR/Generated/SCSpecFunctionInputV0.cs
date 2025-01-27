// Generated code - do not modify
// Source:

// struct SCSpecFunctionInputV0
// {
//     string doc<SC_SPEC_DOC_LIMIT>;
//     string name<30>;
//     SCSpecTypeDef type;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSpecFunctionInputV0
    {
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
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecFunctionInputV0 value)
        {
            value.Validate();
            SCSpecTypeDefXdr.Encode(stream, value.type);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecFunctionInputV0 Decode(XdrReader stream)
        {
            var result = new SCSpecFunctionInputV0();
            result.type = SCSpecTypeDefXdr.Decode(stream);
            return result;
        }
    }
}
