// Generated code - do not modify
// Source:

// union PathPaymentStrictSendResult switch (PathPaymentStrictSendResultCode code)
// {
// case PATH_PAYMENT_STRICT_SEND_SUCCESS:
//     struct
//     {
//         ClaimAtom offers<>;
//         SimplePaymentResult last;
//     } success;
// case PATH_PAYMENT_STRICT_SEND_MALFORMED:
// case PATH_PAYMENT_STRICT_SEND_UNDERFUNDED:
// case PATH_PAYMENT_STRICT_SEND_SRC_NO_TRUST:
// case PATH_PAYMENT_STRICT_SEND_SRC_NOT_AUTHORIZED:
// case PATH_PAYMENT_STRICT_SEND_NO_DESTINATION:
// case PATH_PAYMENT_STRICT_SEND_NO_TRUST:
// case PATH_PAYMENT_STRICT_SEND_NOT_AUTHORIZED:
// case PATH_PAYMENT_STRICT_SEND_LINE_FULL:
//     void;
// case PATH_PAYMENT_STRICT_SEND_NO_ISSUER:
//     Asset noIssuer; // the asset that caused the error
// case PATH_PAYMENT_STRICT_SEND_TOO_FEW_OFFERS:
// case PATH_PAYMENT_STRICT_SEND_OFFER_CROSS_SELF:
// case PATH_PAYMENT_STRICT_SEND_UNDER_DESTMIN:
//     void;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class PathPaymentStrictSendResult
    {
        public abstract PathPaymentStrictSendResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public partial class successStruct
        {
            private ClaimAtom[] _offers;
            public ClaimAtom[] offers
            {
                get => _offers;
                set
                {
                    _offers = value;
                }
            }

            private SimplePaymentResult _last;
            public SimplePaymentResult last
            {
                get => _last;
                set
                {
                    _last = value;
                }
            }

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
    }
    public sealed partial class PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_SUCCESS : PathPaymentStrictSendResult
    {
        public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_SUCCESS;
        private successStruct _success;
        public successStruct success
        {
            get => _success;
            set
            {
                _success = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_MALFORMED : PathPaymentStrictSendResult
    {
        public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_MALFORMED;

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_UNDERFUNDED : PathPaymentStrictSendResult
    {
        public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_UNDERFUNDED;

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_SRC_NO_TRUST : PathPaymentStrictSendResult
    {
        public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_SRC_NO_TRUST;

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_SRC_NOT_AUTHORIZED : PathPaymentStrictSendResult
    {
        public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_SRC_NOT_AUTHORIZED;

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_NO_DESTINATION : PathPaymentStrictSendResult
    {
        public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_NO_DESTINATION;

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_NO_TRUST : PathPaymentStrictSendResult
    {
        public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_NO_TRUST;

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_NOT_AUTHORIZED : PathPaymentStrictSendResult
    {
        public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_NOT_AUTHORIZED;

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_LINE_FULL : PathPaymentStrictSendResult
    {
        public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_LINE_FULL;

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_NO_ISSUER : PathPaymentStrictSendResult
    {
        public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_NO_ISSUER;
        private Asset _noIssuer;
        public Asset noIssuer
        {
            get => _noIssuer;
            set
            {
                _noIssuer = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_TOO_FEW_OFFERS : PathPaymentStrictSendResult
    {
        public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_TOO_FEW_OFFERS;

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_OFFER_CROSS_SELF : PathPaymentStrictSendResult
    {
        public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_OFFER_CROSS_SELF;

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_UNDER_DESTMIN : PathPaymentStrictSendResult
    {
        public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_UNDER_DESTMIN;

        public override void ValidateCase() {}
    }
    public static partial class PathPaymentStrictSendResultXdr
    {
        public static void Encode(XdrWriter stream, PathPaymentStrictSendResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_SUCCESS case_PATH_PAYMENT_STRICT_SEND_SUCCESS:
                PathPaymentStrictSendResult.successStructXdr.Encode(stream, case_PATH_PAYMENT_STRICT_SEND_SUCCESS.success);
                break;
                case PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_MALFORMED case_PATH_PAYMENT_STRICT_SEND_MALFORMED:
                break;
                case PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_UNDERFUNDED case_PATH_PAYMENT_STRICT_SEND_UNDERFUNDED:
                break;
                case PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_SRC_NO_TRUST case_PATH_PAYMENT_STRICT_SEND_SRC_NO_TRUST:
                break;
                case PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_SRC_NOT_AUTHORIZED case_PATH_PAYMENT_STRICT_SEND_SRC_NOT_AUTHORIZED:
                break;
                case PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_NO_DESTINATION case_PATH_PAYMENT_STRICT_SEND_NO_DESTINATION:
                break;
                case PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_NO_TRUST case_PATH_PAYMENT_STRICT_SEND_NO_TRUST:
                break;
                case PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_NOT_AUTHORIZED case_PATH_PAYMENT_STRICT_SEND_NOT_AUTHORIZED:
                break;
                case PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_LINE_FULL case_PATH_PAYMENT_STRICT_SEND_LINE_FULL:
                break;
                case PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_NO_ISSUER case_PATH_PAYMENT_STRICT_SEND_NO_ISSUER:
                AssetXdr.Encode(stream, case_PATH_PAYMENT_STRICT_SEND_NO_ISSUER.noIssuer);
                break;
                case PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_TOO_FEW_OFFERS case_PATH_PAYMENT_STRICT_SEND_TOO_FEW_OFFERS:
                break;
                case PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_OFFER_CROSS_SELF case_PATH_PAYMENT_STRICT_SEND_OFFER_CROSS_SELF:
                break;
                case PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_UNDER_DESTMIN case_PATH_PAYMENT_STRICT_SEND_UNDER_DESTMIN:
                break;
            }
        }
        public static PathPaymentStrictSendResult Decode(XdrReader stream)
        {
            var discriminator = (PathPaymentStrictSendResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_SUCCESS:
                var result_PATH_PAYMENT_STRICT_SEND_SUCCESS = new PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_SUCCESS();
                result_PATH_PAYMENT_STRICT_SEND_SUCCESS.success = PathPaymentStrictSendResult.successStructXdr.Decode(stream);
                return result_PATH_PAYMENT_STRICT_SEND_SUCCESS;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_MALFORMED:
                var result_PATH_PAYMENT_STRICT_SEND_MALFORMED = new PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_MALFORMED();
                return result_PATH_PAYMENT_STRICT_SEND_MALFORMED;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_UNDERFUNDED:
                var result_PATH_PAYMENT_STRICT_SEND_UNDERFUNDED = new PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_UNDERFUNDED();
                return result_PATH_PAYMENT_STRICT_SEND_UNDERFUNDED;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_SRC_NO_TRUST:
                var result_PATH_PAYMENT_STRICT_SEND_SRC_NO_TRUST = new PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_SRC_NO_TRUST();
                return result_PATH_PAYMENT_STRICT_SEND_SRC_NO_TRUST;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_SRC_NOT_AUTHORIZED:
                var result_PATH_PAYMENT_STRICT_SEND_SRC_NOT_AUTHORIZED = new PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_SRC_NOT_AUTHORIZED();
                return result_PATH_PAYMENT_STRICT_SEND_SRC_NOT_AUTHORIZED;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_NO_DESTINATION:
                var result_PATH_PAYMENT_STRICT_SEND_NO_DESTINATION = new PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_NO_DESTINATION();
                return result_PATH_PAYMENT_STRICT_SEND_NO_DESTINATION;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_NO_TRUST:
                var result_PATH_PAYMENT_STRICT_SEND_NO_TRUST = new PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_NO_TRUST();
                return result_PATH_PAYMENT_STRICT_SEND_NO_TRUST;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_NOT_AUTHORIZED:
                var result_PATH_PAYMENT_STRICT_SEND_NOT_AUTHORIZED = new PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_NOT_AUTHORIZED();
                return result_PATH_PAYMENT_STRICT_SEND_NOT_AUTHORIZED;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_LINE_FULL:
                var result_PATH_PAYMENT_STRICT_SEND_LINE_FULL = new PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_LINE_FULL();
                return result_PATH_PAYMENT_STRICT_SEND_LINE_FULL;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_NO_ISSUER:
                var result_PATH_PAYMENT_STRICT_SEND_NO_ISSUER = new PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_NO_ISSUER();
                result_PATH_PAYMENT_STRICT_SEND_NO_ISSUER.noIssuer = AssetXdr.Decode(stream);
                return result_PATH_PAYMENT_STRICT_SEND_NO_ISSUER;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_TOO_FEW_OFFERS:
                var result_PATH_PAYMENT_STRICT_SEND_TOO_FEW_OFFERS = new PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_TOO_FEW_OFFERS();
                return result_PATH_PAYMENT_STRICT_SEND_TOO_FEW_OFFERS;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_OFFER_CROSS_SELF:
                var result_PATH_PAYMENT_STRICT_SEND_OFFER_CROSS_SELF = new PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_OFFER_CROSS_SELF();
                return result_PATH_PAYMENT_STRICT_SEND_OFFER_CROSS_SELF;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_UNDER_DESTMIN:
                var result_PATH_PAYMENT_STRICT_SEND_UNDER_DESTMIN = new PathPaymentStrictSendResult_PATH_PAYMENT_STRICT_SEND_UNDER_DESTMIN();
                return result_PATH_PAYMENT_STRICT_SEND_UNDER_DESTMIN;
                default:
                throw new Exception($"Unknown discriminator for PathPaymentStrictSendResult: {discriminator}");
            }
        }
    }
}
