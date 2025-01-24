// Generated code - do not modify
// Source:

// typedef opaque Signature<64>;


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class Signature
{
    private byte[] _innerValue;
    public byte[] InnerValue
    {
        get => _innerValue;
        set
        {
            if (value.Length > 64)
                throw new ArgumentException($"Cannot exceed 64 bytes");
            _innerValue = value;
        }
    }

    public Signature() { }

    public Signature(byte[] value)
    {
        InnerValue = value;
    }
}

public static partial class SignatureXdr
{
    public static void Encode(XdrWriter stream, Signature value)
    {
        stream.WriteOpaque(value.InnerValue);
    }
    public static Signature Decode(XdrReader stream)
    {
        var result = new Signature();
        result.InnerValue = stream.ReadOpaque();
        return result;
    }
}
}
