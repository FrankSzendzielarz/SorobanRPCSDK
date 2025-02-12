// Generated code - do not modify
// Source:

// union ManageBuyOfferResult switch (ManageBuyOfferResultCode code)
// {
// case MANAGE_BUY_OFFER_SUCCESS:
//     ManageOfferSuccessResult success;
// case MANAGE_BUY_OFFER_MALFORMED:
// case MANAGE_BUY_OFFER_SELL_NO_TRUST:
// case MANAGE_BUY_OFFER_BUY_NO_TRUST:
// case MANAGE_BUY_OFFER_SELL_NOT_AUTHORIZED:
// case MANAGE_BUY_OFFER_BUY_NOT_AUTHORIZED:
// case MANAGE_BUY_OFFER_LINE_FULL:
// case MANAGE_BUY_OFFER_UNDERFUNDED:
// case MANAGE_BUY_OFFER_CROSS_SELF:
// case MANAGE_BUY_OFFER_SELL_NO_ISSUER:
// case MANAGE_BUY_OFFER_BUY_NO_ISSUER:
// case MANAGE_BUY_OFFER_NOT_FOUND:
// case MANAGE_BUY_OFFER_LOW_RESERVE:
//     void;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public abstract partial class ManageBuyOfferResult
    {
        public abstract ManageBuyOfferResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        public sealed partial class ManageBuyOfferSuccess : ManageBuyOfferResult
        {
            public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_SUCCESS;
            public ManageOfferSuccessResult success
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
            private ManageOfferSuccessResult _success;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ManageBuyOfferMalformed : ManageBuyOfferResult
        {
            public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_MALFORMED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ManageBuyOfferSellNoTrust : ManageBuyOfferResult
        {
            public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_SELL_NO_TRUST;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ManageBuyOfferBuyNoTrust : ManageBuyOfferResult
        {
            public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_BUY_NO_TRUST;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ManageBuyOfferSellNotAuthorized : ManageBuyOfferResult
        {
            public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_SELL_NOT_AUTHORIZED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ManageBuyOfferBuyNotAuthorized : ManageBuyOfferResult
        {
            public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_BUY_NOT_AUTHORIZED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ManageBuyOfferLineFull : ManageBuyOfferResult
        {
            public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_LINE_FULL;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ManageBuyOfferUnderfunded : ManageBuyOfferResult
        {
            public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_UNDERFUNDED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ManageBuyOfferCrossSelf : ManageBuyOfferResult
        {
            public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_CROSS_SELF;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ManageBuyOfferSellNoIssuer : ManageBuyOfferResult
        {
            public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_SELL_NO_ISSUER;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ManageBuyOfferBuyNoIssuer : ManageBuyOfferResult
        {
            public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_BUY_NO_ISSUER;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ManageBuyOfferNotFound : ManageBuyOfferResult
        {
            public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_NOT_FOUND;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ManageBuyOfferLowReserve : ManageBuyOfferResult
        {
            public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_LOW_RESERVE;

            public override void ValidateCase() {}
        }
    }
    public static partial class ManageBuyOfferResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ManageBuyOfferResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ManageBuyOfferResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, ManageBuyOfferResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ManageBuyOfferResult.ManageBuyOfferSuccess case_MANAGE_BUY_OFFER_SUCCESS:
                ManageOfferSuccessResultXdr.Encode(stream, case_MANAGE_BUY_OFFER_SUCCESS.success);
                break;
                case ManageBuyOfferResult.ManageBuyOfferMalformed case_MANAGE_BUY_OFFER_MALFORMED:
                break;
                case ManageBuyOfferResult.ManageBuyOfferSellNoTrust case_MANAGE_BUY_OFFER_SELL_NO_TRUST:
                break;
                case ManageBuyOfferResult.ManageBuyOfferBuyNoTrust case_MANAGE_BUY_OFFER_BUY_NO_TRUST:
                break;
                case ManageBuyOfferResult.ManageBuyOfferSellNotAuthorized case_MANAGE_BUY_OFFER_SELL_NOT_AUTHORIZED:
                break;
                case ManageBuyOfferResult.ManageBuyOfferBuyNotAuthorized case_MANAGE_BUY_OFFER_BUY_NOT_AUTHORIZED:
                break;
                case ManageBuyOfferResult.ManageBuyOfferLineFull case_MANAGE_BUY_OFFER_LINE_FULL:
                break;
                case ManageBuyOfferResult.ManageBuyOfferUnderfunded case_MANAGE_BUY_OFFER_UNDERFUNDED:
                break;
                case ManageBuyOfferResult.ManageBuyOfferCrossSelf case_MANAGE_BUY_OFFER_CROSS_SELF:
                break;
                case ManageBuyOfferResult.ManageBuyOfferSellNoIssuer case_MANAGE_BUY_OFFER_SELL_NO_ISSUER:
                break;
                case ManageBuyOfferResult.ManageBuyOfferBuyNoIssuer case_MANAGE_BUY_OFFER_BUY_NO_ISSUER:
                break;
                case ManageBuyOfferResult.ManageBuyOfferNotFound case_MANAGE_BUY_OFFER_NOT_FOUND:
                break;
                case ManageBuyOfferResult.ManageBuyOfferLowReserve case_MANAGE_BUY_OFFER_LOW_RESERVE:
                break;
            }
        }
        public static ManageBuyOfferResult Decode(XdrReader stream)
        {
            var discriminator = (ManageBuyOfferResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_SUCCESS:
                var result_MANAGE_BUY_OFFER_SUCCESS = new ManageBuyOfferResult.ManageBuyOfferSuccess();
                result_MANAGE_BUY_OFFER_SUCCESS.success = ManageOfferSuccessResultXdr.Decode(stream);
                return result_MANAGE_BUY_OFFER_SUCCESS;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_MALFORMED:
                var result_MANAGE_BUY_OFFER_MALFORMED = new ManageBuyOfferResult.ManageBuyOfferMalformed();
                return result_MANAGE_BUY_OFFER_MALFORMED;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_SELL_NO_TRUST:
                var result_MANAGE_BUY_OFFER_SELL_NO_TRUST = new ManageBuyOfferResult.ManageBuyOfferSellNoTrust();
                return result_MANAGE_BUY_OFFER_SELL_NO_TRUST;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_BUY_NO_TRUST:
                var result_MANAGE_BUY_OFFER_BUY_NO_TRUST = new ManageBuyOfferResult.ManageBuyOfferBuyNoTrust();
                return result_MANAGE_BUY_OFFER_BUY_NO_TRUST;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_SELL_NOT_AUTHORIZED:
                var result_MANAGE_BUY_OFFER_SELL_NOT_AUTHORIZED = new ManageBuyOfferResult.ManageBuyOfferSellNotAuthorized();
                return result_MANAGE_BUY_OFFER_SELL_NOT_AUTHORIZED;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_BUY_NOT_AUTHORIZED:
                var result_MANAGE_BUY_OFFER_BUY_NOT_AUTHORIZED = new ManageBuyOfferResult.ManageBuyOfferBuyNotAuthorized();
                return result_MANAGE_BUY_OFFER_BUY_NOT_AUTHORIZED;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_LINE_FULL:
                var result_MANAGE_BUY_OFFER_LINE_FULL = new ManageBuyOfferResult.ManageBuyOfferLineFull();
                return result_MANAGE_BUY_OFFER_LINE_FULL;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_UNDERFUNDED:
                var result_MANAGE_BUY_OFFER_UNDERFUNDED = new ManageBuyOfferResult.ManageBuyOfferUnderfunded();
                return result_MANAGE_BUY_OFFER_UNDERFUNDED;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_CROSS_SELF:
                var result_MANAGE_BUY_OFFER_CROSS_SELF = new ManageBuyOfferResult.ManageBuyOfferCrossSelf();
                return result_MANAGE_BUY_OFFER_CROSS_SELF;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_SELL_NO_ISSUER:
                var result_MANAGE_BUY_OFFER_SELL_NO_ISSUER = new ManageBuyOfferResult.ManageBuyOfferSellNoIssuer();
                return result_MANAGE_BUY_OFFER_SELL_NO_ISSUER;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_BUY_NO_ISSUER:
                var result_MANAGE_BUY_OFFER_BUY_NO_ISSUER = new ManageBuyOfferResult.ManageBuyOfferBuyNoIssuer();
                return result_MANAGE_BUY_OFFER_BUY_NO_ISSUER;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_NOT_FOUND:
                var result_MANAGE_BUY_OFFER_NOT_FOUND = new ManageBuyOfferResult.ManageBuyOfferNotFound();
                return result_MANAGE_BUY_OFFER_NOT_FOUND;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_LOW_RESERVE:
                var result_MANAGE_BUY_OFFER_LOW_RESERVE = new ManageBuyOfferResult.ManageBuyOfferLowReserve();
                return result_MANAGE_BUY_OFFER_LOW_RESERVE;
                default:
                throw new Exception($"Unknown discriminator for ManageBuyOfferResult: {discriminator}");
            }
        }
    }
}
