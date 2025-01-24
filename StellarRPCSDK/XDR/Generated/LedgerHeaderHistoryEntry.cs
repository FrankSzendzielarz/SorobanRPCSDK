// Generated code - do not modify
// Source:

// struct LedgerHeaderHistoryEntry
// {
//     Hash hash;
//     LedgerHeader header;
// 
//     // reserved for future use
//     union switch (int v)
//     {
//     case 0:
//         void;
//     }
//     ext;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class LedgerHeaderHistoryEntry
{
    private Hash _hash;
    public Hash hash
    {
        get => _hash;
        set
        {
            _hash = value;
        }
    }

    private LedgerHeader _header;
    public LedgerHeader header
    {
        get => _header;
        set
        {
            _header = value;
        }
    }

    private object _ext;
    public object ext
    {
        get => _ext;
        set
        {
            _ext = value;
        }
    }

    public LedgerHeaderHistoryEntry()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class LedgerHeaderHistoryEntryXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, LedgerHeaderHistoryEntry value)
    {
        value.Validate();
        HashXdr.Encode(stream, value.hash);
        LedgerHeaderXdr.Encode(stream, value.header);
        Xdr.Encode(stream, value.ext);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static LedgerHeaderHistoryEntry Decode(XdrReader stream)
    {
        var result = new LedgerHeaderHistoryEntry();
        result.hash = HashXdr.Decode(stream);
        result.header = LedgerHeaderXdr.Decode(stream);
        result.ext = Xdr.Decode(stream);
        return result;
    }
}
}
