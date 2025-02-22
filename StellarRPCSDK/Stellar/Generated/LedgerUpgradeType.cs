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
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LedgerUpgradeType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LedgerUpgradeTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
}
