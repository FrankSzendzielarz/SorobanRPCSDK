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
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public abstract partial class OperationResult
    {
        public abstract OperationResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        public abstract partial class trUnion
        {
            public abstract OperationType Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.Serializable]
            public sealed partial class CreateAccount : trUnion
            {
                public override OperationType Discriminator => OperationType.CREATE_ACCOUNT;
                public CreateAccountResult createAccountResult
                {
                    get => _createAccountResult;
                    set
                    {
                        _createAccountResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Create Account Result")]
                #endif
                private CreateAccountResult _createAccountResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class Payment : trUnion
            {
                public override OperationType Discriminator => OperationType.PAYMENT;
                public PaymentResult paymentResult
                {
                    get => _paymentResult;
                    set
                    {
                        _paymentResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Payment Result")]
                #endif
                private PaymentResult _paymentResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class PathPaymentStrictReceive : trUnion
            {
                public override OperationType Discriminator => OperationType.PATH_PAYMENT_STRICT_RECEIVE;
                public PathPaymentStrictReceiveResult pathPaymentStrictReceiveResult
                {
                    get => _pathPaymentStrictReceiveResult;
                    set
                    {
                        _pathPaymentStrictReceiveResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Path Payment Strict Receive Result")]
                #endif
                private PathPaymentStrictReceiveResult _pathPaymentStrictReceiveResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class ManageSellOffer : trUnion
            {
                public override OperationType Discriminator => OperationType.MANAGE_SELL_OFFER;
                public ManageSellOfferResult manageSellOfferResult
                {
                    get => _manageSellOfferResult;
                    set
                    {
                        _manageSellOfferResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Manage Sell Offer Result")]
                #endif
                private ManageSellOfferResult _manageSellOfferResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class CreatePassiveSellOffer : trUnion
            {
                public override OperationType Discriminator => OperationType.CREATE_PASSIVE_SELL_OFFER;
                public ManageSellOfferResult createPassiveSellOfferResult
                {
                    get => _createPassiveSellOfferResult;
                    set
                    {
                        _createPassiveSellOfferResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Create Passive Sell Offer Result")]
                #endif
                private ManageSellOfferResult _createPassiveSellOfferResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class SetOptions : trUnion
            {
                public override OperationType Discriminator => OperationType.SET_OPTIONS;
                public SetOptionsResult setOptionsResult
                {
                    get => _setOptionsResult;
                    set
                    {
                        _setOptionsResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Set Options Result")]
                #endif
                private SetOptionsResult _setOptionsResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class ChangeTrust : trUnion
            {
                public override OperationType Discriminator => OperationType.CHANGE_TRUST;
                public ChangeTrustResult changeTrustResult
                {
                    get => _changeTrustResult;
                    set
                    {
                        _changeTrustResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Change Trust Result")]
                #endif
                private ChangeTrustResult _changeTrustResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class AllowTrust : trUnion
            {
                public override OperationType Discriminator => OperationType.ALLOW_TRUST;
                public AllowTrustResult allowTrustResult
                {
                    get => _allowTrustResult;
                    set
                    {
                        _allowTrustResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Allow Trust Result")]
                #endif
                private AllowTrustResult _allowTrustResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class AccountMerge : trUnion
            {
                public override OperationType Discriminator => OperationType.ACCOUNT_MERGE;
                public AccountMergeResult accountMergeResult
                {
                    get => _accountMergeResult;
                    set
                    {
                        _accountMergeResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Account Merge Result")]
                #endif
                private AccountMergeResult _accountMergeResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class Inflation : trUnion
            {
                public override OperationType Discriminator => OperationType.INFLATION;
                public InflationResult inflationResult
                {
                    get => _inflationResult;
                    set
                    {
                        _inflationResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Inflation Result")]
                #endif
                private InflationResult _inflationResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class ManageData : trUnion
            {
                public override OperationType Discriminator => OperationType.MANAGE_DATA;
                public ManageDataResult manageDataResult
                {
                    get => _manageDataResult;
                    set
                    {
                        _manageDataResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Manage Data Result")]
                #endif
                private ManageDataResult _manageDataResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class BumpSequence : trUnion
            {
                public override OperationType Discriminator => OperationType.BUMP_SEQUENCE;
                public BumpSequenceResult bumpSeqResult
                {
                    get => _bumpSeqResult;
                    set
                    {
                        _bumpSeqResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Bump Seq Result")]
                #endif
                private BumpSequenceResult _bumpSeqResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class ManageBuyOffer : trUnion
            {
                public override OperationType Discriminator => OperationType.MANAGE_BUY_OFFER;
                public ManageBuyOfferResult manageBuyOfferResult
                {
                    get => _manageBuyOfferResult;
                    set
                    {
                        _manageBuyOfferResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Manage Buy Offer Result")]
                #endif
                private ManageBuyOfferResult _manageBuyOfferResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class PathPaymentStrictSend : trUnion
            {
                public override OperationType Discriminator => OperationType.PATH_PAYMENT_STRICT_SEND;
                public PathPaymentStrictSendResult pathPaymentStrictSendResult
                {
                    get => _pathPaymentStrictSendResult;
                    set
                    {
                        _pathPaymentStrictSendResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Path Payment Strict Send Result")]
                #endif
                private PathPaymentStrictSendResult _pathPaymentStrictSendResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class CreateClaimableBalance : trUnion
            {
                public override OperationType Discriminator => OperationType.CREATE_CLAIMABLE_BALANCE;
                public CreateClaimableBalanceResult createClaimableBalanceResult
                {
                    get => _createClaimableBalanceResult;
                    set
                    {
                        _createClaimableBalanceResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Create Claimable Balance Result")]
                #endif
                private CreateClaimableBalanceResult _createClaimableBalanceResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class ClaimClaimableBalance : trUnion
            {
                public override OperationType Discriminator => OperationType.CLAIM_CLAIMABLE_BALANCE;
                public ClaimClaimableBalanceResult claimClaimableBalanceResult
                {
                    get => _claimClaimableBalanceResult;
                    set
                    {
                        _claimClaimableBalanceResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Claim Claimable Balance Result")]
                #endif
                private ClaimClaimableBalanceResult _claimClaimableBalanceResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class BeginSponsoringFutureReserves : trUnion
            {
                public override OperationType Discriminator => OperationType.BEGIN_SPONSORING_FUTURE_RESERVES;
                public BeginSponsoringFutureReservesResult beginSponsoringFutureReservesResult
                {
                    get => _beginSponsoringFutureReservesResult;
                    set
                    {
                        _beginSponsoringFutureReservesResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Begin Sponsoring Future Reserves Result")]
                #endif
                private BeginSponsoringFutureReservesResult _beginSponsoringFutureReservesResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class EndSponsoringFutureReserves : trUnion
            {
                public override OperationType Discriminator => OperationType.END_SPONSORING_FUTURE_RESERVES;
                public EndSponsoringFutureReservesResult endSponsoringFutureReservesResult
                {
                    get => _endSponsoringFutureReservesResult;
                    set
                    {
                        _endSponsoringFutureReservesResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"End Sponsoring Future Reserves Result")]
                #endif
                private EndSponsoringFutureReservesResult _endSponsoringFutureReservesResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class RevokeSponsorship : trUnion
            {
                public override OperationType Discriminator => OperationType.REVOKE_SPONSORSHIP;
                public RevokeSponsorshipResult revokeSponsorshipResult
                {
                    get => _revokeSponsorshipResult;
                    set
                    {
                        _revokeSponsorshipResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Revoke Sponsorship Result")]
                #endif
                private RevokeSponsorshipResult _revokeSponsorshipResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class Clawback : trUnion
            {
                public override OperationType Discriminator => OperationType.CLAWBACK;
                public ClawbackResult clawbackResult
                {
                    get => _clawbackResult;
                    set
                    {
                        _clawbackResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Clawback Result")]
                #endif
                private ClawbackResult _clawbackResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class ClawbackClaimableBalance : trUnion
            {
                public override OperationType Discriminator => OperationType.CLAWBACK_CLAIMABLE_BALANCE;
                public ClawbackClaimableBalanceResult clawbackClaimableBalanceResult
                {
                    get => _clawbackClaimableBalanceResult;
                    set
                    {
                        _clawbackClaimableBalanceResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Clawback Claimable Balance Result")]
                #endif
                private ClawbackClaimableBalanceResult _clawbackClaimableBalanceResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class SetTrustLineFlags : trUnion
            {
                public override OperationType Discriminator => OperationType.SET_TRUST_LINE_FLAGS;
                public SetTrustLineFlagsResult setTrustLineFlagsResult
                {
                    get => _setTrustLineFlagsResult;
                    set
                    {
                        _setTrustLineFlagsResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Set Trust Line Flags Result")]
                #endif
                private SetTrustLineFlagsResult _setTrustLineFlagsResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class LiquidityPoolDeposit : trUnion
            {
                public override OperationType Discriminator => OperationType.LIQUIDITY_POOL_DEPOSIT;
                public LiquidityPoolDepositResult liquidityPoolDepositResult
                {
                    get => _liquidityPoolDepositResult;
                    set
                    {
                        _liquidityPoolDepositResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Liquidity Pool Deposit Result")]
                #endif
                private LiquidityPoolDepositResult _liquidityPoolDepositResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class LiquidityPoolWithdraw : trUnion
            {
                public override OperationType Discriminator => OperationType.LIQUIDITY_POOL_WITHDRAW;
                public LiquidityPoolWithdrawResult liquidityPoolWithdrawResult
                {
                    get => _liquidityPoolWithdrawResult;
                    set
                    {
                        _liquidityPoolWithdrawResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Liquidity Pool Withdraw Result")]
                #endif
                private LiquidityPoolWithdrawResult _liquidityPoolWithdrawResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class InvokeHostFunction : trUnion
            {
                public override OperationType Discriminator => OperationType.INVOKE_HOST_FUNCTION;
                public InvokeHostFunctionResult invokeHostFunctionResult
                {
                    get => _invokeHostFunctionResult;
                    set
                    {
                        _invokeHostFunctionResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Invoke Host Function Result")]
                #endif
                private InvokeHostFunctionResult _invokeHostFunctionResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class ExtendFootprintTtl : trUnion
            {
                public override OperationType Discriminator => OperationType.EXTEND_FOOTPRINT_TTL;
                public ExtendFootprintTTLResult extendFootprintTTLResult
                {
                    get => _extendFootprintTTLResult;
                    set
                    {
                        _extendFootprintTTLResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Extend Footprint T T L Result")]
                #endif
                private ExtendFootprintTTLResult _extendFootprintTTLResult;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class RestoreFootprint : trUnion
            {
                public override OperationType Discriminator => OperationType.RESTORE_FOOTPRINT;
                public RestoreFootprintResult restoreFootprintResult
                {
                    get => _restoreFootprintResult;
                    set
                    {
                        _restoreFootprintResult = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Restore Footprint Result")]
                #endif
                private RestoreFootprintResult _restoreFootprintResult;

                public override void ValidateCase() {}
            }
        }
        public static partial class trUnionXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(trUnion value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    trUnionXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            public static void Encode(XdrWriter stream, trUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case trUnion.CreateAccount case_CREATE_ACCOUNT:
                    CreateAccountResultXdr.Encode(stream, case_CREATE_ACCOUNT.createAccountResult);
                    break;
                    case trUnion.Payment case_PAYMENT:
                    PaymentResultXdr.Encode(stream, case_PAYMENT.paymentResult);
                    break;
                    case trUnion.PathPaymentStrictReceive case_PATH_PAYMENT_STRICT_RECEIVE:
                    PathPaymentStrictReceiveResultXdr.Encode(stream, case_PATH_PAYMENT_STRICT_RECEIVE.pathPaymentStrictReceiveResult);
                    break;
                    case trUnion.ManageSellOffer case_MANAGE_SELL_OFFER:
                    ManageSellOfferResultXdr.Encode(stream, case_MANAGE_SELL_OFFER.manageSellOfferResult);
                    break;
                    case trUnion.CreatePassiveSellOffer case_CREATE_PASSIVE_SELL_OFFER:
                    ManageSellOfferResultXdr.Encode(stream, case_CREATE_PASSIVE_SELL_OFFER.createPassiveSellOfferResult);
                    break;
                    case trUnion.SetOptions case_SET_OPTIONS:
                    SetOptionsResultXdr.Encode(stream, case_SET_OPTIONS.setOptionsResult);
                    break;
                    case trUnion.ChangeTrust case_CHANGE_TRUST:
                    ChangeTrustResultXdr.Encode(stream, case_CHANGE_TRUST.changeTrustResult);
                    break;
                    case trUnion.AllowTrust case_ALLOW_TRUST:
                    AllowTrustResultXdr.Encode(stream, case_ALLOW_TRUST.allowTrustResult);
                    break;
                    case trUnion.AccountMerge case_ACCOUNT_MERGE:
                    AccountMergeResultXdr.Encode(stream, case_ACCOUNT_MERGE.accountMergeResult);
                    break;
                    case trUnion.Inflation case_INFLATION:
                    InflationResultXdr.Encode(stream, case_INFLATION.inflationResult);
                    break;
                    case trUnion.ManageData case_MANAGE_DATA:
                    ManageDataResultXdr.Encode(stream, case_MANAGE_DATA.manageDataResult);
                    break;
                    case trUnion.BumpSequence case_BUMP_SEQUENCE:
                    BumpSequenceResultXdr.Encode(stream, case_BUMP_SEQUENCE.bumpSeqResult);
                    break;
                    case trUnion.ManageBuyOffer case_MANAGE_BUY_OFFER:
                    ManageBuyOfferResultXdr.Encode(stream, case_MANAGE_BUY_OFFER.manageBuyOfferResult);
                    break;
                    case trUnion.PathPaymentStrictSend case_PATH_PAYMENT_STRICT_SEND:
                    PathPaymentStrictSendResultXdr.Encode(stream, case_PATH_PAYMENT_STRICT_SEND.pathPaymentStrictSendResult);
                    break;
                    case trUnion.CreateClaimableBalance case_CREATE_CLAIMABLE_BALANCE:
                    CreateClaimableBalanceResultXdr.Encode(stream, case_CREATE_CLAIMABLE_BALANCE.createClaimableBalanceResult);
                    break;
                    case trUnion.ClaimClaimableBalance case_CLAIM_CLAIMABLE_BALANCE:
                    ClaimClaimableBalanceResultXdr.Encode(stream, case_CLAIM_CLAIMABLE_BALANCE.claimClaimableBalanceResult);
                    break;
                    case trUnion.BeginSponsoringFutureReserves case_BEGIN_SPONSORING_FUTURE_RESERVES:
                    BeginSponsoringFutureReservesResultXdr.Encode(stream, case_BEGIN_SPONSORING_FUTURE_RESERVES.beginSponsoringFutureReservesResult);
                    break;
                    case trUnion.EndSponsoringFutureReserves case_END_SPONSORING_FUTURE_RESERVES:
                    EndSponsoringFutureReservesResultXdr.Encode(stream, case_END_SPONSORING_FUTURE_RESERVES.endSponsoringFutureReservesResult);
                    break;
                    case trUnion.RevokeSponsorship case_REVOKE_SPONSORSHIP:
                    RevokeSponsorshipResultXdr.Encode(stream, case_REVOKE_SPONSORSHIP.revokeSponsorshipResult);
                    break;
                    case trUnion.Clawback case_CLAWBACK:
                    ClawbackResultXdr.Encode(stream, case_CLAWBACK.clawbackResult);
                    break;
                    case trUnion.ClawbackClaimableBalance case_CLAWBACK_CLAIMABLE_BALANCE:
                    ClawbackClaimableBalanceResultXdr.Encode(stream, case_CLAWBACK_CLAIMABLE_BALANCE.clawbackClaimableBalanceResult);
                    break;
                    case trUnion.SetTrustLineFlags case_SET_TRUST_LINE_FLAGS:
                    SetTrustLineFlagsResultXdr.Encode(stream, case_SET_TRUST_LINE_FLAGS.setTrustLineFlagsResult);
                    break;
                    case trUnion.LiquidityPoolDeposit case_LIQUIDITY_POOL_DEPOSIT:
                    LiquidityPoolDepositResultXdr.Encode(stream, case_LIQUIDITY_POOL_DEPOSIT.liquidityPoolDepositResult);
                    break;
                    case trUnion.LiquidityPoolWithdraw case_LIQUIDITY_POOL_WITHDRAW:
                    LiquidityPoolWithdrawResultXdr.Encode(stream, case_LIQUIDITY_POOL_WITHDRAW.liquidityPoolWithdrawResult);
                    break;
                    case trUnion.InvokeHostFunction case_INVOKE_HOST_FUNCTION:
                    InvokeHostFunctionResultXdr.Encode(stream, case_INVOKE_HOST_FUNCTION.invokeHostFunctionResult);
                    break;
                    case trUnion.ExtendFootprintTtl case_EXTEND_FOOTPRINT_TTL:
                    ExtendFootprintTTLResultXdr.Encode(stream, case_EXTEND_FOOTPRINT_TTL.extendFootprintTTLResult);
                    break;
                    case trUnion.RestoreFootprint case_RESTORE_FOOTPRINT:
                    RestoreFootprintResultXdr.Encode(stream, case_RESTORE_FOOTPRINT.restoreFootprintResult);
                    break;
                }
            }
            public static trUnion Decode(XdrReader stream)
            {
                var discriminator = (OperationType)stream.ReadInt();
                switch (discriminator)
                {
                    case OperationType.CREATE_ACCOUNT:
                    var result_CREATE_ACCOUNT = new trUnion.CreateAccount();
                    result_CREATE_ACCOUNT.createAccountResult = CreateAccountResultXdr.Decode(stream);
                    return result_CREATE_ACCOUNT;
                    case OperationType.PAYMENT:
                    var result_PAYMENT = new trUnion.Payment();
                    result_PAYMENT.paymentResult = PaymentResultXdr.Decode(stream);
                    return result_PAYMENT;
                    case OperationType.PATH_PAYMENT_STRICT_RECEIVE:
                    var result_PATH_PAYMENT_STRICT_RECEIVE = new trUnion.PathPaymentStrictReceive();
                    result_PATH_PAYMENT_STRICT_RECEIVE.pathPaymentStrictReceiveResult = PathPaymentStrictReceiveResultXdr.Decode(stream);
                    return result_PATH_PAYMENT_STRICT_RECEIVE;
                    case OperationType.MANAGE_SELL_OFFER:
                    var result_MANAGE_SELL_OFFER = new trUnion.ManageSellOffer();
                    result_MANAGE_SELL_OFFER.manageSellOfferResult = ManageSellOfferResultXdr.Decode(stream);
                    return result_MANAGE_SELL_OFFER;
                    case OperationType.CREATE_PASSIVE_SELL_OFFER:
                    var result_CREATE_PASSIVE_SELL_OFFER = new trUnion.CreatePassiveSellOffer();
                    result_CREATE_PASSIVE_SELL_OFFER.createPassiveSellOfferResult = ManageSellOfferResultXdr.Decode(stream);
                    return result_CREATE_PASSIVE_SELL_OFFER;
                    case OperationType.SET_OPTIONS:
                    var result_SET_OPTIONS = new trUnion.SetOptions();
                    result_SET_OPTIONS.setOptionsResult = SetOptionsResultXdr.Decode(stream);
                    return result_SET_OPTIONS;
                    case OperationType.CHANGE_TRUST:
                    var result_CHANGE_TRUST = new trUnion.ChangeTrust();
                    result_CHANGE_TRUST.changeTrustResult = ChangeTrustResultXdr.Decode(stream);
                    return result_CHANGE_TRUST;
                    case OperationType.ALLOW_TRUST:
                    var result_ALLOW_TRUST = new trUnion.AllowTrust();
                    result_ALLOW_TRUST.allowTrustResult = AllowTrustResultXdr.Decode(stream);
                    return result_ALLOW_TRUST;
                    case OperationType.ACCOUNT_MERGE:
                    var result_ACCOUNT_MERGE = new trUnion.AccountMerge();
                    result_ACCOUNT_MERGE.accountMergeResult = AccountMergeResultXdr.Decode(stream);
                    return result_ACCOUNT_MERGE;
                    case OperationType.INFLATION:
                    var result_INFLATION = new trUnion.Inflation();
                    result_INFLATION.inflationResult = InflationResultXdr.Decode(stream);
                    return result_INFLATION;
                    case OperationType.MANAGE_DATA:
                    var result_MANAGE_DATA = new trUnion.ManageData();
                    result_MANAGE_DATA.manageDataResult = ManageDataResultXdr.Decode(stream);
                    return result_MANAGE_DATA;
                    case OperationType.BUMP_SEQUENCE:
                    var result_BUMP_SEQUENCE = new trUnion.BumpSequence();
                    result_BUMP_SEQUENCE.bumpSeqResult = BumpSequenceResultXdr.Decode(stream);
                    return result_BUMP_SEQUENCE;
                    case OperationType.MANAGE_BUY_OFFER:
                    var result_MANAGE_BUY_OFFER = new trUnion.ManageBuyOffer();
                    result_MANAGE_BUY_OFFER.manageBuyOfferResult = ManageBuyOfferResultXdr.Decode(stream);
                    return result_MANAGE_BUY_OFFER;
                    case OperationType.PATH_PAYMENT_STRICT_SEND:
                    var result_PATH_PAYMENT_STRICT_SEND = new trUnion.PathPaymentStrictSend();
                    result_PATH_PAYMENT_STRICT_SEND.pathPaymentStrictSendResult = PathPaymentStrictSendResultXdr.Decode(stream);
                    return result_PATH_PAYMENT_STRICT_SEND;
                    case OperationType.CREATE_CLAIMABLE_BALANCE:
                    var result_CREATE_CLAIMABLE_BALANCE = new trUnion.CreateClaimableBalance();
                    result_CREATE_CLAIMABLE_BALANCE.createClaimableBalanceResult = CreateClaimableBalanceResultXdr.Decode(stream);
                    return result_CREATE_CLAIMABLE_BALANCE;
                    case OperationType.CLAIM_CLAIMABLE_BALANCE:
                    var result_CLAIM_CLAIMABLE_BALANCE = new trUnion.ClaimClaimableBalance();
                    result_CLAIM_CLAIMABLE_BALANCE.claimClaimableBalanceResult = ClaimClaimableBalanceResultXdr.Decode(stream);
                    return result_CLAIM_CLAIMABLE_BALANCE;
                    case OperationType.BEGIN_SPONSORING_FUTURE_RESERVES:
                    var result_BEGIN_SPONSORING_FUTURE_RESERVES = new trUnion.BeginSponsoringFutureReserves();
                    result_BEGIN_SPONSORING_FUTURE_RESERVES.beginSponsoringFutureReservesResult = BeginSponsoringFutureReservesResultXdr.Decode(stream);
                    return result_BEGIN_SPONSORING_FUTURE_RESERVES;
                    case OperationType.END_SPONSORING_FUTURE_RESERVES:
                    var result_END_SPONSORING_FUTURE_RESERVES = new trUnion.EndSponsoringFutureReserves();
                    result_END_SPONSORING_FUTURE_RESERVES.endSponsoringFutureReservesResult = EndSponsoringFutureReservesResultXdr.Decode(stream);
                    return result_END_SPONSORING_FUTURE_RESERVES;
                    case OperationType.REVOKE_SPONSORSHIP:
                    var result_REVOKE_SPONSORSHIP = new trUnion.RevokeSponsorship();
                    result_REVOKE_SPONSORSHIP.revokeSponsorshipResult = RevokeSponsorshipResultXdr.Decode(stream);
                    return result_REVOKE_SPONSORSHIP;
                    case OperationType.CLAWBACK:
                    var result_CLAWBACK = new trUnion.Clawback();
                    result_CLAWBACK.clawbackResult = ClawbackResultXdr.Decode(stream);
                    return result_CLAWBACK;
                    case OperationType.CLAWBACK_CLAIMABLE_BALANCE:
                    var result_CLAWBACK_CLAIMABLE_BALANCE = new trUnion.ClawbackClaimableBalance();
                    result_CLAWBACK_CLAIMABLE_BALANCE.clawbackClaimableBalanceResult = ClawbackClaimableBalanceResultXdr.Decode(stream);
                    return result_CLAWBACK_CLAIMABLE_BALANCE;
                    case OperationType.SET_TRUST_LINE_FLAGS:
                    var result_SET_TRUST_LINE_FLAGS = new trUnion.SetTrustLineFlags();
                    result_SET_TRUST_LINE_FLAGS.setTrustLineFlagsResult = SetTrustLineFlagsResultXdr.Decode(stream);
                    return result_SET_TRUST_LINE_FLAGS;
                    case OperationType.LIQUIDITY_POOL_DEPOSIT:
                    var result_LIQUIDITY_POOL_DEPOSIT = new trUnion.LiquidityPoolDeposit();
                    result_LIQUIDITY_POOL_DEPOSIT.liquidityPoolDepositResult = LiquidityPoolDepositResultXdr.Decode(stream);
                    return result_LIQUIDITY_POOL_DEPOSIT;
                    case OperationType.LIQUIDITY_POOL_WITHDRAW:
                    var result_LIQUIDITY_POOL_WITHDRAW = new trUnion.LiquidityPoolWithdraw();
                    result_LIQUIDITY_POOL_WITHDRAW.liquidityPoolWithdrawResult = LiquidityPoolWithdrawResultXdr.Decode(stream);
                    return result_LIQUIDITY_POOL_WITHDRAW;
                    case OperationType.INVOKE_HOST_FUNCTION:
                    var result_INVOKE_HOST_FUNCTION = new trUnion.InvokeHostFunction();
                    result_INVOKE_HOST_FUNCTION.invokeHostFunctionResult = InvokeHostFunctionResultXdr.Decode(stream);
                    return result_INVOKE_HOST_FUNCTION;
                    case OperationType.EXTEND_FOOTPRINT_TTL:
                    var result_EXTEND_FOOTPRINT_TTL = new trUnion.ExtendFootprintTtl();
                    result_EXTEND_FOOTPRINT_TTL.extendFootprintTTLResult = ExtendFootprintTTLResultXdr.Decode(stream);
                    return result_EXTEND_FOOTPRINT_TTL;
                    case OperationType.RESTORE_FOOTPRINT:
                    var result_RESTORE_FOOTPRINT = new trUnion.RestoreFootprint();
                    result_RESTORE_FOOTPRINT.restoreFootprintResult = RestoreFootprintResultXdr.Decode(stream);
                    return result_RESTORE_FOOTPRINT;
                    default:
                    throw new Exception($"Unknown discriminator for trUnion: {discriminator}");
                }
            }
        }
        [System.Serializable]
        public sealed partial class OpINNER : OperationResult
        {
            public override OperationResultCode Discriminator => OperationResultCode.opINNER;
            public trUnion tr
            {
                get => _tr;
                set
                {
                    _tr = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Tr")]
            #endif
            private trUnion _tr;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class OpbadAuth : OperationResult
        {
            public override OperationResultCode Discriminator => OperationResultCode.opBAD_AUTH;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class OpnoAccount : OperationResult
        {
            public override OperationResultCode Discriminator => OperationResultCode.opNO_ACCOUNT;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class OpnotSupported : OperationResult
        {
            public override OperationResultCode Discriminator => OperationResultCode.opNOT_SUPPORTED;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class OptooManySubentries : OperationResult
        {
            public override OperationResultCode Discriminator => OperationResultCode.opTOO_MANY_SUBENTRIES;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class OpexceededWorkLimit : OperationResult
        {
            public override OperationResultCode Discriminator => OperationResultCode.opEXCEEDED_WORK_LIMIT;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class OptooManySponsoring : OperationResult
        {
            public override OperationResultCode Discriminator => OperationResultCode.opTOO_MANY_SPONSORING;

            public override void ValidateCase() {}
        }
    }
    public static partial class OperationResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(OperationResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                OperationResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, OperationResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case OperationResult.OpINNER case_opINNER:
                OperationResult.trUnionXdr.Encode(stream, case_opINNER.tr);
                break;
                case OperationResult.OpbadAuth case_opBAD_AUTH:
                break;
                case OperationResult.OpnoAccount case_opNO_ACCOUNT:
                break;
                case OperationResult.OpnotSupported case_opNOT_SUPPORTED:
                break;
                case OperationResult.OptooManySubentries case_opTOO_MANY_SUBENTRIES:
                break;
                case OperationResult.OpexceededWorkLimit case_opEXCEEDED_WORK_LIMIT:
                break;
                case OperationResult.OptooManySponsoring case_opTOO_MANY_SPONSORING:
                break;
            }
        }
        public static OperationResult Decode(XdrReader stream)
        {
            var discriminator = (OperationResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case OperationResultCode.opINNER:
                var result_opINNER = new OperationResult.OpINNER();
                result_opINNER.tr = OperationResult.trUnionXdr.Decode(stream);
                return result_opINNER;
                case OperationResultCode.opBAD_AUTH:
                var result_opBAD_AUTH = new OperationResult.OpbadAuth();
                return result_opBAD_AUTH;
                case OperationResultCode.opNO_ACCOUNT:
                var result_opNO_ACCOUNT = new OperationResult.OpnoAccount();
                return result_opNO_ACCOUNT;
                case OperationResultCode.opNOT_SUPPORTED:
                var result_opNOT_SUPPORTED = new OperationResult.OpnotSupported();
                return result_opNOT_SUPPORTED;
                case OperationResultCode.opTOO_MANY_SUBENTRIES:
                var result_opTOO_MANY_SUBENTRIES = new OperationResult.OptooManySubentries();
                return result_opTOO_MANY_SUBENTRIES;
                case OperationResultCode.opEXCEEDED_WORK_LIMIT:
                var result_opEXCEEDED_WORK_LIMIT = new OperationResult.OpexceededWorkLimit();
                return result_opEXCEEDED_WORK_LIMIT;
                case OperationResultCode.opTOO_MANY_SPONSORING:
                var result_opTOO_MANY_SPONSORING = new OperationResult.OptooManySponsoring();
                return result_opTOO_MANY_SPONSORING;
                default:
                throw new Exception($"Unknown discriminator for OperationResult: {discriminator}");
            }
        }
    }
}
