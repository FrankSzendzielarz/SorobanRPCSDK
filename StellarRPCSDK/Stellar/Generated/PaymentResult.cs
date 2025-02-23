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
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    [ProtoInclude(100, typeof(PaymentSuccess), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(PaymentMalformed), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(PaymentUnderfunded), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(PaymentSrcNoTrust), DataFormat = DataFormat.Default)]
    [ProtoInclude(104, typeof(PaymentSrcNotAuthorized), DataFormat = DataFormat.Default)]
    [ProtoInclude(105, typeof(PaymentNoDestination), DataFormat = DataFormat.Default)]
    [ProtoInclude(106, typeof(PaymentNoTrust), DataFormat = DataFormat.Default)]
    [ProtoInclude(107, typeof(PaymentNotAuthorized), DataFormat = DataFormat.Default)]
    [ProtoInclude(108, typeof(PaymentLineFull), DataFormat = DataFormat.Default)]
    [ProtoInclude(109, typeof(PaymentNoIssuer), DataFormat = DataFormat.Default)]
    public abstract partial class PaymentResult
    {
        public abstract PaymentResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "PaymentResult.PaymentSuccess")]
        public sealed partial class PaymentSuccess : PaymentResult
        {
            public override PaymentResultCode Discriminator => PaymentResultCode.PAYMENT_SUCCESS;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "PaymentResult.PaymentMalformed")]
        public sealed partial class PaymentMalformed : PaymentResult
        {
            public override PaymentResultCode Discriminator => PaymentResultCode.PAYMENT_MALFORMED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "PaymentResult.PaymentUnderfunded")]
        public sealed partial class PaymentUnderfunded : PaymentResult
        {
            public override PaymentResultCode Discriminator => PaymentResultCode.PAYMENT_UNDERFUNDED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "PaymentResult.PaymentSrcNoTrust")]
        public sealed partial class PaymentSrcNoTrust : PaymentResult
        {
            public override PaymentResultCode Discriminator => PaymentResultCode.PAYMENT_SRC_NO_TRUST;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "PaymentResult.PaymentSrcNotAuthorized")]
        public sealed partial class PaymentSrcNotAuthorized : PaymentResult
        {
            public override PaymentResultCode Discriminator => PaymentResultCode.PAYMENT_SRC_NOT_AUTHORIZED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "PaymentResult.PaymentNoDestination")]
        public sealed partial class PaymentNoDestination : PaymentResult
        {
            public override PaymentResultCode Discriminator => PaymentResultCode.PAYMENT_NO_DESTINATION;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "PaymentResult.PaymentNoTrust")]
        public sealed partial class PaymentNoTrust : PaymentResult
        {
            public override PaymentResultCode Discriminator => PaymentResultCode.PAYMENT_NO_TRUST;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "PaymentResult.PaymentNotAuthorized")]
        public sealed partial class PaymentNotAuthorized : PaymentResult
        {
            public override PaymentResultCode Discriminator => PaymentResultCode.PAYMENT_NOT_AUTHORIZED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "PaymentResult.PaymentLineFull")]
        public sealed partial class PaymentLineFull : PaymentResult
        {
            public override PaymentResultCode Discriminator => PaymentResultCode.PAYMENT_LINE_FULL;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "PaymentResult.PaymentNoIssuer")]
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
        /// <summary>Decodes value from XDR base64 string</summary>
        public static PaymentResult DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return PaymentResultXdr.Decode(reader);
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
