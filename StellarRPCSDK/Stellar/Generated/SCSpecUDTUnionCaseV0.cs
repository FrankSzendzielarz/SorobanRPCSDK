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
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    [ProtoInclude(100, typeof(ScSpecUdtUnionCaseVoidV0), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(ScSpecUdtUnionCaseTupleV0), DataFormat = DataFormat.Default)]
    public abstract partial class SCSpecUDTUnionCaseV0
    {
        public abstract SCSpecUDTUnionCaseV0Kind Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "SCSpecUDTUnionCaseV0_ScSpecUdtUnionCaseVoidV0")]
        public sealed partial class ScSpecUdtUnionCaseVoidV0 : SCSpecUDTUnionCaseV0
        {
            public override SCSpecUDTUnionCaseV0Kind Discriminator => SCSpecUDTUnionCaseV0Kind.SC_SPEC_UDT_UNION_CASE_VOID_V0;
            [ProtoMember(1)]
            public SCSpecUDTUnionCaseVoidV0 voidCase
            {
                get => _voidCase;
                set
                {
                    _voidCase = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Void Case")]
            #endif
            private SCSpecUDTUnionCaseVoidV0 _voidCase;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SCSpecUDTUnionCaseV0_ScSpecUdtUnionCaseTupleV0")]
        public sealed partial class ScSpecUdtUnionCaseTupleV0 : SCSpecUDTUnionCaseV0
        {
            public override SCSpecUDTUnionCaseV0Kind Discriminator => SCSpecUDTUnionCaseV0Kind.SC_SPEC_UDT_UNION_CASE_TUPLE_V0;
            [ProtoMember(2)]
            public SCSpecUDTUnionCaseTupleV0 tupleCase
            {
                get => _tupleCase;
                set
                {
                    _tupleCase = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Tuple Case")]
            #endif
            private SCSpecUDTUnionCaseTupleV0 _tupleCase;

            public override void ValidateCase() {}
        }
    }
    public static partial class SCSpecUDTUnionCaseV0Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecUDTUnionCaseV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecUDTUnionCaseV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SCSpecUDTUnionCaseV0 DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SCSpecUDTUnionCaseV0Xdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, SCSpecUDTUnionCaseV0 value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SCSpecUDTUnionCaseV0.ScSpecUdtUnionCaseVoidV0 case_SC_SPEC_UDT_UNION_CASE_VOID_V0:
                SCSpecUDTUnionCaseVoidV0Xdr.Encode(stream, case_SC_SPEC_UDT_UNION_CASE_VOID_V0.voidCase);
                break;
                case SCSpecUDTUnionCaseV0.ScSpecUdtUnionCaseTupleV0 case_SC_SPEC_UDT_UNION_CASE_TUPLE_V0:
                SCSpecUDTUnionCaseTupleV0Xdr.Encode(stream, case_SC_SPEC_UDT_UNION_CASE_TUPLE_V0.tupleCase);
                break;
            }
        }
        public static SCSpecUDTUnionCaseV0 Decode(XdrReader stream)
        {
            var discriminator = (SCSpecUDTUnionCaseV0Kind)stream.ReadInt();
            switch (discriminator)
            {
                case SCSpecUDTUnionCaseV0Kind.SC_SPEC_UDT_UNION_CASE_VOID_V0:
                var result_SC_SPEC_UDT_UNION_CASE_VOID_V0 = new SCSpecUDTUnionCaseV0.ScSpecUdtUnionCaseVoidV0();
                result_SC_SPEC_UDT_UNION_CASE_VOID_V0.voidCase = SCSpecUDTUnionCaseVoidV0Xdr.Decode(stream);
                return result_SC_SPEC_UDT_UNION_CASE_VOID_V0;
                case SCSpecUDTUnionCaseV0Kind.SC_SPEC_UDT_UNION_CASE_TUPLE_V0:
                var result_SC_SPEC_UDT_UNION_CASE_TUPLE_V0 = new SCSpecUDTUnionCaseV0.ScSpecUdtUnionCaseTupleV0();
                result_SC_SPEC_UDT_UNION_CASE_TUPLE_V0.tupleCase = SCSpecUDTUnionCaseTupleV0Xdr.Decode(stream);
                return result_SC_SPEC_UDT_UNION_CASE_TUPLE_V0;
                default:
                throw new Exception($"Unknown discriminator for SCSpecUDTUnionCaseV0: {discriminator}");
            }
        }
    }
}
