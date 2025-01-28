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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class ClawbackClaimableBalanceResult
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class ClawbackClaimableBalanceResult_CLAWBACK_CLAIMABLE_BALANCE_SUCCESS : ClawbackClaimableBalanceResult
    {
        public override int Discriminator => CLAWBACK_CLAIMABLE_BALANCE_SUCCESS;

        public override void ValidateCase() {}
    }
    public sealed partial class ClawbackClaimableBalanceResult_CLAWBACK_CLAIMABLE_BALANCE_DOES_NOT_EXIST : ClawbackClaimableBalanceResult
    {
        public override int Discriminator => CLAWBACK_CLAIMABLE_BALANCE_DOES_NOT_EXIST;

        public override void ValidateCase() {}
    }
    public sealed partial class ClawbackClaimableBalanceResult_CLAWBACK_CLAIMABLE_BALANCE_NOT_ISSUER : ClawbackClaimableBalanceResult
    {
        public override int Discriminator => CLAWBACK_CLAIMABLE_BALANCE_NOT_ISSUER;

        public override void ValidateCase() {}
    }
    public sealed partial class ClawbackClaimableBalanceResult_CLAWBACK_CLAIMABLE_BALANCE_NOT_CLAWBACK_ENABLED : ClawbackClaimableBalanceResult
    {
        public override int Discriminator => CLAWBACK_CLAIMABLE_BALANCE_NOT_CLAWBACK_ENABLED;

        public override void ValidateCase() {}
    }
    public static partial class ClawbackClaimableBalanceResultXdr
    {
        public static void Encode(XdrWriter stream, ClawbackClaimableBalanceResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ClawbackClaimableBalanceResult_CLAWBACK_CLAIMABLE_BALANCE_SUCCESS case_CLAWBACK_CLAIMABLE_BALANCE_SUCCESS:
                break;
                case ClawbackClaimableBalanceResult_CLAWBACK_CLAIMABLE_BALANCE_DOES_NOT_EXIST case_CLAWBACK_CLAIMABLE_BALANCE_DOES_NOT_EXIST:
                break;
                case ClawbackClaimableBalanceResult_CLAWBACK_CLAIMABLE_BALANCE_NOT_ISSUER case_CLAWBACK_CLAIMABLE_BALANCE_NOT_ISSUER:
                break;
                case ClawbackClaimableBalanceResult_CLAWBACK_CLAIMABLE_BALANCE_NOT_CLAWBACK_ENABLED case_CLAWBACK_CLAIMABLE_BALANCE_NOT_CLAWBACK_ENABLED:
                break;
            }
        }
        public static ClawbackClaimableBalanceResult Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case CLAWBACK_CLAIMABLE_BALANCE_SUCCESS:
                var result_CLAWBACK_CLAIMABLE_BALANCE_SUCCESS = new ClawbackClaimableBalanceResult_CLAWBACK_CLAIMABLE_BALANCE_SUCCESS();
                return result_CLAWBACK_CLAIMABLE_BALANCE_SUCCESS;
                case CLAWBACK_CLAIMABLE_BALANCE_DOES_NOT_EXIST:
                var result_CLAWBACK_CLAIMABLE_BALANCE_DOES_NOT_EXIST = new ClawbackClaimableBalanceResult_CLAWBACK_CLAIMABLE_BALANCE_DOES_NOT_EXIST();
                return result_CLAWBACK_CLAIMABLE_BALANCE_DOES_NOT_EXIST;
                case CLAWBACK_CLAIMABLE_BALANCE_NOT_ISSUER:
                var result_CLAWBACK_CLAIMABLE_BALANCE_NOT_ISSUER = new ClawbackClaimableBalanceResult_CLAWBACK_CLAIMABLE_BALANCE_NOT_ISSUER();
                return result_CLAWBACK_CLAIMABLE_BALANCE_NOT_ISSUER;
                case CLAWBACK_CLAIMABLE_BALANCE_NOT_CLAWBACK_ENABLED:
                var result_CLAWBACK_CLAIMABLE_BALANCE_NOT_CLAWBACK_ENABLED = new ClawbackClaimableBalanceResult_CLAWBACK_CLAIMABLE_BALANCE_NOT_CLAWBACK_ENABLED();
                return result_CLAWBACK_CLAIMABLE_BALANCE_NOT_CLAWBACK_ENABLED;
                default:
                throw new Exception($"Unknown discriminator for ClawbackClaimableBalanceResult: {discriminator}");
            }
        }
    }
}
