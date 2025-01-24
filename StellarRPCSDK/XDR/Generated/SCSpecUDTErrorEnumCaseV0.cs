// Generated code - do not modify
// Source:

// struct SCSpecUDTErrorEnumCaseV0
// {
//     string doc<SC_SPEC_DOC_LIMIT>;
//     string name<60>;
//     uint32 value;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class SCSpecUDTErrorEnumCaseV0
{
    private uint32 _value;
    public uint32 value
    {
        get => _value;
        set
        {
            _value = value;
        }
    }

    public SCSpecUDTErrorEnumCaseV0()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class SCSpecUDTErrorEnumCaseV0Xdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, SCSpecUDTErrorEnumCaseV0 value)
    {
        value.Validate();
        uint32Xdr.Encode(stream, value.value);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static SCSpecUDTErrorEnumCaseV0 Decode(XdrReader stream)
    {
        var result = new SCSpecUDTErrorEnumCaseV0();
        result.value = uint32Xdr.Decode(stream);
        return result;
    }
}
}
