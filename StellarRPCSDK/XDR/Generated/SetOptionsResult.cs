// Generated code - do not modify
// Source:

// union SetOptionsResult switch (SetOptionsResultCode code)
// {
// case SET_OPTIONS_SUCCESS:
//     void;
// case SET_OPTIONS_LOW_RESERVE:
// case SET_OPTIONS_TOO_MANY_SIGNERS:
// case SET_OPTIONS_BAD_FLAGS:
// case SET_OPTIONS_INVALID_INFLATION:
// case SET_OPTIONS_CANT_CHANGE:
// case SET_OPTIONS_UNKNOWN_FLAG:
// case SET_OPTIONS_THRESHOLD_OUT_OF_RANGE:
// case SET_OPTIONS_BAD_SIGNER:
// case SET_OPTIONS_INVALID_HOME_DOMAIN:
// case SET_OPTIONS_AUTH_REVOCABLE_REQUIRED:
//     void;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class SetOptionsResult
    {
        public abstract SetOptionsResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class SetOptionsResult_SET_OPTIONS_SUCCESS : SetOptionsResult
    {
        public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_SUCCESS;

        public override void ValidateCase() {}
    }
    public sealed partial class SetOptionsResult_SET_OPTIONS_LOW_RESERVE : SetOptionsResult
    {
        public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_LOW_RESERVE;

        public override void ValidateCase() {}
    }
    public sealed partial class SetOptionsResult_SET_OPTIONS_TOO_MANY_SIGNERS : SetOptionsResult
    {
        public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_TOO_MANY_SIGNERS;

        public override void ValidateCase() {}
    }
    public sealed partial class SetOptionsResult_SET_OPTIONS_BAD_FLAGS : SetOptionsResult
    {
        public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_BAD_FLAGS;

        public override void ValidateCase() {}
    }
    public sealed partial class SetOptionsResult_SET_OPTIONS_INVALID_INFLATION : SetOptionsResult
    {
        public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_INVALID_INFLATION;

        public override void ValidateCase() {}
    }
    public sealed partial class SetOptionsResult_SET_OPTIONS_CANT_CHANGE : SetOptionsResult
    {
        public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_CANT_CHANGE;

        public override void ValidateCase() {}
    }
    public sealed partial class SetOptionsResult_SET_OPTIONS_UNKNOWN_FLAG : SetOptionsResult
    {
        public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_UNKNOWN_FLAG;

        public override void ValidateCase() {}
    }
    public sealed partial class SetOptionsResult_SET_OPTIONS_THRESHOLD_OUT_OF_RANGE : SetOptionsResult
    {
        public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_THRESHOLD_OUT_OF_RANGE;

        public override void ValidateCase() {}
    }
    public sealed partial class SetOptionsResult_SET_OPTIONS_BAD_SIGNER : SetOptionsResult
    {
        public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_BAD_SIGNER;

        public override void ValidateCase() {}
    }
    public sealed partial class SetOptionsResult_SET_OPTIONS_INVALID_HOME_DOMAIN : SetOptionsResult
    {
        public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_INVALID_HOME_DOMAIN;

        public override void ValidateCase() {}
    }
    public sealed partial class SetOptionsResult_SET_OPTIONS_AUTH_REVOCABLE_REQUIRED : SetOptionsResult
    {
        public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_AUTH_REVOCABLE_REQUIRED;

        public override void ValidateCase() {}
    }
    public static partial class SetOptionsResultXdr
    {
        public static void Encode(XdrWriter stream, SetOptionsResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SetOptionsResult_SET_OPTIONS_SUCCESS case_SET_OPTIONS_SUCCESS:
                break;
                case SetOptionsResult_SET_OPTIONS_LOW_RESERVE case_SET_OPTIONS_LOW_RESERVE:
                break;
                case SetOptionsResult_SET_OPTIONS_TOO_MANY_SIGNERS case_SET_OPTIONS_TOO_MANY_SIGNERS:
                break;
                case SetOptionsResult_SET_OPTIONS_BAD_FLAGS case_SET_OPTIONS_BAD_FLAGS:
                break;
                case SetOptionsResult_SET_OPTIONS_INVALID_INFLATION case_SET_OPTIONS_INVALID_INFLATION:
                break;
                case SetOptionsResult_SET_OPTIONS_CANT_CHANGE case_SET_OPTIONS_CANT_CHANGE:
                break;
                case SetOptionsResult_SET_OPTIONS_UNKNOWN_FLAG case_SET_OPTIONS_UNKNOWN_FLAG:
                break;
                case SetOptionsResult_SET_OPTIONS_THRESHOLD_OUT_OF_RANGE case_SET_OPTIONS_THRESHOLD_OUT_OF_RANGE:
                break;
                case SetOptionsResult_SET_OPTIONS_BAD_SIGNER case_SET_OPTIONS_BAD_SIGNER:
                break;
                case SetOptionsResult_SET_OPTIONS_INVALID_HOME_DOMAIN case_SET_OPTIONS_INVALID_HOME_DOMAIN:
                break;
                case SetOptionsResult_SET_OPTIONS_AUTH_REVOCABLE_REQUIRED case_SET_OPTIONS_AUTH_REVOCABLE_REQUIRED:
                break;
            }
        }
        public static SetOptionsResult Decode(XdrReader stream)
        {
            var discriminator = (SetOptionsResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case SetOptionsResultCode.SET_OPTIONS_SUCCESS:
                var result_SET_OPTIONS_SUCCESS = new SetOptionsResult_SET_OPTIONS_SUCCESS();
                return result_SET_OPTIONS_SUCCESS;
                case SetOptionsResultCode.SET_OPTIONS_LOW_RESERVE:
                var result_SET_OPTIONS_LOW_RESERVE = new SetOptionsResult_SET_OPTIONS_LOW_RESERVE();
                return result_SET_OPTIONS_LOW_RESERVE;
                case SetOptionsResultCode.SET_OPTIONS_TOO_MANY_SIGNERS:
                var result_SET_OPTIONS_TOO_MANY_SIGNERS = new SetOptionsResult_SET_OPTIONS_TOO_MANY_SIGNERS();
                return result_SET_OPTIONS_TOO_MANY_SIGNERS;
                case SetOptionsResultCode.SET_OPTIONS_BAD_FLAGS:
                var result_SET_OPTIONS_BAD_FLAGS = new SetOptionsResult_SET_OPTIONS_BAD_FLAGS();
                return result_SET_OPTIONS_BAD_FLAGS;
                case SetOptionsResultCode.SET_OPTIONS_INVALID_INFLATION:
                var result_SET_OPTIONS_INVALID_INFLATION = new SetOptionsResult_SET_OPTIONS_INVALID_INFLATION();
                return result_SET_OPTIONS_INVALID_INFLATION;
                case SetOptionsResultCode.SET_OPTIONS_CANT_CHANGE:
                var result_SET_OPTIONS_CANT_CHANGE = new SetOptionsResult_SET_OPTIONS_CANT_CHANGE();
                return result_SET_OPTIONS_CANT_CHANGE;
                case SetOptionsResultCode.SET_OPTIONS_UNKNOWN_FLAG:
                var result_SET_OPTIONS_UNKNOWN_FLAG = new SetOptionsResult_SET_OPTIONS_UNKNOWN_FLAG();
                return result_SET_OPTIONS_UNKNOWN_FLAG;
                case SetOptionsResultCode.SET_OPTIONS_THRESHOLD_OUT_OF_RANGE:
                var result_SET_OPTIONS_THRESHOLD_OUT_OF_RANGE = new SetOptionsResult_SET_OPTIONS_THRESHOLD_OUT_OF_RANGE();
                return result_SET_OPTIONS_THRESHOLD_OUT_OF_RANGE;
                case SetOptionsResultCode.SET_OPTIONS_BAD_SIGNER:
                var result_SET_OPTIONS_BAD_SIGNER = new SetOptionsResult_SET_OPTIONS_BAD_SIGNER();
                return result_SET_OPTIONS_BAD_SIGNER;
                case SetOptionsResultCode.SET_OPTIONS_INVALID_HOME_DOMAIN:
                var result_SET_OPTIONS_INVALID_HOME_DOMAIN = new SetOptionsResult_SET_OPTIONS_INVALID_HOME_DOMAIN();
                return result_SET_OPTIONS_INVALID_HOME_DOMAIN;
                case SetOptionsResultCode.SET_OPTIONS_AUTH_REVOCABLE_REQUIRED:
                var result_SET_OPTIONS_AUTH_REVOCABLE_REQUIRED = new SetOptionsResult_SET_OPTIONS_AUTH_REVOCABLE_REQUIRED();
                return result_SET_OPTIONS_AUTH_REVOCABLE_REQUIRED;
                default:
                throw new Exception($"Unknown discriminator for SetOptionsResult: {discriminator}");
            }
        }
    }
}
