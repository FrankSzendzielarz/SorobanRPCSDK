// Generated code - do not modify
// Source:

// struct SCMetaV0
// {
//     string key<>;
//     string val<>;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class SCMetaV0
{
    public SCMetaV0()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class SCMetaV0Xdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, SCMetaV0 value)
    {
        value.Validate();
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static SCMetaV0 Decode(XdrReader stream)
    {
        var result = new SCMetaV0();
        return result;
    }
}
}
