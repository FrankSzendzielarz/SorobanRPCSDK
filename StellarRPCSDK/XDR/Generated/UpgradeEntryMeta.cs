// Generated code - do not modify
// Source:

// struct UpgradeEntryMeta
// {
//     LedgerUpgrade upgrade;
//     LedgerEntryChanges changes;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class UpgradeEntryMeta
    {
        private LedgerUpgrade _upgrade;
        public LedgerUpgrade upgrade
        {
            get => _upgrade;
            set
            {
                _upgrade = value;
            }
        }

        private LedgerEntryChanges _changes;
        public LedgerEntryChanges changes
        {
            get => _changes;
            set
            {
                _changes = value;
            }
        }

        public UpgradeEntryMeta()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class UpgradeEntryMetaXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, UpgradeEntryMeta value)
        {
            value.Validate();
            LedgerUpgradeXdr.Encode(stream, value.upgrade);
            LedgerEntryChangesXdr.Encode(stream, value.changes);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static UpgradeEntryMeta Decode(XdrReader stream)
        {
            var result = new UpgradeEntryMeta();
            result.upgrade = LedgerUpgradeXdr.Decode(stream);
            result.changes = LedgerEntryChangesXdr.Decode(stream);
            return result;
        }
    }
}
