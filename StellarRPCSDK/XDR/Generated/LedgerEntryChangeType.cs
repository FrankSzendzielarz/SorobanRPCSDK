// Generated code - do not modify
// Source:

// enum LedgerEntryChangeType
// {
//     LEDGER_ENTRY_CREATED = 0, // entry was added to the ledger
//     LEDGER_ENTRY_UPDATED = 1, // entry was modified in the ledger
//     LEDGER_ENTRY_REMOVED = 2, // entry was removed from the ledger
//     LEDGER_ENTRY_STATE = 3    // value of the entry
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum LedgerEntryChangeType
    {
        LEDGER_ENTRY_CREATED = 0,
        LEDGER_ENTRY_UPDATED = 1,
        LEDGER_ENTRY_REMOVED = 2,
        LEDGER_ENTRY_STATE = 3,
    }

    public static partial class LedgerEntryChangeTypeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, LedgerEntryChangeType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static LedgerEntryChangeType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(LedgerEntryChangeType), value))
              throw new InvalidOperationException($"Unknown LedgerEntryChangeType value: {value}");
            return (LedgerEntryChangeType)value;
        }
    }
