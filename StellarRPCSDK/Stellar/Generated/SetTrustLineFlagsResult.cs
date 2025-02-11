// Generated code - do not modify
// Source:

// union SetTrustLineFlagsResult switch (SetTrustLineFlagsResultCode code)
// {
// case SET_TRUST_LINE_FLAGS_SUCCESS:
//     void;
// case SET_TRUST_LINE_FLAGS_MALFORMED:
// case SET_TRUST_LINE_FLAGS_NO_TRUST_LINE:
// case SET_TRUST_LINE_FLAGS_CANT_REVOKE:
// case SET_TRUST_LINE_FLAGS_INVALID_STATE:
// case SET_TRUST_LINE_FLAGS_LOW_RESERVE:
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
    public abstract partial class SetTrustLineFlagsResult
    {
        public abstract SetTrustLineFlagsResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        public sealed partial class SetTrustLineFlagsSuccess : SetTrustLineFlagsResult
        {
            public override SetTrustLineFlagsResultCode Discriminator => SetTrustLineFlagsResultCode.SET_TRUST_LINE_FLAGS_SUCCESS;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class SetTrustLineFlagsMalformed : SetTrustLineFlagsResult
        {
            public override SetTrustLineFlagsResultCode Discriminator => SetTrustLineFlagsResultCode.SET_TRUST_LINE_FLAGS_MALFORMED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class SetTrustLineFlagsNoTrustLine : SetTrustLineFlagsResult
        {
            public override SetTrustLineFlagsResultCode Discriminator => SetTrustLineFlagsResultCode.SET_TRUST_LINE_FLAGS_NO_TRUST_LINE;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class SetTrustLineFlagsCantRevoke : SetTrustLineFlagsResult
        {
            public override SetTrustLineFlagsResultCode Discriminator => SetTrustLineFlagsResultCode.SET_TRUST_LINE_FLAGS_CANT_REVOKE;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class SetTrustLineFlagsInvalidState : SetTrustLineFlagsResult
        {
            public override SetTrustLineFlagsResultCode Discriminator => SetTrustLineFlagsResultCode.SET_TRUST_LINE_FLAGS_INVALID_STATE;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class SetTrustLineFlagsLowReserve : SetTrustLineFlagsResult
        {
            public override SetTrustLineFlagsResultCode Discriminator => SetTrustLineFlagsResultCode.SET_TRUST_LINE_FLAGS_LOW_RESERVE;

            public override void ValidateCase() {}
        }
    }
    public static partial class SetTrustLineFlagsResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SetTrustLineFlagsResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SetTrustLineFlagsResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, SetTrustLineFlagsResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SetTrustLineFlagsResult.SetTrustLineFlagsSuccess case_SET_TRUST_LINE_FLAGS_SUCCESS:
                break;
                case SetTrustLineFlagsResult.SetTrustLineFlagsMalformed case_SET_TRUST_LINE_FLAGS_MALFORMED:
                break;
                case SetTrustLineFlagsResult.SetTrustLineFlagsNoTrustLine case_SET_TRUST_LINE_FLAGS_NO_TRUST_LINE:
                break;
                case SetTrustLineFlagsResult.SetTrustLineFlagsCantRevoke case_SET_TRUST_LINE_FLAGS_CANT_REVOKE:
                break;
                case SetTrustLineFlagsResult.SetTrustLineFlagsInvalidState case_SET_TRUST_LINE_FLAGS_INVALID_STATE:
                break;
                case SetTrustLineFlagsResult.SetTrustLineFlagsLowReserve case_SET_TRUST_LINE_FLAGS_LOW_RESERVE:
                break;
            }
        }
        public static SetTrustLineFlagsResult Decode(XdrReader stream)
        {
            var discriminator = (SetTrustLineFlagsResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case SetTrustLineFlagsResultCode.SET_TRUST_LINE_FLAGS_SUCCESS:
                var result_SET_TRUST_LINE_FLAGS_SUCCESS = new SetTrustLineFlagsResult.SetTrustLineFlagsSuccess();
                return result_SET_TRUST_LINE_FLAGS_SUCCESS;
                case SetTrustLineFlagsResultCode.SET_TRUST_LINE_FLAGS_MALFORMED:
                var result_SET_TRUST_LINE_FLAGS_MALFORMED = new SetTrustLineFlagsResult.SetTrustLineFlagsMalformed();
                return result_SET_TRUST_LINE_FLAGS_MALFORMED;
                case SetTrustLineFlagsResultCode.SET_TRUST_LINE_FLAGS_NO_TRUST_LINE:
                var result_SET_TRUST_LINE_FLAGS_NO_TRUST_LINE = new SetTrustLineFlagsResult.SetTrustLineFlagsNoTrustLine();
                return result_SET_TRUST_LINE_FLAGS_NO_TRUST_LINE;
                case SetTrustLineFlagsResultCode.SET_TRUST_LINE_FLAGS_CANT_REVOKE:
                var result_SET_TRUST_LINE_FLAGS_CANT_REVOKE = new SetTrustLineFlagsResult.SetTrustLineFlagsCantRevoke();
                return result_SET_TRUST_LINE_FLAGS_CANT_REVOKE;
                case SetTrustLineFlagsResultCode.SET_TRUST_LINE_FLAGS_INVALID_STATE:
                var result_SET_TRUST_LINE_FLAGS_INVALID_STATE = new SetTrustLineFlagsResult.SetTrustLineFlagsInvalidState();
                return result_SET_TRUST_LINE_FLAGS_INVALID_STATE;
                case SetTrustLineFlagsResultCode.SET_TRUST_LINE_FLAGS_LOW_RESERVE:
                var result_SET_TRUST_LINE_FLAGS_LOW_RESERVE = new SetTrustLineFlagsResult.SetTrustLineFlagsLowReserve();
                return result_SET_TRUST_LINE_FLAGS_LOW_RESERVE;
                default:
                throw new Exception($"Unknown discriminator for SetTrustLineFlagsResult: {discriminator}");
            }
        }
    }
}
