// Generated code - do not modify
// Source:

// struct NonexistenceProofBody
// {
//     ColdArchiveBucketEntry entriesToProve<>;
// 
//     // Vector of vectors, where proofLevels[level]
//     // contains all HashNodes that correspond with that level
//     ProofLevel proofLevels<>;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class NonexistenceProofBody
{
    private ColdArchiveBucketEntry[] _entriesToProve;
    public ColdArchiveBucketEntry[] entriesToProve
    {
        get => _entriesToProve;
        set
        {
            _entriesToProve = value;
        }
    }

    private ProofLevel[] _proofLevels;
    public ProofLevel[] proofLevels
    {
        get => _proofLevels;
        set
        {
            _proofLevels = value;
        }
    }

    public NonexistenceProofBody()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class NonexistenceProofBodyXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, NonexistenceProofBody value)
    {
        value.Validate();
        stream.WriteInt(value.entriesToProve.Length);
        foreach (var item in value.entriesToProve)
        {
            ColdArchiveBucketEntryXdr.Encode(stream, item);
        }
        stream.WriteInt(value.proofLevels.Length);
        foreach (var item in value.proofLevels)
        {
            ProofLevelXdr.Encode(stream, item);
        }
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static NonexistenceProofBody Decode(XdrReader stream)
    {
        var result = new NonexistenceProofBody();
        var length = stream.ReadInt();
        result.entriesToProve = new ColdArchiveBucketEntry[length];
        for (var i = 0; i < length; i++)
        {
            result.entriesToProve[i] = ColdArchiveBucketEntryXdr.Decode(stream);
        }
        var length = stream.ReadInt();
        result.proofLevels = new ProofLevel[length];
        for (var i = 0; i < length; i++)
        {
            result.proofLevels[i] = ProofLevelXdr.Decode(stream);
        }
        return result;
    }
}
}
