// Generated code - do not modify
// Source:

// struct TransactionResult
// {
//     int64 feeCharged; // actual fee charged for the transaction
// 
//     union switch (TransactionResultCode code)
//     {
//     case txFEE_BUMP_INNER_SUCCESS:
//     case txFEE_BUMP_INNER_FAILED:
//         InnerTransactionResultPair innerResultPair;
//     case txSUCCESS:
//     case txFAILED:
//         OperationResult results<>;
//     case txTOO_EARLY:
//     case txTOO_LATE:
//     case txMISSING_OPERATION:
//     case txBAD_SEQ:
//     case txBAD_AUTH:
//     case txINSUFFICIENT_BALANCE:
//     case txNO_ACCOUNT:
//     case txINSUFFICIENT_FEE:
//     case txBAD_AUTH_EXTRA:
//     case txINTERNAL_ERROR:
//     case txNOT_SUPPORTED:
//     // case txFEE_BUMP_INNER_FAILED: handled above
//     case txBAD_SPONSORSHIP:
//     case txBAD_MIN_SEQ_AGE_OR_GAP:
//     case txMALFORMED:
//     case txSOROBAN_INVALID:
//         void;
//     }
//     result;
// 
//     // reserved for future use
//     union switch (int v)
//     {
//     case 0:
//         void;
//     }
//     ext;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class TransactionResult
{
    private int64 _feeCharged;
    public int64 feeCharged
    {
        get => _feeCharged;
        set
        {
            _feeCharged = value;
        }
    }

    private object _result;
    public object result
    {
        get => _result;
        set
        {
            _result = value;
        }
    }

    private object _ext;
    public object ext
    {
        get => _ext;
        set
        {
            _ext = value;
        }
    }

    public TransactionResult()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class TransactionResultXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, TransactionResult value)
    {
        value.Validate();
        int64Xdr.Encode(stream, value.feeCharged);
        Xdr.Encode(stream, value.result);
        Xdr.Encode(stream, value.ext);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static TransactionResult Decode(XdrReader stream)
    {
        var result = new TransactionResult();
        result.feeCharged = int64Xdr.Decode(stream);
        result.result = Xdr.Decode(stream);
        result.ext = Xdr.Decode(stream);
        return result;
    }
}
}
