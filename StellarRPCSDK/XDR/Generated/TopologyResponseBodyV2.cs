// Generated code - do not modify
// Source:

// struct TopologyResponseBodyV2
// {
//     TimeSlicedPeerDataList inboundPeers;
//     TimeSlicedPeerDataList outboundPeers;
//     TimeSlicedNodeData nodeData;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TopologyResponseBodyV2
    {
        private TimeSlicedPeerDataList _inboundPeers;
        public TimeSlicedPeerDataList inboundPeers
        {
            get => _inboundPeers;
            set
            {
                _inboundPeers = value;
            }
        }

        private TimeSlicedPeerDataList _outboundPeers;
        public TimeSlicedPeerDataList outboundPeers
        {
            get => _outboundPeers;
            set
            {
                _outboundPeers = value;
            }
        }

        private TimeSlicedNodeData _nodeData;
        public TimeSlicedNodeData nodeData
        {
            get => _nodeData;
            set
            {
                _nodeData = value;
            }
        }

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
