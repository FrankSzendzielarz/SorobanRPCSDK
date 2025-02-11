// Generated code - do not modify
// Source:

// struct TimeSlicedSurveyStartCollectingMessage
// {
//     NodeID surveyorID;
//     uint32 nonce;
//     uint32 ledgerNum;
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
    public partial class TimeSlicedSurveyStartCollectingMessage
    {
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
        	[InspectorName(@"Surveyor I D")]
        #endif
        private NodeID _surveyorID;

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
        	[InspectorName(@"Ledger Num")]
        #endif
        private uint32 _ledgerNum;

        public TimeSlicedSurveyStartCollectingMessage()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class TimeSlicedSurveyStartCollectingMessageXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TimeSlicedSurveyStartCollectingMessage value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TimeSlicedSurveyStartCollectingMessageXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TimeSlicedSurveyStartCollectingMessage value)
        {
            value.Validate();
            NodeIDXdr.Encode(stream, value.surveyorID);
            uint32Xdr.Encode(stream, value.nonce);
            uint32Xdr.Encode(stream, value.ledgerNum);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TimeSlicedSurveyStartCollectingMessage Decode(XdrReader stream)
        {
            var result = new TimeSlicedSurveyStartCollectingMessage();
            result.surveyorID = NodeIDXdr.Decode(stream);
            result.nonce = uint32Xdr.Decode(stream);
            result.ledgerNum = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
