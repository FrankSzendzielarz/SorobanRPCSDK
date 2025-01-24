// Generated code - do not modify
// Source:

// struct Int128Parts {
//     int64 hi;
//     uint64 lo;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class Int128Parts
{
    private int64 _hi;
    public int64 hi
    {
        get => _hi;
        set
        {
            _hi = value;
        }
    }

    private uint64 _lo;
    public uint64 lo
    {
        get => _lo;
        set
        {
            _lo = value;
        }
    }

    public Int128Parts()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class Int128PartsXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, Int128Parts value)
    {
        value.Validate();
        int64Xdr.Encode(stream, value.hi);
        uint64Xdr.Encode(stream, value.lo);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static Int128Parts Decode(XdrReader stream)
    {
        var result = new Int128Parts();
        result.hi = int64Xdr.Decode(stream);
        result.lo = uint64Xdr.Decode(stream);
        return result;
    }
}
}
