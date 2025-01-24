// Generated code - do not modify
// Source:

// struct Error
// {
//     ErrorCode code;
//     string msg<100>;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class Error
{
    private ErrorCode _code;
    public ErrorCode code
    {
        get => _code;
        set
        {
            _code = value;
        }
    }

    public Error()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class ErrorXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, Error value)
    {
        value.Validate();
        ErrorCodeXdr.Encode(stream, value.code);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static Error Decode(XdrReader stream)
    {
        var result = new Error();
        result.code = ErrorCodeXdr.Decode(stream);
        return result;
    }
}
}
