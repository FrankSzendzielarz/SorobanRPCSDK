// Generated code - do not modify
// Source:

// typedef uint64 Duration;


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class Duration
{
    private uint64 _innerValue;
    public uint64 InnerValue
    {
        get => _innerValue;
        set
        {
            _innerValue = value;
        }
    }

    public Duration() { }

    public Duration(uint64 value)
    {
        InnerValue = value;
    }
}

public static partial class DurationXdr
{
    public static void Encode(XdrWriter stream, Duration value)
    {
        uint64Xdr.Encode(stream, value.InnerValue);
    }
    public static Duration Decode(XdrReader stream)
    {
        var result = new Duration();
        result.InnerValue = uint64Xdr.Decode(stream);
        return result;
    }
}
}
