// Generated code - do not modify
// Source:

// struct TimeSlicedSurveyRequestMessage
// {
//     SurveyRequestMessage request;
//     uint32 nonce;
//     uint32 inboundPeersIndex;
//     uint32 outboundPeersIndex;
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
    public partial class TimeSlicedSurveyRequestMessage
    {
        [ProtoMember(1)]
        public SurveyRequestMessage request
        {
            get => _request;
            set
            {
                _request = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Request")]
        #endif
        private SurveyRequestMessage _request;

        [ProtoMember(2)]
        public uint32 nonce
        {
            get => _nonce;
            set
            {
                _nonce = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Nonce")]
        #endif
        private uint32 _nonce;

        [ProtoMember(3)]
        public uint32 inboundPeersIndex
        {
            get => _inboundPeersIndex;
            set
            {
                _inboundPeersIndex = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inbound Peers Index")]
        #endif
        private uint32 _inboundPeersIndex;

        [ProtoMember(4)]
        public uint32 outboundPeersIndex
        {
            get => _outboundPeersIndex;
            set
            {
                _outboundPeersIndex = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Outbound Peers Index")]
        #endif
        private uint32 _outboundPeersIndex;

        public TimeSlicedSurveyRequestMessage()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class TimeSlicedSurveyRequestMessageXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TimeSlicedSurveyRequestMessage value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TimeSlicedSurveyRequestMessageXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TimeSlicedSurveyRequestMessage value)
        {
            value.Validate();
            SurveyRequestMessageXdr.Encode(stream, value.request);
            uint32Xdr.Encode(stream, value.nonce);
            uint32Xdr.Encode(stream, value.inboundPeersIndex);
            uint32Xdr.Encode(stream, value.outboundPeersIndex);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TimeSlicedSurveyRequestMessage Decode(XdrReader stream)
        {
            var result = new TimeSlicedSurveyRequestMessage();
            result.request = SurveyRequestMessageXdr.Decode(stream);
            result.nonce = uint32Xdr.Decode(stream);
            result.inboundPeersIndex = uint32Xdr.Decode(stream);
            result.outboundPeersIndex = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
