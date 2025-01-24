// Generated code - do not modify
// Source:

// struct ColdArchiveHashEntry
// {
//     uint32 index;
//     uint32 level;
//     Hash hash;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class ColdArchiveHashEntry
{
    private uint32 _index;
    public uint32 index
    {
        get => _index;
        set
        {
            _index = value;
        }
    }

    private uint32 _level;
    public uint32 level
    {
        get => _level;
        set
        {
            _level = value;
        }
    }

    private Hash _hash;
    public Hash hash
    {
        get => _hash;
        set
        {
            _hash = value;
        }
    }

    public ColdArchiveHashEntry()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class ColdArchiveHashEntryXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, ColdArchiveHashEntry value)
    {
        value.Validate();
        uint32Xdr.Encode(stream, value.index);
        uint32Xdr.Encode(stream, value.level);
        HashXdr.Encode(stream, value.hash);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static ColdArchiveHashEntry Decode(XdrReader stream)
    {
        var result = new ColdArchiveHashEntry();
        result.index = uint32Xdr.Decode(stream);
        result.level = uint32Xdr.Decode(stream);
        result.hash = HashXdr.Decode(stream);
        return result;
    }
}
}
