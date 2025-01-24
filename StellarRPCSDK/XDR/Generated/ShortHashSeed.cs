// Generated code - do not modify
// Source:

// struct ShortHashSeed
// {
//     opaque seed[16];
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class ShortHashSeed
{
    public ShortHashSeed()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class ShortHashSeedXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, ShortHashSeed value)
    {
        value.Validate();
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static ShortHashSeed Decode(XdrReader stream)
    {
        var result = new ShortHashSeed();
        return result;
    }
}
}
