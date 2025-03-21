// Generated code - do not modify
// Source:

// struct TopologyResponseBodyV2
// {
//     TimeSlicedPeerDataList inboundPeers;
//     TimeSlicedPeerDataList outboundPeers;
//     TimeSlicedNodeData nodeData;
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
    public partial class TopologyResponseBodyV2
    {
        [ProtoMember(1)]
        public TimeSlicedPeerDataList inboundPeers
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
        private TimeSlicedPeerDataList _inboundPeers;

        [ProtoMember(2)]
        public TimeSlicedPeerDataList outboundPeers
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
        private TimeSlicedPeerDataList _outboundPeers;

        [ProtoMember(3)]
        public TimeSlicedNodeData nodeData
        {
            get => _nodeData;
            set
            {
                _nodeData = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Node Data")]
        #endif
        private TimeSlicedNodeData _nodeData;

        public TopologyResponseBodyV2()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class TopologyResponseBodyV2Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TopologyResponseBodyV2 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TopologyResponseBodyV2Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static TopologyResponseBodyV2 DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return TopologyResponseBodyV2Xdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TopologyResponseBodyV2 value)
        {
            value.Validate();
            TimeSlicedPeerDataListXdr.Encode(stream, value.inboundPeers);
            TimeSlicedPeerDataListXdr.Encode(stream, value.outboundPeers);
            TimeSlicedNodeDataXdr.Encode(stream, value.nodeData);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TopologyResponseBodyV2 Decode(XdrReader stream)
        {
            var result = new TopologyResponseBodyV2();
            result.inboundPeers = TimeSlicedPeerDataListXdr.Decode(stream);
            result.outboundPeers = TimeSlicedPeerDataListXdr.Decode(stream);
            result.nodeData = TimeSlicedNodeDataXdr.Decode(stream);
            return result;
        }
    }
}
