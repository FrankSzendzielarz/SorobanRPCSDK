// Generated code - do not modify
// Source:

// union PathPaymentStrictReceiveResult switch (
//     PathPaymentStrictReceiveResultCode code)
// {
// case PATH_PAYMENT_STRICT_RECEIVE_SUCCESS:
//     struct
//     {
//         ClaimAtom offers<>;
//         SimplePaymentResult last;
//     } success;
// case PATH_PAYMENT_STRICT_RECEIVE_MALFORMED:
// case PATH_PAYMENT_STRICT_RECEIVE_UNDERFUNDED:
// case PATH_PAYMENT_STRICT_RECEIVE_SRC_NO_TRUST:
// case PATH_PAYMENT_STRICT_RECEIVE_SRC_NOT_AUTHORIZED:
// case PATH_PAYMENT_STRICT_RECEIVE_NO_DESTINATION:
// case PATH_PAYMENT_STRICT_RECEIVE_NO_TRUST:
// case PATH_PAYMENT_STRICT_RECEIVE_NOT_AUTHORIZED:
// case PATH_PAYMENT_STRICT_RECEIVE_LINE_FULL:
//     void;
// case PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER:
//     Asset noIssuer; // the asset that caused the error
// case PATH_PAYMENT_STRICT_RECEIVE_TOO_FEW_OFFERS:
// case PATH_PAYMENT_STRICT_RECEIVE_OFFER_CROSS_SELF:
// case PATH_PAYMENT_STRICT_RECEIVE_OVER_SENDMAX:
//     void;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class PathPaymentStrictReceiveResult
    {
        public abstract PathPaymentStrictReceiveResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public partial class successStruct
        {
            public ClaimAtom[] offers
            {
                get => _offers;
                set
                {
                    _offers = value;
                }
            }
            private ClaimAtom[] _offers;

            public SimplePaymentResult last
            {
                get => _last;
                set
                {
                    _last = value;
                }
            }
            private SimplePaymentResult _last;

            public successStruct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class successStructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(successStruct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    successStructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, successStruct value)
            {
                value.Validate();
                stream.WriteInt(value.offers.Length);
                foreach (var item in value.offers)
                {
                        ClaimAtomXdr.Encode(stream, item);
                }
                SimplePaymentResultXdr.Encode(stream, value.last);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static successStruct Decode(XdrReader stream)
            {
                var result = new successStruct();
                {
                    var length = stream.ReadInt();
                    result.offers = new ClaimAtom[length];
                    for (var i = 0; i < length; i++)
                    {
                        result.offers[i] = ClaimAtomXdr.Decode(stream);
                    }
                }
                result.last = SimplePaymentResultXdr.Decode(stream);
                return result;
            }
        }
        public sealed partial class PathPaymentStrictReceiveSuccess : PathPaymentStrictReceiveResult
        {
            public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_SUCCESS;
            public successStruct success
            {
                get => _success;
                set
                {
                    _success = value;
                }
            }
            private successStruct _success;

            public override void ValidateCase() {}
        }
        public sealed partial class PathPaymentStrictReceiveMalformed : PathPaymentStrictReceiveResult
        {
            public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_MALFORMED;

            public override void ValidateCase() {}
        }
        public sealed partial class PathPaymentStrictReceiveUnderfunded : PathPaymentStrictReceiveResult
        {
            public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_UNDERFUNDED;

            public override void ValidateCase() {}
        }
        public sealed partial class PathPaymentStrictReceiveSrcNoTrust : PathPaymentStrictReceiveResult
        {
            public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_SRC_NO_TRUST;

            public override void ValidateCase() {}
        }
        public sealed partial class PathPaymentStrictReceiveSrcNotAuthorized : PathPaymentStrictReceiveResult
        {
            public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_SRC_NOT_AUTHORIZED;

            public override void ValidateCase() {}
        }
        public sealed partial class PathPaymentStrictReceiveNoDestination : PathPaymentStrictReceiveResult
        {
            public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_NO_DESTINATION;

            public override void ValidateCase() {}
        }
        public sealed partial class PathPaymentStrictReceiveNoTrust : PathPaymentStrictReceiveResult
        {
            public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_NO_TRUST;

            public override void ValidateCase() {}
        }
        public sealed partial class PathPaymentStrictReceiveNotAuthorized : PathPaymentStrictReceiveResult
        {
            public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_NOT_AUTHORIZED;

            public override void ValidateCase() {}
        }
        public sealed partial class PathPaymentStrictReceiveLineFull : PathPaymentStrictReceiveResult
        {
            public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_LINE_FULL;

            public override void ValidateCase() {}
        }
        public sealed partial class PathPaymentStrictReceiveNoIssuer : PathPaymentStrictReceiveResult
        {
            public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER;
            public Asset noIssuer
            {
                get => _noIssuer;
                set
                {
                    _noIssuer = value;
                }
            }
            private Asset _noIssuer;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// the asset that caused the error
        /// </summary>
        public sealed partial class PathPaymentStrictReceiveTooFewOffers : PathPaymentStrictReceiveResult
        {
            public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_TOO_FEW_OFFERS;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// the asset that caused the error
        /// </summary>
        public sealed partial class PathPaymentStrictReceiveOfferCrossSelf : PathPaymentStrictReceiveResult
        {
            public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_OFFER_CROSS_SELF;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// the asset that caused the error
        /// </summary>
        public sealed partial class PathPaymentStrictReceiveOverSendmax : PathPaymentStrictReceiveResult
        {
            public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_OVER_SENDMAX;

            public override void ValidateCase() {}
        }
    }
    public static partial class PathPaymentStrictReceiveResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(PathPaymentStrictReceiveResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                PathPaymentStrictReceiveResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, PathPaymentStrictReceiveResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case PathPaymentStrictReceiveResult.PathPaymentStrictReceiveSuccess case_PATH_PAYMENT_STRICT_RECEIVE_SUCCESS:
                PathPaymentStrictReceiveResult.successStructXdr.Encode(stream, case_PATH_PAYMENT_STRICT_RECEIVE_SUCCESS.success);
                break;
                case PathPaymentStrictReceiveResult.PathPaymentStrictReceiveMalformed case_PATH_PAYMENT_STRICT_RECEIVE_MALFORMED:
                break;
                case PathPaymentStrictReceiveResult.PathPaymentStrictReceiveUnderfunded case_PATH_PAYMENT_STRICT_RECEIVE_UNDERFUNDED:
                break;
                case PathPaymentStrictReceiveResult.PathPaymentStrictReceiveSrcNoTrust case_PATH_PAYMENT_STRICT_RECEIVE_SRC_NO_TRUST:
                break;
                case PathPaymentStrictReceiveResult.PathPaymentStrictReceiveSrcNotAuthorized case_PATH_PAYMENT_STRICT_RECEIVE_SRC_NOT_AUTHORIZED:
                break;
                case PathPaymentStrictReceiveResult.PathPaymentStrictReceiveNoDestination case_PATH_PAYMENT_STRICT_RECEIVE_NO_DESTINATION:
                break;
                case PathPaymentStrictReceiveResult.PathPaymentStrictReceiveNoTrust case_PATH_PAYMENT_STRICT_RECEIVE_NO_TRUST:
                break;
                case PathPaymentStrictReceiveResult.PathPaymentStrictReceiveNotAuthorized case_PATH_PAYMENT_STRICT_RECEIVE_NOT_AUTHORIZED:
                break;
                case PathPaymentStrictReceiveResult.PathPaymentStrictReceiveLineFull case_PATH_PAYMENT_STRICT_RECEIVE_LINE_FULL:
                break;
                case PathPaymentStrictReceiveResult.PathPaymentStrictReceiveNoIssuer case_PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER:
                AssetXdr.Encode(stream, case_PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER.noIssuer);
                break;
                case PathPaymentStrictReceiveResult.PathPaymentStrictReceiveTooFewOffers case_PATH_PAYMENT_STRICT_RECEIVE_TOO_FEW_OFFERS:
                break;
                case PathPaymentStrictReceiveResult.PathPaymentStrictReceiveOfferCrossSelf case_PATH_PAYMENT_STRICT_RECEIVE_OFFER_CROSS_SELF:
                break;
                case PathPaymentStrictReceiveResult.PathPaymentStrictReceiveOverSendmax case_PATH_PAYMENT_STRICT_RECEIVE_OVER_SENDMAX:
                break;
            }
        }
        public static PathPaymentStrictReceiveResult Decode(XdrReader stream)
        {
            var discriminator = (PathPaymentStrictReceiveResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_SUCCESS:
                var result_PATH_PAYMENT_STRICT_RECEIVE_SUCCESS = new PathPaymentStrictReceiveResult.PathPaymentStrictReceiveSuccess();
                result_PATH_PAYMENT_STRICT_RECEIVE_SUCCESS.success = PathPaymentStrictReceiveResult.successStructXdr.Decode(stream);
                return result_PATH_PAYMENT_STRICT_RECEIVE_SUCCESS;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_MALFORMED:
                var result_PATH_PAYMENT_STRICT_RECEIVE_MALFORMED = new PathPaymentStrictReceiveResult.PathPaymentStrictReceiveMalformed();
                return result_PATH_PAYMENT_STRICT_RECEIVE_MALFORMED;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_UNDERFUNDED:
                var result_PATH_PAYMENT_STRICT_RECEIVE_UNDERFUNDED = new PathPaymentStrictReceiveResult.PathPaymentStrictReceiveUnderfunded();
                return result_PATH_PAYMENT_STRICT_RECEIVE_UNDERFUNDED;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_SRC_NO_TRUST:
                var result_PATH_PAYMENT_STRICT_RECEIVE_SRC_NO_TRUST = new PathPaymentStrictReceiveResult.PathPaymentStrictReceiveSrcNoTrust();
                return result_PATH_PAYMENT_STRICT_RECEIVE_SRC_NO_TRUST;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_SRC_NOT_AUTHORIZED:
                var result_PATH_PAYMENT_STRICT_RECEIVE_SRC_NOT_AUTHORIZED = new PathPaymentStrictReceiveResult.PathPaymentStrictReceiveSrcNotAuthorized();
                return result_PATH_PAYMENT_STRICT_RECEIVE_SRC_NOT_AUTHORIZED;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_NO_DESTINATION:
                var result_PATH_PAYMENT_STRICT_RECEIVE_NO_DESTINATION = new PathPaymentStrictReceiveResult.PathPaymentStrictReceiveNoDestination();
                return result_PATH_PAYMENT_STRICT_RECEIVE_NO_DESTINATION;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_NO_TRUST:
                var result_PATH_PAYMENT_STRICT_RECEIVE_NO_TRUST = new PathPaymentStrictReceiveResult.PathPaymentStrictReceiveNoTrust();
                return result_PATH_PAYMENT_STRICT_RECEIVE_NO_TRUST;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_NOT_AUTHORIZED:
                var result_PATH_PAYMENT_STRICT_RECEIVE_NOT_AUTHORIZED = new PathPaymentStrictReceiveResult.PathPaymentStrictReceiveNotAuthorized();
                return result_PATH_PAYMENT_STRICT_RECEIVE_NOT_AUTHORIZED;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_LINE_FULL:
                var result_PATH_PAYMENT_STRICT_RECEIVE_LINE_FULL = new PathPaymentStrictReceiveResult.PathPaymentStrictReceiveLineFull();
                return result_PATH_PAYMENT_STRICT_RECEIVE_LINE_FULL;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER:
                var result_PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER = new PathPaymentStrictReceiveResult.PathPaymentStrictReceiveNoIssuer();
                result_PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER.noIssuer = AssetXdr.Decode(stream);
                return result_PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_TOO_FEW_OFFERS:
                var result_PATH_PAYMENT_STRICT_RECEIVE_TOO_FEW_OFFERS = new PathPaymentStrictReceiveResult.PathPaymentStrictReceiveTooFewOffers();
                return result_PATH_PAYMENT_STRICT_RECEIVE_TOO_FEW_OFFERS;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_OFFER_CROSS_SELF:
                var result_PATH_PAYMENT_STRICT_RECEIVE_OFFER_CROSS_SELF = new PathPaymentStrictReceiveResult.PathPaymentStrictReceiveOfferCrossSelf();
                return result_PATH_PAYMENT_STRICT_RECEIVE_OFFER_CROSS_SELF;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_OVER_SENDMAX:
                var result_PATH_PAYMENT_STRICT_RECEIVE_OVER_SENDMAX = new PathPaymentStrictReceiveResult.PathPaymentStrictReceiveOverSendmax();
                return result_PATH_PAYMENT_STRICT_RECEIVE_OVER_SENDMAX;
                default:
                throw new Exception($"Unknown discriminator for PathPaymentStrictReceiveResult: {discriminator}");
            }
        }
    }
}
