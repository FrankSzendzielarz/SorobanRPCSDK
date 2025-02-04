// Generated code - do not modify
// Source:

// union PaymentResult switch (PaymentResultCode code)
// {
// case PAYMENT_SUCCESS:
//     void;
// case PAYMENT_MALFORMED:
// case PAYMENT_UNDERFUNDED:
// case PAYMENT_SRC_NO_TRUST:
// case PAYMENT_SRC_NOT_AUTHORIZED:
// case PAYMENT_NO_DESTINATION:
// case PAYMENT_NO_TRUST:
// case PAYMENT_NOT_AUTHORIZED:
// case PAYMENT_LINE_FULL:
// case PAYMENT_NO_ISSUER:
//     void;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class PaymentResult
    {
        public abstract PaymentResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        public sealed partial class PaymentSuccess : PaymentResult
        {
            public override PaymentResultCode Discriminator => PaymentResultCode.PAYMENT_SUCCESS;

            public override void ValidateCase() {}
        }
        public sealed partial class PaymentMalformed : PaymentResult
        {
            public override PaymentResultCode Discriminator => PaymentResultCode.PAYMENT_MALFORMED;

            public override void ValidateCase() {}
        }
        public sealed partial class PaymentUnderfunded : PaymentResult
        {
            public override PaymentResultCode Discriminator => PaymentResultCode.PAYMENT_UNDERFUNDED;

            public override void ValidateCase() {}
        }
        public sealed partial class PaymentSrcNoTrust : PaymentResult
        {
            public override PaymentResultCode Discriminator => PaymentResultCode.PAYMENT_SRC_NO_TRUST;

            public override void ValidateCase() {}
        }
        public sealed partial class PaymentSrcNotAuthorized : PaymentResult
        {
            public override PaymentResultCode Discriminator => PaymentResultCode.PAYMENT_SRC_NOT_AUTHORIZED;

            public override void ValidateCase() {}
        }
        public sealed partial class PaymentNoDestination : PaymentResult
        {
            public override PaymentResultCode Discriminator => PaymentResultCode.PAYMENT_NO_DESTINATION;

            public override void ValidateCase() {}
        }
        public sealed partial class PaymentNoTrust : PaymentResult
        {
            public override PaymentResultCode Discriminator => PaymentResultCode.PAYMENT_NO_TRUST;

            public override void ValidateCase() {}
        }
        public sealed partial class PaymentNotAuthorized : PaymentResult
        {
            public override PaymentResultCode Discriminator => PaymentResultCode.PAYMENT_NOT_AUTHORIZED;

            public override void ValidateCase() {}
        }
        public sealed partial class PaymentLineFull : PaymentResult
        {
            public override PaymentResultCode Discriminator => PaymentResultCode.PAYMENT_LINE_FULL;

            public override void ValidateCase() {}
        }
        public sealed partial class PaymentNoIssuer : PaymentResult
        {
            public override PaymentResultCode Discriminator => PaymentResultCode.PAYMENT_NO_ISSUER;

            public override void ValidateCase() {}
        }
    }
    public static partial class PaymentResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(PaymentResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                PaymentResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, PaymentResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case PaymentResult.PaymentSuccess case_PAYMENT_SUCCESS:
                break;
                case PaymentResult.PaymentMalformed case_PAYMENT_MALFORMED:
                break;
                case PaymentResult.PaymentUnderfunded case_PAYMENT_UNDERFUNDED:
                break;
                case PaymentResult.PaymentSrcNoTrust case_PAYMENT_SRC_NO_TRUST:
                break;
                case PaymentResult.PaymentSrcNotAuthorized case_PAYMENT_SRC_NOT_AUTHORIZED:
                break;
                case PaymentResult.PaymentNoDestination case_PAYMENT_NO_DESTINATION:
                break;
                case PaymentResult.PaymentNoTrust case_PAYMENT_NO_TRUST:
                break;
                case PaymentResult.PaymentNotAuthorized case_PAYMENT_NOT_AUTHORIZED:
                break;
                case PaymentResult.PaymentLineFull case_PAYMENT_LINE_FULL:
                break;
                case PaymentResult.PaymentNoIssuer case_PAYMENT_NO_ISSUER:
                break;
            }
        }
        public static PaymentResult Decode(XdrReader stream)
        {
            var discriminator = (PaymentResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case PaymentResultCode.PAYMENT_SUCCESS:
                var result_PAYMENT_SUCCESS = new PaymentResult.PaymentSuccess();
                return result_PAYMENT_SUCCESS;
                case PaymentResultCode.PAYMENT_MALFORMED:
                var result_PAYMENT_MALFORMED = new PaymentResult.PaymentMalformed();
                return result_PAYMENT_MALFORMED;
                case PaymentResultCode.PAYMENT_UNDERFUNDED:
                var result_PAYMENT_UNDERFUNDED = new PaymentResult.PaymentUnderfunded();
                return result_PAYMENT_UNDERFUNDED;
                case PaymentResultCode.PAYMENT_SRC_NO_TRUST:
                var result_PAYMENT_SRC_NO_TRUST = new PaymentResult.PaymentSrcNoTrust();
                return result_PAYMENT_SRC_NO_TRUST;
                case PaymentResultCode.PAYMENT_SRC_NOT_AUTHORIZED:
                var result_PAYMENT_SRC_NOT_AUTHORIZED = new PaymentResult.PaymentSrcNotAuthorized();
                return result_PAYMENT_SRC_NOT_AUTHORIZED;
                case PaymentResultCode.PAYMENT_NO_DESTINATION:
                var result_PAYMENT_NO_DESTINATION = new PaymentResult.PaymentNoDestination();
                return result_PAYMENT_NO_DESTINATION;
                case PaymentResultCode.PAYMENT_NO_TRUST:
                var result_PAYMENT_NO_TRUST = new PaymentResult.PaymentNoTrust();
                return result_PAYMENT_NO_TRUST;
                case PaymentResultCode.PAYMENT_NOT_AUTHORIZED:
                var result_PAYMENT_NOT_AUTHORIZED = new PaymentResult.PaymentNotAuthorized();
                return result_PAYMENT_NOT_AUTHORIZED;
                case PaymentResultCode.PAYMENT_LINE_FULL:
                var result_PAYMENT_LINE_FULL = new PaymentResult.PaymentLineFull();
                return result_PAYMENT_LINE_FULL;
                case PaymentResultCode.PAYMENT_NO_ISSUER:
                var result_PAYMENT_NO_ISSUER = new PaymentResult.PaymentNoIssuer();
                return result_PAYMENT_NO_ISSUER;
                default:
                throw new Exception($"Unknown discriminator for PaymentResult: {discriminator}");
            }
        }
    }
}
