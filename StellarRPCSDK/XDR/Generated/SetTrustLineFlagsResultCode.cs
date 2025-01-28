// Generated code - do not modify
// Source:

// enum SetTrustLineFlagsResultCode
// {
//     // codes considered as "success" for the operation
//     SET_TRUST_LINE_FLAGS_SUCCESS = 0,
// 
//     // codes considered as "failure" for the operation
//     SET_TRUST_LINE_FLAGS_MALFORMED = -1,
//     SET_TRUST_LINE_FLAGS_NO_TRUST_LINE = -2,
//     SET_TRUST_LINE_FLAGS_CANT_REVOKE = -3,
//     SET_TRUST_LINE_FLAGS_INVALID_STATE = -4,
//     SET_TRUST_LINE_FLAGS_LOW_RESERVE = -5 // claimable balances can't be created
//                                           // on revoke due to low reserves
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum SetTrustLineFlagsResultCode
    {
        SET_TRUST_LINE_FLAGS_SUCCESS = 0,
        SET_TRUST_LINE_FLAGS_MALFORMED = -1,
        SET_TRUST_LINE_FLAGS_NO_TRUST_LINE = -2,
        SET_TRUST_LINE_FLAGS_CANT_REVOKE = -3,
        SET_TRUST_LINE_FLAGS_INVALID_STATE = -4,
        SET_TRUST_LINE_FLAGS_LOW_RESERVE = -5,
    }

    public static partial class SetTrustLineFlagsResultCodeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, SetTrustLineFlagsResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static SetTrustLineFlagsResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(SetTrustLineFlagsResultCode), value))
              throw new InvalidOperationException($"Unknown SetTrustLineFlagsResultCode value: {value}");
            return (SetTrustLineFlagsResultCode)value;
        }
    }
}
