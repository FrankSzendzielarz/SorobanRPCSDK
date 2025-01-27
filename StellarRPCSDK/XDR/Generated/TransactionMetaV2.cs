// Generated code - do not modify
// Source:

// struct TransactionMetaV2
// {
//     LedgerEntryChanges txChangesBefore; // tx level changes before operations
//                                         // are applied if any
//     OperationMeta operations<>;         // meta for each operation
//     LedgerEntryChanges txChangesAfter;  // tx level changes after operations are
//                                         // applied if any
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TransactionMetaV2
    {
        private LedgerEntryChanges _txChangesBefore;
        public LedgerEntryChanges txChangesBefore
        {
            get => _txChangesBefore;
            set
            {
                _txChangesBefore = value;
            }
        }

        private OperationMeta[] _operations;
        public OperationMeta[] operations
        {
            get => _operations;
            set
            {
                _operations = value;
            }
        }

        private LedgerEntryChanges _txChangesAfter;
        public LedgerEntryChanges txChangesAfter
        {
            get => _txChangesAfter;
            set
            {
                _txChangesAfter = value;
            }
        }

        public TransactionMetaV2()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class TransactionMetaV2Xdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TransactionMetaV2 value)
        {
            value.Validate();
            LedgerEntryChangesXdr.Encode(stream, value.txChangesBefore);
            stream.WriteInt(value.operations.Length);
            foreach (var item in value.operations)
            {
                    OperationMetaXdr.Encode(stream, item);
            }
            LedgerEntryChangesXdr.Encode(stream, value.txChangesAfter);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TransactionMetaV2 Decode(XdrReader stream)
        {
            var result = new TransactionMetaV2();
            result.txChangesBefore = LedgerEntryChangesXdr.Decode(stream);
            var length = stream.ReadInt();
            result.operations = new OperationMeta[length];
            for (var i = 0; i < length; i++)
            {
                result.operations[i] = OperationMetaXdr.Decode(stream);
            }
            result.txChangesAfter = LedgerEntryChangesXdr.Decode(stream);
            return result;
        }
    }
}
