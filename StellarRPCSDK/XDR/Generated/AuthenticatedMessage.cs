// Generated code - do not modify
// Source:

// union AuthenticatedMessage switch (uint32 v)
// {
// case 0:
//     struct
//     {
//         uint64 sequence;
//         StellarMessage message;
//         HmacSha256Mac mac;
//     } v0;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public abstract partial class AuthenticatedMessage
{
    public abstract uint32 Discriminator { get; }

    /// <summary>Validates the union case matches its discriminator</summary>
    public abstract void ValidateCase();
}

public sealed partial class AuthenticatedMessage_0 : AuthenticatedMessage
{
    public override uint32 Discriminator => 0;
    private object _v0;
    public object v0
    {
        get => _v0;
        set
        {
            _v0 = value;
        }
    }

    public override void ValidateCase() {}
}

public static partial class AuthenticatedMessageXdr
{
    public static void Encode(XdrWriter stream, AuthenticatedMessage value)
    {
        value.ValidateCase();
        stream.WriteInt((int)value.Discriminator);
        switch (value)
        {
            case AuthenticatedMessage_0 case_0:
                Xdr.Encode(stream, case_0.v0);
                break;
        }
    }
    public static AuthenticatedMessage Decode(XdrReader stream)
    {
        var discriminator = (uint32)stream.ReadInt();
        switch (discriminator)
        {
            case 0:
                var result_0 = new AuthenticatedMessage_0();
                result_0.v0 = Xdr.Decode(stream);
                return result_0;
            default:
                throw new Exception($"Unknown discriminator for AuthenticatedMessage: {discriminator}");
        }
    }
}
}
