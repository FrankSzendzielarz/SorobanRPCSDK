// Generated code - do not modify
// Source:

// typedef Hash TxDemandVector<TX_DEMAND_VECTOR_MAX_SIZE>;


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class TxDemandVector
{
    private Hash[] _innerValue;
    public Hash[] InnerValue
    {
        get => _innerValue;
        set
        {
            _innerValue = value;
        }
    }

    public TxDemandVector() { }

    public TxDemandVector(Hash[] value)
    {
        InnerValue = value;
    }
}

public static partial class TxDemandVectorXdr
{
    public static void Encode(XdrWriter stream, TxDemandVector value)
    {
        stream.WriteInt(value.InnerValue.Length);
        foreach (var item in value.InnerValue)
        {
            HashXdr.Encode(stream, item);
        }
    }
    public static TxDemandVector Decode(XdrReader stream)
    {
        var result = new TxDemandVector();
        var length = stream.ReadInt();
        result.InnerValue = new Hash[length];
        for (var i = 0; i < length; i++)
        {
            result.InnerValue[i] = HashXdr.Decode(stream);
        }
        return result;
    }
}
}
