// Generated code - do not modify
// Source:

// typedef opaque Value<>;


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class Value
{
    private byte[] _innerValue;
    public byte[] InnerValue
    {
        get => _innerValue;
        set
        {
            _innerValue = value;
        }
    }

    public Value() { }

    public Value(byte[] value)
    {
        InnerValue = value;
    }
}

public static partial class ValueXdr
{
    public static void Encode(XdrWriter stream, Value value)
    {
        stream.WriteOpaque(value.InnerValue);
    }
    public static Value Decode(XdrReader stream)
    {
        var result = new Value();
        result.InnerValue = stream.ReadOpaque();
        return result;
    }
}
}
