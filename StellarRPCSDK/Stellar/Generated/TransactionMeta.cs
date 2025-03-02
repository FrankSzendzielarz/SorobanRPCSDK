// Generated code - do not modify
// Source:

// union TransactionMeta switch (int v)
// {
// case 0:
//     OperationMeta operations<>;
// case 1:
//     TransactionMetaV1 v1;
// case 2:
//     TransactionMetaV2 v2;
// case 3:
//     TransactionMetaV3 v3;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    /// <summary>
    /// it does not include pre-apply updates such as fees
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    [ProtoInclude(100, typeof(case_0), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(case_1), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(case_2), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(case_3), DataFormat = DataFormat.Default)]
    public abstract partial class TransactionMeta
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "TransactionMeta_case_0")]
        public sealed partial class case_0 : TransactionMeta
        {
            public override int Discriminator => 0;
            [ProtoMember(1, OverwriteList = true)]
            public OperationMeta[] operations
            {
                get => _operations;
                set
                {
                    _operations = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Operations")]
            #endif
            private OperationMeta[] _operations;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "TransactionMeta_case_1")]
        public sealed partial class case_1 : TransactionMeta
        {
            public override int Discriminator => 1;
            [ProtoMember(2)]
            public TransactionMetaV1 v1
            {
                get => _v1;
                set
                {
                    _v1 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"V1")]
            #endif
            private TransactionMetaV1 _v1;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "TransactionMeta_case_2")]
        public sealed partial class case_2 : TransactionMeta
        {
            public override int Discriminator => 2;
            [ProtoMember(3)]
            public TransactionMetaV2 v2
            {
                get => _v2;
                set
                {
                    _v2 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"V2")]
            #endif
            private TransactionMetaV2 _v2;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "TransactionMeta_case_3")]
        public sealed partial class case_3 : TransactionMeta
        {
            public override int Discriminator => 3;
            [ProtoMember(4)]
            public TransactionMetaV3 v3
            {
                get => _v3;
                set
                {
                    _v3 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"V3")]
            #endif
            private TransactionMetaV3 _v3;

            public override void ValidateCase() {}
        }
    }
    public static partial class TransactionMetaXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TransactionMeta value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TransactionMetaXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static TransactionMeta DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return TransactionMetaXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, TransactionMeta value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case TransactionMeta.case_0 case_0:
                stream.WriteInt(case_0.operations.Length);
                foreach (var item in case_0.operations)
                {
                        OperationMetaXdr.Encode(stream, item);
                }
                break;
                case TransactionMeta.case_1 case_1:
                TransactionMetaV1Xdr.Encode(stream, case_1.v1);
                break;
                case TransactionMeta.case_2 case_2:
                TransactionMetaV2Xdr.Encode(stream, case_2.v2);
                break;
                case TransactionMeta.case_3 case_3:
                TransactionMetaV3Xdr.Encode(stream, case_3.v3);
                break;
            }
        }
        public static TransactionMeta Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case 0:
                var result_0 = new TransactionMeta.case_0();
                {
                    var length = stream.ReadInt();
                    result_0.operations = new OperationMeta[length];
                    for (var i = 0; i < length; i++)
                    {
                        result_0.operations[i] = OperationMetaXdr.Decode(stream);
                    }
                }
                return result_0;
                case 1:
                var result_1 = new TransactionMeta.case_1();
                result_1.v1 = TransactionMetaV1Xdr.Decode(stream);
                return result_1;
                case 2:
                var result_2 = new TransactionMeta.case_2();
                result_2.v2 = TransactionMetaV2Xdr.Decode(stream);
                return result_2;
                case 3:
                var result_3 = new TransactionMeta.case_3();
                result_3.v3 = TransactionMetaV3Xdr.Decode(stream);
                return result_3;
                default:
                throw new Exception($"Unknown discriminator for TransactionMeta: {discriminator}");
            }
        }
    }
}
