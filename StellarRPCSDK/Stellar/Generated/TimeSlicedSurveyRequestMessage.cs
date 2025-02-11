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
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class TimeSlicedSurveyRequestMessage
    {
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
        	[InspectorName(@"Request")]
        #endif
        private SurveyRequestMessage _request;

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
        	[InspectorName(@"Nonce")]
        #endif
        private uint32 _nonce;

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
        	[InspectorName(@"Inbound Peers Index")]
        #endif
        private uint32 _inboundPeersIndex;

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
