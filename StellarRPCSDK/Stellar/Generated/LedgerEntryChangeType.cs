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
    public enum LedgerEntryChangeType
    {
        LEDGER_ENTRY_CREATED = 0,
        /// <summary>
        /// entry was added to the ledger
        /// </summary>
        LEDGER_ENTRY_UPDATED = 1,
        /// <summary>
        /// entry was modified in the ledger
        /// </summary>
        LEDGER_ENTRY_REMOVED = 2,
        /// <summary>
        /// entry was removed from the ledger
        /// </summary>
        LEDGER_ENTRY_STATE = 3,
    }

    public static partial class LedgerEntryChangeTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LedgerEntryChangeType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LedgerEntryChangeTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static LedgerEntryChangeType DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return LedgerEntryChangeTypeXdr.Decode(reader);
            }
        }
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
}
