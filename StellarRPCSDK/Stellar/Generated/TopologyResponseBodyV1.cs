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
    public partial class TopologyResponseBodyV1
    {
        [ProtoMember(1)]
        public PeerStatList inboundPeers
        {
            get => _inboundPeers;
            set
            {
                _inboundPeers = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inbound Peers")]
        #endif
        private PeerStatList _inboundPeers;

        [ProtoMember(2)]
        public PeerStatList outboundPeers
        {
            get => _outboundPeers;
            set
            {
                _outboundPeers = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Outbound Peers")]
        #endif
        private PeerStatList _outboundPeers;

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

        [ProtoMember(5)]
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

        [ProtoMember(6)]
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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TopologyResponseBodyV1 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TopologyResponseBodyV1Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static TopologyResponseBodyV1 DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return TopologyResponseBodyV1Xdr.Decode(reader);
            }
        }
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
