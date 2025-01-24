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

namespace stellar {

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

    private object _body;
    public object body
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
}

public static partial class OperationXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, Operation value)
    {
        value.Validate();
        MuxedAccountXdr.Encode(stream, value.sourceAccount);
        Xdr.Encode(stream, value.body);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static Operation Decode(XdrReader stream)
    {
        var result = new Operation();
        result.sourceAccount = MuxedAccountXdr.Decode(stream);
        result.body = Xdr.Decode(stream);
        return result;
    }
}
}
