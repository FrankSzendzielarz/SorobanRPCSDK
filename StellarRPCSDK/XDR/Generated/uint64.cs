// Generated code - do not modify
// Source:

// typedef unsigned hyper uint64;


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class uint64
{
    private object _innerValue;
    public object InnerValue
    {
        get => _innerValue;
        set
        {
            _innerValue = value;
        }
    }

    public uint64() { }

    public uint64(object value)
    {
        InnerValue = value;
    }
}

public static partial class uint64Xdr
{
    public static void Encode(XdrWriter stream, uint64 value)
    {
        Xdr.Encode(stream, value.InnerValue);
    }
    public static uint64 Decode(XdrReader stream)
    {
        var result = new uint64();
        result.InnerValue = Xdr.Decode(stream);
        return result;
    }
}
}
