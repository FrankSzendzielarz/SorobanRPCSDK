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
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public abstract partial class ClaimClaimableBalanceResult
    {
        public abstract ClaimClaimableBalanceResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        public sealed partial class ClaimClaimableBalanceSuccess : ClaimClaimableBalanceResult
        {
            public override ClaimClaimableBalanceResultCode Discriminator => ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_SUCCESS;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ClaimClaimableBalanceDoesNotExist : ClaimClaimableBalanceResult
        {
            public override ClaimClaimableBalanceResultCode Discriminator => ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_DOES_NOT_EXIST;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ClaimClaimableBalanceCannotClaim : ClaimClaimableBalanceResult
        {
            public override ClaimClaimableBalanceResultCode Discriminator => ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_CANNOT_CLAIM;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ClaimClaimableBalanceLineFull : ClaimClaimableBalanceResult
        {
            public override ClaimClaimableBalanceResultCode Discriminator => ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_LINE_FULL;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ClaimClaimableBalanceNoTrust : ClaimClaimableBalanceResult
        {
            public override ClaimClaimableBalanceResultCode Discriminator => ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_NO_TRUST;

            public override void ValidateCase() {}
        }
        [System.Serializable]
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
