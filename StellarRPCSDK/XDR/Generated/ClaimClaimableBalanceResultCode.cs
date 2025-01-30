// Generated code - do not modify
// Source:

// enum ClaimClaimableBalanceResultCode
// {
//     CLAIM_CLAIMABLE_BALANCE_SUCCESS = 0,
//     CLAIM_CLAIMABLE_BALANCE_DOES_NOT_EXIST = -1,
//     CLAIM_CLAIMABLE_BALANCE_CANNOT_CLAIM = -2,
//     CLAIM_CLAIMABLE_BALANCE_LINE_FULL = -3,
//     CLAIM_CLAIMABLE_BALANCE_NO_TRUST = -4,
//     CLAIM_CLAIMABLE_BALANCE_NOT_AUTHORIZED = -5
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum ClaimClaimableBalanceResultCode
    {
        CLAIM_CLAIMABLE_BALANCE_SUCCESS = 0,
        CLAIM_CLAIMABLE_BALANCE_DOES_NOT_EXIST = -1,
        CLAIM_CLAIMABLE_BALANCE_CANNOT_CLAIM = -2,
        CLAIM_CLAIMABLE_BALANCE_LINE_FULL = -3,
        CLAIM_CLAIMABLE_BALANCE_NO_TRUST = -4,
        CLAIM_CLAIMABLE_BALANCE_NOT_AUTHORIZED = -5,
    }

    public static partial class ClaimClaimableBalanceResultCodeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ClaimClaimableBalanceResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ClaimClaimableBalanceResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ClaimClaimableBalanceResultCode), value))
              throw new InvalidOperationException($"Unknown ClaimClaimableBalanceResultCode value: {value}");
            return (ClaimClaimableBalanceResultCode)value;
        }
    }
}
