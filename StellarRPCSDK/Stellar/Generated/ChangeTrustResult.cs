// Generated code - do not modify
// Source:

// union ChangeTrustResult switch (ChangeTrustResultCode code)
// {
// case CHANGE_TRUST_SUCCESS:
//     void;
// case CHANGE_TRUST_MALFORMED:
// case CHANGE_TRUST_NO_ISSUER:
// case CHANGE_TRUST_INVALID_LIMIT:
// case CHANGE_TRUST_LOW_RESERVE:
// case CHANGE_TRUST_SELF_NOT_ALLOWED:
// case CHANGE_TRUST_TRUST_LINE_MISSING:
// case CHANGE_TRUST_CANNOT_DELETE:
// case CHANGE_TRUST_NOT_AUTH_MAINTAIN_LIABILITIES:
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
    [ProtoInclude(100, typeof(ChangeTrustSuccess), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(ChangeTrustMalformed), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(ChangeTrustNoIssuer), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(ChangeTrustInvalidLimit), DataFormat = DataFormat.Default)]
    [ProtoInclude(104, typeof(ChangeTrustLowReserve), DataFormat = DataFormat.Default)]
    [ProtoInclude(105, typeof(ChangeTrustSelfNotAllowed), DataFormat = DataFormat.Default)]
    [ProtoInclude(106, typeof(ChangeTrustTrustLineMissing), DataFormat = DataFormat.Default)]
    [ProtoInclude(107, typeof(ChangeTrustCannotDelete), DataFormat = DataFormat.Default)]
    [ProtoInclude(108, typeof(ChangeTrustNotAuthMaintainLiabilities), DataFormat = DataFormat.Default)]
    public abstract partial class ChangeTrustResult
    {
        public abstract ChangeTrustResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "ChangeTrustResult.ChangeTrustSuccess")]
        public sealed partial class ChangeTrustSuccess : ChangeTrustResult
        {
            public override ChangeTrustResultCode Discriminator => ChangeTrustResultCode.CHANGE_TRUST_SUCCESS;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ChangeTrustResult.ChangeTrustMalformed")]
        public sealed partial class ChangeTrustMalformed : ChangeTrustResult
        {
            public override ChangeTrustResultCode Discriminator => ChangeTrustResultCode.CHANGE_TRUST_MALFORMED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ChangeTrustResult.ChangeTrustNoIssuer")]
        public sealed partial class ChangeTrustNoIssuer : ChangeTrustResult
        {
            public override ChangeTrustResultCode Discriminator => ChangeTrustResultCode.CHANGE_TRUST_NO_ISSUER;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ChangeTrustResult.ChangeTrustInvalidLimit")]
        public sealed partial class ChangeTrustInvalidLimit : ChangeTrustResult
        {
            public override ChangeTrustResultCode Discriminator => ChangeTrustResultCode.CHANGE_TRUST_INVALID_LIMIT;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ChangeTrustResult.ChangeTrustLowReserve")]
        public sealed partial class ChangeTrustLowReserve : ChangeTrustResult
        {
            public override ChangeTrustResultCode Discriminator => ChangeTrustResultCode.CHANGE_TRUST_LOW_RESERVE;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ChangeTrustResult.ChangeTrustSelfNotAllowed")]
        public sealed partial class ChangeTrustSelfNotAllowed : ChangeTrustResult
        {
            public override ChangeTrustResultCode Discriminator => ChangeTrustResultCode.CHANGE_TRUST_SELF_NOT_ALLOWED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ChangeTrustResult.ChangeTrustTrustLineMissing")]
        public sealed partial class ChangeTrustTrustLineMissing : ChangeTrustResult
        {
            public override ChangeTrustResultCode Discriminator => ChangeTrustResultCode.CHANGE_TRUST_TRUST_LINE_MISSING;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ChangeTrustResult.ChangeTrustCannotDelete")]
        public sealed partial class ChangeTrustCannotDelete : ChangeTrustResult
        {
            public override ChangeTrustResultCode Discriminator => ChangeTrustResultCode.CHANGE_TRUST_CANNOT_DELETE;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ChangeTrustResult.ChangeTrustNotAuthMaintainLiabilities")]
        public sealed partial class ChangeTrustNotAuthMaintainLiabilities : ChangeTrustResult
        {
            public override ChangeTrustResultCode Discriminator => ChangeTrustResultCode.CHANGE_TRUST_NOT_AUTH_MAINTAIN_LIABILITIES;

            public override void ValidateCase() {}
        }
    }
    public static partial class ChangeTrustResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ChangeTrustResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ChangeTrustResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ChangeTrustResult DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ChangeTrustResultXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, ChangeTrustResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ChangeTrustResult.ChangeTrustSuccess case_CHANGE_TRUST_SUCCESS:
                break;
                case ChangeTrustResult.ChangeTrustMalformed case_CHANGE_TRUST_MALFORMED:
                break;
                case ChangeTrustResult.ChangeTrustNoIssuer case_CHANGE_TRUST_NO_ISSUER:
                break;
                case ChangeTrustResult.ChangeTrustInvalidLimit case_CHANGE_TRUST_INVALID_LIMIT:
                break;
                case ChangeTrustResult.ChangeTrustLowReserve case_CHANGE_TRUST_LOW_RESERVE:
                break;
                case ChangeTrustResult.ChangeTrustSelfNotAllowed case_CHANGE_TRUST_SELF_NOT_ALLOWED:
                break;
                case ChangeTrustResult.ChangeTrustTrustLineMissing case_CHANGE_TRUST_TRUST_LINE_MISSING:
                break;
                case ChangeTrustResult.ChangeTrustCannotDelete case_CHANGE_TRUST_CANNOT_DELETE:
                break;
                case ChangeTrustResult.ChangeTrustNotAuthMaintainLiabilities case_CHANGE_TRUST_NOT_AUTH_MAINTAIN_LIABILITIES:
                break;
            }
        }
        public static ChangeTrustResult Decode(XdrReader stream)
        {
            var discriminator = (ChangeTrustResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case ChangeTrustResultCode.CHANGE_TRUST_SUCCESS:
                var result_CHANGE_TRUST_SUCCESS = new ChangeTrustResult.ChangeTrustSuccess();
                return result_CHANGE_TRUST_SUCCESS;
                case ChangeTrustResultCode.CHANGE_TRUST_MALFORMED:
                var result_CHANGE_TRUST_MALFORMED = new ChangeTrustResult.ChangeTrustMalformed();
                return result_CHANGE_TRUST_MALFORMED;
                case ChangeTrustResultCode.CHANGE_TRUST_NO_ISSUER:
                var result_CHANGE_TRUST_NO_ISSUER = new ChangeTrustResult.ChangeTrustNoIssuer();
                return result_CHANGE_TRUST_NO_ISSUER;
                case ChangeTrustResultCode.CHANGE_TRUST_INVALID_LIMIT:
                var result_CHANGE_TRUST_INVALID_LIMIT = new ChangeTrustResult.ChangeTrustInvalidLimit();
                return result_CHANGE_TRUST_INVALID_LIMIT;
                case ChangeTrustResultCode.CHANGE_TRUST_LOW_RESERVE:
                var result_CHANGE_TRUST_LOW_RESERVE = new ChangeTrustResult.ChangeTrustLowReserve();
                return result_CHANGE_TRUST_LOW_RESERVE;
                case ChangeTrustResultCode.CHANGE_TRUST_SELF_NOT_ALLOWED:
                var result_CHANGE_TRUST_SELF_NOT_ALLOWED = new ChangeTrustResult.ChangeTrustSelfNotAllowed();
                return result_CHANGE_TRUST_SELF_NOT_ALLOWED;
                case ChangeTrustResultCode.CHANGE_TRUST_TRUST_LINE_MISSING:
                var result_CHANGE_TRUST_TRUST_LINE_MISSING = new ChangeTrustResult.ChangeTrustTrustLineMissing();
                return result_CHANGE_TRUST_TRUST_LINE_MISSING;
                case ChangeTrustResultCode.CHANGE_TRUST_CANNOT_DELETE:
                var result_CHANGE_TRUST_CANNOT_DELETE = new ChangeTrustResult.ChangeTrustCannotDelete();
                return result_CHANGE_TRUST_CANNOT_DELETE;
                case ChangeTrustResultCode.CHANGE_TRUST_NOT_AUTH_MAINTAIN_LIABILITIES:
                var result_CHANGE_TRUST_NOT_AUTH_MAINTAIN_LIABILITIES = new ChangeTrustResult.ChangeTrustNotAuthMaintainLiabilities();
                return result_CHANGE_TRUST_NOT_AUTH_MAINTAIN_LIABILITIES;
                default:
                throw new Exception($"Unknown discriminator for ChangeTrustResult: {discriminator}");
            }
        }
    }
}
