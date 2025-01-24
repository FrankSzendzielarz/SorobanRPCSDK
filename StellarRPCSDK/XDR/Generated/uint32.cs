// Generated code - do not modify
// Source:

// typedef unsigned int uint32;


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class uint32
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

    public uint32() { }

    public uint32(object value)
    {
        InnerValue = value;
    }
}

public static partial class uint32Xdr
{
    public static void Encode(XdrWriter stream, uint32 value)
    {
        Xdr.Encode(stream, value.InnerValue);
    }
    public static uint32 Decode(XdrReader stream)
    {
        var result = new uint32();
        result.InnerValue = Xdr.Decode(stream);
        return result;
    }
}
}
