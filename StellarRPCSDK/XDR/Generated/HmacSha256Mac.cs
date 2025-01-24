// Generated code - do not modify
// Source:

// struct HmacSha256Mac
// {
//     opaque mac[32];
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class HmacSha256Mac
{
    public HmacSha256Mac()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class HmacSha256MacXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, HmacSha256Mac value)
    {
        value.Validate();
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static HmacSha256Mac Decode(XdrReader stream)
    {
        var result = new HmacSha256Mac();
        return result;
    }
}
}
