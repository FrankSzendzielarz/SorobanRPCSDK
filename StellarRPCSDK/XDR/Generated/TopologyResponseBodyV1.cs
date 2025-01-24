// Generated code - do not modify
// Source:

// struct TopologyResponseBodyV1
// {
//     PeerStatList inboundPeers;
//     PeerStatList outboundPeers;
// 
//     uint32 totalInboundPeerCount;
//     uint32 totalOutboundPeerCount;
// 
//     uint32 maxInboundPeerCount;
//     uint32 maxOutboundPeerCount;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class TopologyResponseBodyV1
{
    private PeerStatList _inboundPeers;
    public PeerStatList inboundPeers
    {
        get => _inboundPeers;
        set
        {
            _inboundPeers = value;
        }
    }

    private PeerStatList _outboundPeers;
    public PeerStatList outboundPeers
    {
        get => _outboundPeers;
        set
        {
            _outboundPeers = value;
        }
    }

    private uint32 _totalInboundPeerCount;
    public uint32 totalInboundPeerCount
    {
        get => _totalInboundPeerCount;
        set
        {
            _totalInboundPeerCount = value;
        }
    }

    private uint32 _totalOutboundPeerCount;
    public uint32 totalOutboundPeerCount
    {
        get => _totalOutboundPeerCount;
        set
        {
            _totalOutboundPeerCount = value;
        }
    }

    private uint32 _maxInboundPeerCount;
    public uint32 maxInboundPeerCount
    {
        get => _maxInboundPeerCount;
        set
        {
            _maxInboundPeerCount = value;
        }
    }

    private uint32 _maxOutboundPeerCount;
    public uint32 maxOutboundPeerCount
    {
        get => _maxOutboundPeerCount;
        set
        {
            _maxOutboundPeerCount = value;
        }
    }

    public TopologyResponseBodyV1()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class TopologyResponseBodyV1Xdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, TopologyResponseBodyV1 value)
    {
        value.Validate();
        PeerStatListXdr.Encode(stream, value.inboundPeers);
        PeerStatListXdr.Encode(stream, value.outboundPeers);
        uint32Xdr.Encode(stream, value.totalInboundPeerCount);
        uint32Xdr.Encode(stream, value.totalOutboundPeerCount);
        uint32Xdr.Encode(stream, value.maxInboundPeerCount);
        uint32Xdr.Encode(stream, value.maxOutboundPeerCount);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static TopologyResponseBodyV1 Decode(XdrReader stream)
    {
        var result = new TopologyResponseBodyV1();
        result.inboundPeers = PeerStatListXdr.Decode(stream);
        result.outboundPeers = PeerStatListXdr.Decode(stream);
        result.totalInboundPeerCount = uint32Xdr.Decode(stream);
        result.totalOutboundPeerCount = uint32Xdr.Decode(stream);
        result.maxInboundPeerCount = uint32Xdr.Decode(stream);
        result.maxOutboundPeerCount = uint32Xdr.Decode(stream);
        return result;
    }
}
}
