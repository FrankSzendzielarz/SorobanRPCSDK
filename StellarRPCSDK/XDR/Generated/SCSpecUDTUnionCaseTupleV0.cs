// Generated code - do not modify
// Source:

// struct SCSpecUDTUnionCaseTupleV0
// {
//     string doc<SC_SPEC_DOC_LIMIT>;
//     string name<60>;
//     SCSpecTypeDef type<12>;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class SCSpecUDTUnionCaseTupleV0
{
    private SCSpecTypeDef[] _type;
    public SCSpecTypeDef[] type
    {
        get => _type;
        set
        {
            if (value.Length > 12)
                throw new ArgumentException($"Cannot exceed 12 bytes");
            _type = value;
        }
    }

    public SCSpecUDTUnionCaseTupleV0()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
        if (type.Length > 12)
            throw new InvalidOperationException($"type cannot exceed 12 elements");
    }
}

public static partial class SCSpecUDTUnionCaseTupleV0Xdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, SCSpecUDTUnionCaseTupleV0 value)
    {
        value.Validate();
        stream.WriteInt(value.type.Length);
        foreach (var item in value.type)
        {
            SCSpecTypeDefXdr.Encode(stream, item);
        }
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static SCSpecUDTUnionCaseTupleV0 Decode(XdrReader stream)
    {
        var result = new SCSpecUDTUnionCaseTupleV0();
        var length = stream.ReadInt();
        result.type = new SCSpecTypeDef[length];
        for (var i = 0; i < length; i++)
        {
            result.type[i] = SCSpecTypeDefXdr.Decode(stream);
        }
        return result;
    }
}
}
