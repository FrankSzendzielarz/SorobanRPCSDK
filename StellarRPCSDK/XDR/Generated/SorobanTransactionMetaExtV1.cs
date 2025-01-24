// Generated code - do not modify
// Source:

// struct SorobanTransactionMetaExtV1
// {
//     ExtensionPoint ext;
// 
//     // The following are the components of the overall Soroban resource fee
//     // charged for the transaction.
//     // The following relation holds:
//     // `resourceFeeCharged = totalNonRefundableResourceFeeCharged + totalRefundableResourceFeeCharged`
//     // where `resourceFeeCharged` is the overall fee charged for the 
//     // transaction. Also, `resourceFeeCharged` <= `sorobanData.resourceFee` 
//     // i.e.we never charge more than the declared resource fee.
//     // The inclusion fee for charged the Soroban transaction can be found using 
//     // the following equation:
//     // `result.feeCharged = resourceFeeCharged + inclusionFeeCharged`.
// 
//     // Total amount (in stroops) that has been charged for non-refundable
//     // Soroban resources.
//     // Non-refundable resources are charged based on the usage declared in
//     // the transaction envelope (such as `instructions`, `readBytes` etc.) and 
//     // is charged regardless of the success of the transaction.
//     int64 totalNonRefundableResourceFeeCharged;
//     // Total amount (in stroops) that has been charged for refundable
//     // Soroban resource fees.
//     // Currently this comprises the rent fee (`rentFeeCharged`) and the
//     // fee for the events and return value.
//     // Refundable resources are charged based on the actual resources usage.
//     // Since currently refundable resources are only used for the successful
//     // transactions, this will be `0` for failed transactions.
//     int64 totalRefundableResourceFeeCharged;
//     // Amount (in stroops) that has been charged for rent.
//     // This is a part of `totalNonRefundableResourceFeeCharged`.
//     int64 rentFeeCharged;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class SorobanTransactionMetaExtV1
{
    private ExtensionPoint _ext;
    public ExtensionPoint ext
    {
        get => _ext;
        set
        {
            _ext = value;
        }
    }

    private int64 _totalNonRefundableResourceFeeCharged;
    public int64 totalNonRefundableResourceFeeCharged
    {
        get => _totalNonRefundableResourceFeeCharged;
        set
        {
            _totalNonRefundableResourceFeeCharged = value;
        }
    }

    private int64 _totalRefundableResourceFeeCharged;
    public int64 totalRefundableResourceFeeCharged
    {
        get => _totalRefundableResourceFeeCharged;
        set
        {
            _totalRefundableResourceFeeCharged = value;
        }
    }

    private int64 _rentFeeCharged;
    public int64 rentFeeCharged
    {
        get => _rentFeeCharged;
        set
        {
            _rentFeeCharged = value;
        }
    }

    public SorobanTransactionMetaExtV1()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class SorobanTransactionMetaExtV1Xdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, SorobanTransactionMetaExtV1 value)
    {
        value.Validate();
        ExtensionPointXdr.Encode(stream, value.ext);
        int64Xdr.Encode(stream, value.totalNonRefundableResourceFeeCharged);
        int64Xdr.Encode(stream, value.totalRefundableResourceFeeCharged);
        int64Xdr.Encode(stream, value.rentFeeCharged);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static SorobanTransactionMetaExtV1 Decode(XdrReader stream)
    {
        var result = new SorobanTransactionMetaExtV1();
        result.ext = ExtensionPointXdr.Decode(stream);
        result.totalNonRefundableResourceFeeCharged = int64Xdr.Decode(stream);
        result.totalRefundableResourceFeeCharged = int64Xdr.Decode(stream);
        result.rentFeeCharged = int64Xdr.Decode(stream);
        return result;
    }
}
}
