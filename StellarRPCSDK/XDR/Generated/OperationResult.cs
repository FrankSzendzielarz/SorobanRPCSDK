// Generated code - do not modify
// Source:

// union OperationResult switch (OperationResultCode code)
// {
// case opINNER:
//     union switch (OperationType type)
//     {
//     case CREATE_ACCOUNT:
//         CreateAccountResult createAccountResult;
//     case PAYMENT:
//         PaymentResult paymentResult;
//     case PATH_PAYMENT_STRICT_RECEIVE:
//         PathPaymentStrictReceiveResult pathPaymentStrictReceiveResult;
//     case MANAGE_SELL_OFFER:
//         ManageSellOfferResult manageSellOfferResult;
//     case CREATE_PASSIVE_SELL_OFFER:
//         ManageSellOfferResult createPassiveSellOfferResult;
//     case SET_OPTIONS:
//         SetOptionsResult setOptionsResult;
//     case CHANGE_TRUST:
//         ChangeTrustResult changeTrustResult;
//     case ALLOW_TRUST:
//         AllowTrustResult allowTrustResult;
//     case ACCOUNT_MERGE:
//         AccountMergeResult accountMergeResult;
//     case INFLATION:
//         InflationResult inflationResult;
//     case MANAGE_DATA:
//         ManageDataResult manageDataResult;
//     case BUMP_SEQUENCE:
//         BumpSequenceResult bumpSeqResult;
//     case MANAGE_BUY_OFFER:
//         ManageBuyOfferResult manageBuyOfferResult;
//     case PATH_PAYMENT_STRICT_SEND:
//         PathPaymentStrictSendResult pathPaymentStrictSendResult;
//     case CREATE_CLAIMABLE_BALANCE:
//         CreateClaimableBalanceResult createClaimableBalanceResult;
//     case CLAIM_CLAIMABLE_BALANCE:
//         ClaimClaimableBalanceResult claimClaimableBalanceResult;
//     case BEGIN_SPONSORING_FUTURE_RESERVES:
//         BeginSponsoringFutureReservesResult beginSponsoringFutureReservesResult;
//     case END_SPONSORING_FUTURE_RESERVES:
//         EndSponsoringFutureReservesResult endSponsoringFutureReservesResult;
//     case REVOKE_SPONSORSHIP:
//         RevokeSponsorshipResult revokeSponsorshipResult;
//     case CLAWBACK:
//         ClawbackResult clawbackResult;
//     case CLAWBACK_CLAIMABLE_BALANCE:
//         ClawbackClaimableBalanceResult clawbackClaimableBalanceResult;
//     case SET_TRUST_LINE_FLAGS:
//         SetTrustLineFlagsResult setTrustLineFlagsResult;
//     case LIQUIDITY_POOL_DEPOSIT:
//         LiquidityPoolDepositResult liquidityPoolDepositResult;
//     case LIQUIDITY_POOL_WITHDRAW:
//         LiquidityPoolWithdrawResult liquidityPoolWithdrawResult;
//     case INVOKE_HOST_FUNCTION:
//         InvokeHostFunctionResult invokeHostFunctionResult;
//     case EXTEND_FOOTPRINT_TTL:
//         ExtendFootprintTTLResult extendFootprintTTLResult;
//     case RESTORE_FOOTPRINT:
//         RestoreFootprintResult restoreFootprintResult;
//     }
//     tr;
// case opBAD_AUTH:
// case opNO_ACCOUNT:
// case opNOT_SUPPORTED:
// case opTOO_MANY_SUBENTRIES:
// case opEXCEEDED_WORK_LIMIT:
// case opTOO_MANY_SPONSORING:
//     void;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class OperationResult
    {
        public abstract OperationResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class OperationResult_opINNER : OperationResult
    {
        public override OperationResultCode Discriminator => opINNER;
        private object _tr;
        public object tr
        {
            get => _tr;
            set
            {
                _tr = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class OperationResult_opBAD_AUTH : OperationResult
    {
        public override OperationResultCode Discriminator => opBAD_AUTH;

        public override void ValidateCase() {}
    }
    public sealed partial class OperationResult_opNO_ACCOUNT : OperationResult
    {
        public override OperationResultCode Discriminator => opNO_ACCOUNT;

        public override void ValidateCase() {}
    }
    public sealed partial class OperationResult_opNOT_SUPPORTED : OperationResult
    {
        public override OperationResultCode Discriminator => opNOT_SUPPORTED;

        public override void ValidateCase() {}
    }
    public sealed partial class OperationResult_opTOO_MANY_SUBENTRIES : OperationResult
    {
        public override OperationResultCode Discriminator => opTOO_MANY_SUBENTRIES;

        public override void ValidateCase() {}
    }
    public sealed partial class OperationResult_opEXCEEDED_WORK_LIMIT : OperationResult
    {
        public override OperationResultCode Discriminator => opEXCEEDED_WORK_LIMIT;

        public override void ValidateCase() {}
    }
    public sealed partial class OperationResult_opTOO_MANY_SPONSORING : OperationResult
    {
        public override OperationResultCode Discriminator => opTOO_MANY_SPONSORING;

        public override void ValidateCase() {}
    }
    public static partial class OperationResultXdr
    {
        public static void Encode(XdrWriter stream, OperationResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case OperationResult_opINNER case_opINNER:
                Xdr.Encode(stream, case_opINNER.tr);
                break;
                case OperationResult_opBAD_AUTH case_opBAD_AUTH:
                break;
                case OperationResult_opNO_ACCOUNT case_opNO_ACCOUNT:
                break;
                case OperationResult_opNOT_SUPPORTED case_opNOT_SUPPORTED:
                break;
                case OperationResult_opTOO_MANY_SUBENTRIES case_opTOO_MANY_SUBENTRIES:
                break;
                case OperationResult_opEXCEEDED_WORK_LIMIT case_opEXCEEDED_WORK_LIMIT:
                break;
                case OperationResult_opTOO_MANY_SPONSORING case_opTOO_MANY_SPONSORING:
                break;
            }
        }
        public static OperationResult Decode(XdrReader stream)
        {
            var discriminator = (OperationResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case opINNER:
                var result_opINNER = new OperationResult_opINNER();
                result_opINNER.                 = Xdr.Decode(stream);
                return result_opINNER;
                case opBAD_AUTH:
                var result_opBAD_AUTH = new OperationResult_opBAD_AUTH();
                return result_opBAD_AUTH;
                case opNO_ACCOUNT:
                var result_opNO_ACCOUNT = new OperationResult_opNO_ACCOUNT();
                return result_opNO_ACCOUNT;
                case opNOT_SUPPORTED:
                var result_opNOT_SUPPORTED = new OperationResult_opNOT_SUPPORTED();
                return result_opNOT_SUPPORTED;
                case opTOO_MANY_SUBENTRIES:
                var result_opTOO_MANY_SUBENTRIES = new OperationResult_opTOO_MANY_SUBENTRIES();
                return result_opTOO_MANY_SUBENTRIES;
                case opEXCEEDED_WORK_LIMIT:
                var result_opEXCEEDED_WORK_LIMIT = new OperationResult_opEXCEEDED_WORK_LIMIT();
                return result_opEXCEEDED_WORK_LIMIT;
                case opTOO_MANY_SPONSORING:
                var result_opTOO_MANY_SPONSORING = new OperationResult_opTOO_MANY_SPONSORING();
                return result_opTOO_MANY_SPONSORING;
                default:
                throw new Exception($"Unknown discriminator for OperationResult: {discriminator}");
            }
        }
    }
}
