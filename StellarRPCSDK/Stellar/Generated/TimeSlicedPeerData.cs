// Generated code - do not modify
// Source:

// struct TimeSlicedPeerData
// {
//     PeerStats peerStats;
//     uint32 averageLatencyMs;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class TimeSlicedPeerData
    {
        public PeerStats peerStats
        {
            get => _peerStats;
            set
            {
                _peerStats = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Peer Stats")]
        #endif
        private PeerStats _peerStats;

        public uint32 averageLatencyMs
        {
            get => _averageLatencyMs;
            set
            {
                _averageLatencyMs = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Average Latency Ms")]
        #endif
        private uint32 _averageLatencyMs;

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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TimeSlicedPeerData value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TimeSlicedPeerDataXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
