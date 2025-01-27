// Generated code - do not modify
// Source:

// enum AllowTrustResultCode
// {
//     // codes considered as "success" for the operation
//     ALLOW_TRUST_SUCCESS = 0,
//     // codes considered as "failure" for the operation
//     ALLOW_TRUST_MALFORMED = -1,     // asset is not ASSET_TYPE_ALPHANUM
//     ALLOW_TRUST_NO_TRUST_LINE = -2, // trustor does not have a trustline
//                                     // source account does not require trust
//     ALLOW_TRUST_TRUST_NOT_REQUIRED = -3,
//     ALLOW_TRUST_CANT_REVOKE = -4,      // source account can't revoke trust,
//     ALLOW_TRUST_SELF_NOT_ALLOWED = -5, // trusting self is not allowed
//     ALLOW_TRUST_LOW_RESERVE = -6       // claimable balances can't be created
//                                        // on revoke due to low reserves
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum AllowTrustResultCode
    {
        ALLOW_TRUST_SUCCESS = 0,
        ALLOW_TRUST_MALFORMED = -1,
        ALLOW_TRUST_NO_TRUST_LINE = -2,
        ALLOW_TRUST_TRUST_NOT_REQUIRED = -3,
        ALLOW_TRUST_CANT_REVOKE = -4,
        ALLOW_TRUST_SELF_NOT_ALLOWED = -5,
        ALLOW_TRUST_LOW_RESERVE = -6,
    }

    public static partial class AllowTrustResultCodeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, AllowTrustResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static AllowTrustResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(AllowTrustResultCode), value))
              throw new InvalidOperationException($"Unknown AllowTrustResultCode value: {value}");
            return (AllowTrustResultCode)value;
        }
    }
