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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class PaymentResult
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class PaymentResult_PAYMENT_SUCCESS : PaymentResult
    {
        public override int Discriminator => PAYMENT_SUCCESS;

        public override void ValidateCase() {}
    }
    public sealed partial class PaymentResult_PAYMENT_MALFORMED : PaymentResult
    {
        public override int Discriminator => PAYMENT_MALFORMED;

        public override void ValidateCase() {}
    }
    public sealed partial class PaymentResult_PAYMENT_UNDERFUNDED : PaymentResult
    {
        public override int Discriminator => PAYMENT_UNDERFUNDED;

        public override void ValidateCase() {}
    }
    public sealed partial class PaymentResult_PAYMENT_SRC_NO_TRUST : PaymentResult
    {
        public override int Discriminator => PAYMENT_SRC_NO_TRUST;

        public override void ValidateCase() {}
    }
    public sealed partial class PaymentResult_PAYMENT_SRC_NOT_AUTHORIZED : PaymentResult
    {
        public override int Discriminator => PAYMENT_SRC_NOT_AUTHORIZED;

        public override void ValidateCase() {}
    }
    public sealed partial class PaymentResult_PAYMENT_NO_DESTINATION : PaymentResult
    {
        public override int Discriminator => PAYMENT_NO_DESTINATION;

        public override void ValidateCase() {}
    }
    public sealed partial class PaymentResult_PAYMENT_NO_TRUST : PaymentResult
    {
        public override int Discriminator => PAYMENT_NO_TRUST;

        public override void ValidateCase() {}
    }
    public sealed partial class PaymentResult_PAYMENT_NOT_AUTHORIZED : PaymentResult
    {
        public override int Discriminator => PAYMENT_NOT_AUTHORIZED;

        public override void ValidateCase() {}
    }
    public sealed partial class PaymentResult_PAYMENT_LINE_FULL : PaymentResult
    {
        public override int Discriminator => PAYMENT_LINE_FULL;

        public override void ValidateCase() {}
    }
    public sealed partial class PaymentResult_PAYMENT_NO_ISSUER : PaymentResult
    {
        public override int Discriminator => PAYMENT_NO_ISSUER;

        public override void ValidateCase() {}
    }
    public static partial class PaymentResultXdr
    {
        public static void Encode(XdrWriter stream, PaymentResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case PaymentResult_PAYMENT_SUCCESS case_PAYMENT_SUCCESS:
                break;
                case PaymentResult_PAYMENT_MALFORMED case_PAYMENT_MALFORMED:
                break;
                case PaymentResult_PAYMENT_UNDERFUNDED case_PAYMENT_UNDERFUNDED:
                break;
                case PaymentResult_PAYMENT_SRC_NO_TRUST case_PAYMENT_SRC_NO_TRUST:
                break;
                case PaymentResult_PAYMENT_SRC_NOT_AUTHORIZED case_PAYMENT_SRC_NOT_AUTHORIZED:
                break;
                case PaymentResult_PAYMENT_NO_DESTINATION case_PAYMENT_NO_DESTINATION:
                break;
                case PaymentResult_PAYMENT_NO_TRUST case_PAYMENT_NO_TRUST:
                break;
                case PaymentResult_PAYMENT_NOT_AUTHORIZED case_PAYMENT_NOT_AUTHORIZED:
                break;
                case PaymentResult_PAYMENT_LINE_FULL case_PAYMENT_LINE_FULL:
                break;
                case PaymentResult_PAYMENT_NO_ISSUER case_PAYMENT_NO_ISSUER:
                break;
            }
        }
        public static PaymentResult Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case PAYMENT_SUCCESS:
                var result_PAYMENT_SUCCESS = new PaymentResult_PAYMENT_SUCCESS();
                return result_PAYMENT_SUCCESS;
                case PAYMENT_MALFORMED:
                var result_PAYMENT_MALFORMED = new PaymentResult_PAYMENT_MALFORMED();
                return result_PAYMENT_MALFORMED;
                case PAYMENT_UNDERFUNDED:
                var result_PAYMENT_UNDERFUNDED = new PaymentResult_PAYMENT_UNDERFUNDED();
                return result_PAYMENT_UNDERFUNDED;
                case PAYMENT_SRC_NO_TRUST:
                var result_PAYMENT_SRC_NO_TRUST = new PaymentResult_PAYMENT_SRC_NO_TRUST();
                return result_PAYMENT_SRC_NO_TRUST;
                case PAYMENT_SRC_NOT_AUTHORIZED:
                var result_PAYMENT_SRC_NOT_AUTHORIZED = new PaymentResult_PAYMENT_SRC_NOT_AUTHORIZED();
                return result_PAYMENT_SRC_NOT_AUTHORIZED;
                case PAYMENT_NO_DESTINATION:
                var result_PAYMENT_NO_DESTINATION = new PaymentResult_PAYMENT_NO_DESTINATION();
                return result_PAYMENT_NO_DESTINATION;
                case PAYMENT_NO_TRUST:
                var result_PAYMENT_NO_TRUST = new PaymentResult_PAYMENT_NO_TRUST();
                return result_PAYMENT_NO_TRUST;
                case PAYMENT_NOT_AUTHORIZED:
                var result_PAYMENT_NOT_AUTHORIZED = new PaymentResult_PAYMENT_NOT_AUTHORIZED();
                return result_PAYMENT_NOT_AUTHORIZED;
                case PAYMENT_LINE_FULL:
                var result_PAYMENT_LINE_FULL = new PaymentResult_PAYMENT_LINE_FULL();
                return result_PAYMENT_LINE_FULL;
                case PAYMENT_NO_ISSUER:
                var result_PAYMENT_NO_ISSUER = new PaymentResult_PAYMENT_NO_ISSUER();
                return result_PAYMENT_NO_ISSUER;
                default:
                throw new Exception($"Unknown discriminator for PaymentResult: {discriminator}");
            }
        }
    }
}
