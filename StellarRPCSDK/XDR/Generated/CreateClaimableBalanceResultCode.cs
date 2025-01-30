// Generated code - do not modify
// Source:

// enum CreateClaimableBalanceResultCode
// {
//     CREATE_CLAIMABLE_BALANCE_SUCCESS = 0,
//     CREATE_CLAIMABLE_BALANCE_MALFORMED = -1,
//     CREATE_CLAIMABLE_BALANCE_LOW_RESERVE = -2,
//     CREATE_CLAIMABLE_BALANCE_NO_TRUST = -3,
//     CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED = -4,
//     CREATE_CLAIMABLE_BALANCE_UNDERFUNDED = -5
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum CreateClaimableBalanceResultCode
    {
        CREATE_CLAIMABLE_BALANCE_SUCCESS = 0,
        CREATE_CLAIMABLE_BALANCE_MALFORMED = -1,
        CREATE_CLAIMABLE_BALANCE_LOW_RESERVE = -2,
        CREATE_CLAIMABLE_BALANCE_NO_TRUST = -3,
        CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED = -4,
        CREATE_CLAIMABLE_BALANCE_UNDERFUNDED = -5,
    }

    public static partial class CreateClaimableBalanceResultCodeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, CreateClaimableBalanceResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static CreateClaimableBalanceResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(CreateClaimableBalanceResultCode), value))
              throw new InvalidOperationException($"Unknown CreateClaimableBalanceResultCode value: {value}");
            return (CreateClaimableBalanceResultCode)value;
        }
    }
}
