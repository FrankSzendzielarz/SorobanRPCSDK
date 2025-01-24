// Generated code - do not modify
// Source:

// struct ArchivalProof
// {
//     uint32 epoch; // AST Subtree for this proof
// 
//     union switch (ArchivalProofType t)
//     {
//     case EXISTENCE:
//         NonexistenceProofBody nonexistenceProof;
//     case NONEXISTENCE:
//         ExistenceProofBody existenceProof;
//     } body;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class ArchivalProof
{
    private uint32 _epoch;
    public uint32 epoch
    {
        get => _epoch;
        set
        {
            _epoch = value;
        }
    }

    private object _body;
    public object body
    {
        get => _body;
        set
        {
            _body = value;
        }
    }

    public ArchivalProof()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class ArchivalProofXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, ArchivalProof value)
    {
        value.Validate();
        uint32Xdr.Encode(stream, value.epoch);
        Xdr.Encode(stream, value.body);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static ArchivalProof Decode(XdrReader stream)
    {
        var result = new ArchivalProof();
        result.epoch = uint32Xdr.Decode(stream);
        result.body = Xdr.Decode(stream);
        return result;
    }
}
}
