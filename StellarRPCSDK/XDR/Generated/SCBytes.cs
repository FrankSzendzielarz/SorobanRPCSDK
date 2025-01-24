// Generated code - do not modify
// Source:

// typedef opaque SCBytes<>;


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class SCBytes
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

    public SCBytes() { }

    public SCBytes(byte[] value)
    {
        InnerValue = value;
    }
}

public static partial class SCBytesXdr
{
    public static void Encode(XdrWriter stream, SCBytes value)
    {
        stream.WriteOpaque(value.InnerValue);
    }
    public static SCBytes Decode(XdrReader stream)
    {
        var result = new SCBytes();
        result.InnerValue = stream.ReadOpaque();
        return result;
    }
}
}
