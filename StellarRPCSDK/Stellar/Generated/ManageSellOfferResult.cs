// Generated code - do not modify
// Source:

// union ManageSellOfferResult switch (ManageSellOfferResultCode code)
// {
// case MANAGE_SELL_OFFER_SUCCESS:
//     ManageOfferSuccessResult success;
// case MANAGE_SELL_OFFER_MALFORMED:
// case MANAGE_SELL_OFFER_SELL_NO_TRUST:
// case MANAGE_SELL_OFFER_BUY_NO_TRUST:
// case MANAGE_SELL_OFFER_SELL_NOT_AUTHORIZED:
// case MANAGE_SELL_OFFER_BUY_NOT_AUTHORIZED:
// case MANAGE_SELL_OFFER_LINE_FULL:
// case MANAGE_SELL_OFFER_UNDERFUNDED:
// case MANAGE_SELL_OFFER_CROSS_SELF:
// case MANAGE_SELL_OFFER_SELL_NO_ISSUER:
// case MANAGE_SELL_OFFER_BUY_NO_ISSUER:
// case MANAGE_SELL_OFFER_NOT_FOUND:
// case MANAGE_SELL_OFFER_LOW_RESERVE:
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
    [ProtoInclude(100, typeof(ManageSellOfferSuccess), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(ManageSellOfferMalformed), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(ManageSellOfferSellNoTrust), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(ManageSellOfferBuyNoTrust), DataFormat = DataFormat.Default)]
    [ProtoInclude(104, typeof(ManageSellOfferSellNotAuthorized), DataFormat = DataFormat.Default)]
    [ProtoInclude(105, typeof(ManageSellOfferBuyNotAuthorized), DataFormat = DataFormat.Default)]
    [ProtoInclude(106, typeof(ManageSellOfferLineFull), DataFormat = DataFormat.Default)]
    [ProtoInclude(107, typeof(ManageSellOfferUnderfunded), DataFormat = DataFormat.Default)]
    [ProtoInclude(108, typeof(ManageSellOfferCrossSelf), DataFormat = DataFormat.Default)]
    [ProtoInclude(109, typeof(ManageSellOfferSellNoIssuer), DataFormat = DataFormat.Default)]
    [ProtoInclude(110, typeof(ManageSellOfferBuyNoIssuer), DataFormat = DataFormat.Default)]
    [ProtoInclude(111, typeof(ManageSellOfferNotFound), DataFormat = DataFormat.Default)]
    [ProtoInclude(112, typeof(ManageSellOfferLowReserve), DataFormat = DataFormat.Default)]
    public abstract partial class ManageSellOfferResult
    {
        public abstract ManageSellOfferResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "ManageSellOfferResult_ManageSellOfferSuccess")]
        public sealed partial class ManageSellOfferSuccess : ManageSellOfferResult
        {
            public override ManageSellOfferResultCode Discriminator => ManageSellOfferResultCode.MANAGE_SELL_OFFER_SUCCESS;
            [ProtoMember(1)]
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
        [ProtoContract(Name = "ManageSellOfferResult_ManageSellOfferMalformed")]
        public sealed partial class ManageSellOfferMalformed : ManageSellOfferResult
        {
            public override ManageSellOfferResultCode Discriminator => ManageSellOfferResultCode.MANAGE_SELL_OFFER_MALFORMED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ManageSellOfferResult_ManageSellOfferSellNoTrust")]
        public sealed partial class ManageSellOfferSellNoTrust : ManageSellOfferResult
        {
            public override ManageSellOfferResultCode Discriminator => ManageSellOfferResultCode.MANAGE_SELL_OFFER_SELL_NO_TRUST;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ManageSellOfferResult_ManageSellOfferBuyNoTrust")]
        public sealed partial class ManageSellOfferBuyNoTrust : ManageSellOfferResult
        {
            public override ManageSellOfferResultCode Discriminator => ManageSellOfferResultCode.MANAGE_SELL_OFFER_BUY_NO_TRUST;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ManageSellOfferResult_ManageSellOfferSellNotAuthorized")]
        public sealed partial class ManageSellOfferSellNotAuthorized : ManageSellOfferResult
        {
            public override ManageSellOfferResultCode Discriminator => ManageSellOfferResultCode.MANAGE_SELL_OFFER_SELL_NOT_AUTHORIZED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ManageSellOfferResult_ManageSellOfferBuyNotAuthorized")]
        public sealed partial class ManageSellOfferBuyNotAuthorized : ManageSellOfferResult
        {
            public override ManageSellOfferResultCode Discriminator => ManageSellOfferResultCode.MANAGE_SELL_OFFER_BUY_NOT_AUTHORIZED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ManageSellOfferResult_ManageSellOfferLineFull")]
        public sealed partial class ManageSellOfferLineFull : ManageSellOfferResult
        {
            public override ManageSellOfferResultCode Discriminator => ManageSellOfferResultCode.MANAGE_SELL_OFFER_LINE_FULL;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ManageSellOfferResult_ManageSellOfferUnderfunded")]
        public sealed partial class ManageSellOfferUnderfunded : ManageSellOfferResult
        {
            public override ManageSellOfferResultCode Discriminator => ManageSellOfferResultCode.MANAGE_SELL_OFFER_UNDERFUNDED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ManageSellOfferResult_ManageSellOfferCrossSelf")]
        public sealed partial class ManageSellOfferCrossSelf : ManageSellOfferResult
        {
            public override ManageSellOfferResultCode Discriminator => ManageSellOfferResultCode.MANAGE_SELL_OFFER_CROSS_SELF;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ManageSellOfferResult_ManageSellOfferSellNoIssuer")]
        public sealed partial class ManageSellOfferSellNoIssuer : ManageSellOfferResult
        {
            public override ManageSellOfferResultCode Discriminator => ManageSellOfferResultCode.MANAGE_SELL_OFFER_SELL_NO_ISSUER;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ManageSellOfferResult_ManageSellOfferBuyNoIssuer")]
        public sealed partial class ManageSellOfferBuyNoIssuer : ManageSellOfferResult
        {
            public override ManageSellOfferResultCode Discriminator => ManageSellOfferResultCode.MANAGE_SELL_OFFER_BUY_NO_ISSUER;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ManageSellOfferResult_ManageSellOfferNotFound")]
        public sealed partial class ManageSellOfferNotFound : ManageSellOfferResult
        {
            public override ManageSellOfferResultCode Discriminator => ManageSellOfferResultCode.MANAGE_SELL_OFFER_NOT_FOUND;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ManageSellOfferResult_ManageSellOfferLowReserve")]
        public sealed partial class ManageSellOfferLowReserve : ManageSellOfferResult
        {
            public override ManageSellOfferResultCode Discriminator => ManageSellOfferResultCode.MANAGE_SELL_OFFER_LOW_RESERVE;

            public override void ValidateCase() {}
        }
    }
    public static partial class ManageSellOfferResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ManageSellOfferResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ManageSellOfferResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ManageSellOfferResult DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ManageSellOfferResultXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, ManageSellOfferResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ManageSellOfferResult.ManageSellOfferSuccess case_MANAGE_SELL_OFFER_SUCCESS:
                ManageOfferSuccessResultXdr.Encode(stream, case_MANAGE_SELL_OFFER_SUCCESS.success);
                break;
                case ManageSellOfferResult.ManageSellOfferMalformed case_MANAGE_SELL_OFFER_MALFORMED:
                break;
                case ManageSellOfferResult.ManageSellOfferSellNoTrust case_MANAGE_SELL_OFFER_SELL_NO_TRUST:
                break;
                case ManageSellOfferResult.ManageSellOfferBuyNoTrust case_MANAGE_SELL_OFFER_BUY_NO_TRUST:
                break;
                case ManageSellOfferResult.ManageSellOfferSellNotAuthorized case_MANAGE_SELL_OFFER_SELL_NOT_AUTHORIZED:
                break;
                case ManageSellOfferResult.ManageSellOfferBuyNotAuthorized case_MANAGE_SELL_OFFER_BUY_NOT_AUTHORIZED:
                break;
                case ManageSellOfferResult.ManageSellOfferLineFull case_MANAGE_SELL_OFFER_LINE_FULL:
                break;
                case ManageSellOfferResult.ManageSellOfferUnderfunded case_MANAGE_SELL_OFFER_UNDERFUNDED:
                break;
                case ManageSellOfferResult.ManageSellOfferCrossSelf case_MANAGE_SELL_OFFER_CROSS_SELF:
                break;
                case ManageSellOfferResult.ManageSellOfferSellNoIssuer case_MANAGE_SELL_OFFER_SELL_NO_ISSUER:
                break;
                case ManageSellOfferResult.ManageSellOfferBuyNoIssuer case_MANAGE_SELL_OFFER_BUY_NO_ISSUER:
                break;
                case ManageSellOfferResult.ManageSellOfferNotFound case_MANAGE_SELL_OFFER_NOT_FOUND:
                break;
                case ManageSellOfferResult.ManageSellOfferLowReserve case_MANAGE_SELL_OFFER_LOW_RESERVE:
                break;
            }
        }
        public static ManageSellOfferResult Decode(XdrReader stream)
        {
            var discriminator = (ManageSellOfferResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case ManageSellOfferResultCode.MANAGE_SELL_OFFER_SUCCESS:
                var result_MANAGE_SELL_OFFER_SUCCESS = new ManageSellOfferResult.ManageSellOfferSuccess();
                result_MANAGE_SELL_OFFER_SUCCESS.success = ManageOfferSuccessResultXdr.Decode(stream);
                return result_MANAGE_SELL_OFFER_SUCCESS;
                case ManageSellOfferResultCode.MANAGE_SELL_OFFER_MALFORMED:
                var result_MANAGE_SELL_OFFER_MALFORMED = new ManageSellOfferResult.ManageSellOfferMalformed();
                return result_MANAGE_SELL_OFFER_MALFORMED;
                case ManageSellOfferResultCode.MANAGE_SELL_OFFER_SELL_NO_TRUST:
                var result_MANAGE_SELL_OFFER_SELL_NO_TRUST = new ManageSellOfferResult.ManageSellOfferSellNoTrust();
                return result_MANAGE_SELL_OFFER_SELL_NO_TRUST;
                case ManageSellOfferResultCode.MANAGE_SELL_OFFER_BUY_NO_TRUST:
                var result_MANAGE_SELL_OFFER_BUY_NO_TRUST = new ManageSellOfferResult.ManageSellOfferBuyNoTrust();
                return result_MANAGE_SELL_OFFER_BUY_NO_TRUST;
                case ManageSellOfferResultCode.MANAGE_SELL_OFFER_SELL_NOT_AUTHORIZED:
                var result_MANAGE_SELL_OFFER_SELL_NOT_AUTHORIZED = new ManageSellOfferResult.ManageSellOfferSellNotAuthorized();
                return result_MANAGE_SELL_OFFER_SELL_NOT_AUTHORIZED;
                case ManageSellOfferResultCode.MANAGE_SELL_OFFER_BUY_NOT_AUTHORIZED:
                var result_MANAGE_SELL_OFFER_BUY_NOT_AUTHORIZED = new ManageSellOfferResult.ManageSellOfferBuyNotAuthorized();
                return result_MANAGE_SELL_OFFER_BUY_NOT_AUTHORIZED;
                case ManageSellOfferResultCode.MANAGE_SELL_OFFER_LINE_FULL:
                var result_MANAGE_SELL_OFFER_LINE_FULL = new ManageSellOfferResult.ManageSellOfferLineFull();
                return result_MANAGE_SELL_OFFER_LINE_FULL;
                case ManageSellOfferResultCode.MANAGE_SELL_OFFER_UNDERFUNDED:
                var result_MANAGE_SELL_OFFER_UNDERFUNDED = new ManageSellOfferResult.ManageSellOfferUnderfunded();
                return result_MANAGE_SELL_OFFER_UNDERFUNDED;
                case ManageSellOfferResultCode.MANAGE_SELL_OFFER_CROSS_SELF:
                var result_MANAGE_SELL_OFFER_CROSS_SELF = new ManageSellOfferResult.ManageSellOfferCrossSelf();
                return result_MANAGE_SELL_OFFER_CROSS_SELF;
                case ManageSellOfferResultCode.MANAGE_SELL_OFFER_SELL_NO_ISSUER:
                var result_MANAGE_SELL_OFFER_SELL_NO_ISSUER = new ManageSellOfferResult.ManageSellOfferSellNoIssuer();
                return result_MANAGE_SELL_OFFER_SELL_NO_ISSUER;
                case ManageSellOfferResultCode.MANAGE_SELL_OFFER_BUY_NO_ISSUER:
                var result_MANAGE_SELL_OFFER_BUY_NO_ISSUER = new ManageSellOfferResult.ManageSellOfferBuyNoIssuer();
                return result_MANAGE_SELL_OFFER_BUY_NO_ISSUER;
                case ManageSellOfferResultCode.MANAGE_SELL_OFFER_NOT_FOUND:
                var result_MANAGE_SELL_OFFER_NOT_FOUND = new ManageSellOfferResult.ManageSellOfferNotFound();
                return result_MANAGE_SELL_OFFER_NOT_FOUND;
                case ManageSellOfferResultCode.MANAGE_SELL_OFFER_LOW_RESERVE:
                var result_MANAGE_SELL_OFFER_LOW_RESERVE = new ManageSellOfferResult.ManageSellOfferLowReserve();
                return result_MANAGE_SELL_OFFER_LOW_RESERVE;
                default:
                throw new Exception($"Unknown discriminator for ManageSellOfferResult: {discriminator}");
            }
        }
    }
}
