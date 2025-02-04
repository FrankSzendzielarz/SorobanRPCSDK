// Generated code - do not modify
// Source:

// enum PaymentResultCode
// {
//     // codes considered as "success" for the operation
//     PAYMENT_SUCCESS = 0, // payment successfully completed
// 
//     // codes considered as "failure" for the operation
//     PAYMENT_MALFORMED = -1,          // bad input
//     PAYMENT_UNDERFUNDED = -2,        // not enough funds in source account
//     PAYMENT_SRC_NO_TRUST = -3,       // no trust line on source account
//     PAYMENT_SRC_NOT_AUTHORIZED = -4, // source not authorized to transfer
//     PAYMENT_NO_DESTINATION = -5,     // destination account does not exist
//     PAYMENT_NO_TRUST = -6,       // destination missing a trust line for asset
//     PAYMENT_NOT_AUTHORIZED = -7, // destination not authorized to hold asset
//     PAYMENT_LINE_FULL = -8,      // destination would go above their limit
//     PAYMENT_NO_ISSUER = -9       // missing issuer on asset
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum PaymentResultCode
    {
        PAYMENT_SUCCESS = 0,
        PAYMENT_MALFORMED = -1,
        PAYMENT_UNDERFUNDED = -2,
        PAYMENT_SRC_NO_TRUST = -3,
        PAYMENT_SRC_NOT_AUTHORIZED = -4,
        PAYMENT_NO_DESTINATION = -5,
        PAYMENT_NO_TRUST = -6,
        PAYMENT_NOT_AUTHORIZED = -7,
        PAYMENT_LINE_FULL = -8,
        PAYMENT_NO_ISSUER = -9,
    }

    public static partial class PaymentResultCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(PaymentResultCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                PaymentResultCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, PaymentResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static PaymentResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(PaymentResultCode), value))
              throw new InvalidOperationException($"Unknown PaymentResultCode value: {value}");
            return (PaymentResultCode)value;
        }
    }
}
