// Generated code - do not modify
// Source:

// enum LedgerHeaderFlags
// {
//     DISABLE_LIQUIDITY_POOL_TRADING_FLAG = 0x1,
//     DISABLE_LIQUIDITY_POOL_DEPOSIT_FLAG = 0x2,
//     DISABLE_LIQUIDITY_POOL_WITHDRAWAL_FLAG = 0x4
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum LedgerHeaderFlags
    {
        DISABLE_LIQUIDITY_POOL_TRADING_FLAG = 1,
        DISABLE_LIQUIDITY_POOL_DEPOSIT_FLAG = 2,
        DISABLE_LIQUIDITY_POOL_WITHDRAWAL_FLAG = 4,
    }

    public static partial class LedgerHeaderFlagsXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LedgerHeaderFlags value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LedgerHeaderFlagsXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, LedgerHeaderFlags value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static LedgerHeaderFlags Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(LedgerHeaderFlags), value))
              throw new InvalidOperationException($"Unknown LedgerHeaderFlags value: {value}");
            return (LedgerHeaderFlags)value;
        }
    }
}
