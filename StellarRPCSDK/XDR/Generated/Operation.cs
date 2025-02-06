// Generated code - do not modify
// Source:

// struct Operation
// {
//     // sourceAccount is the account used to run the operation
//     // if not set, the runtime defaults to "sourceAccount" specified at
//     // the transaction level
//     MuxedAccount* sourceAccount;
// 
//     union switch (OperationType type)
//     {
//     case CREATE_ACCOUNT:
//         CreateAccountOp createAccountOp;
//     case PAYMENT:
//         PaymentOp paymentOp;
//     case PATH_PAYMENT_STRICT_RECEIVE:
//         PathPaymentStrictReceiveOp pathPaymentStrictReceiveOp;
//     case MANAGE_SELL_OFFER:
//         ManageSellOfferOp manageSellOfferOp;
//     case CREATE_PASSIVE_SELL_OFFER:
//         CreatePassiveSellOfferOp createPassiveSellOfferOp;
//     case SET_OPTIONS:
//         SetOptionsOp setOptionsOp;
//     case CHANGE_TRUST:
//         ChangeTrustOp changeTrustOp;
//     case ALLOW_TRUST:
//         AllowTrustOp allowTrustOp;
//     case ACCOUNT_MERGE:
//         MuxedAccount destination;
//     case INFLATION:
//         void;
//     case MANAGE_DATA:
//         ManageDataOp manageDataOp;
//     case BUMP_SEQUENCE:
//         BumpSequenceOp bumpSequenceOp;
//     case MANAGE_BUY_OFFER:
//         ManageBuyOfferOp manageBuyOfferOp;
//     case PATH_PAYMENT_STRICT_SEND:
//         PathPaymentStrictSendOp pathPaymentStrictSendOp;
//     case CREATE_CLAIMABLE_BALANCE:
//         CreateClaimableBalanceOp createClaimableBalanceOp;
//     case CLAIM_CLAIMABLE_BALANCE:
//         ClaimClaimableBalanceOp claimClaimableBalanceOp;
//     case BEGIN_SPONSORING_FUTURE_RESERVES:
//         BeginSponsoringFutureReservesOp beginSponsoringFutureReservesOp;
//     case END_SPONSORING_FUTURE_RESERVES:
//         void;
//     case REVOKE_SPONSORSHIP:
//         RevokeSponsorshipOp revokeSponsorshipOp;
//     case CLAWBACK:
//         ClawbackOp clawbackOp;
//     case CLAWBACK_CLAIMABLE_BALANCE:
//         ClawbackClaimableBalanceOp clawbackClaimableBalanceOp;
//     case SET_TRUST_LINE_FLAGS:
//         SetTrustLineFlagsOp setTrustLineFlagsOp;
//     case LIQUIDITY_POOL_DEPOSIT:
//         LiquidityPoolDepositOp liquidityPoolDepositOp;
//     case LIQUIDITY_POOL_WITHDRAW:
//         LiquidityPoolWithdrawOp liquidityPoolWithdrawOp;
//     case INVOKE_HOST_FUNCTION:
//         InvokeHostFunctionOp invokeHostFunctionOp;
//     case EXTEND_FOOTPRINT_TTL:
//         ExtendFootprintTTLOp extendFootprintTTLOp;
//     case RESTORE_FOOTPRINT:
//         RestoreFootprintOp restoreFootprintOp;
//     }
//     body;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    /// <summary>
    /// An operation is the lowest unit of work that a transaction does
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class Operation
    {
        /// <summary>
        /// the transaction level
        /// </summary>
        public MuxedAccount sourceAccount
        {
            get => _sourceAccount;
            set
            {
                _sourceAccount = value;
            }
        }
        private MuxedAccount _sourceAccount;

        public bodyUnion body
        {
            get => _body;
            set
            {
                _body = value;
            }
        }
        private bodyUnion _body;

        public Operation()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class bodyUnion
        {
            public abstract OperationType Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            public sealed partial class CreateAccount : bodyUnion
            {
                public override OperationType Discriminator => OperationType.CREATE_ACCOUNT;
                public CreateAccountOp createAccountOp
                {
                    get => _createAccountOp;
                    set
                    {
                        _createAccountOp = value;
                    }
                }
                private CreateAccountOp _createAccountOp;

                public override void ValidateCase() {}
            }
            public sealed partial class Payment : bodyUnion
            {
                public override OperationType Discriminator => OperationType.PAYMENT;
                public PaymentOp paymentOp
                {
                    get => _paymentOp;
                    set
                    {
                        _paymentOp = value;
                    }
                }
                private PaymentOp _paymentOp;

                public override void ValidateCase() {}
            }
            public sealed partial class PathPaymentStrictReceive : bodyUnion
            {
                public override OperationType Discriminator => OperationType.PATH_PAYMENT_STRICT_RECEIVE;
                public PathPaymentStrictReceiveOp pathPaymentStrictReceiveOp
                {
                    get => _pathPaymentStrictReceiveOp;
                    set
                    {
                        _pathPaymentStrictReceiveOp = value;
                    }
                }
                private PathPaymentStrictReceiveOp _pathPaymentStrictReceiveOp;

                public override void ValidateCase() {}
            }
            public sealed partial class ManageSellOffer : bodyUnion
            {
                public override OperationType Discriminator => OperationType.MANAGE_SELL_OFFER;
                public ManageSellOfferOp manageSellOfferOp
                {
                    get => _manageSellOfferOp;
                    set
                    {
                        _manageSellOfferOp = value;
                    }
                }
                private ManageSellOfferOp _manageSellOfferOp;

                public override void ValidateCase() {}
            }
            public sealed partial class CreatePassiveSellOffer : bodyUnion
            {
                public override OperationType Discriminator => OperationType.CREATE_PASSIVE_SELL_OFFER;
                public CreatePassiveSellOfferOp createPassiveSellOfferOp
                {
                    get => _createPassiveSellOfferOp;
                    set
                    {
                        _createPassiveSellOfferOp = value;
                    }
                }
                private CreatePassiveSellOfferOp _createPassiveSellOfferOp;

                public override void ValidateCase() {}
            }
            public sealed partial class SetOptions : bodyUnion
            {
                public override OperationType Discriminator => OperationType.SET_OPTIONS;
                public SetOptionsOp setOptionsOp
                {
                    get => _setOptionsOp;
                    set
                    {
                        _setOptionsOp = value;
                    }
                }
                private SetOptionsOp _setOptionsOp;

                public override void ValidateCase() {}
            }
            public sealed partial class ChangeTrust : bodyUnion
            {
                public override OperationType Discriminator => OperationType.CHANGE_TRUST;
                public ChangeTrustOp changeTrustOp
                {
                    get => _changeTrustOp;
                    set
                    {
                        _changeTrustOp = value;
                    }
                }
                private ChangeTrustOp _changeTrustOp;

                public override void ValidateCase() {}
            }
            public sealed partial class AllowTrust : bodyUnion
            {
                public override OperationType Discriminator => OperationType.ALLOW_TRUST;
                public AllowTrustOp allowTrustOp
                {
                    get => _allowTrustOp;
                    set
                    {
                        _allowTrustOp = value;
                    }
                }
                private AllowTrustOp _allowTrustOp;

                public override void ValidateCase() {}
            }
            public sealed partial class AccountMerge : bodyUnion
            {
                public override OperationType Discriminator => OperationType.ACCOUNT_MERGE;
                public MuxedAccount destination
                {
                    get => _destination;
                    set
                    {
                        _destination = value;
                    }
                }
                private MuxedAccount _destination;

                public override void ValidateCase() {}
            }
            public sealed partial class Inflation : bodyUnion
            {
                public override OperationType Discriminator => OperationType.INFLATION;

                public override void ValidateCase() {}
            }
            public sealed partial class ManageData : bodyUnion
            {
                public override OperationType Discriminator => OperationType.MANAGE_DATA;
                public ManageDataOp manageDataOp
                {
                    get => _manageDataOp;
                    set
                    {
                        _manageDataOp = value;
                    }
                }
                private ManageDataOp _manageDataOp;

                public override void ValidateCase() {}
            }
            public sealed partial class BumpSequence : bodyUnion
            {
                public override OperationType Discriminator => OperationType.BUMP_SEQUENCE;
                public BumpSequenceOp bumpSequenceOp
                {
                    get => _bumpSequenceOp;
                    set
                    {
                        _bumpSequenceOp = value;
                    }
                }
                private BumpSequenceOp _bumpSequenceOp;

                public override void ValidateCase() {}
            }
            public sealed partial class ManageBuyOffer : bodyUnion
            {
                public override OperationType Discriminator => OperationType.MANAGE_BUY_OFFER;
                public ManageBuyOfferOp manageBuyOfferOp
                {
                    get => _manageBuyOfferOp;
                    set
                    {
                        _manageBuyOfferOp = value;
                    }
                }
                private ManageBuyOfferOp _manageBuyOfferOp;

                public override void ValidateCase() {}
            }
            public sealed partial class PathPaymentStrictSend : bodyUnion
            {
                public override OperationType Discriminator => OperationType.PATH_PAYMENT_STRICT_SEND;
                public PathPaymentStrictSendOp pathPaymentStrictSendOp
                {
                    get => _pathPaymentStrictSendOp;
                    set
                    {
                        _pathPaymentStrictSendOp = value;
                    }
                }
                private PathPaymentStrictSendOp _pathPaymentStrictSendOp;

                public override void ValidateCase() {}
            }
            public sealed partial class CreateClaimableBalance : bodyUnion
            {
                public override OperationType Discriminator => OperationType.CREATE_CLAIMABLE_BALANCE;
                public CreateClaimableBalanceOp createClaimableBalanceOp
                {
                    get => _createClaimableBalanceOp;
                    set
                    {
                        _createClaimableBalanceOp = value;
                    }
                }
                private CreateClaimableBalanceOp _createClaimableBalanceOp;

                public override void ValidateCase() {}
            }
            public sealed partial class ClaimClaimableBalance : bodyUnion
            {
                public override OperationType Discriminator => OperationType.CLAIM_CLAIMABLE_BALANCE;
                public ClaimClaimableBalanceOp claimClaimableBalanceOp
                {
                    get => _claimClaimableBalanceOp;
                    set
                    {
                        _claimClaimableBalanceOp = value;
                    }
                }
                private ClaimClaimableBalanceOp _claimClaimableBalanceOp;

                public override void ValidateCase() {}
            }
            public sealed partial class BeginSponsoringFutureReserves : bodyUnion
            {
                public override OperationType Discriminator => OperationType.BEGIN_SPONSORING_FUTURE_RESERVES;
                public BeginSponsoringFutureReservesOp beginSponsoringFutureReservesOp
                {
                    get => _beginSponsoringFutureReservesOp;
                    set
                    {
                        _beginSponsoringFutureReservesOp = value;
                    }
                }
                private BeginSponsoringFutureReservesOp _beginSponsoringFutureReservesOp;

                public override void ValidateCase() {}
            }
            public sealed partial class EndSponsoringFutureReserves : bodyUnion
            {
                public override OperationType Discriminator => OperationType.END_SPONSORING_FUTURE_RESERVES;

                public override void ValidateCase() {}
            }
            public sealed partial class RevokeSponsorship : bodyUnion
            {
                public override OperationType Discriminator => OperationType.REVOKE_SPONSORSHIP;
                public RevokeSponsorshipOp revokeSponsorshipOp
                {
                    get => _revokeSponsorshipOp;
                    set
                    {
                        _revokeSponsorshipOp = value;
                    }
                }
                private RevokeSponsorshipOp _revokeSponsorshipOp;

                public override void ValidateCase() {}
            }
            public sealed partial class Clawback : bodyUnion
            {
                public override OperationType Discriminator => OperationType.CLAWBACK;
                public ClawbackOp clawbackOp
                {
                    get => _clawbackOp;
                    set
                    {
                        _clawbackOp = value;
                    }
                }
                private ClawbackOp _clawbackOp;

                public override void ValidateCase() {}
            }
            public sealed partial class ClawbackClaimableBalance : bodyUnion
            {
                public override OperationType Discriminator => OperationType.CLAWBACK_CLAIMABLE_BALANCE;
                public ClawbackClaimableBalanceOp clawbackClaimableBalanceOp
                {
                    get => _clawbackClaimableBalanceOp;
                    set
                    {
                        _clawbackClaimableBalanceOp = value;
                    }
                }
                private ClawbackClaimableBalanceOp _clawbackClaimableBalanceOp;

                public override void ValidateCase() {}
            }
            public sealed partial class SetTrustLineFlags : bodyUnion
            {
                public override OperationType Discriminator => OperationType.SET_TRUST_LINE_FLAGS;
                public SetTrustLineFlagsOp setTrustLineFlagsOp
                {
                    get => _setTrustLineFlagsOp;
                    set
                    {
                        _setTrustLineFlagsOp = value;
                    }
                }
                private SetTrustLineFlagsOp _setTrustLineFlagsOp;

                public override void ValidateCase() {}
            }
            public sealed partial class LiquidityPoolDeposit : bodyUnion
            {
                public override OperationType Discriminator => OperationType.LIQUIDITY_POOL_DEPOSIT;
                public LiquidityPoolDepositOp liquidityPoolDepositOp
                {
                    get => _liquidityPoolDepositOp;
                    set
                    {
                        _liquidityPoolDepositOp = value;
                    }
                }
                private LiquidityPoolDepositOp _liquidityPoolDepositOp;

                public override void ValidateCase() {}
            }
            public sealed partial class LiquidityPoolWithdraw : bodyUnion
            {
                public override OperationType Discriminator => OperationType.LIQUIDITY_POOL_WITHDRAW;
                public LiquidityPoolWithdrawOp liquidityPoolWithdrawOp
                {
                    get => _liquidityPoolWithdrawOp;
                    set
                    {
                        _liquidityPoolWithdrawOp = value;
                    }
                }
                private LiquidityPoolWithdrawOp _liquidityPoolWithdrawOp;

                public override void ValidateCase() {}
            }
            public sealed partial class InvokeHostFunction : bodyUnion
            {
                public override OperationType Discriminator => OperationType.INVOKE_HOST_FUNCTION;
                public InvokeHostFunctionOp invokeHostFunctionOp
                {
                    get => _invokeHostFunctionOp;
                    set
                    {
                        _invokeHostFunctionOp = value;
                    }
                }
                private InvokeHostFunctionOp _invokeHostFunctionOp;

                public override void ValidateCase() {}
            }
            public sealed partial class ExtendFootprintTtl : bodyUnion
            {
                public override OperationType Discriminator => OperationType.EXTEND_FOOTPRINT_TTL;
                public ExtendFootprintTTLOp extendFootprintTTLOp
                {
                    get => _extendFootprintTTLOp;
                    set
                    {
                        _extendFootprintTTLOp = value;
                    }
                }
                private ExtendFootprintTTLOp _extendFootprintTTLOp;

                public override void ValidateCase() {}
            }
            public sealed partial class RestoreFootprint : bodyUnion
            {
                public override OperationType Discriminator => OperationType.RESTORE_FOOTPRINT;
                public RestoreFootprintOp restoreFootprintOp
                {
                    get => _restoreFootprintOp;
                    set
                    {
                        _restoreFootprintOp = value;
                    }
                }
                private RestoreFootprintOp _restoreFootprintOp;

                public override void ValidateCase() {}
            }
        }
        public static partial class bodyUnionXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(bodyUnion value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    bodyUnionXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            public static void Encode(XdrWriter stream, bodyUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case bodyUnion.CreateAccount case_CREATE_ACCOUNT:
                    CreateAccountOpXdr.Encode(stream, case_CREATE_ACCOUNT.createAccountOp);
                    break;
                    case bodyUnion.Payment case_PAYMENT:
                    PaymentOpXdr.Encode(stream, case_PAYMENT.paymentOp);
                    break;
                    case bodyUnion.PathPaymentStrictReceive case_PATH_PAYMENT_STRICT_RECEIVE:
                    PathPaymentStrictReceiveOpXdr.Encode(stream, case_PATH_PAYMENT_STRICT_RECEIVE.pathPaymentStrictReceiveOp);
                    break;
                    case bodyUnion.ManageSellOffer case_MANAGE_SELL_OFFER:
                    ManageSellOfferOpXdr.Encode(stream, case_MANAGE_SELL_OFFER.manageSellOfferOp);
                    break;
                    case bodyUnion.CreatePassiveSellOffer case_CREATE_PASSIVE_SELL_OFFER:
                    CreatePassiveSellOfferOpXdr.Encode(stream, case_CREATE_PASSIVE_SELL_OFFER.createPassiveSellOfferOp);
                    break;
                    case bodyUnion.SetOptions case_SET_OPTIONS:
                    SetOptionsOpXdr.Encode(stream, case_SET_OPTIONS.setOptionsOp);
                    break;
                    case bodyUnion.ChangeTrust case_CHANGE_TRUST:
                    ChangeTrustOpXdr.Encode(stream, case_CHANGE_TRUST.changeTrustOp);
                    break;
                    case bodyUnion.AllowTrust case_ALLOW_TRUST:
                    AllowTrustOpXdr.Encode(stream, case_ALLOW_TRUST.allowTrustOp);
                    break;
                    case bodyUnion.AccountMerge case_ACCOUNT_MERGE:
                    MuxedAccountXdr.Encode(stream, case_ACCOUNT_MERGE.destination);
                    break;
                    case bodyUnion.Inflation case_INFLATION:
                    break;
                    case bodyUnion.ManageData case_MANAGE_DATA:
                    ManageDataOpXdr.Encode(stream, case_MANAGE_DATA.manageDataOp);
                    break;
                    case bodyUnion.BumpSequence case_BUMP_SEQUENCE:
                    BumpSequenceOpXdr.Encode(stream, case_BUMP_SEQUENCE.bumpSequenceOp);
                    break;
                    case bodyUnion.ManageBuyOffer case_MANAGE_BUY_OFFER:
                    ManageBuyOfferOpXdr.Encode(stream, case_MANAGE_BUY_OFFER.manageBuyOfferOp);
                    break;
                    case bodyUnion.PathPaymentStrictSend case_PATH_PAYMENT_STRICT_SEND:
                    PathPaymentStrictSendOpXdr.Encode(stream, case_PATH_PAYMENT_STRICT_SEND.pathPaymentStrictSendOp);
                    break;
                    case bodyUnion.CreateClaimableBalance case_CREATE_CLAIMABLE_BALANCE:
                    CreateClaimableBalanceOpXdr.Encode(stream, case_CREATE_CLAIMABLE_BALANCE.createClaimableBalanceOp);
                    break;
                    case bodyUnion.ClaimClaimableBalance case_CLAIM_CLAIMABLE_BALANCE:
                    ClaimClaimableBalanceOpXdr.Encode(stream, case_CLAIM_CLAIMABLE_BALANCE.claimClaimableBalanceOp);
                    break;
                    case bodyUnion.BeginSponsoringFutureReserves case_BEGIN_SPONSORING_FUTURE_RESERVES:
                    BeginSponsoringFutureReservesOpXdr.Encode(stream, case_BEGIN_SPONSORING_FUTURE_RESERVES.beginSponsoringFutureReservesOp);
                    break;
                    case bodyUnion.EndSponsoringFutureReserves case_END_SPONSORING_FUTURE_RESERVES:
                    break;
                    case bodyUnion.RevokeSponsorship case_REVOKE_SPONSORSHIP:
                    RevokeSponsorshipOpXdr.Encode(stream, case_REVOKE_SPONSORSHIP.revokeSponsorshipOp);
                    break;
                    case bodyUnion.Clawback case_CLAWBACK:
                    ClawbackOpXdr.Encode(stream, case_CLAWBACK.clawbackOp);
                    break;
                    case bodyUnion.ClawbackClaimableBalance case_CLAWBACK_CLAIMABLE_BALANCE:
                    ClawbackClaimableBalanceOpXdr.Encode(stream, case_CLAWBACK_CLAIMABLE_BALANCE.clawbackClaimableBalanceOp);
                    break;
                    case bodyUnion.SetTrustLineFlags case_SET_TRUST_LINE_FLAGS:
                    SetTrustLineFlagsOpXdr.Encode(stream, case_SET_TRUST_LINE_FLAGS.setTrustLineFlagsOp);
                    break;
                    case bodyUnion.LiquidityPoolDeposit case_LIQUIDITY_POOL_DEPOSIT:
                    LiquidityPoolDepositOpXdr.Encode(stream, case_LIQUIDITY_POOL_DEPOSIT.liquidityPoolDepositOp);
                    break;
                    case bodyUnion.LiquidityPoolWithdraw case_LIQUIDITY_POOL_WITHDRAW:
                    LiquidityPoolWithdrawOpXdr.Encode(stream, case_LIQUIDITY_POOL_WITHDRAW.liquidityPoolWithdrawOp);
                    break;
                    case bodyUnion.InvokeHostFunction case_INVOKE_HOST_FUNCTION:
                    InvokeHostFunctionOpXdr.Encode(stream, case_INVOKE_HOST_FUNCTION.invokeHostFunctionOp);
                    break;
                    case bodyUnion.ExtendFootprintTtl case_EXTEND_FOOTPRINT_TTL:
                    ExtendFootprintTTLOpXdr.Encode(stream, case_EXTEND_FOOTPRINT_TTL.extendFootprintTTLOp);
                    break;
                    case bodyUnion.RestoreFootprint case_RESTORE_FOOTPRINT:
                    RestoreFootprintOpXdr.Encode(stream, case_RESTORE_FOOTPRINT.restoreFootprintOp);
                    break;
                }
            }
            public static bodyUnion Decode(XdrReader stream)
            {
                var discriminator = (OperationType)stream.ReadInt();
                switch (discriminator)
                {
                    case OperationType.CREATE_ACCOUNT:
                    var result_CREATE_ACCOUNT = new bodyUnion.CreateAccount();
                    result_CREATE_ACCOUNT.createAccountOp = CreateAccountOpXdr.Decode(stream);
                    return result_CREATE_ACCOUNT;
                    case OperationType.PAYMENT:
                    var result_PAYMENT = new bodyUnion.Payment();
                    result_PAYMENT.paymentOp = PaymentOpXdr.Decode(stream);
                    return result_PAYMENT;
                    case OperationType.PATH_PAYMENT_STRICT_RECEIVE:
                    var result_PATH_PAYMENT_STRICT_RECEIVE = new bodyUnion.PathPaymentStrictReceive();
                    result_PATH_PAYMENT_STRICT_RECEIVE.pathPaymentStrictReceiveOp = PathPaymentStrictReceiveOpXdr.Decode(stream);
                    return result_PATH_PAYMENT_STRICT_RECEIVE;
                    case OperationType.MANAGE_SELL_OFFER:
                    var result_MANAGE_SELL_OFFER = new bodyUnion.ManageSellOffer();
                    result_MANAGE_SELL_OFFER.manageSellOfferOp = ManageSellOfferOpXdr.Decode(stream);
                    return result_MANAGE_SELL_OFFER;
                    case OperationType.CREATE_PASSIVE_SELL_OFFER:
                    var result_CREATE_PASSIVE_SELL_OFFER = new bodyUnion.CreatePassiveSellOffer();
                    result_CREATE_PASSIVE_SELL_OFFER.createPassiveSellOfferOp = CreatePassiveSellOfferOpXdr.Decode(stream);
                    return result_CREATE_PASSIVE_SELL_OFFER;
                    case OperationType.SET_OPTIONS:
                    var result_SET_OPTIONS = new bodyUnion.SetOptions();
                    result_SET_OPTIONS.setOptionsOp = SetOptionsOpXdr.Decode(stream);
                    return result_SET_OPTIONS;
                    case OperationType.CHANGE_TRUST:
                    var result_CHANGE_TRUST = new bodyUnion.ChangeTrust();
                    result_CHANGE_TRUST.changeTrustOp = ChangeTrustOpXdr.Decode(stream);
                    return result_CHANGE_TRUST;
                    case OperationType.ALLOW_TRUST:
                    var result_ALLOW_TRUST = new bodyUnion.AllowTrust();
                    result_ALLOW_TRUST.allowTrustOp = AllowTrustOpXdr.Decode(stream);
                    return result_ALLOW_TRUST;
                    case OperationType.ACCOUNT_MERGE:
                    var result_ACCOUNT_MERGE = new bodyUnion.AccountMerge();
                    result_ACCOUNT_MERGE.destination = MuxedAccountXdr.Decode(stream);
                    return result_ACCOUNT_MERGE;
                    case OperationType.INFLATION:
                    var result_INFLATION = new bodyUnion.Inflation();
                    return result_INFLATION;
                    case OperationType.MANAGE_DATA:
                    var result_MANAGE_DATA = new bodyUnion.ManageData();
                    result_MANAGE_DATA.manageDataOp = ManageDataOpXdr.Decode(stream);
                    return result_MANAGE_DATA;
                    case OperationType.BUMP_SEQUENCE:
                    var result_BUMP_SEQUENCE = new bodyUnion.BumpSequence();
                    result_BUMP_SEQUENCE.bumpSequenceOp = BumpSequenceOpXdr.Decode(stream);
                    return result_BUMP_SEQUENCE;
                    case OperationType.MANAGE_BUY_OFFER:
                    var result_MANAGE_BUY_OFFER = new bodyUnion.ManageBuyOffer();
                    result_MANAGE_BUY_OFFER.manageBuyOfferOp = ManageBuyOfferOpXdr.Decode(stream);
                    return result_MANAGE_BUY_OFFER;
                    case OperationType.PATH_PAYMENT_STRICT_SEND:
                    var result_PATH_PAYMENT_STRICT_SEND = new bodyUnion.PathPaymentStrictSend();
                    result_PATH_PAYMENT_STRICT_SEND.pathPaymentStrictSendOp = PathPaymentStrictSendOpXdr.Decode(stream);
                    return result_PATH_PAYMENT_STRICT_SEND;
                    case OperationType.CREATE_CLAIMABLE_BALANCE:
                    var result_CREATE_CLAIMABLE_BALANCE = new bodyUnion.CreateClaimableBalance();
                    result_CREATE_CLAIMABLE_BALANCE.createClaimableBalanceOp = CreateClaimableBalanceOpXdr.Decode(stream);
                    return result_CREATE_CLAIMABLE_BALANCE;
                    case OperationType.CLAIM_CLAIMABLE_BALANCE:
                    var result_CLAIM_CLAIMABLE_BALANCE = new bodyUnion.ClaimClaimableBalance();
                    result_CLAIM_CLAIMABLE_BALANCE.claimClaimableBalanceOp = ClaimClaimableBalanceOpXdr.Decode(stream);
                    return result_CLAIM_CLAIMABLE_BALANCE;
                    case OperationType.BEGIN_SPONSORING_FUTURE_RESERVES:
                    var result_BEGIN_SPONSORING_FUTURE_RESERVES = new bodyUnion.BeginSponsoringFutureReserves();
                    result_BEGIN_SPONSORING_FUTURE_RESERVES.beginSponsoringFutureReservesOp = BeginSponsoringFutureReservesOpXdr.Decode(stream);
                    return result_BEGIN_SPONSORING_FUTURE_RESERVES;
                    case OperationType.END_SPONSORING_FUTURE_RESERVES:
                    var result_END_SPONSORING_FUTURE_RESERVES = new bodyUnion.EndSponsoringFutureReserves();
                    return result_END_SPONSORING_FUTURE_RESERVES;
                    case OperationType.REVOKE_SPONSORSHIP:
                    var result_REVOKE_SPONSORSHIP = new bodyUnion.RevokeSponsorship();
                    result_REVOKE_SPONSORSHIP.revokeSponsorshipOp = RevokeSponsorshipOpXdr.Decode(stream);
                    return result_REVOKE_SPONSORSHIP;
                    case OperationType.CLAWBACK:
                    var result_CLAWBACK = new bodyUnion.Clawback();
                    result_CLAWBACK.clawbackOp = ClawbackOpXdr.Decode(stream);
                    return result_CLAWBACK;
                    case OperationType.CLAWBACK_CLAIMABLE_BALANCE:
                    var result_CLAWBACK_CLAIMABLE_BALANCE = new bodyUnion.ClawbackClaimableBalance();
                    result_CLAWBACK_CLAIMABLE_BALANCE.clawbackClaimableBalanceOp = ClawbackClaimableBalanceOpXdr.Decode(stream);
                    return result_CLAWBACK_CLAIMABLE_BALANCE;
                    case OperationType.SET_TRUST_LINE_FLAGS:
                    var result_SET_TRUST_LINE_FLAGS = new bodyUnion.SetTrustLineFlags();
                    result_SET_TRUST_LINE_FLAGS.setTrustLineFlagsOp = SetTrustLineFlagsOpXdr.Decode(stream);
                    return result_SET_TRUST_LINE_FLAGS;
                    case OperationType.LIQUIDITY_POOL_DEPOSIT:
                    var result_LIQUIDITY_POOL_DEPOSIT = new bodyUnion.LiquidityPoolDeposit();
                    result_LIQUIDITY_POOL_DEPOSIT.liquidityPoolDepositOp = LiquidityPoolDepositOpXdr.Decode(stream);
                    return result_LIQUIDITY_POOL_DEPOSIT;
                    case OperationType.LIQUIDITY_POOL_WITHDRAW:
                    var result_LIQUIDITY_POOL_WITHDRAW = new bodyUnion.LiquidityPoolWithdraw();
                    result_LIQUIDITY_POOL_WITHDRAW.liquidityPoolWithdrawOp = LiquidityPoolWithdrawOpXdr.Decode(stream);
                    return result_LIQUIDITY_POOL_WITHDRAW;
                    case OperationType.INVOKE_HOST_FUNCTION:
                    var result_INVOKE_HOST_FUNCTION = new bodyUnion.InvokeHostFunction();
                    result_INVOKE_HOST_FUNCTION.invokeHostFunctionOp = InvokeHostFunctionOpXdr.Decode(stream);
                    return result_INVOKE_HOST_FUNCTION;
                    case OperationType.EXTEND_FOOTPRINT_TTL:
                    var result_EXTEND_FOOTPRINT_TTL = new bodyUnion.ExtendFootprintTtl();
                    result_EXTEND_FOOTPRINT_TTL.extendFootprintTTLOp = ExtendFootprintTTLOpXdr.Decode(stream);
                    return result_EXTEND_FOOTPRINT_TTL;
                    case OperationType.RESTORE_FOOTPRINT:
                    var result_RESTORE_FOOTPRINT = new bodyUnion.RestoreFootprint();
                    result_RESTORE_FOOTPRINT.restoreFootprintOp = RestoreFootprintOpXdr.Decode(stream);
                    return result_RESTORE_FOOTPRINT;
                    default:
                    throw new Exception($"Unknown discriminator for bodyUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class OperationXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(Operation value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                OperationXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, Operation value)
        {
            value.Validate();
            if (value.sourceAccount==null){
            	stream.WriteInt(0);
            }
            else
            {
                stream.WriteInt(1);
                MuxedAccountXdr.Encode(stream, value.sourceAccount);
            }
            Operation.bodyUnionXdr.Encode(stream, value.body);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static Operation Decode(XdrReader stream)
        {
            var result = new Operation();
            if (stream.ReadInt()==1)
            {
                result.sourceAccount = MuxedAccountXdr.Decode(stream);
            }
            result.body = Operation.bodyUnionXdr.Decode(stream);
            return result;
        }
    }
}
