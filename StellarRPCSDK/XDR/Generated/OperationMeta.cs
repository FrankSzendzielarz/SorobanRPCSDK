// Generated code - do not modify
// Source:

// struct OperationMeta
// {
//     LedgerEntryChanges changes;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class OperationMeta
    {
        private LedgerEntryChanges _changes;
        public LedgerEntryChanges changes
        {
            get => _changes;
            set
            {
                _changes = value;
            }
        }

        public OperationMeta()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class OperationMetaXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, OperationMeta value)
        {
            value.Validate();
            LedgerEntryChangesXdr.Encode(stream, value.changes);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static OperationMeta Decode(XdrReader stream)
        {
            var result = new OperationMeta();
            result.changes = LedgerEntryChangesXdr.Decode(stream);
            return result;
        }
    }
}
