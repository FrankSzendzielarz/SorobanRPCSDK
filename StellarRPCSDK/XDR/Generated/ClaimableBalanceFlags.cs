// Generated code - do not modify
// Source:

// enum ClaimableBalanceFlags
// {
//     // If set, the issuer account of the asset held by the claimable balance may
//     // clawback the claimable balance
//     CLAIMABLE_BALANCE_CLAWBACK_ENABLED_FLAG = 0x1
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum ClaimableBalanceFlags
    {
        CLAIMABLE_BALANCE_CLAWBACK_ENABLED_FLAG = 0x1,
    }

    public static partial class ClaimableBalanceFlagsXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ClaimableBalanceFlags value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ClaimableBalanceFlags Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ClaimableBalanceFlags), value))
              throw new InvalidOperationException($"Unknown ClaimableBalanceFlags value: {value}");
            return (ClaimableBalanceFlags)value;
        }
    }
