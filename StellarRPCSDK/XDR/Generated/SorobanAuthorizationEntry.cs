// Generated code - do not modify
// Source:

// struct SorobanAuthorizationEntry
// {
//     SorobanCredentials credentials;
//     SorobanAuthorizedInvocation rootInvocation;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class SorobanAuthorizationEntry
{
    private SorobanCredentials _credentials;
    public SorobanCredentials credentials
    {
        get => _credentials;
        set
        {
            _credentials = value;
        }
    }

    private SorobanAuthorizedInvocation _rootInvocation;
    public SorobanAuthorizedInvocation rootInvocation
    {
        get => _rootInvocation;
        set
        {
            _rootInvocation = value;
        }
    }

    public SorobanAuthorizationEntry()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class SorobanAuthorizationEntryXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, SorobanAuthorizationEntry value)
    {
        value.Validate();
        SorobanCredentialsXdr.Encode(stream, value.credentials);
        SorobanAuthorizedInvocationXdr.Encode(stream, value.rootInvocation);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static SorobanAuthorizationEntry Decode(XdrReader stream)
    {
        var result = new SorobanAuthorizationEntry();
        result.credentials = SorobanCredentialsXdr.Decode(stream);
        result.rootInvocation = SorobanAuthorizedInvocationXdr.Decode(stream);
        return result;
    }
}
}
