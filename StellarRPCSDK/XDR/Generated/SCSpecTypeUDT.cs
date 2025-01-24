// Generated code - do not modify
// Source:

// struct SCSpecTypeUDT
// {
//     string name<60>;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class SCSpecTypeUDT
{
    public SCSpecTypeUDT()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class SCSpecTypeUDTXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, SCSpecTypeUDT value)
    {
        value.Validate();
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static SCSpecTypeUDT Decode(XdrReader stream)
    {
        var result = new SCSpecTypeUDT();
        return result;
    }
}
}
