// Generated code - do not modify
// Source:

// struct ClaimClaimableBalanceOp
// {
//     ClaimableBalanceID balanceID;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class ClaimClaimableBalanceOp
{
    private ClaimableBalanceID _balanceID;
    public ClaimableBalanceID balanceID
    {
        get => _balanceID;
        set
        {
            _balanceID = value;
        }
    }

    public ClaimClaimableBalanceOp()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class ClaimClaimableBalanceOpXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, ClaimClaimableBalanceOp value)
    {
        value.Validate();
        ClaimableBalanceIDXdr.Encode(stream, value.balanceID);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static ClaimClaimableBalanceOp Decode(XdrReader stream)
    {
        var result = new ClaimClaimableBalanceOp();
        result.balanceID = ClaimableBalanceIDXdr.Decode(stream);
        return result;
    }
}
}
