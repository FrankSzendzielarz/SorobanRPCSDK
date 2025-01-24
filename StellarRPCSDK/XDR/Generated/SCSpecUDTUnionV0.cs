// Generated code - do not modify
// Source:

// struct SCSpecUDTUnionV0
// {
//     string doc<SC_SPEC_DOC_LIMIT>;
//     string lib<80>;
//     string name<60>;
//     SCSpecUDTUnionCaseV0 cases<50>;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class SCSpecUDTUnionV0
{
    private SCSpecUDTUnionCaseV0[] _cases;
    public SCSpecUDTUnionCaseV0[] cases
    {
        get => _cases;
        set
        {
            if (value.Length > 50)
                throw new ArgumentException($"Cannot exceed 50 bytes");
            _cases = value;
        }
    }

    public SCSpecUDTUnionV0()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
        if (cases.Length > 50)
            throw new InvalidOperationException($"cases cannot exceed 50 elements");
    }
}

public static partial class SCSpecUDTUnionV0Xdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, SCSpecUDTUnionV0 value)
    {
        value.Validate();
        stream.WriteInt(value.cases.Length);
        foreach (var item in value.cases)
        {
            SCSpecUDTUnionCaseV0Xdr.Encode(stream, item);
        }
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static SCSpecUDTUnionV0 Decode(XdrReader stream)
    {
        var result = new SCSpecUDTUnionV0();
        var length = stream.ReadInt();
        result.cases = new SCSpecUDTUnionCaseV0[length];
        for (var i = 0; i < length; i++)
        {
            result.cases[i] = SCSpecUDTUnionCaseV0Xdr.Decode(stream);
        }
        return result;
    }
}
}
