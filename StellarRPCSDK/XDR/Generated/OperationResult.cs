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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class OperationResult
    {
        public abstract OperationResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class trUnion
        {
            public abstract OperationType Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

        }
        public sealed partial class trUnion_CREATE_ACCOUNT : trUnion
        {
            public override OperationType Discriminator => OperationType.CREATE_ACCOUNT;
            private CreateAccountResult _createAccountResult;
            public CreateAccountResult createAccountResult
            {
                get => _createAccountResult;
                set
                {
                    _createAccountResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_PAYMENT : trUnion
        {
            public override OperationType Discriminator => OperationType.PAYMENT;
            private PaymentResult _paymentResult;
            public PaymentResult paymentResult
            {
                get => _paymentResult;
                set
                {
                    _paymentResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_PATH_PAYMENT_STRICT_RECEIVE : trUnion
        {
            public override OperationType Discriminator => OperationType.PATH_PAYMENT_STRICT_RECEIVE;
            private PathPaymentStrictReceiveResult _pathPaymentStrictReceiveResult;
            public PathPaymentStrictReceiveResult pathPaymentStrictReceiveResult
            {
                get => _pathPaymentStrictReceiveResult;
                set
                {
                    _pathPaymentStrictReceiveResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_MANAGE_SELL_OFFER : trUnion
        {
            public override OperationType Discriminator => OperationType.MANAGE_SELL_OFFER;
            private ManageSellOfferResult _manageSellOfferResult;
            public ManageSellOfferResult manageSellOfferResult
            {
                get => _manageSellOfferResult;
                set
                {
                    _manageSellOfferResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_CREATE_PASSIVE_SELL_OFFER : trUnion
        {
            public override OperationType Discriminator => OperationType.CREATE_PASSIVE_SELL_OFFER;
            private ManageSellOfferResult _createPassiveSellOfferResult;
            public ManageSellOfferResult createPassiveSellOfferResult
            {
                get => _createPassiveSellOfferResult;
                set
                {
                    _createPassiveSellOfferResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_SET_OPTIONS : trUnion
        {
            public override OperationType Discriminator => OperationType.SET_OPTIONS;
            private SetOptionsResult _setOptionsResult;
            public SetOptionsResult setOptionsResult
            {
                get => _setOptionsResult;
                set
                {
                    _setOptionsResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_CHANGE_TRUST : trUnion
        {
            public override OperationType Discriminator => OperationType.CHANGE_TRUST;
            private ChangeTrustResult _changeTrustResult;
            public ChangeTrustResult changeTrustResult
            {
                get => _changeTrustResult;
                set
                {
                    _changeTrustResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_ALLOW_TRUST : trUnion
        {
            public override OperationType Discriminator => OperationType.ALLOW_TRUST;
            private AllowTrustResult _allowTrustResult;
            public AllowTrustResult allowTrustResult
            {
                get => _allowTrustResult;
                set
                {
                    _allowTrustResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_ACCOUNT_MERGE : trUnion
        {
            public override OperationType Discriminator => OperationType.ACCOUNT_MERGE;
            private AccountMergeResult _accountMergeResult;
            public AccountMergeResult accountMergeResult
            {
                get => _accountMergeResult;
                set
                {
                    _accountMergeResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_INFLATION : trUnion
        {
            public override OperationType Discriminator => OperationType.INFLATION;
            private InflationResult _inflationResult;
            public InflationResult inflationResult
            {
                get => _inflationResult;
                set
                {
                    _inflationResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_MANAGE_DATA : trUnion
        {
            public override OperationType Discriminator => OperationType.MANAGE_DATA;
            private ManageDataResult _manageDataResult;
            public ManageDataResult manageDataResult
            {
                get => _manageDataResult;
                set
                {
                    _manageDataResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_BUMP_SEQUENCE : trUnion
        {
            public override OperationType Discriminator => OperationType.BUMP_SEQUENCE;
            private BumpSequenceResult _bumpSeqResult;
            public BumpSequenceResult bumpSeqResult
            {
                get => _bumpSeqResult;
                set
                {
                    _bumpSeqResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_MANAGE_BUY_OFFER : trUnion
        {
            public override OperationType Discriminator => OperationType.MANAGE_BUY_OFFER;
            private ManageBuyOfferResult _manageBuyOfferResult;
            public ManageBuyOfferResult manageBuyOfferResult
            {
                get => _manageBuyOfferResult;
                set
                {
                    _manageBuyOfferResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_PATH_PAYMENT_STRICT_SEND : trUnion
        {
            public override OperationType Discriminator => OperationType.PATH_PAYMENT_STRICT_SEND;
            private PathPaymentStrictSendResult _pathPaymentStrictSendResult;
            public PathPaymentStrictSendResult pathPaymentStrictSendResult
            {
                get => _pathPaymentStrictSendResult;
                set
                {
                    _pathPaymentStrictSendResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_CREATE_CLAIMABLE_BALANCE : trUnion
        {
            public override OperationType Discriminator => OperationType.CREATE_CLAIMABLE_BALANCE;
            private CreateClaimableBalanceResult _createClaimableBalanceResult;
            public CreateClaimableBalanceResult createClaimableBalanceResult
            {
                get => _createClaimableBalanceResult;
                set
                {
                    _createClaimableBalanceResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_CLAIM_CLAIMABLE_BALANCE : trUnion
        {
            public override OperationType Discriminator => OperationType.CLAIM_CLAIMABLE_BALANCE;
            private ClaimClaimableBalanceResult _claimClaimableBalanceResult;
            public ClaimClaimableBalanceResult claimClaimableBalanceResult
            {
                get => _claimClaimableBalanceResult;
                set
                {
                    _claimClaimableBalanceResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_BEGIN_SPONSORING_FUTURE_RESERVES : trUnion
        {
            public override OperationType Discriminator => OperationType.BEGIN_SPONSORING_FUTURE_RESERVES;
            private BeginSponsoringFutureReservesResult _beginSponsoringFutureReservesResult;
            public BeginSponsoringFutureReservesResult beginSponsoringFutureReservesResult
            {
                get => _beginSponsoringFutureReservesResult;
                set
                {
                    _beginSponsoringFutureReservesResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_END_SPONSORING_FUTURE_RESERVES : trUnion
        {
            public override OperationType Discriminator => OperationType.END_SPONSORING_FUTURE_RESERVES;
            private EndSponsoringFutureReservesResult _endSponsoringFutureReservesResult;
            public EndSponsoringFutureReservesResult endSponsoringFutureReservesResult
            {
                get => _endSponsoringFutureReservesResult;
                set
                {
                    _endSponsoringFutureReservesResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_REVOKE_SPONSORSHIP : trUnion
        {
            public override OperationType Discriminator => OperationType.REVOKE_SPONSORSHIP;
            private RevokeSponsorshipResult _revokeSponsorshipResult;
            public RevokeSponsorshipResult revokeSponsorshipResult
            {
                get => _revokeSponsorshipResult;
                set
                {
                    _revokeSponsorshipResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_CLAWBACK : trUnion
        {
            public override OperationType Discriminator => OperationType.CLAWBACK;
            private ClawbackResult _clawbackResult;
            public ClawbackResult clawbackResult
            {
                get => _clawbackResult;
                set
                {
                    _clawbackResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_CLAWBACK_CLAIMABLE_BALANCE : trUnion
        {
            public override OperationType Discriminator => OperationType.CLAWBACK_CLAIMABLE_BALANCE;
            private ClawbackClaimableBalanceResult _clawbackClaimableBalanceResult;
            public ClawbackClaimableBalanceResult clawbackClaimableBalanceResult
            {
                get => _clawbackClaimableBalanceResult;
                set
                {
                    _clawbackClaimableBalanceResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_SET_TRUST_LINE_FLAGS : trUnion
        {
            public override OperationType Discriminator => OperationType.SET_TRUST_LINE_FLAGS;
            private SetTrustLineFlagsResult _setTrustLineFlagsResult;
            public SetTrustLineFlagsResult setTrustLineFlagsResult
            {
                get => _setTrustLineFlagsResult;
                set
                {
                    _setTrustLineFlagsResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_LIQUIDITY_POOL_DEPOSIT : trUnion
        {
            public override OperationType Discriminator => OperationType.LIQUIDITY_POOL_DEPOSIT;
            private LiquidityPoolDepositResult _liquidityPoolDepositResult;
            public LiquidityPoolDepositResult liquidityPoolDepositResult
            {
                get => _liquidityPoolDepositResult;
                set
                {
                    _liquidityPoolDepositResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_LIQUIDITY_POOL_WITHDRAW : trUnion
        {
            public override OperationType Discriminator => OperationType.LIQUIDITY_POOL_WITHDRAW;
            private LiquidityPoolWithdrawResult _liquidityPoolWithdrawResult;
            public LiquidityPoolWithdrawResult liquidityPoolWithdrawResult
            {
                get => _liquidityPoolWithdrawResult;
                set
                {
                    _liquidityPoolWithdrawResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_INVOKE_HOST_FUNCTION : trUnion
        {
            public override OperationType Discriminator => OperationType.INVOKE_HOST_FUNCTION;
            private InvokeHostFunctionResult _invokeHostFunctionResult;
            public InvokeHostFunctionResult invokeHostFunctionResult
            {
                get => _invokeHostFunctionResult;
                set
                {
                    _invokeHostFunctionResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_EXTEND_FOOTPRINT_TTL : trUnion
        {
            public override OperationType Discriminator => OperationType.EXTEND_FOOTPRINT_TTL;
            private ExtendFootprintTTLResult _extendFootprintTTLResult;
            public ExtendFootprintTTLResult extendFootprintTTLResult
            {
                get => _extendFootprintTTLResult;
                set
                {
                    _extendFootprintTTLResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class trUnion_RESTORE_FOOTPRINT : trUnion
        {
            public override OperationType Discriminator => OperationType.RESTORE_FOOTPRINT;
            private RestoreFootprintResult _restoreFootprintResult;
            public RestoreFootprintResult restoreFootprintResult
            {
                get => _restoreFootprintResult;
                set
                {
                    _restoreFootprintResult = value;
                }
            }

            public override void ValidateCase() {}
        }
        public static partial class trUnionXdr
        {
            public static void Encode(XdrWriter stream, trUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case trUnion_CREATE_ACCOUNT case_CREATE_ACCOUNT:
                    CreateAccountResultXdr.Encode(stream, case_CREATE_ACCOUNT.createAccountResult);
                    break;
                    case trUnion_PAYMENT case_PAYMENT:
                    PaymentResultXdr.Encode(stream, case_PAYMENT.paymentResult);
                    break;
                    case trUnion_PATH_PAYMENT_STRICT_RECEIVE case_PATH_PAYMENT_STRICT_RECEIVE:
                    PathPaymentStrictReceiveResultXdr.Encode(stream, case_PATH_PAYMENT_STRICT_RECEIVE.pathPaymentStrictReceiveResult);
                    break;
                    case trUnion_MANAGE_SELL_OFFER case_MANAGE_SELL_OFFER:
                    ManageSellOfferResultXdr.Encode(stream, case_MANAGE_SELL_OFFER.manageSellOfferResult);
                    break;
                    case trUnion_CREATE_PASSIVE_SELL_OFFER case_CREATE_PASSIVE_SELL_OFFER:
                    ManageSellOfferResultXdr.Encode(stream, case_CREATE_PASSIVE_SELL_OFFER.createPassiveSellOfferResult);
                    break;
                    case trUnion_SET_OPTIONS case_SET_OPTIONS:
                    SetOptionsResultXdr.Encode(stream, case_SET_OPTIONS.setOptionsResult);
                    break;
                    case trUnion_CHANGE_TRUST case_CHANGE_TRUST:
                    ChangeTrustResultXdr.Encode(stream, case_CHANGE_TRUST.changeTrustResult);
                    break;
                    case trUnion_ALLOW_TRUST case_ALLOW_TRUST:
                    AllowTrustResultXdr.Encode(stream, case_ALLOW_TRUST.allowTrustResult);
                    break;
                    case trUnion_ACCOUNT_MERGE case_ACCOUNT_MERGE:
                    AccountMergeResultXdr.Encode(stream, case_ACCOUNT_MERGE.accountMergeResult);
                    break;
                    case trUnion_INFLATION case_INFLATION:
                    InflationResultXdr.Encode(stream, case_INFLATION.inflationResult);
                    break;
                    case trUnion_MANAGE_DATA case_MANAGE_DATA:
                    ManageDataResultXdr.Encode(stream, case_MANAGE_DATA.manageDataResult);
                    break;
                    case trUnion_BUMP_SEQUENCE case_BUMP_SEQUENCE:
                    BumpSequenceResultXdr.Encode(stream, case_BUMP_SEQUENCE.bumpSeqResult);
                    break;
                    case trUnion_MANAGE_BUY_OFFER case_MANAGE_BUY_OFFER:
                    ManageBuyOfferResultXdr.Encode(stream, case_MANAGE_BUY_OFFER.manageBuyOfferResult);
                    break;
                    case trUnion_PATH_PAYMENT_STRICT_SEND case_PATH_PAYMENT_STRICT_SEND:
                    PathPaymentStrictSendResultXdr.Encode(stream, case_PATH_PAYMENT_STRICT_SEND.pathPaymentStrictSendResult);
                    break;
                    case trUnion_CREATE_CLAIMABLE_BALANCE case_CREATE_CLAIMABLE_BALANCE:
                    CreateClaimableBalanceResultXdr.Encode(stream, case_CREATE_CLAIMABLE_BALANCE.createClaimableBalanceResult);
                    break;
                    case trUnion_CLAIM_CLAIMABLE_BALANCE case_CLAIM_CLAIMABLE_BALANCE:
                    ClaimClaimableBalanceResultXdr.Encode(stream, case_CLAIM_CLAIMABLE_BALANCE.claimClaimableBalanceResult);
                    break;
                    case trUnion_BEGIN_SPONSORING_FUTURE_RESERVES case_BEGIN_SPONSORING_FUTURE_RESERVES:
                    BeginSponsoringFutureReservesResultXdr.Encode(stream, case_BEGIN_SPONSORING_FUTURE_RESERVES.beginSponsoringFutureReservesResult);
                    break;
                    case trUnion_END_SPONSORING_FUTURE_RESERVES case_END_SPONSORING_FUTURE_RESERVES:
                    EndSponsoringFutureReservesResultXdr.Encode(stream, case_END_SPONSORING_FUTURE_RESERVES.endSponsoringFutureReservesResult);
                    break;
                    case trUnion_REVOKE_SPONSORSHIP case_REVOKE_SPONSORSHIP:
                    RevokeSponsorshipResultXdr.Encode(stream, case_REVOKE_SPONSORSHIP.revokeSponsorshipResult);
                    break;
                    case trUnion_CLAWBACK case_CLAWBACK:
                    ClawbackResultXdr.Encode(stream, case_CLAWBACK.clawbackResult);
                    break;
                    case trUnion_CLAWBACK_CLAIMABLE_BALANCE case_CLAWBACK_CLAIMABLE_BALANCE:
                    ClawbackClaimableBalanceResultXdr.Encode(stream, case_CLAWBACK_CLAIMABLE_BALANCE.clawbackClaimableBalanceResult);
                    break;
                    case trUnion_SET_TRUST_LINE_FLAGS case_SET_TRUST_LINE_FLAGS:
                    SetTrustLineFlagsResultXdr.Encode(stream, case_SET_TRUST_LINE_FLAGS.setTrustLineFlagsResult);
                    break;
                    case trUnion_LIQUIDITY_POOL_DEPOSIT case_LIQUIDITY_POOL_DEPOSIT:
                    LiquidityPoolDepositResultXdr.Encode(stream, case_LIQUIDITY_POOL_DEPOSIT.liquidityPoolDepositResult);
                    break;
                    case trUnion_LIQUIDITY_POOL_WITHDRAW case_LIQUIDITY_POOL_WITHDRAW:
                    LiquidityPoolWithdrawResultXdr.Encode(stream, case_LIQUIDITY_POOL_WITHDRAW.liquidityPoolWithdrawResult);
                    break;
                    case trUnion_INVOKE_HOST_FUNCTION case_INVOKE_HOST_FUNCTION:
                    InvokeHostFunctionResultXdr.Encode(stream, case_INVOKE_HOST_FUNCTION.invokeHostFunctionResult);
                    break;
                    case trUnion_EXTEND_FOOTPRINT_TTL case_EXTEND_FOOTPRINT_TTL:
                    ExtendFootprintTTLResultXdr.Encode(stream, case_EXTEND_FOOTPRINT_TTL.extendFootprintTTLResult);
                    break;
                    case trUnion_RESTORE_FOOTPRINT case_RESTORE_FOOTPRINT:
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
                    var result_CREATE_ACCOUNT = new trUnion_CREATE_ACCOUNT();
                    result_CREATE_ACCOUNT.createAccountResult = CreateAccountResultXdr.Decode(stream);
                    return result_CREATE_ACCOUNT;
                    case OperationType.PAYMENT:
                    var result_PAYMENT = new trUnion_PAYMENT();
                    result_PAYMENT.paymentResult = PaymentResultXdr.Decode(stream);
                    return result_PAYMENT;
                    case OperationType.PATH_PAYMENT_STRICT_RECEIVE:
                    var result_PATH_PAYMENT_STRICT_RECEIVE = new trUnion_PATH_PAYMENT_STRICT_RECEIVE();
                    result_PATH_PAYMENT_STRICT_RECEIVE.pathPaymentStrictReceiveResult = PathPaymentStrictReceiveResultXdr.Decode(stream);
                    return result_PATH_PAYMENT_STRICT_RECEIVE;
                    case OperationType.MANAGE_SELL_OFFER:
                    var result_MANAGE_SELL_OFFER = new trUnion_MANAGE_SELL_OFFER();
                    result_MANAGE_SELL_OFFER.manageSellOfferResult = ManageSellOfferResultXdr.Decode(stream);
                    return result_MANAGE_SELL_OFFER;
                    case OperationType.CREATE_PASSIVE_SELL_OFFER:
                    var result_CREATE_PASSIVE_SELL_OFFER = new trUnion_CREATE_PASSIVE_SELL_OFFER();
                    result_CREATE_PASSIVE_SELL_OFFER.createPassiveSellOfferResult = ManageSellOfferResultXdr.Decode(stream);
                    return result_CREATE_PASSIVE_SELL_OFFER;
                    case OperationType.SET_OPTIONS:
                    var result_SET_OPTIONS = new trUnion_SET_OPTIONS();
                    result_SET_OPTIONS.setOptionsResult = SetOptionsResultXdr.Decode(stream);
                    return result_SET_OPTIONS;
                    case OperationType.CHANGE_TRUST:
                    var result_CHANGE_TRUST = new trUnion_CHANGE_TRUST();
                    result_CHANGE_TRUST.changeTrustResult = ChangeTrustResultXdr.Decode(stream);
                    return result_CHANGE_TRUST;
                    case OperationType.ALLOW_TRUST:
                    var result_ALLOW_TRUST = new trUnion_ALLOW_TRUST();
                    result_ALLOW_TRUST.allowTrustResult = AllowTrustResultXdr.Decode(stream);
                    return result_ALLOW_TRUST;
                    case OperationType.ACCOUNT_MERGE:
                    var result_ACCOUNT_MERGE = new trUnion_ACCOUNT_MERGE();
                    result_ACCOUNT_MERGE.accountMergeResult = AccountMergeResultXdr.Decode(stream);
                    return result_ACCOUNT_MERGE;
                    case OperationType.INFLATION:
                    var result_INFLATION = new trUnion_INFLATION();
                    result_INFLATION.inflationResult = InflationResultXdr.Decode(stream);
                    return result_INFLATION;
                    case OperationType.MANAGE_DATA:
                    var result_MANAGE_DATA = new trUnion_MANAGE_DATA();
                    result_MANAGE_DATA.manageDataResult = ManageDataResultXdr.Decode(stream);
                    return result_MANAGE_DATA;
                    case OperationType.BUMP_SEQUENCE:
                    var result_BUMP_SEQUENCE = new trUnion_BUMP_SEQUENCE();
                    result_BUMP_SEQUENCE.bumpSeqResult = BumpSequenceResultXdr.Decode(stream);
                    return result_BUMP_SEQUENCE;
                    case OperationType.MANAGE_BUY_OFFER:
                    var result_MANAGE_BUY_OFFER = new trUnion_MANAGE_BUY_OFFER();
                    result_MANAGE_BUY_OFFER.manageBuyOfferResult = ManageBuyOfferResultXdr.Decode(stream);
                    return result_MANAGE_BUY_OFFER;
                    case OperationType.PATH_PAYMENT_STRICT_SEND:
                    var result_PATH_PAYMENT_STRICT_SEND = new trUnion_PATH_PAYMENT_STRICT_SEND();
                    result_PATH_PAYMENT_STRICT_SEND.pathPaymentStrictSendResult = PathPaymentStrictSendResultXdr.Decode(stream);
                    return result_PATH_PAYMENT_STRICT_SEND;
                    case OperationType.CREATE_CLAIMABLE_BALANCE:
                    var result_CREATE_CLAIMABLE_BALANCE = new trUnion_CREATE_CLAIMABLE_BALANCE();
                    result_CREATE_CLAIMABLE_BALANCE.createClaimableBalanceResult = CreateClaimableBalanceResultXdr.Decode(stream);
                    return result_CREATE_CLAIMABLE_BALANCE;
                    case OperationType.CLAIM_CLAIMABLE_BALANCE:
                    var result_CLAIM_CLAIMABLE_BALANCE = new trUnion_CLAIM_CLAIMABLE_BALANCE();
                    result_CLAIM_CLAIMABLE_BALANCE.claimClaimableBalanceResult = ClaimClaimableBalanceResultXdr.Decode(stream);
                    return result_CLAIM_CLAIMABLE_BALANCE;
                    case OperationType.BEGIN_SPONSORING_FUTURE_RESERVES:
                    var result_BEGIN_SPONSORING_FUTURE_RESERVES = new trUnion_BEGIN_SPONSORING_FUTURE_RESERVES();
                    result_BEGIN_SPONSORING_FUTURE_RESERVES.beginSponsoringFutureReservesResult = BeginSponsoringFutureReservesResultXdr.Decode(stream);
                    return result_BEGIN_SPONSORING_FUTURE_RESERVES;
                    case OperationType.END_SPONSORING_FUTURE_RESERVES:
                    var result_END_SPONSORING_FUTURE_RESERVES = new trUnion_END_SPONSORING_FUTURE_RESERVES();
                    result_END_SPONSORING_FUTURE_RESERVES.endSponsoringFutureReservesResult = EndSponsoringFutureReservesResultXdr.Decode(stream);
                    return result_END_SPONSORING_FUTURE_RESERVES;
                    case OperationType.REVOKE_SPONSORSHIP:
                    var result_REVOKE_SPONSORSHIP = new trUnion_REVOKE_SPONSORSHIP();
                    result_REVOKE_SPONSORSHIP.revokeSponsorshipResult = RevokeSponsorshipResultXdr.Decode(stream);
                    return result_REVOKE_SPONSORSHIP;
                    case OperationType.CLAWBACK:
                    var result_CLAWBACK = new trUnion_CLAWBACK();
                    result_CLAWBACK.clawbackResult = ClawbackResultXdr.Decode(stream);
                    return result_CLAWBACK;
                    case OperationType.CLAWBACK_CLAIMABLE_BALANCE:
                    var result_CLAWBACK_CLAIMABLE_BALANCE = new trUnion_CLAWBACK_CLAIMABLE_BALANCE();
                    result_CLAWBACK_CLAIMABLE_BALANCE.clawbackClaimableBalanceResult = ClawbackClaimableBalanceResultXdr.Decode(stream);
                    return result_CLAWBACK_CLAIMABLE_BALANCE;
                    case OperationType.SET_TRUST_LINE_FLAGS:
                    var result_SET_TRUST_LINE_FLAGS = new trUnion_SET_TRUST_LINE_FLAGS();
                    result_SET_TRUST_LINE_FLAGS.setTrustLineFlagsResult = SetTrustLineFlagsResultXdr.Decode(stream);
                    return result_SET_TRUST_LINE_FLAGS;
                    case OperationType.LIQUIDITY_POOL_DEPOSIT:
                    var result_LIQUIDITY_POOL_DEPOSIT = new trUnion_LIQUIDITY_POOL_DEPOSIT();
                    result_LIQUIDITY_POOL_DEPOSIT.liquidityPoolDepositResult = LiquidityPoolDepositResultXdr.Decode(stream);
                    return result_LIQUIDITY_POOL_DEPOSIT;
                    case OperationType.LIQUIDITY_POOL_WITHDRAW:
                    var result_LIQUIDITY_POOL_WITHDRAW = new trUnion_LIQUIDITY_POOL_WITHDRAW();
                    result_LIQUIDITY_POOL_WITHDRAW.liquidityPoolWithdrawResult = LiquidityPoolWithdrawResultXdr.Decode(stream);
                    return result_LIQUIDITY_POOL_WITHDRAW;
                    case OperationType.INVOKE_HOST_FUNCTION:
                    var result_INVOKE_HOST_FUNCTION = new trUnion_INVOKE_HOST_FUNCTION();
                    result_INVOKE_HOST_FUNCTION.invokeHostFunctionResult = InvokeHostFunctionResultXdr.Decode(stream);
                    return result_INVOKE_HOST_FUNCTION;
                    case OperationType.EXTEND_FOOTPRINT_TTL:
                    var result_EXTEND_FOOTPRINT_TTL = new trUnion_EXTEND_FOOTPRINT_TTL();
                    result_EXTEND_FOOTPRINT_TTL.extendFootprintTTLResult = ExtendFootprintTTLResultXdr.Decode(stream);
                    return result_EXTEND_FOOTPRINT_TTL;
                    case OperationType.RESTORE_FOOTPRINT:
                    var result_RESTORE_FOOTPRINT = new trUnion_RESTORE_FOOTPRINT();
                    result_RESTORE_FOOTPRINT.restoreFootprintResult = RestoreFootprintResultXdr.Decode(stream);
                    return result_RESTORE_FOOTPRINT;
                    default:
                    throw new Exception($"Unknown discriminator for trUnion: {discriminator}");
                }
            }
        }
    }
    public sealed partial class OperationResult_opINNER : OperationResult
    {
        public override OperationResultCode Discriminator => OperationResultCode.opINNER;
        private trUnion _tr;
        public trUnion tr
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
        public override OperationResultCode Discriminator => OperationResultCode.opBAD_AUTH;

        public override void ValidateCase() {}
    }
    public sealed partial class OperationResult_opNO_ACCOUNT : OperationResult
    {
        public override OperationResultCode Discriminator => OperationResultCode.opNO_ACCOUNT;

        public override void ValidateCase() {}
    }
    public sealed partial class OperationResult_opNOT_SUPPORTED : OperationResult
    {
        public override OperationResultCode Discriminator => OperationResultCode.opNOT_SUPPORTED;

        public override void ValidateCase() {}
    }
    public sealed partial class OperationResult_opTOO_MANY_SUBENTRIES : OperationResult
    {
        public override OperationResultCode Discriminator => OperationResultCode.opTOO_MANY_SUBENTRIES;

        public override void ValidateCase() {}
    }
    public sealed partial class OperationResult_opEXCEEDED_WORK_LIMIT : OperationResult
    {
        public override OperationResultCode Discriminator => OperationResultCode.opEXCEEDED_WORK_LIMIT;

        public override void ValidateCase() {}
    }
    public sealed partial class OperationResult_opTOO_MANY_SPONSORING : OperationResult
    {
        public override OperationResultCode Discriminator => OperationResultCode.opTOO_MANY_SPONSORING;

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
                OperationResult.trUnionXdr.Encode(stream, case_opINNER.tr);
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
                case OperationResultCode.opINNER:
                var result_opINNER = new OperationResult_opINNER();
                result_opINNER.tr = OperationResult.trUnionXdr.Decode(stream);
                return result_opINNER;
                case OperationResultCode.opBAD_AUTH:
                var result_opBAD_AUTH = new OperationResult_opBAD_AUTH();
                return result_opBAD_AUTH;
                case OperationResultCode.opNO_ACCOUNT:
                var result_opNO_ACCOUNT = new OperationResult_opNO_ACCOUNT();
                return result_opNO_ACCOUNT;
                case OperationResultCode.opNOT_SUPPORTED:
                var result_opNOT_SUPPORTED = new OperationResult_opNOT_SUPPORTED();
                return result_opNOT_SUPPORTED;
                case OperationResultCode.opTOO_MANY_SUBENTRIES:
                var result_opTOO_MANY_SUBENTRIES = new OperationResult_opTOO_MANY_SUBENTRIES();
                return result_opTOO_MANY_SUBENTRIES;
                case OperationResultCode.opEXCEEDED_WORK_LIMIT:
                var result_opEXCEEDED_WORK_LIMIT = new OperationResult_opEXCEEDED_WORK_LIMIT();
                return result_opEXCEEDED_WORK_LIMIT;
                case OperationResultCode.opTOO_MANY_SPONSORING:
                var result_opTOO_MANY_SPONSORING = new OperationResult_opTOO_MANY_SPONSORING();
                return result_opTOO_MANY_SPONSORING;
                default:
                throw new Exception($"Unknown discriminator for OperationResult: {discriminator}");
            }
        }
    }
}
