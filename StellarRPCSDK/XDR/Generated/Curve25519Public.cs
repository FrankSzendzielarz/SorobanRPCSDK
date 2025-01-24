// Generated code - do not modify
// Source:

// struct Curve25519Public
// {
//     opaque key[32];
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class Curve25519Public
{
    public Curve25519Public()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class Curve25519PublicXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, Curve25519Public value)
    {
        value.Validate();
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static Curve25519Public Decode(XdrReader stream)
    {
        var result = new Curve25519Public();
        return result;
    }
}
}
