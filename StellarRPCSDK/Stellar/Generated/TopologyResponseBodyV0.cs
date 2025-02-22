// Generated code - do not modify
// Source:

// struct TopologyResponseBodyV0
// {
//     PeerStatList inboundPeers;
//     PeerStatList outboundPeers;
// 
//     uint32 totalInboundPeerCount;
//     uint32 totalOutboundPeerCount;
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
    public partial class TopologyResponseBodyV0
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

        public TopologyResponseBodyV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class TopologyResponseBodyV0Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TopologyResponseBodyV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TopologyResponseBodyV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TopologyResponseBodyV0 value)
        {
            value.Validate();
            PeerStatListXdr.Encode(stream, value.inboundPeers);
            PeerStatListXdr.Encode(stream, value.outboundPeers);
            uint32Xdr.Encode(stream, value.totalInboundPeerCount);
            uint32Xdr.Encode(stream, value.totalOutboundPeerCount);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TopologyResponseBodyV0 Decode(XdrReader stream)
        {
            var result = new TopologyResponseBodyV0();
            result.inboundPeers = PeerStatListXdr.Decode(stream);
            result.outboundPeers = PeerStatListXdr.Decode(stream);
            result.totalInboundPeerCount = uint32Xdr.Decode(stream);
            result.totalOutboundPeerCount = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
