// Generated code - do not modify
// Source:

// struct TransactionResultMeta
// {
//     TransactionResultPair result;
//     LedgerEntryChanges feeProcessing;
//     TransactionMeta txApplyProcessing;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    /// <summary>
    /// phases
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TransactionResultMeta
    {
        public TransactionResultPair result
        {
            get => _result;
            set
            {
                _result = value;
            }
        }
        private TransactionResultPair _result;

        public LedgerEntryChanges feeProcessing
        {
            get => _feeProcessing;
            set
            {
                _feeProcessing = value;
            }
        }
        private LedgerEntryChanges _feeProcessing;

        public TransactionMeta txApplyProcessing
        {
            get => _txApplyProcessing;
            set
            {
                _txApplyProcessing = value;
            }
        }
        private TransactionMeta _txApplyProcessing;

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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TransactionResultMeta value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TransactionResultMetaXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
