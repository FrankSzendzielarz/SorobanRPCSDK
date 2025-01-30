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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class ManageBuyOfferResult
    {
        public abstract ManageBuyOfferResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class ManageBuyOfferResult_MANAGE_BUY_OFFER_SUCCESS : ManageBuyOfferResult
    {
        public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_SUCCESS;
        private ManageOfferSuccessResult _success;
        public ManageOfferSuccessResult success
        {
            get => _success;
            set
            {
                _success = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class ManageBuyOfferResult_MANAGE_BUY_OFFER_MALFORMED : ManageBuyOfferResult
    {
        public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_MALFORMED;

        public override void ValidateCase() {}
    }
    public sealed partial class ManageBuyOfferResult_MANAGE_BUY_OFFER_SELL_NO_TRUST : ManageBuyOfferResult
    {
        public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_SELL_NO_TRUST;

        public override void ValidateCase() {}
    }
    public sealed partial class ManageBuyOfferResult_MANAGE_BUY_OFFER_BUY_NO_TRUST : ManageBuyOfferResult
    {
        public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_BUY_NO_TRUST;

        public override void ValidateCase() {}
    }
    public sealed partial class ManageBuyOfferResult_MANAGE_BUY_OFFER_SELL_NOT_AUTHORIZED : ManageBuyOfferResult
    {
        public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_SELL_NOT_AUTHORIZED;

        public override void ValidateCase() {}
    }
    public sealed partial class ManageBuyOfferResult_MANAGE_BUY_OFFER_BUY_NOT_AUTHORIZED : ManageBuyOfferResult
    {
        public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_BUY_NOT_AUTHORIZED;

        public override void ValidateCase() {}
    }
    public sealed partial class ManageBuyOfferResult_MANAGE_BUY_OFFER_LINE_FULL : ManageBuyOfferResult
    {
        public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_LINE_FULL;

        public override void ValidateCase() {}
    }
    public sealed partial class ManageBuyOfferResult_MANAGE_BUY_OFFER_UNDERFUNDED : ManageBuyOfferResult
    {
        public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_UNDERFUNDED;

        public override void ValidateCase() {}
    }
    public sealed partial class ManageBuyOfferResult_MANAGE_BUY_OFFER_CROSS_SELF : ManageBuyOfferResult
    {
        public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_CROSS_SELF;

        public override void ValidateCase() {}
    }
    public sealed partial class ManageBuyOfferResult_MANAGE_BUY_OFFER_SELL_NO_ISSUER : ManageBuyOfferResult
    {
        public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_SELL_NO_ISSUER;

        public override void ValidateCase() {}
    }
    public sealed partial class ManageBuyOfferResult_MANAGE_BUY_OFFER_BUY_NO_ISSUER : ManageBuyOfferResult
    {
        public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_BUY_NO_ISSUER;

        public override void ValidateCase() {}
    }
    public sealed partial class ManageBuyOfferResult_MANAGE_BUY_OFFER_NOT_FOUND : ManageBuyOfferResult
    {
        public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_NOT_FOUND;

        public override void ValidateCase() {}
    }
    public sealed partial class ManageBuyOfferResult_MANAGE_BUY_OFFER_LOW_RESERVE : ManageBuyOfferResult
    {
        public override ManageBuyOfferResultCode Discriminator => ManageBuyOfferResultCode.MANAGE_BUY_OFFER_LOW_RESERVE;

        public override void ValidateCase() {}
    }
    public static partial class ManageBuyOfferResultXdr
    {
        public static void Encode(XdrWriter stream, ManageBuyOfferResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ManageBuyOfferResult_MANAGE_BUY_OFFER_SUCCESS case_MANAGE_BUY_OFFER_SUCCESS:
                ManageOfferSuccessResultXdr.Encode(stream, case_MANAGE_BUY_OFFER_SUCCESS.success);
                break;
                case ManageBuyOfferResult_MANAGE_BUY_OFFER_MALFORMED case_MANAGE_BUY_OFFER_MALFORMED:
                break;
                case ManageBuyOfferResult_MANAGE_BUY_OFFER_SELL_NO_TRUST case_MANAGE_BUY_OFFER_SELL_NO_TRUST:
                break;
                case ManageBuyOfferResult_MANAGE_BUY_OFFER_BUY_NO_TRUST case_MANAGE_BUY_OFFER_BUY_NO_TRUST:
                break;
                case ManageBuyOfferResult_MANAGE_BUY_OFFER_SELL_NOT_AUTHORIZED case_MANAGE_BUY_OFFER_SELL_NOT_AUTHORIZED:
                break;
                case ManageBuyOfferResult_MANAGE_BUY_OFFER_BUY_NOT_AUTHORIZED case_MANAGE_BUY_OFFER_BUY_NOT_AUTHORIZED:
                break;
                case ManageBuyOfferResult_MANAGE_BUY_OFFER_LINE_FULL case_MANAGE_BUY_OFFER_LINE_FULL:
                break;
                case ManageBuyOfferResult_MANAGE_BUY_OFFER_UNDERFUNDED case_MANAGE_BUY_OFFER_UNDERFUNDED:
                break;
                case ManageBuyOfferResult_MANAGE_BUY_OFFER_CROSS_SELF case_MANAGE_BUY_OFFER_CROSS_SELF:
                break;
                case ManageBuyOfferResult_MANAGE_BUY_OFFER_SELL_NO_ISSUER case_MANAGE_BUY_OFFER_SELL_NO_ISSUER:
                break;
                case ManageBuyOfferResult_MANAGE_BUY_OFFER_BUY_NO_ISSUER case_MANAGE_BUY_OFFER_BUY_NO_ISSUER:
                break;
                case ManageBuyOfferResult_MANAGE_BUY_OFFER_NOT_FOUND case_MANAGE_BUY_OFFER_NOT_FOUND:
                break;
                case ManageBuyOfferResult_MANAGE_BUY_OFFER_LOW_RESERVE case_MANAGE_BUY_OFFER_LOW_RESERVE:
                break;
            }
        }
        public static ManageBuyOfferResult Decode(XdrReader stream)
        {
            var discriminator = (ManageBuyOfferResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_SUCCESS:
                var result_MANAGE_BUY_OFFER_SUCCESS = new ManageBuyOfferResult_MANAGE_BUY_OFFER_SUCCESS();
                result_MANAGE_BUY_OFFER_SUCCESS.success = ManageOfferSuccessResultXdr.Decode(stream);
                return result_MANAGE_BUY_OFFER_SUCCESS;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_MALFORMED:
                var result_MANAGE_BUY_OFFER_MALFORMED = new ManageBuyOfferResult_MANAGE_BUY_OFFER_MALFORMED();
                return result_MANAGE_BUY_OFFER_MALFORMED;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_SELL_NO_TRUST:
                var result_MANAGE_BUY_OFFER_SELL_NO_TRUST = new ManageBuyOfferResult_MANAGE_BUY_OFFER_SELL_NO_TRUST();
                return result_MANAGE_BUY_OFFER_SELL_NO_TRUST;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_BUY_NO_TRUST:
                var result_MANAGE_BUY_OFFER_BUY_NO_TRUST = new ManageBuyOfferResult_MANAGE_BUY_OFFER_BUY_NO_TRUST();
                return result_MANAGE_BUY_OFFER_BUY_NO_TRUST;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_SELL_NOT_AUTHORIZED:
                var result_MANAGE_BUY_OFFER_SELL_NOT_AUTHORIZED = new ManageBuyOfferResult_MANAGE_BUY_OFFER_SELL_NOT_AUTHORIZED();
                return result_MANAGE_BUY_OFFER_SELL_NOT_AUTHORIZED;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_BUY_NOT_AUTHORIZED:
                var result_MANAGE_BUY_OFFER_BUY_NOT_AUTHORIZED = new ManageBuyOfferResult_MANAGE_BUY_OFFER_BUY_NOT_AUTHORIZED();
                return result_MANAGE_BUY_OFFER_BUY_NOT_AUTHORIZED;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_LINE_FULL:
                var result_MANAGE_BUY_OFFER_LINE_FULL = new ManageBuyOfferResult_MANAGE_BUY_OFFER_LINE_FULL();
                return result_MANAGE_BUY_OFFER_LINE_FULL;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_UNDERFUNDED:
                var result_MANAGE_BUY_OFFER_UNDERFUNDED = new ManageBuyOfferResult_MANAGE_BUY_OFFER_UNDERFUNDED();
                return result_MANAGE_BUY_OFFER_UNDERFUNDED;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_CROSS_SELF:
                var result_MANAGE_BUY_OFFER_CROSS_SELF = new ManageBuyOfferResult_MANAGE_BUY_OFFER_CROSS_SELF();
                return result_MANAGE_BUY_OFFER_CROSS_SELF;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_SELL_NO_ISSUER:
                var result_MANAGE_BUY_OFFER_SELL_NO_ISSUER = new ManageBuyOfferResult_MANAGE_BUY_OFFER_SELL_NO_ISSUER();
                return result_MANAGE_BUY_OFFER_SELL_NO_ISSUER;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_BUY_NO_ISSUER:
                var result_MANAGE_BUY_OFFER_BUY_NO_ISSUER = new ManageBuyOfferResult_MANAGE_BUY_OFFER_BUY_NO_ISSUER();
                return result_MANAGE_BUY_OFFER_BUY_NO_ISSUER;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_NOT_FOUND:
                var result_MANAGE_BUY_OFFER_NOT_FOUND = new ManageBuyOfferResult_MANAGE_BUY_OFFER_NOT_FOUND();
                return result_MANAGE_BUY_OFFER_NOT_FOUND;
                case ManageBuyOfferResultCode.MANAGE_BUY_OFFER_LOW_RESERVE:
                var result_MANAGE_BUY_OFFER_LOW_RESERVE = new ManageBuyOfferResult_MANAGE_BUY_OFFER_LOW_RESERVE();
                return result_MANAGE_BUY_OFFER_LOW_RESERVE;
                default:
                throw new Exception($"Unknown discriminator for ManageBuyOfferResult: {discriminator}");
            }
        }
    }
}
