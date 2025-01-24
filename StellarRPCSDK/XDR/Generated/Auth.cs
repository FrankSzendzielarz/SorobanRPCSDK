// Generated code - do not modify
// Source:

// struct Auth
// {
//     int flags;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class Auth
{
    private int _flags;
    public int flags
    {
        get => _flags;
        set
        {
            _flags = value;
        }
    }

    public Auth()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class AuthXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, Auth value)
    {
        value.Validate();
        stream.WriteInt(value.flags);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static Auth Decode(XdrReader stream)
    {
        var result = new Auth();
        result.flags = stream.ReadInt();
        return result;
    }
}
}
