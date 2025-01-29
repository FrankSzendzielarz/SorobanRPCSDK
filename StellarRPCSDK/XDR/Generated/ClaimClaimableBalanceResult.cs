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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class ClaimClaimableBalanceResult
    {
        public abstract ClaimClaimableBalanceResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class ClaimClaimableBalanceResult_CLAIM_CLAIMABLE_BALANCE_SUCCESS : ClaimClaimableBalanceResult
    {
        public override ClaimClaimableBalanceResultCode Discriminator => ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_SUCCESS;

        public override void ValidateCase() {}
    }
    public sealed partial class ClaimClaimableBalanceResult_CLAIM_CLAIMABLE_BALANCE_DOES_NOT_EXIST : ClaimClaimableBalanceResult
    {
        public override ClaimClaimableBalanceResultCode Discriminator => ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_DOES_NOT_EXIST;

        public override void ValidateCase() {}
    }
    public sealed partial class ClaimClaimableBalanceResult_CLAIM_CLAIMABLE_BALANCE_CANNOT_CLAIM : ClaimClaimableBalanceResult
    {
        public override ClaimClaimableBalanceResultCode Discriminator => ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_CANNOT_CLAIM;

        public override void ValidateCase() {}
    }
    public sealed partial class ClaimClaimableBalanceResult_CLAIM_CLAIMABLE_BALANCE_LINE_FULL : ClaimClaimableBalanceResult
    {
        public override ClaimClaimableBalanceResultCode Discriminator => ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_LINE_FULL;

        public override void ValidateCase() {}
    }
    public sealed partial class ClaimClaimableBalanceResult_CLAIM_CLAIMABLE_BALANCE_NO_TRUST : ClaimClaimableBalanceResult
    {
        public override ClaimClaimableBalanceResultCode Discriminator => ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_NO_TRUST;

        public override void ValidateCase() {}
    }
    public sealed partial class ClaimClaimableBalanceResult_CLAIM_CLAIMABLE_BALANCE_NOT_AUTHORIZED : ClaimClaimableBalanceResult
    {
        public override ClaimClaimableBalanceResultCode Discriminator => ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_NOT_AUTHORIZED;

        public override void ValidateCase() {}
    }
    public static partial class ClaimClaimableBalanceResultXdr
    {
        public static void Encode(XdrWriter stream, ClaimClaimableBalanceResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ClaimClaimableBalanceResult_CLAIM_CLAIMABLE_BALANCE_SUCCESS case_CLAIM_CLAIMABLE_BALANCE_SUCCESS:
                break;
                case ClaimClaimableBalanceResult_CLAIM_CLAIMABLE_BALANCE_DOES_NOT_EXIST case_CLAIM_CLAIMABLE_BALANCE_DOES_NOT_EXIST:
                break;
                case ClaimClaimableBalanceResult_CLAIM_CLAIMABLE_BALANCE_CANNOT_CLAIM case_CLAIM_CLAIMABLE_BALANCE_CANNOT_CLAIM:
                break;
                case ClaimClaimableBalanceResult_CLAIM_CLAIMABLE_BALANCE_LINE_FULL case_CLAIM_CLAIMABLE_BALANCE_LINE_FULL:
                break;
                case ClaimClaimableBalanceResult_CLAIM_CLAIMABLE_BALANCE_NO_TRUST case_CLAIM_CLAIMABLE_BALANCE_NO_TRUST:
                break;
                case ClaimClaimableBalanceResult_CLAIM_CLAIMABLE_BALANCE_NOT_AUTHORIZED case_CLAIM_CLAIMABLE_BALANCE_NOT_AUTHORIZED:
                break;
            }
        }
        public static ClaimClaimableBalanceResult Decode(XdrReader stream)
        {
            var discriminator = (ClaimClaimableBalanceResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_SUCCESS:
                var result_CLAIM_CLAIMABLE_BALANCE_SUCCESS = new ClaimClaimableBalanceResult_CLAIM_CLAIMABLE_BALANCE_SUCCESS();
                return result_CLAIM_CLAIMABLE_BALANCE_SUCCESS;
                case ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_DOES_NOT_EXIST:
                var result_CLAIM_CLAIMABLE_BALANCE_DOES_NOT_EXIST = new ClaimClaimableBalanceResult_CLAIM_CLAIMABLE_BALANCE_DOES_NOT_EXIST();
                return result_CLAIM_CLAIMABLE_BALANCE_DOES_NOT_EXIST;
                case ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_CANNOT_CLAIM:
                var result_CLAIM_CLAIMABLE_BALANCE_CANNOT_CLAIM = new ClaimClaimableBalanceResult_CLAIM_CLAIMABLE_BALANCE_CANNOT_CLAIM();
                return result_CLAIM_CLAIMABLE_BALANCE_CANNOT_CLAIM;
                case ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_LINE_FULL:
                var result_CLAIM_CLAIMABLE_BALANCE_LINE_FULL = new ClaimClaimableBalanceResult_CLAIM_CLAIMABLE_BALANCE_LINE_FULL();
                return result_CLAIM_CLAIMABLE_BALANCE_LINE_FULL;
                case ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_NO_TRUST:
                var result_CLAIM_CLAIMABLE_BALANCE_NO_TRUST = new ClaimClaimableBalanceResult_CLAIM_CLAIMABLE_BALANCE_NO_TRUST();
                return result_CLAIM_CLAIMABLE_BALANCE_NO_TRUST;
                case ClaimClaimableBalanceResultCode.CLAIM_CLAIMABLE_BALANCE_NOT_AUTHORIZED:
                var result_CLAIM_CLAIMABLE_BALANCE_NOT_AUTHORIZED = new ClaimClaimableBalanceResult_CLAIM_CLAIMABLE_BALANCE_NOT_AUTHORIZED();
                return result_CLAIM_CLAIMABLE_BALANCE_NOT_AUTHORIZED;
                default:
                throw new Exception($"Unknown discriminator for ClaimClaimableBalanceResult: {discriminator}");
            }
        }
    }
}
