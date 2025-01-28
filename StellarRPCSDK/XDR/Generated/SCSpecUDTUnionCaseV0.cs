// Generated code - do not modify
// Source:

// union SCSpecUDTUnionCaseV0 switch (SCSpecUDTUnionCaseV0Kind kind)
// {
// case SC_SPEC_UDT_UNION_CASE_VOID_V0:
//     SCSpecUDTUnionCaseVoidV0 voidCase;
// case SC_SPEC_UDT_UNION_CASE_TUPLE_V0:
//     SCSpecUDTUnionCaseTupleV0 tupleCase;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class SCSpecUDTUnionCaseV0
    {
        public abstract SCSpecUDTUnionCaseV0Kind Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class SCSpecUDTUnionCaseV0_SC_SPEC_UDT_UNION_CASE_VOID_V0 : SCSpecUDTUnionCaseV0
    {
        public override SCSpecUDTUnionCaseV0Kind Discriminator => SCSpecUDTUnionCaseV0Kind.SC_SPEC_UDT_UNION_CASE_VOID_V0;
        private SCSpecUDTUnionCaseVoidV0 _voidCase;
        public SCSpecUDTUnionCaseVoidV0 voidCase
        {
            get => _voidCase;
            set
            {
                _voidCase = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecUDTUnionCaseV0_SC_SPEC_UDT_UNION_CASE_TUPLE_V0 : SCSpecUDTUnionCaseV0
    {
        public override SCSpecUDTUnionCaseV0Kind Discriminator => SCSpecUDTUnionCaseV0Kind.SC_SPEC_UDT_UNION_CASE_TUPLE_V0;
        private SCSpecUDTUnionCaseTupleV0 _tupleCase;
        public SCSpecUDTUnionCaseTupleV0 tupleCase
        {
            get => _tupleCase;
            set
            {
                _tupleCase = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class SCSpecUDTUnionCaseV0Xdr
    {
        public static void Encode(XdrWriter stream, SCSpecUDTUnionCaseV0 value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SCSpecUDTUnionCaseV0_SC_SPEC_UDT_UNION_CASE_VOID_V0 case_SC_SPEC_UDT_UNION_CASE_VOID_V0:
                SCSpecUDTUnionCaseVoidV0Xdr.Encode(stream, case_SC_SPEC_UDT_UNION_CASE_VOID_V0.voidCase);
                break;
                case SCSpecUDTUnionCaseV0_SC_SPEC_UDT_UNION_CASE_TUPLE_V0 case_SC_SPEC_UDT_UNION_CASE_TUPLE_V0:
                SCSpecUDTUnionCaseTupleV0Xdr.Encode(stream, case_SC_SPEC_UDT_UNION_CASE_TUPLE_V0.tupleCase);
                break;
            }
        }
        public static SCSpecUDTUnionCaseV0 Decode(XdrReader stream)
        {
            var discriminator = (SCSpecUDTUnionCaseV0Kind)stream.ReadInt();
            switch (discriminator)
            {
                case SC_SPEC_UDT_UNION_CASE_VOID_V0:
                var result_SC_SPEC_UDT_UNION_CASE_VOID_V0 = new SCSpecUDTUnionCaseV0_SC_SPEC_UDT_UNION_CASE_VOID_V0();
                result_SC_SPEC_UDT_UNION_CASE_VOID_V0.                 = SCSpecUDTUnionCaseVoidV0Xdr.Decode(stream);
                return result_SC_SPEC_UDT_UNION_CASE_VOID_V0;
                case SC_SPEC_UDT_UNION_CASE_TUPLE_V0:
                var result_SC_SPEC_UDT_UNION_CASE_TUPLE_V0 = new SCSpecUDTUnionCaseV0_SC_SPEC_UDT_UNION_CASE_TUPLE_V0();
                result_SC_SPEC_UDT_UNION_CASE_TUPLE_V0.                 = SCSpecUDTUnionCaseTupleV0Xdr.Decode(stream);
                return result_SC_SPEC_UDT_UNION_CASE_TUPLE_V0;
                default:
                throw new Exception($"Unknown discriminator for SCSpecUDTUnionCaseV0: {discriminator}");
            }
        }
    }
}
