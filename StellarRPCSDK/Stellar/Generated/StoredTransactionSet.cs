// Generated code - do not modify
// Source:

// union StoredTransactionSet switch (int v)
// {
// case 0:
// 	TransactionSet txSet;
// case 1:
// 	GeneralizedTransactionSet generalizedTxSet;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public abstract partial class StoredTransactionSet
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        public sealed partial class case_0 : StoredTransactionSet
        {
            public override int Discriminator => 0;
            public TransactionSet txSet
            {
                get => _txSet;
                set
                {
                    _txSet = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[InspectorName(@"Tx Set")]
            #endif
            private TransactionSet _txSet;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class case_1 : StoredTransactionSet
        {
            public override int Discriminator => 1;
            public GeneralizedTransactionSet generalizedTxSet
            {
                get => _generalizedTxSet;
                set
                {
                    _generalizedTxSet = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[InspectorName(@"Generalized Tx Set")]
            #endif
            private GeneralizedTransactionSet _generalizedTxSet;

            public override void ValidateCase() {}
        }
    }
    public static partial class StoredTransactionSetXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(StoredTransactionSet value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                StoredTransactionSetXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, StoredTransactionSet value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case StoredTransactionSet.case_0 case_0:
                TransactionSetXdr.Encode(stream, case_0.txSet);
                break;
                case StoredTransactionSet.case_1 case_1:
                GeneralizedTransactionSetXdr.Encode(stream, case_1.generalizedTxSet);
                break;
            }
        }
        public static StoredTransactionSet Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case 0:
                var result_0 = new StoredTransactionSet.case_0();
                result_0.txSet = TransactionSetXdr.Decode(stream);
                return result_0;
                case 1:
                var result_1 = new StoredTransactionSet.case_1();
                result_1.generalizedTxSet = GeneralizedTransactionSetXdr.Decode(stream);
                return result_1;
                default:
                throw new Exception($"Unknown discriminator for StoredTransactionSet: {discriminator}");
            }
        }
    }
}
