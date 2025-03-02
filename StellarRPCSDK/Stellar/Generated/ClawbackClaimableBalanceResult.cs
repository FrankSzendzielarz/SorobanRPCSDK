// Generated code - do not modify
// Source:

// union ClawbackClaimableBalanceResult switch (
//     ClawbackClaimableBalanceResultCode code)
// {
// case CLAWBACK_CLAIMABLE_BALANCE_SUCCESS:
//     void;
// case CLAWBACK_CLAIMABLE_BALANCE_DOES_NOT_EXIST:
// case CLAWBACK_CLAIMABLE_BALANCE_NOT_ISSUER:
// case CLAWBACK_CLAIMABLE_BALANCE_NOT_CLAWBACK_ENABLED:
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
    [ProtoInclude(100, typeof(ClawbackClaimableBalanceSuccess), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(ClawbackClaimableBalanceDoesNotExist), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(ClawbackClaimableBalanceNotIssuer), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(ClawbackClaimableBalanceNotClawbackEnabled), DataFormat = DataFormat.Default)]
    public abstract partial class ClawbackClaimableBalanceResult
    {
        public abstract ClawbackClaimableBalanceResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "ClawbackClaimableBalanceResult_ClawbackClaimableBalanceSuccess")]
        public sealed partial class ClawbackClaimableBalanceSuccess : ClawbackClaimableBalanceResult
        {
            public override ClawbackClaimableBalanceResultCode Discriminator => ClawbackClaimableBalanceResultCode.CLAWBACK_CLAIMABLE_BALANCE_SUCCESS;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ClawbackClaimableBalanceResult_ClawbackClaimableBalanceDoesNotExist")]
        public sealed partial class ClawbackClaimableBalanceDoesNotExist : ClawbackClaimableBalanceResult
        {
            public override ClawbackClaimableBalanceResultCode Discriminator => ClawbackClaimableBalanceResultCode.CLAWBACK_CLAIMABLE_BALANCE_DOES_NOT_EXIST;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ClawbackClaimableBalanceResult_ClawbackClaimableBalanceNotIssuer")]
        public sealed partial class ClawbackClaimableBalanceNotIssuer : ClawbackClaimableBalanceResult
        {
            public override ClawbackClaimableBalanceResultCode Discriminator => ClawbackClaimableBalanceResultCode.CLAWBACK_CLAIMABLE_BALANCE_NOT_ISSUER;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "ClawbackClaimableBalanceResult_ClawbackClaimableBalanceNotClawbackEnabled")]
        public sealed partial class ClawbackClaimableBalanceNotClawbackEnabled : ClawbackClaimableBalanceResult
        {
            public override ClawbackClaimableBalanceResultCode Discriminator => ClawbackClaimableBalanceResultCode.CLAWBACK_CLAIMABLE_BALANCE_NOT_CLAWBACK_ENABLED;

            public override void ValidateCase() {}
        }
    }
    public static partial class ClawbackClaimableBalanceResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ClawbackClaimableBalanceResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ClawbackClaimableBalanceResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ClawbackClaimableBalanceResult DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ClawbackClaimableBalanceResultXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, ClawbackClaimableBalanceResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ClawbackClaimableBalanceResult.ClawbackClaimableBalanceSuccess case_CLAWBACK_CLAIMABLE_BALANCE_SUCCESS:
                break;
                case ClawbackClaimableBalanceResult.ClawbackClaimableBalanceDoesNotExist case_CLAWBACK_CLAIMABLE_BALANCE_DOES_NOT_EXIST:
                break;
                case ClawbackClaimableBalanceResult.ClawbackClaimableBalanceNotIssuer case_CLAWBACK_CLAIMABLE_BALANCE_NOT_ISSUER:
                break;
                case ClawbackClaimableBalanceResult.ClawbackClaimableBalanceNotClawbackEnabled case_CLAWBACK_CLAIMABLE_BALANCE_NOT_CLAWBACK_ENABLED:
                break;
            }
        }
        public static ClawbackClaimableBalanceResult Decode(XdrReader stream)
        {
            var discriminator = (ClawbackClaimableBalanceResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case ClawbackClaimableBalanceResultCode.CLAWBACK_CLAIMABLE_BALANCE_SUCCESS:
                var result_CLAWBACK_CLAIMABLE_BALANCE_SUCCESS = new ClawbackClaimableBalanceResult.ClawbackClaimableBalanceSuccess();
                return result_CLAWBACK_CLAIMABLE_BALANCE_SUCCESS;
                case ClawbackClaimableBalanceResultCode.CLAWBACK_CLAIMABLE_BALANCE_DOES_NOT_EXIST:
                var result_CLAWBACK_CLAIMABLE_BALANCE_DOES_NOT_EXIST = new ClawbackClaimableBalanceResult.ClawbackClaimableBalanceDoesNotExist();
                return result_CLAWBACK_CLAIMABLE_BALANCE_DOES_NOT_EXIST;
                case ClawbackClaimableBalanceResultCode.CLAWBACK_CLAIMABLE_BALANCE_NOT_ISSUER:
                var result_CLAWBACK_CLAIMABLE_BALANCE_NOT_ISSUER = new ClawbackClaimableBalanceResult.ClawbackClaimableBalanceNotIssuer();
                return result_CLAWBACK_CLAIMABLE_BALANCE_NOT_ISSUER;
                case ClawbackClaimableBalanceResultCode.CLAWBACK_CLAIMABLE_BALANCE_NOT_CLAWBACK_ENABLED:
                var result_CLAWBACK_CLAIMABLE_BALANCE_NOT_CLAWBACK_ENABLED = new ClawbackClaimableBalanceResult.ClawbackClaimableBalanceNotClawbackEnabled();
                return result_CLAWBACK_CLAIMABLE_BALANCE_NOT_CLAWBACK_ENABLED;
                default:
                throw new Exception($"Unknown discriminator for ClawbackClaimableBalanceResult: {discriminator}");
            }
        }
    }
}
