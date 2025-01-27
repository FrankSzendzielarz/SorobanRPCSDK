// Generated code - do not modify
// Source:

// enum LedgerUpgradeType
// {
//     LEDGER_UPGRADE_VERSION = 1,
//     LEDGER_UPGRADE_BASE_FEE = 2,
//     LEDGER_UPGRADE_MAX_TX_SET_SIZE = 3,
//     LEDGER_UPGRADE_BASE_RESERVE = 4,
//     LEDGER_UPGRADE_FLAGS = 5,
//     LEDGER_UPGRADE_CONFIG = 6,
//     LEDGER_UPGRADE_MAX_SOROBAN_TX_SET_SIZE = 7
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum LedgerUpgradeType
    {
        LEDGER_UPGRADE_VERSION = 1,
        LEDGER_UPGRADE_BASE_FEE = 2,
        LEDGER_UPGRADE_MAX_TX_SET_SIZE = 3,
        LEDGER_UPGRADE_BASE_RESERVE = 4,
        LEDGER_UPGRADE_FLAGS = 5,
        LEDGER_UPGRADE_CONFIG = 6,
        LEDGER_UPGRADE_MAX_SOROBAN_TX_SET_SIZE = 7,
    }

    public static partial class LedgerUpgradeTypeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, LedgerUpgradeType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static LedgerUpgradeType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(LedgerUpgradeType), value))
              throw new InvalidOperationException($"Unknown LedgerUpgradeType value: {value}");
            return (LedgerUpgradeType)value;
        }
    }
