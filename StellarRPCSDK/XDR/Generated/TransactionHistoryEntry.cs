// Generated code - do not modify
// Source:

// struct TransactionHistoryEntry
// {
//     uint32 ledgerSeq;
//     TransactionSet txSet;
// 
//     // when v != 0, txSet must be empty
//     union switch (int v)
//     {
//     case 0:
//         void;
//     case 1:
//         GeneralizedTransactionSet generalizedTxSet;
//     }
//     ext;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TransactionHistoryEntry
    {
        private uint32 _ledgerSeq;
        public uint32 ledgerSeq
        {
            get => _ledgerSeq;
            set
            {
                _ledgerSeq = value;
            }
        }

        private TransactionSet _txSet;
        public TransactionSet txSet
        {
            get => _txSet;
            set
            {
                _txSet = value;
            }
        }

        private extUnion _ext;
        public extUnion ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }

        public TransactionHistoryEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

        }
        public sealed partial class extUnion_0 : extUnion
        {
            public override int Discriminator => 0;

            public override void ValidateCase() {}
        }
        public sealed partial class extUnion_1 : extUnion
        {
            public override int Discriminator => 1;
            private GeneralizedTransactionSet _generalizedTxSet;
            public GeneralizedTransactionSet generalizedTxSet
            {
                get => _generalizedTxSet;
                set
                {
                    _generalizedTxSet = value;
                }
            }

            public override void ValidateCase() {}
        }
        public static partial class extUnionXdr
        {
            public static void Encode(XdrWriter stream, extUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case extUnion_0 case_0:
                    break;
                    case extUnion_1 case_1:
                    GeneralizedTransactionSetXdr.Encode(stream, case_1.generalizedTxSet);
                    break;
                }
            }
            public static extUnion Decode(XdrReader stream)
            {
                var discriminator = (int)stream.ReadInt();
                switch (discriminator)
                {
                    case 0:
                    var result_0 = new extUnion_0();
                    return result_0;
                    case 1:
                    var result_1 = new extUnion_1();
                    result_1.generalizedTxSet = GeneralizedTransactionSetXdr.Decode(stream);
                    return result_1;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class TransactionHistoryEntryXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TransactionHistoryEntry value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.ledgerSeq);
            TransactionSetXdr.Encode(stream, value.txSet);
            TransactionHistoryEntry.extUnionXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TransactionHistoryEntry Decode(XdrReader stream)
        {
            var result = new TransactionHistoryEntry();
            result.ledgerSeq = uint32Xdr.Decode(stream);
            result.txSet = TransactionSetXdr.Decode(stream);
            result.ext = TransactionHistoryEntry.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
