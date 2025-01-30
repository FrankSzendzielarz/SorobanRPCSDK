// Generated code - do not modify
// Source:

// enum ClawbackClaimableBalanceResultCode
// {
//     // codes considered as "success" for the operation
//     CLAWBACK_CLAIMABLE_BALANCE_SUCCESS = 0,
// 
//     // codes considered as "failure" for the operation
//     CLAWBACK_CLAIMABLE_BALANCE_DOES_NOT_EXIST = -1,
//     CLAWBACK_CLAIMABLE_BALANCE_NOT_ISSUER = -2,
//     CLAWBACK_CLAIMABLE_BALANCE_NOT_CLAWBACK_ENABLED = -3
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum ClawbackClaimableBalanceResultCode
    {
        CLAWBACK_CLAIMABLE_BALANCE_SUCCESS = 0,
        CLAWBACK_CLAIMABLE_BALANCE_DOES_NOT_EXIST = -1,
        CLAWBACK_CLAIMABLE_BALANCE_NOT_ISSUER = -2,
        CLAWBACK_CLAIMABLE_BALANCE_NOT_CLAWBACK_ENABLED = -3,
    }

    public static partial class ClawbackClaimableBalanceResultCodeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ClawbackClaimableBalanceResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ClawbackClaimableBalanceResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ClawbackClaimableBalanceResultCode), value))
              throw new InvalidOperationException($"Unknown ClawbackClaimableBalanceResultCode value: {value}");
            return (ClawbackClaimableBalanceResultCode)value;
        }
    }
}
