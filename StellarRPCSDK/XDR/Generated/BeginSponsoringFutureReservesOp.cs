// Generated code - do not modify
// Source:

// struct BeginSponsoringFutureReservesOp
// {
//     AccountID sponsoredID;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class BeginSponsoringFutureReservesOp
{
    private AccountID _sponsoredID;
    public AccountID sponsoredID
    {
        get => _sponsoredID;
        set
        {
            _sponsoredID = value;
        }
    }

    public BeginSponsoringFutureReservesOp()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class BeginSponsoringFutureReservesOpXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, BeginSponsoringFutureReservesOp value)
    {
        value.Validate();
        AccountIDXdr.Encode(stream, value.sponsoredID);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static BeginSponsoringFutureReservesOp Decode(XdrReader stream)
    {
        var result = new BeginSponsoringFutureReservesOp();
        result.sponsoredID = AccountIDXdr.Decode(stream);
        return result;
    }
}
}
