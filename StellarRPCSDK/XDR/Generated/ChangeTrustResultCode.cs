// Generated code - do not modify
// Source:

// enum ChangeTrustResultCode
// {
//     // codes considered as "success" for the operation
//     CHANGE_TRUST_SUCCESS = 0,
//     // codes considered as "failure" for the operation
//     CHANGE_TRUST_MALFORMED = -1,     // bad input
//     CHANGE_TRUST_NO_ISSUER = -2,     // could not find issuer
//     CHANGE_TRUST_INVALID_LIMIT = -3, // cannot drop limit below balance
//                                      // cannot create with a limit of 0
//     CHANGE_TRUST_LOW_RESERVE =
//         -4, // not enough funds to create a new trust line,
//     CHANGE_TRUST_SELF_NOT_ALLOWED = -5,   // trusting self is not allowed
//     CHANGE_TRUST_TRUST_LINE_MISSING = -6, // Asset trustline is missing for pool
//     CHANGE_TRUST_CANNOT_DELETE =
//         -7, // Asset trustline is still referenced in a pool
//     CHANGE_TRUST_NOT_AUTH_MAINTAIN_LIABILITIES =
//         -8 // Asset trustline is deauthorized
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum ChangeTrustResultCode
    {
        CHANGE_TRUST_SUCCESS = 0,
        CHANGE_TRUST_MALFORMED = -1,
        CHANGE_TRUST_NO_ISSUER = -2,
        CHANGE_TRUST_INVALID_LIMIT = -3,
        CHANGE_TRUST_LOW_RESERVE = -4,
        CHANGE_TRUST_SELF_NOT_ALLOWED = -5,
        CHANGE_TRUST_TRUST_LINE_MISSING = -6,
        CHANGE_TRUST_CANNOT_DELETE = -7,
        CHANGE_TRUST_NOT_AUTH_MAINTAIN_LIABILITIES = -8,
    }

    public static partial class ChangeTrustResultCodeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ChangeTrustResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ChangeTrustResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ChangeTrustResultCode), value))
              throw new InvalidOperationException($"Unknown ChangeTrustResultCode value: {value}");
            return (ChangeTrustResultCode)value;
        }
    }
}
