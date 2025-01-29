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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class PathPaymentStrictReceiveResult
    {
        public abstract PathPaymentStrictReceiveResultCode Discriminator { get; }

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
                var length = stream.ReadInt();
                result.offers = new ClaimAtom[length];
                for (var i = 0; i < length; i++)
                {
                    result.offers[i] = ClaimAtomXdr.Decode(stream);
                }
                result.last = SimplePaymentResultXdr.Decode(stream);
                return result;
            }
        }
    }
    public sealed partial class PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_SUCCESS : PathPaymentStrictReceiveResult
    {
        public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_SUCCESS;
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
    public sealed partial class PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_MALFORMED : PathPaymentStrictReceiveResult
    {
        public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_MALFORMED;

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_UNDERFUNDED : PathPaymentStrictReceiveResult
    {
        public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_UNDERFUNDED;

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_SRC_NO_TRUST : PathPaymentStrictReceiveResult
    {
        public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_SRC_NO_TRUST;

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_SRC_NOT_AUTHORIZED : PathPaymentStrictReceiveResult
    {
        public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_SRC_NOT_AUTHORIZED;

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_NO_DESTINATION : PathPaymentStrictReceiveResult
    {
        public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_NO_DESTINATION;

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_NO_TRUST : PathPaymentStrictReceiveResult
    {
        public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_NO_TRUST;

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_NOT_AUTHORIZED : PathPaymentStrictReceiveResult
    {
        public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_NOT_AUTHORIZED;

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_LINE_FULL : PathPaymentStrictReceiveResult
    {
        public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_LINE_FULL;

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER : PathPaymentStrictReceiveResult
    {
        public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER;
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
    public sealed partial class PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_TOO_FEW_OFFERS : PathPaymentStrictReceiveResult
    {
        public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_TOO_FEW_OFFERS;

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_OFFER_CROSS_SELF : PathPaymentStrictReceiveResult
    {
        public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_OFFER_CROSS_SELF;

        public override void ValidateCase() {}
    }
    public sealed partial class PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_OVER_SENDMAX : PathPaymentStrictReceiveResult
    {
        public override PathPaymentStrictReceiveResultCode Discriminator => PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_OVER_SENDMAX;

        public override void ValidateCase() {}
    }
    public static partial class PathPaymentStrictReceiveResultXdr
    {
        public static void Encode(XdrWriter stream, PathPaymentStrictReceiveResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_SUCCESS case_PATH_PAYMENT_STRICT_RECEIVE_SUCCESS:
                PathPaymentStrictReceiveResult.successStructXdr.Encode(stream, case_PATH_PAYMENT_STRICT_RECEIVE_SUCCESS.success);
                break;
                case PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_MALFORMED case_PATH_PAYMENT_STRICT_RECEIVE_MALFORMED:
                break;
                case PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_UNDERFUNDED case_PATH_PAYMENT_STRICT_RECEIVE_UNDERFUNDED:
                break;
                case PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_SRC_NO_TRUST case_PATH_PAYMENT_STRICT_RECEIVE_SRC_NO_TRUST:
                break;
                case PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_SRC_NOT_AUTHORIZED case_PATH_PAYMENT_STRICT_RECEIVE_SRC_NOT_AUTHORIZED:
                break;
                case PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_NO_DESTINATION case_PATH_PAYMENT_STRICT_RECEIVE_NO_DESTINATION:
                break;
                case PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_NO_TRUST case_PATH_PAYMENT_STRICT_RECEIVE_NO_TRUST:
                break;
                case PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_NOT_AUTHORIZED case_PATH_PAYMENT_STRICT_RECEIVE_NOT_AUTHORIZED:
                break;
                case PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_LINE_FULL case_PATH_PAYMENT_STRICT_RECEIVE_LINE_FULL:
                break;
                case PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER case_PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER:
                AssetXdr.Encode(stream, case_PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER.noIssuer);
                break;
                case PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_TOO_FEW_OFFERS case_PATH_PAYMENT_STRICT_RECEIVE_TOO_FEW_OFFERS:
                break;
                case PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_OFFER_CROSS_SELF case_PATH_PAYMENT_STRICT_RECEIVE_OFFER_CROSS_SELF:
                break;
                case PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_OVER_SENDMAX case_PATH_PAYMENT_STRICT_RECEIVE_OVER_SENDMAX:
                break;
            }
        }
        public static PathPaymentStrictReceiveResult Decode(XdrReader stream)
        {
            var discriminator = (PathPaymentStrictReceiveResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_SUCCESS:
                var result_PATH_PAYMENT_STRICT_RECEIVE_SUCCESS = new PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_SUCCESS();
                result_PATH_PAYMENT_STRICT_RECEIVE_SUCCESS.success = PathPaymentStrictReceiveResult.successStructXdr.Decode(stream);
                return result_PATH_PAYMENT_STRICT_RECEIVE_SUCCESS;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_MALFORMED:
                var result_PATH_PAYMENT_STRICT_RECEIVE_MALFORMED = new PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_MALFORMED();
                return result_PATH_PAYMENT_STRICT_RECEIVE_MALFORMED;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_UNDERFUNDED:
                var result_PATH_PAYMENT_STRICT_RECEIVE_UNDERFUNDED = new PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_UNDERFUNDED();
                return result_PATH_PAYMENT_STRICT_RECEIVE_UNDERFUNDED;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_SRC_NO_TRUST:
                var result_PATH_PAYMENT_STRICT_RECEIVE_SRC_NO_TRUST = new PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_SRC_NO_TRUST();
                return result_PATH_PAYMENT_STRICT_RECEIVE_SRC_NO_TRUST;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_SRC_NOT_AUTHORIZED:
                var result_PATH_PAYMENT_STRICT_RECEIVE_SRC_NOT_AUTHORIZED = new PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_SRC_NOT_AUTHORIZED();
                return result_PATH_PAYMENT_STRICT_RECEIVE_SRC_NOT_AUTHORIZED;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_NO_DESTINATION:
                var result_PATH_PAYMENT_STRICT_RECEIVE_NO_DESTINATION = new PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_NO_DESTINATION();
                return result_PATH_PAYMENT_STRICT_RECEIVE_NO_DESTINATION;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_NO_TRUST:
                var result_PATH_PAYMENT_STRICT_RECEIVE_NO_TRUST = new PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_NO_TRUST();
                return result_PATH_PAYMENT_STRICT_RECEIVE_NO_TRUST;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_NOT_AUTHORIZED:
                var result_PATH_PAYMENT_STRICT_RECEIVE_NOT_AUTHORIZED = new PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_NOT_AUTHORIZED();
                return result_PATH_PAYMENT_STRICT_RECEIVE_NOT_AUTHORIZED;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_LINE_FULL:
                var result_PATH_PAYMENT_STRICT_RECEIVE_LINE_FULL = new PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_LINE_FULL();
                return result_PATH_PAYMENT_STRICT_RECEIVE_LINE_FULL;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER:
                var result_PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER = new PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER();
                result_PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER.noIssuer = AssetXdr.Decode(stream);
                return result_PATH_PAYMENT_STRICT_RECEIVE_NO_ISSUER;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_TOO_FEW_OFFERS:
                var result_PATH_PAYMENT_STRICT_RECEIVE_TOO_FEW_OFFERS = new PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_TOO_FEW_OFFERS();
                return result_PATH_PAYMENT_STRICT_RECEIVE_TOO_FEW_OFFERS;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_OFFER_CROSS_SELF:
                var result_PATH_PAYMENT_STRICT_RECEIVE_OFFER_CROSS_SELF = new PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_OFFER_CROSS_SELF();
                return result_PATH_PAYMENT_STRICT_RECEIVE_OFFER_CROSS_SELF;
                case PathPaymentStrictReceiveResultCode.PATH_PAYMENT_STRICT_RECEIVE_OVER_SENDMAX:
                var result_PATH_PAYMENT_STRICT_RECEIVE_OVER_SENDMAX = new PathPaymentStrictReceiveResult_PATH_PAYMENT_STRICT_RECEIVE_OVER_SENDMAX();
                return result_PATH_PAYMENT_STRICT_RECEIVE_OVER_SENDMAX;
                default:
                throw new Exception($"Unknown discriminator for PathPaymentStrictReceiveResult: {discriminator}");
            }
        }
    }
}
