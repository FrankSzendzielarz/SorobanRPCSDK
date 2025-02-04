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
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class SetOptionsResult
    {
        public abstract SetOptionsResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        public sealed partial class SetOptionsSuccess : SetOptionsResult
        {
            public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_SUCCESS;

            public override void ValidateCase() {}
        }
        public sealed partial class SetOptionsLowReserve : SetOptionsResult
        {
            public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_LOW_RESERVE;

            public override void ValidateCase() {}
        }
        public sealed partial class SetOptionsTooManySigners : SetOptionsResult
        {
            public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_TOO_MANY_SIGNERS;

            public override void ValidateCase() {}
        }
        public sealed partial class SetOptionsBadFlags : SetOptionsResult
        {
            public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_BAD_FLAGS;

            public override void ValidateCase() {}
        }
        public sealed partial class SetOptionsInvalidInflation : SetOptionsResult
        {
            public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_INVALID_INFLATION;

            public override void ValidateCase() {}
        }
        public sealed partial class SetOptionsCantChange : SetOptionsResult
        {
            public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_CANT_CHANGE;

            public override void ValidateCase() {}
        }
        public sealed partial class SetOptionsUnknownFlag : SetOptionsResult
        {
            public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_UNKNOWN_FLAG;

            public override void ValidateCase() {}
        }
        public sealed partial class SetOptionsThresholdOutOfRange : SetOptionsResult
        {
            public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_THRESHOLD_OUT_OF_RANGE;

            public override void ValidateCase() {}
        }
        public sealed partial class SetOptionsBadSigner : SetOptionsResult
        {
            public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_BAD_SIGNER;

            public override void ValidateCase() {}
        }
        public sealed partial class SetOptionsInvalidHomeDomain : SetOptionsResult
        {
            public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_INVALID_HOME_DOMAIN;

            public override void ValidateCase() {}
        }
        public sealed partial class SetOptionsAuthRevocableRequired : SetOptionsResult
        {
            public override SetOptionsResultCode Discriminator => SetOptionsResultCode.SET_OPTIONS_AUTH_REVOCABLE_REQUIRED;

            public override void ValidateCase() {}
        }
    }
    public static partial class SetOptionsResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SetOptionsResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SetOptionsResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, SetOptionsResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SetOptionsResult.SetOptionsSuccess case_SET_OPTIONS_SUCCESS:
                break;
                case SetOptionsResult.SetOptionsLowReserve case_SET_OPTIONS_LOW_RESERVE:
                break;
                case SetOptionsResult.SetOptionsTooManySigners case_SET_OPTIONS_TOO_MANY_SIGNERS:
                break;
                case SetOptionsResult.SetOptionsBadFlags case_SET_OPTIONS_BAD_FLAGS:
                break;
                case SetOptionsResult.SetOptionsInvalidInflation case_SET_OPTIONS_INVALID_INFLATION:
                break;
                case SetOptionsResult.SetOptionsCantChange case_SET_OPTIONS_CANT_CHANGE:
                break;
                case SetOptionsResult.SetOptionsUnknownFlag case_SET_OPTIONS_UNKNOWN_FLAG:
                break;
                case SetOptionsResult.SetOptionsThresholdOutOfRange case_SET_OPTIONS_THRESHOLD_OUT_OF_RANGE:
                break;
                case SetOptionsResult.SetOptionsBadSigner case_SET_OPTIONS_BAD_SIGNER:
                break;
                case SetOptionsResult.SetOptionsInvalidHomeDomain case_SET_OPTIONS_INVALID_HOME_DOMAIN:
                break;
                case SetOptionsResult.SetOptionsAuthRevocableRequired case_SET_OPTIONS_AUTH_REVOCABLE_REQUIRED:
                break;
            }
        }
        public static SetOptionsResult Decode(XdrReader stream)
        {
            var discriminator = (SetOptionsResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case SetOptionsResultCode.SET_OPTIONS_SUCCESS:
                var result_SET_OPTIONS_SUCCESS = new SetOptionsResult.SetOptionsSuccess();
                return result_SET_OPTIONS_SUCCESS;
                case SetOptionsResultCode.SET_OPTIONS_LOW_RESERVE:
                var result_SET_OPTIONS_LOW_RESERVE = new SetOptionsResult.SetOptionsLowReserve();
                return result_SET_OPTIONS_LOW_RESERVE;
                case SetOptionsResultCode.SET_OPTIONS_TOO_MANY_SIGNERS:
                var result_SET_OPTIONS_TOO_MANY_SIGNERS = new SetOptionsResult.SetOptionsTooManySigners();
                return result_SET_OPTIONS_TOO_MANY_SIGNERS;
                case SetOptionsResultCode.SET_OPTIONS_BAD_FLAGS:
                var result_SET_OPTIONS_BAD_FLAGS = new SetOptionsResult.SetOptionsBadFlags();
                return result_SET_OPTIONS_BAD_FLAGS;
                case SetOptionsResultCode.SET_OPTIONS_INVALID_INFLATION:
                var result_SET_OPTIONS_INVALID_INFLATION = new SetOptionsResult.SetOptionsInvalidInflation();
                return result_SET_OPTIONS_INVALID_INFLATION;
                case SetOptionsResultCode.SET_OPTIONS_CANT_CHANGE:
                var result_SET_OPTIONS_CANT_CHANGE = new SetOptionsResult.SetOptionsCantChange();
                return result_SET_OPTIONS_CANT_CHANGE;
                case SetOptionsResultCode.SET_OPTIONS_UNKNOWN_FLAG:
                var result_SET_OPTIONS_UNKNOWN_FLAG = new SetOptionsResult.SetOptionsUnknownFlag();
                return result_SET_OPTIONS_UNKNOWN_FLAG;
                case SetOptionsResultCode.SET_OPTIONS_THRESHOLD_OUT_OF_RANGE:
                var result_SET_OPTIONS_THRESHOLD_OUT_OF_RANGE = new SetOptionsResult.SetOptionsThresholdOutOfRange();
                return result_SET_OPTIONS_THRESHOLD_OUT_OF_RANGE;
                case SetOptionsResultCode.SET_OPTIONS_BAD_SIGNER:
                var result_SET_OPTIONS_BAD_SIGNER = new SetOptionsResult.SetOptionsBadSigner();
                return result_SET_OPTIONS_BAD_SIGNER;
                case SetOptionsResultCode.SET_OPTIONS_INVALID_HOME_DOMAIN:
                var result_SET_OPTIONS_INVALID_HOME_DOMAIN = new SetOptionsResult.SetOptionsInvalidHomeDomain();
                return result_SET_OPTIONS_INVALID_HOME_DOMAIN;
                case SetOptionsResultCode.SET_OPTIONS_AUTH_REVOCABLE_REQUIRED:
                var result_SET_OPTIONS_AUTH_REVOCABLE_REQUIRED = new SetOptionsResult.SetOptionsAuthRevocableRequired();
                return result_SET_OPTIONS_AUTH_REVOCABLE_REQUIRED;
                default:
                throw new Exception($"Unknown discriminator for SetOptionsResult: {discriminator}");
            }
        }
    }
}
