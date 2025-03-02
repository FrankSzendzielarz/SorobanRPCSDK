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
    [ProtoInclude(100, typeof(PathPaymentStrictSendSuccess), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(PathPaymentStrictSendMalformed), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(PathPaymentStrictSendUnderfunded), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(PathPaymentStrictSendSrcNoTrust), DataFormat = DataFormat.Default)]
    [ProtoInclude(104, typeof(PathPaymentStrictSendSrcNotAuthorized), DataFormat = DataFormat.Default)]
    [ProtoInclude(105, typeof(PathPaymentStrictSendNoDestination), DataFormat = DataFormat.Default)]
    [ProtoInclude(106, typeof(PathPaymentStrictSendNoTrust), DataFormat = DataFormat.Default)]
    [ProtoInclude(107, typeof(PathPaymentStrictSendNotAuthorized), DataFormat = DataFormat.Default)]
    [ProtoInclude(108, typeof(PathPaymentStrictSendLineFull), DataFormat = DataFormat.Default)]
    [ProtoInclude(109, typeof(PathPaymentStrictSendNoIssuer), DataFormat = DataFormat.Default)]
    [ProtoInclude(110, typeof(PathPaymentStrictSendTooFewOffers), DataFormat = DataFormat.Default)]
    [ProtoInclude(111, typeof(PathPaymentStrictSendOfferCrossSelf), DataFormat = DataFormat.Default)]
    [ProtoInclude(112, typeof(PathPaymentStrictSendUnderDestmin), DataFormat = DataFormat.Default)]
    public abstract partial class PathPaymentStrictSendResult
    {
        public abstract PathPaymentStrictSendResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "PathPaymentStrictSendResult_successStruct")]
        public partial class successStruct
        {
            [ProtoMember(1, OverwriteList = true)]
            public ClaimAtom[] offers
            {
                get => _offers;
                set
                {
                    _offers = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Offers")]
            #endif
            private ClaimAtom[] _offers;

            [ProtoMember(2)]
            public SimplePaymentResult last
            {
                get => _last;
                set
                {
                    _last = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Last")]
            #endif
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
            /// <summary>Decodes value from XDR base64 string</summary>
            public static successStruct DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return successStructXdr.Decode(reader);
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
        [System.Serializable]
        [ProtoContract(Name = "PathPaymentStrictSendResult_PathPaymentStrictSendSuccess")]
        public sealed partial class PathPaymentStrictSendSuccess : PathPaymentStrictSendResult
        {
            public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_SUCCESS;
            [ProtoMember(1)]
            public successStruct success
            {
                get => _success;
                set
                {
                    _success = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Success")]
            #endif
            private successStruct _success;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "PathPaymentStrictSendResult_PathPaymentStrictSendMalformed")]
        public sealed partial class PathPaymentStrictSendMalformed : PathPaymentStrictSendResult
        {
            public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_MALFORMED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "PathPaymentStrictSendResult_PathPaymentStrictSendUnderfunded")]
        public sealed partial class PathPaymentStrictSendUnderfunded : PathPaymentStrictSendResult
        {
            public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_UNDERFUNDED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "PathPaymentStrictSendResult_PathPaymentStrictSendSrcNoTrust")]
        public sealed partial class PathPaymentStrictSendSrcNoTrust : PathPaymentStrictSendResult
        {
            public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_SRC_NO_TRUST;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "PathPaymentStrictSendResult_PathPaymentStrictSendSrcNotAuthorized")]
        public sealed partial class PathPaymentStrictSendSrcNotAuthorized : PathPaymentStrictSendResult
        {
            public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_SRC_NOT_AUTHORIZED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "PathPaymentStrictSendResult_PathPaymentStrictSendNoDestination")]
        public sealed partial class PathPaymentStrictSendNoDestination : PathPaymentStrictSendResult
        {
            public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_NO_DESTINATION;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "PathPaymentStrictSendResult_PathPaymentStrictSendNoTrust")]
        public sealed partial class PathPaymentStrictSendNoTrust : PathPaymentStrictSendResult
        {
            public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_NO_TRUST;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "PathPaymentStrictSendResult_PathPaymentStrictSendNotAuthorized")]
        public sealed partial class PathPaymentStrictSendNotAuthorized : PathPaymentStrictSendResult
        {
            public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_NOT_AUTHORIZED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "PathPaymentStrictSendResult_PathPaymentStrictSendLineFull")]
        public sealed partial class PathPaymentStrictSendLineFull : PathPaymentStrictSendResult
        {
            public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_LINE_FULL;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "PathPaymentStrictSendResult_PathPaymentStrictSendNoIssuer")]
        public sealed partial class PathPaymentStrictSendNoIssuer : PathPaymentStrictSendResult
        {
            public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_NO_ISSUER;
            [ProtoMember(2)]
            public Asset noIssuer
            {
                get => _noIssuer;
                set
                {
                    _noIssuer = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"No Issuer")]
            #endif
            private Asset _noIssuer;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// the asset that caused the error
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "PathPaymentStrictSendResult_PathPaymentStrictSendTooFewOffers")]
        public sealed partial class PathPaymentStrictSendTooFewOffers : PathPaymentStrictSendResult
        {
            public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_TOO_FEW_OFFERS;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// the asset that caused the error
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "PathPaymentStrictSendResult_PathPaymentStrictSendOfferCrossSelf")]
        public sealed partial class PathPaymentStrictSendOfferCrossSelf : PathPaymentStrictSendResult
        {
            public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_OFFER_CROSS_SELF;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// the asset that caused the error
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "PathPaymentStrictSendResult_PathPaymentStrictSendUnderDestmin")]
        public sealed partial class PathPaymentStrictSendUnderDestmin : PathPaymentStrictSendResult
        {
            public override PathPaymentStrictSendResultCode Discriminator => PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_UNDER_DESTMIN;

            public override void ValidateCase() {}
        }
    }
    public static partial class PathPaymentStrictSendResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(PathPaymentStrictSendResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                PathPaymentStrictSendResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static PathPaymentStrictSendResult DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return PathPaymentStrictSendResultXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, PathPaymentStrictSendResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case PathPaymentStrictSendResult.PathPaymentStrictSendSuccess case_PATH_PAYMENT_STRICT_SEND_SUCCESS:
                PathPaymentStrictSendResult.successStructXdr.Encode(stream, case_PATH_PAYMENT_STRICT_SEND_SUCCESS.success);
                break;
                case PathPaymentStrictSendResult.PathPaymentStrictSendMalformed case_PATH_PAYMENT_STRICT_SEND_MALFORMED:
                break;
                case PathPaymentStrictSendResult.PathPaymentStrictSendUnderfunded case_PATH_PAYMENT_STRICT_SEND_UNDERFUNDED:
                break;
                case PathPaymentStrictSendResult.PathPaymentStrictSendSrcNoTrust case_PATH_PAYMENT_STRICT_SEND_SRC_NO_TRUST:
                break;
                case PathPaymentStrictSendResult.PathPaymentStrictSendSrcNotAuthorized case_PATH_PAYMENT_STRICT_SEND_SRC_NOT_AUTHORIZED:
                break;
                case PathPaymentStrictSendResult.PathPaymentStrictSendNoDestination case_PATH_PAYMENT_STRICT_SEND_NO_DESTINATION:
                break;
                case PathPaymentStrictSendResult.PathPaymentStrictSendNoTrust case_PATH_PAYMENT_STRICT_SEND_NO_TRUST:
                break;
                case PathPaymentStrictSendResult.PathPaymentStrictSendNotAuthorized case_PATH_PAYMENT_STRICT_SEND_NOT_AUTHORIZED:
                break;
                case PathPaymentStrictSendResult.PathPaymentStrictSendLineFull case_PATH_PAYMENT_STRICT_SEND_LINE_FULL:
                break;
                case PathPaymentStrictSendResult.PathPaymentStrictSendNoIssuer case_PATH_PAYMENT_STRICT_SEND_NO_ISSUER:
                AssetXdr.Encode(stream, case_PATH_PAYMENT_STRICT_SEND_NO_ISSUER.noIssuer);
                break;
                case PathPaymentStrictSendResult.PathPaymentStrictSendTooFewOffers case_PATH_PAYMENT_STRICT_SEND_TOO_FEW_OFFERS:
                break;
                case PathPaymentStrictSendResult.PathPaymentStrictSendOfferCrossSelf case_PATH_PAYMENT_STRICT_SEND_OFFER_CROSS_SELF:
                break;
                case PathPaymentStrictSendResult.PathPaymentStrictSendUnderDestmin case_PATH_PAYMENT_STRICT_SEND_UNDER_DESTMIN:
                break;
            }
        }
        public static PathPaymentStrictSendResult Decode(XdrReader stream)
        {
            var discriminator = (PathPaymentStrictSendResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_SUCCESS:
                var result_PATH_PAYMENT_STRICT_SEND_SUCCESS = new PathPaymentStrictSendResult.PathPaymentStrictSendSuccess();
                result_PATH_PAYMENT_STRICT_SEND_SUCCESS.success = PathPaymentStrictSendResult.successStructXdr.Decode(stream);
                return result_PATH_PAYMENT_STRICT_SEND_SUCCESS;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_MALFORMED:
                var result_PATH_PAYMENT_STRICT_SEND_MALFORMED = new PathPaymentStrictSendResult.PathPaymentStrictSendMalformed();
                return result_PATH_PAYMENT_STRICT_SEND_MALFORMED;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_UNDERFUNDED:
                var result_PATH_PAYMENT_STRICT_SEND_UNDERFUNDED = new PathPaymentStrictSendResult.PathPaymentStrictSendUnderfunded();
                return result_PATH_PAYMENT_STRICT_SEND_UNDERFUNDED;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_SRC_NO_TRUST:
                var result_PATH_PAYMENT_STRICT_SEND_SRC_NO_TRUST = new PathPaymentStrictSendResult.PathPaymentStrictSendSrcNoTrust();
                return result_PATH_PAYMENT_STRICT_SEND_SRC_NO_TRUST;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_SRC_NOT_AUTHORIZED:
                var result_PATH_PAYMENT_STRICT_SEND_SRC_NOT_AUTHORIZED = new PathPaymentStrictSendResult.PathPaymentStrictSendSrcNotAuthorized();
                return result_PATH_PAYMENT_STRICT_SEND_SRC_NOT_AUTHORIZED;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_NO_DESTINATION:
                var result_PATH_PAYMENT_STRICT_SEND_NO_DESTINATION = new PathPaymentStrictSendResult.PathPaymentStrictSendNoDestination();
                return result_PATH_PAYMENT_STRICT_SEND_NO_DESTINATION;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_NO_TRUST:
                var result_PATH_PAYMENT_STRICT_SEND_NO_TRUST = new PathPaymentStrictSendResult.PathPaymentStrictSendNoTrust();
                return result_PATH_PAYMENT_STRICT_SEND_NO_TRUST;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_NOT_AUTHORIZED:
                var result_PATH_PAYMENT_STRICT_SEND_NOT_AUTHORIZED = new PathPaymentStrictSendResult.PathPaymentStrictSendNotAuthorized();
                return result_PATH_PAYMENT_STRICT_SEND_NOT_AUTHORIZED;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_LINE_FULL:
                var result_PATH_PAYMENT_STRICT_SEND_LINE_FULL = new PathPaymentStrictSendResult.PathPaymentStrictSendLineFull();
                return result_PATH_PAYMENT_STRICT_SEND_LINE_FULL;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_NO_ISSUER:
                var result_PATH_PAYMENT_STRICT_SEND_NO_ISSUER = new PathPaymentStrictSendResult.PathPaymentStrictSendNoIssuer();
                result_PATH_PAYMENT_STRICT_SEND_NO_ISSUER.noIssuer = AssetXdr.Decode(stream);
                return result_PATH_PAYMENT_STRICT_SEND_NO_ISSUER;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_TOO_FEW_OFFERS:
                var result_PATH_PAYMENT_STRICT_SEND_TOO_FEW_OFFERS = new PathPaymentStrictSendResult.PathPaymentStrictSendTooFewOffers();
                return result_PATH_PAYMENT_STRICT_SEND_TOO_FEW_OFFERS;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_OFFER_CROSS_SELF:
                var result_PATH_PAYMENT_STRICT_SEND_OFFER_CROSS_SELF = new PathPaymentStrictSendResult.PathPaymentStrictSendOfferCrossSelf();
                return result_PATH_PAYMENT_STRICT_SEND_OFFER_CROSS_SELF;
                case PathPaymentStrictSendResultCode.PATH_PAYMENT_STRICT_SEND_UNDER_DESTMIN:
                var result_PATH_PAYMENT_STRICT_SEND_UNDER_DESTMIN = new PathPaymentStrictSendResult.PathPaymentStrictSendUnderDestmin();
                return result_PATH_PAYMENT_STRICT_SEND_UNDER_DESTMIN;
                default:
                throw new Exception($"Unknown discriminator for PathPaymentStrictSendResult: {discriminator}");
            }
        }
    }
}
