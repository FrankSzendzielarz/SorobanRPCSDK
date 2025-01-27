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

namespace stellar {

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

        private object _ext;
        public object ext
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
    }
    public static partial class TransactionHistoryEntryXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TransactionHistoryEntry value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.ledgerSeq);
            TransactionSetXdr.Encode(stream, value.txSet);
            Xdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TransactionHistoryEntry Decode(XdrReader stream)
        {
            var result = new TransactionHistoryEntry();
            result.ledgerSeq = uint32Xdr.Decode(stream);
            result.txSet = TransactionSetXdr.Decode(stream);
            result.ext = Xdr.Decode(stream);
            return result;
        }
    }
}
