// Generated code - do not modify
// Source:

// struct HmacSha256Key
// {
//     opaque key[32];
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class HmacSha256Key
{
    public HmacSha256Key()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class HmacSha256KeyXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, HmacSha256Key value)
    {
        value.Validate();
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static HmacSha256Key Decode(XdrReader stream)
    {
        var result = new HmacSha256Key();
        return result;
    }
}
}
