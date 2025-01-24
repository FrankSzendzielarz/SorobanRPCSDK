// Generated code - do not modify
// Source:

// struct PeerAddress
// {
//     union switch (IPAddrType type)
//     {
//     case IPv4:
//         opaque ipv4[4];
//     case IPv6:
//         opaque ipv6[16];
//     }
//     ip;
//     uint32 port;
//     uint32 numFailures;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class PeerAddress
{
    private object _ip;
    public object ip
    {
        get => _ip;
        set
        {
            _ip = value;
        }
    }

    private uint32 _port;
    public uint32 port
    {
        get => _port;
        set
        {
            _port = value;
        }
    }

    private uint32 _numFailures;
    public uint32 numFailures
    {
        get => _numFailures;
        set
        {
            _numFailures = value;
        }
    }

    public PeerAddress()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class PeerAddressXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, PeerAddress value)
    {
        value.Validate();
        Xdr.Encode(stream, value.ip);
        uint32Xdr.Encode(stream, value.port);
        uint32Xdr.Encode(stream, value.numFailures);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static PeerAddress Decode(XdrReader stream)
    {
        var result = new PeerAddress();
        result.ip = Xdr.Decode(stream);
        result.port = uint32Xdr.Decode(stream);
        result.numFailures = uint32Xdr.Decode(stream);
        return result;
    }
}
}
