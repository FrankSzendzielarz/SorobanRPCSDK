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
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum PathPaymentStrictReceiveResultCode
    {
        /// <summary>
        /// codes considered as "success" for the operation
        /// </summary>
        PATH_PAYMENT_STRICT_RECEIVE_SUCCESS = 0,
        /// <summary>
        /// codes considered as "failure" for the operation
        /// </summary>
        PATH_PAYMENT_STRICT_RECEIVE_MALFORMED = -1,
        /// <summary>
        /// bad input
        /// </summary>
        PATH_PAYMENT_STRICT_RECEIVE_UNDERFUNDED = -2,
        /// <summary>
        /// not enough funds in source account
        /// </summary>
        PATH_PAYMENT_STRICT_RECEIVE_SRC_NO_TRUST = -3,
        /// <summary>
        /// no trust line on source account
        /// </summary>
        PATH_PAYMENT_STRICT_RECEIVE_SRC_NOT_AUTHORIZED = -4,
        /// <summary>
        /// source not authorized to transfer
        /// </summary>
        PATH_PAYMENT_STRICT_RECEIVE_NO_DESTINATION = -5,
        /// <summary>
        /// destination account does not exist
        /// </summary>
        PATH_PAYMENT_STRICT_RECEIVE_NO_TRUST = -6,
        /// <summary>
        /// dest missing a trust line for asset
        /// </summary>
        PATH_PAYMENT_STRICT_RECEIVE_NOT_AUTHORIZED = -7,
        /// <summary>
        /// dest not authorized to hold asset
        /// </summary>
        PATH_PAYMENT_STRICT_RECEIVE_LINE_FULL = -8,
        /// <summary>
        /// dest would go above their limit
        /// </summary>
        PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER = -9,
        /// <summary>
        /// missing issuer on one asset
        /// </summary>
        PATH_PAYMENT_STRICT_RECEIVE_TOO_FEW_OFFERS = -10,
        /// <summary>
        /// not enough offers to satisfy path
        /// </summary>
        PATH_PAYMENT_STRICT_RECEIVE_OFFER_CROSS_SELF = -11,
        /// <summary>
        /// would cross one of its own offers
        /// </summary>
        PATH_PAYMENT_STRICT_RECEIVE_OVER_SENDMAX = -12,
    }

    public static partial class PathPaymentStrictReceiveResultCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(PathPaymentStrictReceiveResultCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                PathPaymentStrictReceiveResultCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
