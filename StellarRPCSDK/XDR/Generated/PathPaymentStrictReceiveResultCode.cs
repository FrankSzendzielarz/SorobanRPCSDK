// Generated code - do not modify
// Source:

// enum PathPaymentStrictReceiveResultCode
// {
//     // codes considered as "success" for the operation
//     PATH_PAYMENT_STRICT_RECEIVE_SUCCESS = 0, // success
// 
//     // codes considered as "failure" for the operation
//     PATH_PAYMENT_STRICT_RECEIVE_MALFORMED = -1, // bad input
//     PATH_PAYMENT_STRICT_RECEIVE_UNDERFUNDED =
//         -2, // not enough funds in source account
//     PATH_PAYMENT_STRICT_RECEIVE_SRC_NO_TRUST =
//         -3, // no trust line on source account
//     PATH_PAYMENT_STRICT_RECEIVE_SRC_NOT_AUTHORIZED =
//         -4, // source not authorized to transfer
//     PATH_PAYMENT_STRICT_RECEIVE_NO_DESTINATION =
//         -5, // destination account does not exist
//     PATH_PAYMENT_STRICT_RECEIVE_NO_TRUST =
//         -6, // dest missing a trust line for asset
//     PATH_PAYMENT_STRICT_RECEIVE_NOT_AUTHORIZED =
//         -7, // dest not authorized to hold asset
//     PATH_PAYMENT_STRICT_RECEIVE_LINE_FULL =
//         -8, // dest would go above their limit
//     PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER = -9, // missing issuer on one asset
//     PATH_PAYMENT_STRICT_RECEIVE_TOO_FEW_OFFERS =
//         -10, // not enough offers to satisfy path
//     PATH_PAYMENT_STRICT_RECEIVE_OFFER_CROSS_SELF =
//         -11, // would cross one of its own offers
//     PATH_PAYMENT_STRICT_RECEIVE_OVER_SENDMAX = -12 // could not satisfy sendmax
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum PathPaymentStrictReceiveResultCode
    {
        PATH_PAYMENT_STRICT_RECEIVE_SUCCESS = 0,
        PATH_PAYMENT_STRICT_RECEIVE_MALFORMED = -1,
        PATH_PAYMENT_STRICT_RECEIVE_UNDERFUNDED = -2,
        PATH_PAYMENT_STRICT_RECEIVE_SRC_NO_TRUST = -3,
        PATH_PAYMENT_STRICT_RECEIVE_SRC_NOT_AUTHORIZED = -4,
        PATH_PAYMENT_STRICT_RECEIVE_NO_DESTINATION = -5,
        PATH_PAYMENT_STRICT_RECEIVE_NO_TRUST = -6,
        PATH_PAYMENT_STRICT_RECEIVE_NOT_AUTHORIZED = -7,
        PATH_PAYMENT_STRICT_RECEIVE_LINE_FULL = -8,
        PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER = -9,
        PATH_PAYMENT_STRICT_RECEIVE_TOO_FEW_OFFERS = -10,
        PATH_PAYMENT_STRICT_RECEIVE_OFFER_CROSS_SELF = -11,
        PATH_PAYMENT_STRICT_RECEIVE_OVER_SENDMAX = -12,
    }

    public static partial class PathPaymentStrictReceiveResultCodeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, PathPaymentStrictReceiveResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static PathPaymentStrictReceiveResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(PathPaymentStrictReceiveResultCode), value))
              throw new InvalidOperationException($"Unknown PathPaymentStrictReceiveResultCode value: {value}");
            return (PathPaymentStrictReceiveResultCode)value;
        }
    }
}
