// Generated code - do not modify
// Source:

// union LedgerEntryChange switch (LedgerEntryChangeType type)
// {
// case LEDGER_ENTRY_CREATED:
//     LedgerEntry created;
// case LEDGER_ENTRY_UPDATED:
//     LedgerEntry updated;
// case LEDGER_ENTRY_REMOVED:
//     LedgerKey removed;
// case LEDGER_ENTRY_STATE:
//     LedgerEntry state;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class LedgerEntryChange
    {
        public abstract LedgerEntryChangeType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class LedgerEntryChange_LEDGER_ENTRY_CREATED : LedgerEntryChange
    {
        public override LedgerEntryChangeType Discriminator => LedgerEntryChangeType.LEDGER_ENTRY_CREATED;
        private LedgerEntry _created;
        public LedgerEntry created
        {
            get => _created;
            set
            {
                _created = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class LedgerEntryChange_LEDGER_ENTRY_UPDATED : LedgerEntryChange
    {
        public override LedgerEntryChangeType Discriminator => LedgerEntryChangeType.LEDGER_ENTRY_UPDATED;
        private LedgerEntry _updated;
        public LedgerEntry updated
        {
            get => _updated;
            set
            {
                _updated = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class LedgerEntryChange_LEDGER_ENTRY_REMOVED : LedgerEntryChange
    {
        public override LedgerEntryChangeType Discriminator => LedgerEntryChangeType.LEDGER_ENTRY_REMOVED;
        private LedgerKey _removed;
        public LedgerKey removed
        {
            get => _removed;
            set
            {
                _removed = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class LedgerEntryChange_LEDGER_ENTRY_STATE : LedgerEntryChange
    {
        public override LedgerEntryChangeType Discriminator => LedgerEntryChangeType.LEDGER_ENTRY_STATE;
        private LedgerEntry _state;
        public LedgerEntry state
        {
            get => _state;
            set
            {
                _state = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class LedgerEntryChangeXdr
    {
        public static void Encode(XdrWriter stream, LedgerEntryChange value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case LedgerEntryChange_LEDGER_ENTRY_CREATED case_LEDGER_ENTRY_CREATED:
                LedgerEntryXdr.Encode(stream, case_LEDGER_ENTRY_CREATED.created);
                break;
                case LedgerEntryChange_LEDGER_ENTRY_UPDATED case_LEDGER_ENTRY_UPDATED:
                LedgerEntryXdr.Encode(stream, case_LEDGER_ENTRY_UPDATED.updated);
                break;
                case LedgerEntryChange_LEDGER_ENTRY_REMOVED case_LEDGER_ENTRY_REMOVED:
                LedgerKeyXdr.Encode(stream, case_LEDGER_ENTRY_REMOVED.removed);
                break;
                case LedgerEntryChange_LEDGER_ENTRY_STATE case_LEDGER_ENTRY_STATE:
                LedgerEntryXdr.Encode(stream, case_LEDGER_ENTRY_STATE.state);
                break;
            }
        }
        public static LedgerEntryChange Decode(XdrReader stream)
        {
            var discriminator = (LedgerEntryChangeType)stream.ReadInt();
            switch (discriminator)
            {
                case LedgerEntryChangeType.LEDGER_ENTRY_CREATED:
                var result_LEDGER_ENTRY_CREATED = new LedgerEntryChange_LEDGER_ENTRY_CREATED();
                result_LEDGER_ENTRY_CREATED.created = LedgerEntryXdr.Decode(stream);
                return result_LEDGER_ENTRY_CREATED;
                case LedgerEntryChangeType.LEDGER_ENTRY_UPDATED:
                var result_LEDGER_ENTRY_UPDATED = new LedgerEntryChange_LEDGER_ENTRY_UPDATED();
                result_LEDGER_ENTRY_UPDATED.updated = LedgerEntryXdr.Decode(stream);
                return result_LEDGER_ENTRY_UPDATED;
                case LedgerEntryChangeType.LEDGER_ENTRY_REMOVED:
                var result_LEDGER_ENTRY_REMOVED = new LedgerEntryChange_LEDGER_ENTRY_REMOVED();
                result_LEDGER_ENTRY_REMOVED.removed = LedgerKeyXdr.Decode(stream);
                return result_LEDGER_ENTRY_REMOVED;
                case LedgerEntryChangeType.LEDGER_ENTRY_STATE:
                var result_LEDGER_ENTRY_STATE = new LedgerEntryChange_LEDGER_ENTRY_STATE();
                result_LEDGER_ENTRY_STATE.state = LedgerEntryXdr.Decode(stream);
                return result_LEDGER_ENTRY_STATE;
                default:
                throw new Exception($"Unknown discriminator for LedgerEntryChange: {discriminator}");
            }
        }
    }
}
