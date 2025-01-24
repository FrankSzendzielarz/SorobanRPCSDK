// Generated code - do not modify
// Source:

// struct SCSpecUDTEnumV0
// {
//     string doc<SC_SPEC_DOC_LIMIT>;
//     string lib<80>;
//     string name<60>;
//     SCSpecUDTEnumCaseV0 cases<50>;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class SCSpecUDTEnumV0
{
    private SCSpecUDTEnumCaseV0[] _cases;
    public SCSpecUDTEnumCaseV0[] cases
    {
        get => _cases;
        set
        {
            if (value.Length > 50)
                throw new ArgumentException($"Cannot exceed 50 bytes");
            _cases = value;
        }
    }

    public SCSpecUDTEnumV0()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
        if (cases.Length > 50)
            throw new InvalidOperationException($"cases cannot exceed 50 elements");
    }
}

public static partial class SCSpecUDTEnumV0Xdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, SCSpecUDTEnumV0 value)
    {
        value.Validate();
        stream.WriteInt(value.cases.Length);
        foreach (var item in value.cases)
        {
            SCSpecUDTEnumCaseV0Xdr.Encode(stream, item);
        }
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static SCSpecUDTEnumV0 Decode(XdrReader stream)
    {
        var result = new SCSpecUDTEnumV0();
        var length = stream.ReadInt();
        result.cases = new SCSpecUDTEnumCaseV0[length];
        for (var i = 0; i < length; i++)
        {
            result.cases[i] = SCSpecUDTEnumCaseV0Xdr.Decode(stream);
        }
        return result;
    }
}
}
