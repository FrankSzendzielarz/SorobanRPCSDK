// Generated code - do not modify
// Source:

// struct FloodDemand
// {
//     TxDemandVector txHashes;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class FloodDemand
{
    private TxDemandVector _txHashes;
    public TxDemandVector txHashes
    {
        get => _txHashes;
        set
        {
            _txHashes = value;
        }
    }

    public FloodDemand()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class FloodDemandXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, FloodDemand value)
    {
        value.Validate();
        TxDemandVectorXdr.Encode(stream, value.txHashes);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static FloodDemand Decode(XdrReader stream)
    {
        var result = new FloodDemand();
        result.txHashes = TxDemandVectorXdr.Decode(stream);
        return result;
    }
}
}
