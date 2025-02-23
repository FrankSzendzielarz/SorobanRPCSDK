// Generated code - do not modify
// Source:

// union GeneralizedTransactionSet switch (int v)
// {
// // We consider the legacy TransactionSet to be v0.
// case 1:
//     TransactionSetV1 v1TxSet;
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
    [ProtoInclude(100, typeof(case_1), DataFormat = DataFormat.Default)]
    public abstract partial class GeneralizedTransactionSet
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        /// <summary>
        /// We consider the legacy TransactionSet to be v0.
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "GeneralizedTransactionSet_case_1")]
        public sealed partial class case_1 : GeneralizedTransactionSet
        {
            public override int Discriminator => 1;
            [ProtoMember(1)]
            public TransactionSetV1 v1TxSet
            {
                get => _v1TxSet;
                set
                {
                    _v1TxSet = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"V1 Tx Set")]
            #endif
            private TransactionSetV1 _v1TxSet;

            public override void ValidateCase() {}
        }
    }
    public static partial class GeneralizedTransactionSetXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(GeneralizedTransactionSet value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                GeneralizedTransactionSetXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static GeneralizedTransactionSet DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return GeneralizedTransactionSetXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, GeneralizedTransactionSet value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case GeneralizedTransactionSet.case_1 case_1:
                TransactionSetV1Xdr.Encode(stream, case_1.v1TxSet);
                break;
            }
        }
        public static GeneralizedTransactionSet Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case 1:
                var result_1 = new GeneralizedTransactionSet.case_1();
                result_1.v1TxSet = TransactionSetV1Xdr.Decode(stream);
                return result_1;
                default:
                throw new Exception($"Unknown discriminator for GeneralizedTransactionSet: {discriminator}");
            }
        }
    }
}
