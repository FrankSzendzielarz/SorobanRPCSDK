// Generated code - do not modify
// Source:

// struct TimeSlicedNodeData
// {
//     uint32 addedAuthenticatedPeers;
//     uint32 droppedAuthenticatedPeers;
//     uint32 totalInboundPeerCount;
//     uint32 totalOutboundPeerCount;
// 
//     // SCP stats
//     uint32 p75SCPFirstToSelfLatencyMs;
//     uint32 p75SCPSelfToOtherLatencyMs;
// 
//     // How many times the node lost sync in the time slice
//     uint32 lostSyncCount;
// 
//     // Config data
//     bool isValidator;
//     uint32 maxInboundPeerCount;
//     uint32 maxOutboundPeerCount;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class TimeSlicedNodeData
{
    private uint32 _addedAuthenticatedPeers;
    public uint32 addedAuthenticatedPeers
    {
        get => _addedAuthenticatedPeers;
        set
        {
            _addedAuthenticatedPeers = value;
        }
    }

    private uint32 _droppedAuthenticatedPeers;
    public uint32 droppedAuthenticatedPeers
    {
        get => _droppedAuthenticatedPeers;
        set
        {
            _droppedAuthenticatedPeers = value;
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

    private uint32 _p75SCPFirstToSelfLatencyMs;
    public uint32 p75SCPFirstToSelfLatencyMs
    {
        get => _p75SCPFirstToSelfLatencyMs;
        set
        {
            _p75SCPFirstToSelfLatencyMs = value;
        }
    }

    private uint32 _p75SCPSelfToOtherLatencyMs;
    public uint32 p75SCPSelfToOtherLatencyMs
    {
        get => _p75SCPSelfToOtherLatencyMs;
        set
        {
            _p75SCPSelfToOtherLatencyMs = value;
        }
    }

    private uint32 _lostSyncCount;
    public uint32 lostSyncCount
    {
        get => _lostSyncCount;
        set
        {
            _lostSyncCount = value;
        }
    }

    private bool _isValidator;
    public bool isValidator
    {
        get => _isValidator;
        set
        {
            _isValidator = value;
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

    public TimeSlicedNodeData()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class TimeSlicedNodeDataXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, TimeSlicedNodeData value)
    {
        value.Validate();
        uint32Xdr.Encode(stream, value.addedAuthenticatedPeers);
        uint32Xdr.Encode(stream, value.droppedAuthenticatedPeers);
        uint32Xdr.Encode(stream, value.totalInboundPeerCount);
        uint32Xdr.Encode(stream, value.totalOutboundPeerCount);
        uint32Xdr.Encode(stream, value.p75SCPFirstToSelfLatencyMs);
        uint32Xdr.Encode(stream, value.p75SCPSelfToOtherLatencyMs);
        uint32Xdr.Encode(stream, value.lostSyncCount);
        stream.WriteInt(value.isValidator ? 1 : 0);
        uint32Xdr.Encode(stream, value.maxInboundPeerCount);
        uint32Xdr.Encode(stream, value.maxOutboundPeerCount);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static TimeSlicedNodeData Decode(XdrReader stream)
    {
        var result = new TimeSlicedNodeData();
        result.addedAuthenticatedPeers = uint32Xdr.Decode(stream);
        result.droppedAuthenticatedPeers = uint32Xdr.Decode(stream);
        result.totalInboundPeerCount = uint32Xdr.Decode(stream);
        result.totalOutboundPeerCount = uint32Xdr.Decode(stream);
        result.p75SCPFirstToSelfLatencyMs = uint32Xdr.Decode(stream);
        result.p75SCPSelfToOtherLatencyMs = uint32Xdr.Decode(stream);
        result.lostSyncCount = uint32Xdr.Decode(stream);
        result.isValidator = stream.ReadInt() != 0;
        result.maxInboundPeerCount = uint32Xdr.Decode(stream);
        result.maxOutboundPeerCount = uint32Xdr.Decode(stream);
        return result;
    }
}
}
