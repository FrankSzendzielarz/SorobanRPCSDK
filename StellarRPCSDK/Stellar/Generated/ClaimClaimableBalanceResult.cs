// Generated code - do not modify
// Source:

// union ClaimClaimableBalanceResult switch (ClaimClaimableBalanceResultCode code)
// {
// case CLAIM_CLAIMABLE_BALANCE_SUCCESS:
//     void;
// case CLAIM_CLAIMABLE_BALANCE_DOES_NOT_EXIST:
// case CLAIM_CLAIMABLE_BALANCE_CANNOT_CLAIM:
// case CLAIM_CLAIMABLE_BALANCE_LINE_FULL:
// case CLAIM_CLAIMABLE_BALANCE_NO_TRUST:
// case CLAIM_CLAIMABLE_BALANCE_NOT_AUTHORIZED:
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
    [ProtoInclude(100, typeof(ClaimClaimableBalanceSuccess), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(ClaimClaimableBalanceDoesNotExist), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(ClaimClaimableBalanceCannotClaim), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(ClaimClaimableBalanceLineFull), DataFormat = DataFormat.Default)]
    [ProtoInclude(104, typeof(ClaimClaimableBalanceNoTrust), DataFormat = DataFormat.Default)]
    [ProtoInclude(105, typeof(ClaimClaimableBalanceNotAuthorized), DataFormat = DataFormat.Default)]
    public abstract partial class ClaimClaimableBalanceResult
    {
        public abstract ClaimClaimableBalanceResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "ClaimClaimableBalanceResult.ClaimClaimableBalanceSuccess")]
        public sealed partial class ClaimClaimableBalanceSuccess : ClaimClaimableBalanceResult
        {
            public override ClaimClaimableBalanceResultCode Discriminator => ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_SUCCESS;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ClaimClaimableBalanceResult.ClaimClaimableBalanceDoesNotExist")]
        public sealed partial class ClaimClaimableBalanceDoesNotExist : ClaimClaimableBalanceResult
        {
            public override ClaimClaimableBalanceResultCode Discriminator => ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_DOES_NOT_EXIST;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ClaimClaimableBalanceResult.ClaimClaimableBalanceCannotClaim")]
        public sealed partial class ClaimClaimableBalanceCannotClaim : ClaimClaimableBalanceResult
        {
            public override ClaimClaimableBalanceResultCode Discriminator => ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_CANNOT_CLAIM;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ClaimClaimableBalanceResult.ClaimClaimableBalanceLineFull")]
        public sealed partial class ClaimClaimableBalanceLineFull : ClaimClaimableBalanceResult
        {
            public override ClaimClaimableBalanceResultCode Discriminator => ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_LINE_FULL;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ClaimClaimableBalanceResult.ClaimClaimableBalanceNoTrust")]
        public sealed partial class ClaimClaimableBalanceNoTrust : ClaimClaimableBalanceResult
        {
            public override ClaimClaimableBalanceResultCode Discriminator => ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_NO_TRUST;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ClaimClaimableBalanceResult.ClaimClaimableBalanceNotAuthorized")]
        public sealed partial class ClaimClaimableBalanceNotAuthorized : ClaimClaimableBalanceResult
        {
            public override ClaimClaimableBalanceResultCode Discriminator => ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_NOT_AUTHORIZED;

            public override void ValidateCase() {}
        }
    }
    public static partial class ClaimClaimableBalanceResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ClaimClaimableBalanceResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ClaimClaimableBalanceResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ClaimClaimableBalanceResult DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ClaimClaimableBalanceResultXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, ClaimClaimableBalanceResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ClaimClaimableBalanceResult.ClaimClaimableBalanceSuccess case_CLAIM_CLAIMABLE_BALANCE_SUCCESS:
                break;
                case ClaimClaimableBalanceResult.ClaimClaimableBalanceDoesNotExist case_CLAIM_CLAIMABLE_BALANCE_DOES_NOT_EXIST:
                break;
                case ClaimClaimableBalanceResult.ClaimClaimableBalanceCannotClaim case_CLAIM_CLAIMABLE_BALANCE_CANNOT_CLAIM:
                break;
                case ClaimClaimableBalanceResult.ClaimClaimableBalanceLineFull case_CLAIM_CLAIMABLE_BALANCE_LINE_FULL:
                break;
                case ClaimClaimableBalanceResult.ClaimClaimableBalanceNoTrust case_CLAIM_CLAIMABLE_BALANCE_NO_TRUST:
                break;
                case ClaimClaimableBalanceResult.ClaimClaimableBalanceNotAuthorized case_CLAIM_CLAIMABLE_BALANCE_NOT_AUTHORIZED:
                break;
            }
        }
        public static ClaimClaimableBalanceResult Decode(XdrReader stream)
        {
            var discriminator = (ClaimClaimableBalanceResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_SUCCESS:
                var result_CLAIM_CLAIMABLE_BALANCE_SUCCESS = new ClaimClaimableBalanceResult.ClaimClaimableBalanceSuccess();
                return result_CLAIM_CLAIMABLE_BALANCE_SUCCESS;
                case ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_DOES_NOT_EXIST:
                var result_CLAIM_CLAIMABLE_BALANCE_DOES_NOT_EXIST = new ClaimClaimableBalanceResult.ClaimClaimableBalanceDoesNotExist();
                return result_CLAIM_CLAIMABLE_BALANCE_DOES_NOT_EXIST;
                case ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_CANNOT_CLAIM:
                var result_CLAIM_CLAIMABLE_BALANCE_CANNOT_CLAIM = new ClaimClaimableBalanceResult.ClaimClaimableBalanceCannotClaim();
                return result_CLAIM_CLAIMABLE_BALANCE_CANNOT_CLAIM;
                case ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_LINE_FULL:
                var result_CLAIM_CLAIMABLE_BALANCE_LINE_FULL = new ClaimClaimableBalanceResult.ClaimClaimableBalanceLineFull();
                return result_CLAIM_CLAIMABLE_BALANCE_LINE_FULL;
                case ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_NO_TRUST:
                var result_CLAIM_CLAIMABLE_BALANCE_NO_TRUST = new ClaimClaimableBalanceResult.ClaimClaimableBalanceNoTrust();
                return result_CLAIM_CLAIMABLE_BALANCE_NO_TRUST;
                case ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_NOT_AUTHORIZED:
                var result_CLAIM_CLAIMABLE_BALANCE_NOT_AUTHORIZED = new ClaimClaimableBalanceResult.ClaimClaimableBalanceNotAuthorized();
                return result_CLAIM_CLAIMABLE_BALANCE_NOT_AUTHORIZED;
                default:
                throw new Exception($"Unknown discriminator for ClaimClaimableBalanceResult: {discriminator}");
            }
        }
    }
}
