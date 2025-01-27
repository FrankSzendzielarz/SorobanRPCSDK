// Generated code - do not modify
// Source:

// struct SCSpecUDTUnionCaseVoidV0
// {
//     string doc<SC_SPEC_DOC_LIMIT>;
//     string name<60>;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCSpecUDTUnionCaseVoidV0
    {
        public SCSpecUDTUnionCaseVoidV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCSpecUDTUnionCaseVoidV0Xdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCSpecUDTUnionCaseVoidV0 value)
        {
            value.Validate();
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCSpecUDTUnionCaseVoidV0 Decode(XdrReader stream)
        {
            var result = new SCSpecUDTUnionCaseVoidV0();
            return result;
        }
    }
}
