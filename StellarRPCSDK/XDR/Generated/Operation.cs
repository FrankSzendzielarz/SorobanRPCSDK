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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class Operation
    {
        private MuxedAccount _sourceAccount;
        public MuxedAccount sourceAccount
        {
            get => _sourceAccount;
            set
            {
                _sourceAccount = value;
            }
        }

        private bodyUnion _body;
        public bodyUnion body
        {
            get => _body;
            set
            {
                _body = value;
            }
        }

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

        }
        public sealed partial class bodyUnion_CREATE_ACCOUNT : bodyUnion
        {
            public override OperationType Discriminator => OperationType.CREATE_ACCOUNT;
            private CreateAccountOp _createAccountOp;
            public CreateAccountOp createAccountOp
            {
                get => _createAccountOp;
                set
                {
                    _createAccountOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_PAYMENT : bodyUnion
        {
            public override OperationType Discriminator => OperationType.PAYMENT;
            private PaymentOp _paymentOp;
            public PaymentOp paymentOp
            {
                get => _paymentOp;
                set
                {
                    _paymentOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_PATH_PAYMENT_STRICT_RECEIVE : bodyUnion
        {
            public override OperationType Discriminator => OperationType.PATH_PAYMENT_STRICT_RECEIVE;
            private PathPaymentStrictReceiveOp _pathPaymentStrictReceiveOp;
            public PathPaymentStrictReceiveOp pathPaymentStrictReceiveOp
            {
                get => _pathPaymentStrictReceiveOp;
                set
                {
                    _pathPaymentStrictReceiveOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_MANAGE_SELL_OFFER : bodyUnion
        {
            public override OperationType Discriminator => OperationType.MANAGE_SELL_OFFER;
            private ManageSellOfferOp _manageSellOfferOp;
            public ManageSellOfferOp manageSellOfferOp
            {
                get => _manageSellOfferOp;
                set
                {
                    _manageSellOfferOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_CREATE_PASSIVE_SELL_OFFER : bodyUnion
        {
            public override OperationType Discriminator => OperationType.CREATE_PASSIVE_SELL_OFFER;
            private CreatePassiveSellOfferOp _createPassiveSellOfferOp;
            public CreatePassiveSellOfferOp createPassiveSellOfferOp
            {
                get => _createPassiveSellOfferOp;
                set
                {
                    _createPassiveSellOfferOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_SET_OPTIONS : bodyUnion
        {
            public override OperationType Discriminator => OperationType.SET_OPTIONS;
            private SetOptionsOp _setOptionsOp;
            public SetOptionsOp setOptionsOp
            {
                get => _setOptionsOp;
                set
                {
                    _setOptionsOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_CHANGE_TRUST : bodyUnion
        {
            public override OperationType Discriminator => OperationType.CHANGE_TRUST;
            private ChangeTrustOp _changeTrustOp;
            public ChangeTrustOp changeTrustOp
            {
                get => _changeTrustOp;
                set
                {
                    _changeTrustOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_ALLOW_TRUST : bodyUnion
        {
            public override OperationType Discriminator => OperationType.ALLOW_TRUST;
            private AllowTrustOp _allowTrustOp;
            public AllowTrustOp allowTrustOp
            {
                get => _allowTrustOp;
                set
                {
                    _allowTrustOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_ACCOUNT_MERGE : bodyUnion
        {
            public override OperationType Discriminator => OperationType.ACCOUNT_MERGE;
            private MuxedAccount _destination;
            public MuxedAccount destination
            {
                get => _destination;
                set
                {
                    _destination = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_INFLATION : bodyUnion
        {
            public override OperationType Discriminator => OperationType.INFLATION;

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_MANAGE_DATA : bodyUnion
        {
            public override OperationType Discriminator => OperationType.MANAGE_DATA;
            private ManageDataOp _manageDataOp;
            public ManageDataOp manageDataOp
            {
                get => _manageDataOp;
                set
                {
                    _manageDataOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_BUMP_SEQUENCE : bodyUnion
        {
            public override OperationType Discriminator => OperationType.BUMP_SEQUENCE;
            private BumpSequenceOp _bumpSequenceOp;
            public BumpSequenceOp bumpSequenceOp
            {
                get => _bumpSequenceOp;
                set
                {
                    _bumpSequenceOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_MANAGE_BUY_OFFER : bodyUnion
        {
            public override OperationType Discriminator => OperationType.MANAGE_BUY_OFFER;
            private ManageBuyOfferOp _manageBuyOfferOp;
            public ManageBuyOfferOp manageBuyOfferOp
            {
                get => _manageBuyOfferOp;
                set
                {
                    _manageBuyOfferOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_PATH_PAYMENT_STRICT_SEND : bodyUnion
        {
            public override OperationType Discriminator => OperationType.PATH_PAYMENT_STRICT_SEND;
            private PathPaymentStrictSendOp _pathPaymentStrictSendOp;
            public PathPaymentStrictSendOp pathPaymentStrictSendOp
            {
                get => _pathPaymentStrictSendOp;
                set
                {
                    _pathPaymentStrictSendOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_CREATE_CLAIMABLE_BALANCE : bodyUnion
        {
            public override OperationType Discriminator => OperationType.CREATE_CLAIMABLE_BALANCE;
            private CreateClaimableBalanceOp _createClaimableBalanceOp;
            public CreateClaimableBalanceOp createClaimableBalanceOp
            {
                get => _createClaimableBalanceOp;
                set
                {
                    _createClaimableBalanceOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_CLAIM_CLAIMABLE_BALANCE : bodyUnion
        {
            public override OperationType Discriminator => OperationType.CLAIM_CLAIMABLE_BALANCE;
            private ClaimClaimableBalanceOp _claimClaimableBalanceOp;
            public ClaimClaimableBalanceOp claimClaimableBalanceOp
            {
                get => _claimClaimableBalanceOp;
                set
                {
                    _claimClaimableBalanceOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_BEGIN_SPONSORING_FUTURE_RESERVES : bodyUnion
        {
            public override OperationType Discriminator => OperationType.BEGIN_SPONSORING_FUTURE_RESERVES;
            private BeginSponsoringFutureReservesOp _beginSponsoringFutureReservesOp;
            public BeginSponsoringFutureReservesOp beginSponsoringFutureReservesOp
            {
                get => _beginSponsoringFutureReservesOp;
                set
                {
                    _beginSponsoringFutureReservesOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_END_SPONSORING_FUTURE_RESERVES : bodyUnion
        {
            public override OperationType Discriminator => OperationType.END_SPONSORING_FUTURE_RESERVES;

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_REVOKE_SPONSORSHIP : bodyUnion
        {
            public override OperationType Discriminator => OperationType.REVOKE_SPONSORSHIP;
            private RevokeSponsorshipOp _revokeSponsorshipOp;
            public RevokeSponsorshipOp revokeSponsorshipOp
            {
                get => _revokeSponsorshipOp;
                set
                {
                    _revokeSponsorshipOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_CLAWBACK : bodyUnion
        {
            public override OperationType Discriminator => OperationType.CLAWBACK;
            private ClawbackOp _clawbackOp;
            public ClawbackOp clawbackOp
            {
                get => _clawbackOp;
                set
                {
                    _clawbackOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_CLAWBACK_CLAIMABLE_BALANCE : bodyUnion
        {
            public override OperationType Discriminator => OperationType.CLAWBACK_CLAIMABLE_BALANCE;
            private ClawbackClaimableBalanceOp _clawbackClaimableBalanceOp;
            public ClawbackClaimableBalanceOp clawbackClaimableBalanceOp
            {
                get => _clawbackClaimableBalanceOp;
                set
                {
                    _clawbackClaimableBalanceOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_SET_TRUST_LINE_FLAGS : bodyUnion
        {
            public override OperationType Discriminator => OperationType.SET_TRUST_LINE_FLAGS;
            private SetTrustLineFlagsOp _setTrustLineFlagsOp;
            public SetTrustLineFlagsOp setTrustLineFlagsOp
            {
                get => _setTrustLineFlagsOp;
                set
                {
                    _setTrustLineFlagsOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_LIQUIDITY_POOL_DEPOSIT : bodyUnion
        {
            public override OperationType Discriminator => OperationType.LIQUIDITY_POOL_DEPOSIT;
            private LiquidityPoolDepositOp _liquidityPoolDepositOp;
            public LiquidityPoolDepositOp liquidityPoolDepositOp
            {
                get => _liquidityPoolDepositOp;
                set
                {
                    _liquidityPoolDepositOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_LIQUIDITY_POOL_WITHDRAW : bodyUnion
        {
            public override OperationType Discriminator => OperationType.LIQUIDITY_POOL_WITHDRAW;
            private LiquidityPoolWithdrawOp _liquidityPoolWithdrawOp;
            public LiquidityPoolWithdrawOp liquidityPoolWithdrawOp
            {
                get => _liquidityPoolWithdrawOp;
                set
                {
                    _liquidityPoolWithdrawOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_INVOKE_HOST_FUNCTION : bodyUnion
        {
            public override OperationType Discriminator => OperationType.INVOKE_HOST_FUNCTION;
            private InvokeHostFunctionOp _invokeHostFunctionOp;
            public InvokeHostFunctionOp invokeHostFunctionOp
            {
                get => _invokeHostFunctionOp;
                set
                {
                    _invokeHostFunctionOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_EXTEND_FOOTPRINT_TTL : bodyUnion
        {
            public override OperationType Discriminator => OperationType.EXTEND_FOOTPRINT_TTL;
            private ExtendFootprintTTLOp _extendFootprintTTLOp;
            public ExtendFootprintTTLOp extendFootprintTTLOp
            {
                get => _extendFootprintTTLOp;
                set
                {
                    _extendFootprintTTLOp = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_RESTORE_FOOTPRINT : bodyUnion
        {
            public override OperationType Discriminator => OperationType.RESTORE_FOOTPRINT;
            private RestoreFootprintOp _restoreFootprintOp;
            public RestoreFootprintOp restoreFootprintOp
            {
                get => _restoreFootprintOp;
                set
                {
                    _restoreFootprintOp = value;
                }
            }

            public override void ValidateCase() {}
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
                    case bodyUnion_CREATE_ACCOUNT case_CREATE_ACCOUNT:
                    CreateAccountOpXdr.Encode(stream, case_CREATE_ACCOUNT.createAccountOp);
                    break;
                    case bodyUnion_PAYMENT case_PAYMENT:
                    PaymentOpXdr.Encode(stream, case_PAYMENT.paymentOp);
                    break;
                    case bodyUnion_PATH_PAYMENT_STRICT_RECEIVE case_PATH_PAYMENT_STRICT_RECEIVE:
                    PathPaymentStrictReceiveOpXdr.Encode(stream, case_PATH_PAYMENT_STRICT_RECEIVE.pathPaymentStrictReceiveOp);
                    break;
                    case bodyUnion_MANAGE_SELL_OFFER case_MANAGE_SELL_OFFER:
                    ManageSellOfferOpXdr.Encode(stream, case_MANAGE_SELL_OFFER.manageSellOfferOp);
                    break;
                    case bodyUnion_CREATE_PASSIVE_SELL_OFFER case_CREATE_PASSIVE_SELL_OFFER:
                    CreatePassiveSellOfferOpXdr.Encode(stream, case_CREATE_PASSIVE_SELL_OFFER.createPassiveSellOfferOp);
                    break;
                    case bodyUnion_SET_OPTIONS case_SET_OPTIONS:
                    SetOptionsOpXdr.Encode(stream, case_SET_OPTIONS.setOptionsOp);
                    break;
                    case bodyUnion_CHANGE_TRUST case_CHANGE_TRUST:
                    ChangeTrustOpXdr.Encode(stream, case_CHANGE_TRUST.changeTrustOp);
                    break;
                    case bodyUnion_ALLOW_TRUST case_ALLOW_TRUST:
                    AllowTrustOpXdr.Encode(stream, case_ALLOW_TRUST.allowTrustOp);
                    break;
                    case bodyUnion_ACCOUNT_MERGE case_ACCOUNT_MERGE:
                    MuxedAccountXdr.Encode(stream, case_ACCOUNT_MERGE.destination);
                    break;
                    case bodyUnion_INFLATION case_INFLATION:
                    break;
                    case bodyUnion_MANAGE_DATA case_MANAGE_DATA:
                    ManageDataOpXdr.Encode(stream, case_MANAGE_DATA.manageDataOp);
                    break;
                    case bodyUnion_BUMP_SEQUENCE case_BUMP_SEQUENCE:
                    BumpSequenceOpXdr.Encode(stream, case_BUMP_SEQUENCE.bumpSequenceOp);
                    break;
                    case bodyUnion_MANAGE_BUY_OFFER case_MANAGE_BUY_OFFER:
                    ManageBuyOfferOpXdr.Encode(stream, case_MANAGE_BUY_OFFER.manageBuyOfferOp);
                    break;
                    case bodyUnion_PATH_PAYMENT_STRICT_SEND case_PATH_PAYMENT_STRICT_SEND:
                    PathPaymentStrictSendOpXdr.Encode(stream, case_PATH_PAYMENT_STRICT_SEND.pathPaymentStrictSendOp);
                    break;
                    case bodyUnion_CREATE_CLAIMABLE_BALANCE case_CREATE_CLAIMABLE_BALANCE:
                    CreateClaimableBalanceOpXdr.Encode(stream, case_CREATE_CLAIMABLE_BALANCE.createClaimableBalanceOp);
                    break;
                    case bodyUnion_CLAIM_CLAIMABLE_BALANCE case_CLAIM_CLAIMABLE_BALANCE:
                    ClaimClaimableBalanceOpXdr.Encode(stream, case_CLAIM_CLAIMABLE_BALANCE.claimClaimableBalanceOp);
                    break;
                    case bodyUnion_BEGIN_SPONSORING_FUTURE_RESERVES case_BEGIN_SPONSORING_FUTURE_RESERVES:
                    BeginSponsoringFutureReservesOpXdr.Encode(stream, case_BEGIN_SPONSORING_FUTURE_RESERVES.beginSponsoringFutureReservesOp);
                    break;
                    case bodyUnion_END_SPONSORING_FUTURE_RESERVES case_END_SPONSORING_FUTURE_RESERVES:
                    break;
                    case bodyUnion_REVOKE_SPONSORSHIP case_REVOKE_SPONSORSHIP:
                    RevokeSponsorshipOpXdr.Encode(stream, case_REVOKE_SPONSORSHIP.revokeSponsorshipOp);
                    break;
                    case bodyUnion_CLAWBACK case_CLAWBACK:
                    ClawbackOpXdr.Encode(stream, case_CLAWBACK.clawbackOp);
                    break;
                    case bodyUnion_CLAWBACK_CLAIMABLE_BALANCE case_CLAWBACK_CLAIMABLE_BALANCE:
                    ClawbackClaimableBalanceOpXdr.Encode(stream, case_CLAWBACK_CLAIMABLE_BALANCE.clawbackClaimableBalanceOp);
                    break;
                    case bodyUnion_SET_TRUST_LINE_FLAGS case_SET_TRUST_LINE_FLAGS:
                    SetTrustLineFlagsOpXdr.Encode(stream, case_SET_TRUST_LINE_FLAGS.setTrustLineFlagsOp);
                    break;
                    case bodyUnion_LIQUIDITY_POOL_DEPOSIT case_LIQUIDITY_POOL_DEPOSIT:
                    LiquidityPoolDepositOpXdr.Encode(stream, case_LIQUIDITY_POOL_DEPOSIT.liquidityPoolDepositOp);
                    break;
                    case bodyUnion_LIQUIDITY_POOL_WITHDRAW case_LIQUIDITY_POOL_WITHDRAW:
                    LiquidityPoolWithdrawOpXdr.Encode(stream, case_LIQUIDITY_POOL_WITHDRAW.liquidityPoolWithdrawOp);
                    break;
                    case bodyUnion_INVOKE_HOST_FUNCTION case_INVOKE_HOST_FUNCTION:
                    InvokeHostFunctionOpXdr.Encode(stream, case_INVOKE_HOST_FUNCTION.invokeHostFunctionOp);
                    break;
                    case bodyUnion_EXTEND_FOOTPRINT_TTL case_EXTEND_FOOTPRINT_TTL:
                    ExtendFootprintTTLOpXdr.Encode(stream, case_EXTEND_FOOTPRINT_TTL.extendFootprintTTLOp);
                    break;
                    case bodyUnion_RESTORE_FOOTPRINT case_RESTORE_FOOTPRINT:
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
                    var result_CREATE_ACCOUNT = new bodyUnion_CREATE_ACCOUNT();
                    result_CREATE_ACCOUNT.createAccountOp = CreateAccountOpXdr.Decode(stream);
                    return result_CREATE_ACCOUNT;
                    case OperationType.PAYMENT:
                    var result_PAYMENT = new bodyUnion_PAYMENT();
                    result_PAYMENT.paymentOp = PaymentOpXdr.Decode(stream);
                    return result_PAYMENT;
                    case OperationType.PATH_PAYMENT_STRICT_RECEIVE:
                    var result_PATH_PAYMENT_STRICT_RECEIVE = new bodyUnion_PATH_PAYMENT_STRICT_RECEIVE();
                    result_PATH_PAYMENT_STRICT_RECEIVE.pathPaymentStrictReceiveOp = PathPaymentStrictReceiveOpXdr.Decode(stream);
                    return result_PATH_PAYMENT_STRICT_RECEIVE;
                    case OperationType.MANAGE_SELL_OFFER:
                    var result_MANAGE_SELL_OFFER = new bodyUnion_MANAGE_SELL_OFFER();
                    result_MANAGE_SELL_OFFER.manageSellOfferOp = ManageSellOfferOpXdr.Decode(stream);
                    return result_MANAGE_SELL_OFFER;
                    case OperationType.CREATE_PASSIVE_SELL_OFFER:
                    var result_CREATE_PASSIVE_SELL_OFFER = new bodyUnion_CREATE_PASSIVE_SELL_OFFER();
                    result_CREATE_PASSIVE_SELL_OFFER.createPassiveSellOfferOp = CreatePassiveSellOfferOpXdr.Decode(stream);
                    return result_CREATE_PASSIVE_SELL_OFFER;
                    case OperationType.SET_OPTIONS:
                    var result_SET_OPTIONS = new bodyUnion_SET_OPTIONS();
                    result_SET_OPTIONS.setOptionsOp = SetOptionsOpXdr.Decode(stream);
                    return result_SET_OPTIONS;
                    case OperationType.CHANGE_TRUST:
                    var result_CHANGE_TRUST = new bodyUnion_CHANGE_TRUST();
                    result_CHANGE_TRUST.changeTrustOp = ChangeTrustOpXdr.Decode(stream);
                    return result_CHANGE_TRUST;
                    case OperationType.ALLOW_TRUST:
                    var result_ALLOW_TRUST = new bodyUnion_ALLOW_TRUST();
                    result_ALLOW_TRUST.allowTrustOp = AllowTrustOpXdr.Decode(stream);
                    return result_ALLOW_TRUST;
                    case OperationType.ACCOUNT_MERGE:
                    var result_ACCOUNT_MERGE = new bodyUnion_ACCOUNT_MERGE();
                    result_ACCOUNT_MERGE.destination = MuxedAccountXdr.Decode(stream);
                    return result_ACCOUNT_MERGE;
                    case OperationType.INFLATION:
                    var result_INFLATION = new bodyUnion_INFLATION();
                    return result_INFLATION;
                    case OperationType.MANAGE_DATA:
                    var result_MANAGE_DATA = new bodyUnion_MANAGE_DATA();
                    result_MANAGE_DATA.manageDataOp = ManageDataOpXdr.Decode(stream);
                    return result_MANAGE_DATA;
                    case OperationType.BUMP_SEQUENCE:
                    var result_BUMP_SEQUENCE = new bodyUnion_BUMP_SEQUENCE();
                    result_BUMP_SEQUENCE.bumpSequenceOp = BumpSequenceOpXdr.Decode(stream);
                    return result_BUMP_SEQUENCE;
                    case OperationType.MANAGE_BUY_OFFER:
                    var result_MANAGE_BUY_OFFER = new bodyUnion_MANAGE_BUY_OFFER();
                    result_MANAGE_BUY_OFFER.manageBuyOfferOp = ManageBuyOfferOpXdr.Decode(stream);
                    return result_MANAGE_BUY_OFFER;
                    case OperationType.PATH_PAYMENT_STRICT_SEND:
                    var result_PATH_PAYMENT_STRICT_SEND = new bodyUnion_PATH_PAYMENT_STRICT_SEND();
                    result_PATH_PAYMENT_STRICT_SEND.pathPaymentStrictSendOp = PathPaymentStrictSendOpXdr.Decode(stream);
                    return result_PATH_PAYMENT_STRICT_SEND;
                    case OperationType.CREATE_CLAIMABLE_BALANCE:
                    var result_CREATE_CLAIMABLE_BALANCE = new bodyUnion_CREATE_CLAIMABLE_BALANCE();
                    result_CREATE_CLAIMABLE_BALANCE.createClaimableBalanceOp = CreateClaimableBalanceOpXdr.Decode(stream);
                    return result_CREATE_CLAIMABLE_BALANCE;
                    case OperationType.CLAIM_CLAIMABLE_BALANCE:
                    var result_CLAIM_CLAIMABLE_BALANCE = new bodyUnion_CLAIM_CLAIMABLE_BALANCE();
                    result_CLAIM_CLAIMABLE_BALANCE.claimClaimableBalanceOp = ClaimClaimableBalanceOpXdr.Decode(stream);
                    return result_CLAIM_CLAIMABLE_BALANCE;
                    case OperationType.BEGIN_SPONSORING_FUTURE_RESERVES:
                    var result_BEGIN_SPONSORING_FUTURE_RESERVES = new bodyUnion_BEGIN_SPONSORING_FUTURE_RESERVES();
                    result_BEGIN_SPONSORING_FUTURE_RESERVES.beginSponsoringFutureReservesOp = BeginSponsoringFutureReservesOpXdr.Decode(stream);
                    return result_BEGIN_SPONSORING_FUTURE_RESERVES;
                    case OperationType.END_SPONSORING_FUTURE_RESERVES:
                    var result_END_SPONSORING_FUTURE_RESERVES = new bodyUnion_END_SPONSORING_FUTURE_RESERVES();
                    return result_END_SPONSORING_FUTURE_RESERVES;
                    case OperationType.REVOKE_SPONSORSHIP:
                    var result_REVOKE_SPONSORSHIP = new bodyUnion_REVOKE_SPONSORSHIP();
                    result_REVOKE_SPONSORSHIP.revokeSponsorshipOp = RevokeSponsorshipOpXdr.Decode(stream);
                    return result_REVOKE_SPONSORSHIP;
                    case OperationType.CLAWBACK:
                    var result_CLAWBACK = new bodyUnion_CLAWBACK();
                    result_CLAWBACK.clawbackOp = ClawbackOpXdr.Decode(stream);
                    return result_CLAWBACK;
                    case OperationType.CLAWBACK_CLAIMABLE_BALANCE:
                    var result_CLAWBACK_CLAIMABLE_BALANCE = new bodyUnion_CLAWBACK_CLAIMABLE_BALANCE();
                    result_CLAWBACK_CLAIMABLE_BALANCE.clawbackClaimableBalanceOp = ClawbackClaimableBalanceOpXdr.Decode(stream);
                    return result_CLAWBACK_CLAIMABLE_BALANCE;
                    case OperationType.SET_TRUST_LINE_FLAGS:
                    var result_SET_TRUST_LINE_FLAGS = new bodyUnion_SET_TRUST_LINE_FLAGS();
                    result_SET_TRUST_LINE_FLAGS.setTrustLineFlagsOp = SetTrustLineFlagsOpXdr.Decode(stream);
                    return result_SET_TRUST_LINE_FLAGS;
                    case OperationType.LIQUIDITY_POOL_DEPOSIT:
                    var result_LIQUIDITY_POOL_DEPOSIT = new bodyUnion_LIQUIDITY_POOL_DEPOSIT();
                    result_LIQUIDITY_POOL_DEPOSIT.liquidityPoolDepositOp = LiquidityPoolDepositOpXdr.Decode(stream);
                    return result_LIQUIDITY_POOL_DEPOSIT;
                    case OperationType.LIQUIDITY_POOL_WITHDRAW:
                    var result_LIQUIDITY_POOL_WITHDRAW = new bodyUnion_LIQUIDITY_POOL_WITHDRAW();
                    result_LIQUIDITY_POOL_WITHDRAW.liquidityPoolWithdrawOp = LiquidityPoolWithdrawOpXdr.Decode(stream);
                    return result_LIQUIDITY_POOL_WITHDRAW;
                    case OperationType.INVOKE_HOST_FUNCTION:
                    var result_INVOKE_HOST_FUNCTION = new bodyUnion_INVOKE_HOST_FUNCTION();
                    result_INVOKE_HOST_FUNCTION.invokeHostFunctionOp = InvokeHostFunctionOpXdr.Decode(stream);
                    return result_INVOKE_HOST_FUNCTION;
                    case OperationType.EXTEND_FOOTPRINT_TTL:
                    var result_EXTEND_FOOTPRINT_TTL = new bodyUnion_EXTEND_FOOTPRINT_TTL();
                    result_EXTEND_FOOTPRINT_TTL.extendFootprintTTLOp = ExtendFootprintTTLOpXdr.Decode(stream);
                    return result_EXTEND_FOOTPRINT_TTL;
                    case OperationType.RESTORE_FOOTPRINT:
                    var result_RESTORE_FOOTPRINT = new bodyUnion_RESTORE_FOOTPRINT();
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
