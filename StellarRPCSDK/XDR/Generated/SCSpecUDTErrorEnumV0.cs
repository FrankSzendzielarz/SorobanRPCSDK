// Generated code - do not modify
// Source:

// struct SCSpecUDTErrorEnumV0
// {
//     string doc<SC_SPEC_DOC_LIMIT>;
//     string lib<80>;
//     string name<60>;
//     SCSpecUDTErrorEnumCaseV0 cases<50>;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class SCSpecUDTErrorEnumV0
{
    private SCSpecUDTErrorEnumCaseV0[] _cases;
    public SCSpecUDTErrorEnumCaseV0[] cases
    {
        get => _cases;
        set
        {
            if (value.Length > 50)
                throw new ArgumentException($"Cannot exceed 50 bytes");
            _cases = value;
        }
    }

    public SCSpecUDTErrorEnumV0()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
        if (cases.Length > 50)
            throw new InvalidOperationException($"cases cannot exceed 50 elements");
    }
}

public static partial class SCSpecUDTErrorEnumV0Xdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, SCSpecUDTErrorEnumV0 value)
    {
        value.Validate();
        stream.WriteInt(value.cases.Length);
        foreach (var item in value.cases)
        {
            SCSpecUDTErrorEnumCaseV0Xdr.Encode(stream, item);
        }
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static SCSpecUDTErrorEnumV0 Decode(XdrReader stream)
    {
        var result = new SCSpecUDTErrorEnumV0();
        var length = stream.ReadInt();
        result.cases = new SCSpecUDTErrorEnumCaseV0[length];
        for (var i = 0; i < length; i++)
        {
            result.cases[i] = SCSpecUDTErrorEnumCaseV0Xdr.Decode(stream);
        }
        return result;
    }
}
}
