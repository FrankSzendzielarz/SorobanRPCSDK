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
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class TimeSlicedNodeData
    {
        [ProtoMember(1)]
        public uint32 addedAuthenticatedPeers
        {
            get => _addedAuthenticatedPeers;
            set
            {
                _addedAuthenticatedPeers = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Added Authenticated Peers")]
        #endif
        private uint32 _addedAuthenticatedPeers;

        [ProtoMember(2)]
        public uint32 droppedAuthenticatedPeers
        {
            get => _droppedAuthenticatedPeers;
            set
            {
                _droppedAuthenticatedPeers = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Dropped Authenticated Peers")]
        #endif
        private uint32 _droppedAuthenticatedPeers;

        [ProtoMember(3)]
        public uint32 totalInboundPeerCount
        {
            get => _totalInboundPeerCount;
            set
            {
                _totalInboundPeerCount = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Total Inbound Peer Count")]
        #endif
        private uint32 _totalInboundPeerCount;

        [ProtoMember(4)]
        public uint32 totalOutboundPeerCount
        {
            get => _totalOutboundPeerCount;
            set
            {
                _totalOutboundPeerCount = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Total Outbound Peer Count")]
        #endif
        private uint32 _totalOutboundPeerCount;

        /// <summary>
        /// SCP stats
        /// </summary>
        [ProtoMember(5)]
        public uint32 p75SCPFirstToSelfLatencyMs
        {
            get => _p75SCPFirstToSelfLatencyMs;
            set
            {
                _p75SCPFirstToSelfLatencyMs = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"P75 S C P First To Self Latency Ms")]
        #endif
        private uint32 _p75SCPFirstToSelfLatencyMs;

        [ProtoMember(6)]
        public uint32 p75SCPSelfToOtherLatencyMs
        {
            get => _p75SCPSelfToOtherLatencyMs;
            set
            {
                _p75SCPSelfToOtherLatencyMs = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"P75 S C P Self To Other Latency Ms")]
        #endif
        private uint32 _p75SCPSelfToOtherLatencyMs;

        /// <summary>
        /// How many times the node lost sync in the time slice
        /// </summary>
        [ProtoMember(7)]
        public uint32 lostSyncCount
        {
            get => _lostSyncCount;
            set
            {
                _lostSyncCount = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Lost Sync Count")]
        #endif
        private uint32 _lostSyncCount;

        /// <summary>
        /// Config data
        /// </summary>
        [ProtoMember(8)]
        public bool isValidator
        {
            get => _isValidator;
            set
            {
                _isValidator = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Is Validator")]
        #endif
        private bool _isValidator;

        [ProtoMember(9)]
        public uint32 maxInboundPeerCount
        {
            get => _maxInboundPeerCount;
            set
            {
                _maxInboundPeerCount = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Max Inbound Peer Count")]
        #endif
        private uint32 _maxInboundPeerCount;

        [ProtoMember(10)]
        public uint32 maxOutboundPeerCount
        {
            get => _maxOutboundPeerCount;
            set
            {
                _maxOutboundPeerCount = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Max Outbound Peer Count")]
        #endif
        private uint32 _maxOutboundPeerCount;

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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TimeSlicedNodeData value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TimeSlicedNodeDataXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
