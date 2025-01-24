// Generated code - do not modify
// Source:

// typedef Hash TxAdvertVector<TX_ADVERT_VECTOR_MAX_SIZE>;


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class TxAdvertVector
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

    public TxAdvertVector() { }

    public TxAdvertVector(Hash[] value)
    {
        InnerValue = value;
    }
}

public static partial class TxAdvertVectorXdr
{
    public static void Encode(XdrWriter stream, TxAdvertVector value)
    {
        stream.WriteInt(value.InnerValue.Length);
        foreach (var item in value.InnerValue)
        {
            HashXdr.Encode(stream, item);
        }
    }
    public static TxAdvertVector Decode(XdrReader stream)
    {
        var result = new TxAdvertVector();
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
