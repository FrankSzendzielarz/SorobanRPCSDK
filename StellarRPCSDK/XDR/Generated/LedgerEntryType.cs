// Generated code - do not modify
// Source:

// enum LedgerEntryType
// {
//     ACCOUNT = 0,
//     TRUSTLINE = 1,
//     OFFER = 2,
//     DATA = 3,
//     CLAIMABLE_BALANCE = 4,
//     LIQUIDITY_POOL = 5,
//     CONTRACT_DATA = 6,
//     CONTRACT_CODE = 7,
//     CONFIG_SETTING = 8,
//     TTL = 9
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum LedgerEntryType
    {
        ACCOUNT = 0,
        TRUSTLINE = 1,
        OFFER = 2,
        DATA = 3,
        CLAIMABLE_BALANCE = 4,
        LIQUIDITY_POOL = 5,
        CONTRACT_DATA = 6,
        CONTRACT_CODE = 7,
        CONFIG_SETTING = 8,
        TTL = 9,
    }

    public static partial class LedgerEntryTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LedgerEntryType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LedgerEntryTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, LedgerEntryType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static LedgerEntryType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(LedgerEntryType), value))
              throw new InvalidOperationException($"Unknown LedgerEntryType value: {value}");
            return (LedgerEntryType)value;
        }
    }
}
