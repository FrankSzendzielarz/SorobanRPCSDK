// Generated code - do not modify
// Source:

// struct TransactionResultMeta
// {
//     TransactionResultPair result;
//     LedgerEntryChanges feeProcessing;
//     TransactionMeta txApplyProcessing;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TransactionResultMeta
    {
        private TransactionResultPair _result;
        public TransactionResultPair result
        {
            get => _result;
            set
            {
                _result = value;
            }
        }

        private LedgerEntryChanges _feeProcessing;
        public LedgerEntryChanges feeProcessing
        {
            get => _feeProcessing;
            set
            {
                _feeProcessing = value;
            }
        }

        private TransactionMeta _txApplyProcessing;
        public TransactionMeta txApplyProcessing
        {
            get => _txApplyProcessing;
            set
            {
                _txApplyProcessing = value;
            }
        }

        public TransactionResultMeta()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class TransactionResultMetaXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TransactionResultMeta value)
        {
            value.Validate();
            TransactionResultPairXdr.Encode(stream, value.result);
            LedgerEntryChangesXdr.Encode(stream, value.feeProcessing);
            TransactionMetaXdr.Encode(stream, value.txApplyProcessing);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TransactionResultMeta Decode(XdrReader stream)
        {
            var result = new TransactionResultMeta();
            result.result = TransactionResultPairXdr.Decode(stream);
            result.feeProcessing = LedgerEntryChangesXdr.Decode(stream);
            result.txApplyProcessing = TransactionMetaXdr.Decode(stream);
            return result;
        }
    }
}
