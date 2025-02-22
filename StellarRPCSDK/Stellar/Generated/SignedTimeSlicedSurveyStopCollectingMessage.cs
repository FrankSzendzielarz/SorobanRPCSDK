// Generated code - do not modify
// Source:

// struct SignedTimeSlicedSurveyStopCollectingMessage
// {
//     Signature signature;
//     TimeSlicedSurveyStopCollectingMessage stopCollecting;
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
    public partial class SignedTimeSlicedSurveyStopCollectingMessage
    {
        [ProtoMember(1)]
        public Signature signature
        {
            get => _signature;
            set
            {
                _signature = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Signature")]
        #endif
        private Signature _signature;

        [ProtoMember(2)]
        public TimeSlicedSurveyStopCollectingMessage stopCollecting
        {
            get => _stopCollecting;
            set
            {
                _stopCollecting = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Stop Collecting")]
        #endif
        private TimeSlicedSurveyStopCollectingMessage _stopCollecting;

        public SignedTimeSlicedSurveyStopCollectingMessage()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SignedTimeSlicedSurveyStopCollectingMessageXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SignedTimeSlicedSurveyStopCollectingMessage value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SignedTimeSlicedSurveyStopCollectingMessageXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SignedTimeSlicedSurveyStopCollectingMessage value)
        {
            value.Validate();
            SignatureXdr.Encode(stream, value.signature);
            TimeSlicedSurveyStopCollectingMessageXdr.Encode(stream, value.stopCollecting);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SignedTimeSlicedSurveyStopCollectingMessage Decode(XdrReader stream)
        {
            var result = new SignedTimeSlicedSurveyStopCollectingMessage();
            result.signature = SignatureXdr.Decode(stream);
            result.stopCollecting = TimeSlicedSurveyStopCollectingMessageXdr.Decode(stream);
            return result;
        }
    }
}
