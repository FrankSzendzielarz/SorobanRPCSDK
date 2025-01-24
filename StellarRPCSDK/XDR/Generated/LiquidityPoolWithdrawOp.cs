// Generated code - do not modify
// Source:

// struct LiquidityPoolWithdrawOp
// {
//     PoolID liquidityPoolID;
//     int64 amount;     // amount of pool shares to withdraw
//     int64 minAmountA; // minimum amount of first asset to withdraw
//     int64 minAmountB; // minimum amount of second asset to withdraw
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class LiquidityPoolWithdrawOp
{
    private PoolID _liquidityPoolID;
    public PoolID liquidityPoolID
    {
        get => _liquidityPoolID;
        set
        {
            _liquidityPoolID = value;
        }
    }

    private int64 _amount;
    public int64 amount
    {
        get => _amount;
        set
        {
            _amount = value;
        }
    }

    private int64 _minAmountA;
    public int64 minAmountA
    {
        get => _minAmountA;
        set
        {
            _minAmountA = value;
        }
    }

    private int64 _minAmountB;
    public int64 minAmountB
    {
        get => _minAmountB;
        set
        {
            _minAmountB = value;
        }
    }

    public LiquidityPoolWithdrawOp()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class LiquidityPoolWithdrawOpXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, LiquidityPoolWithdrawOp value)
    {
        value.Validate();
        PoolIDXdr.Encode(stream, value.liquidityPoolID);
        int64Xdr.Encode(stream, value.amount);
        int64Xdr.Encode(stream, value.minAmountA);
        int64Xdr.Encode(stream, value.minAmountB);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static LiquidityPoolWithdrawOp Decode(XdrReader stream)
    {
        var result = new LiquidityPoolWithdrawOp();
        result.liquidityPoolID = PoolIDXdr.Decode(stream);
        result.amount = int64Xdr.Decode(stream);
        result.minAmountA = int64Xdr.Decode(stream);
        result.minAmountB = int64Xdr.Decode(stream);
        return result;
    }
}
}
