// Generated code - do not modify
// Source:

// struct TimeSlicedPeerData
// {
//     PeerStats peerStats;
//     uint32 averageLatencyMs;
// };


using System;

namespace stellar {

[System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
public partial class TimeSlicedPeerData
{
    private PeerStats _peerStats;
    public PeerStats peerStats
    {
        get => _peerStats;
        set
        {
            _peerStats = value;
        }
    }

    private uint32 _averageLatencyMs;
    public uint32 averageLatencyMs
    {
        get => _averageLatencyMs;
        set
        {
            _averageLatencyMs = value;
        }
    }

    public TimeSlicedPeerData()
    {
    }

    /// <summary>Validates all fields have valid values</summary>
    public virtual void Validate()
    {
    }
}

public static partial class TimeSlicedPeerDataXdr
{
    /// <summary>Encodes struct to XDR stream</summary>
    public static void Encode(XdrWriter stream, TimeSlicedPeerData value)
    {
        value.Validate();
        PeerStatsXdr.Encode(stream, value.peerStats);
        uint32Xdr.Encode(stream, value.averageLatencyMs);
    }

    /// <summary>Decodes struct from XDR stream</summary>
    public static TimeSlicedPeerData Decode(XdrReader stream)
    {
        var result = new TimeSlicedPeerData();
        result.peerStats = PeerStatsXdr.Decode(stream);
        result.averageLatencyMs = uint32Xdr.Decode(stream);
        return result;
    }
}
}
