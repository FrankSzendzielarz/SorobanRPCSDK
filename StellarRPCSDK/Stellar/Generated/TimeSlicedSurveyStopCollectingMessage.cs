// Generated code - do not modify
// Source:

// struct TimeSlicedSurveyStopCollectingMessage
// {
//     NodeID surveyorID;
//     uint32 nonce;
//     uint32 ledgerNum;
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
    public partial class TimeSlicedSurveyStopCollectingMessage
    {
        [ProtoMember(1)]
        public NodeID surveyorID
        {
            get => _surveyorID;
            set
            {
                _surveyorID = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Surveyor I D")]
        #endif
        private NodeID _surveyorID;

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
        public uint32 ledgerNum
        {
            get => _ledgerNum;
            set
            {
                _ledgerNum = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Ledger Num")]
        #endif
        private uint32 _ledgerNum;

        public TimeSlicedSurveyStopCollectingMessage()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class TimeSlicedSurveyStopCollectingMessageXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TimeSlicedSurveyStopCollectingMessage value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TimeSlicedSurveyStopCollectingMessageXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static TimeSlicedSurveyStopCollectingMessage DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return TimeSlicedSurveyStopCollectingMessageXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TimeSlicedSurveyStopCollectingMessage value)
        {
            value.Validate();
            NodeIDXdr.Encode(stream, value.surveyorID);
            uint32Xdr.Encode(stream, value.nonce);
            uint32Xdr.Encode(stream, value.ledgerNum);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TimeSlicedSurveyStopCollectingMessage Decode(XdrReader stream)
        {
            var result = new TimeSlicedSurveyStopCollectingMessage();
            result.surveyorID = NodeIDXdr.Decode(stream);
            result.nonce = uint32Xdr.Decode(stream);
            result.ledgerNum = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
