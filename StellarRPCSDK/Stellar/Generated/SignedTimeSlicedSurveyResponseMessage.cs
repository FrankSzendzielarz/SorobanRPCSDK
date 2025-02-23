// Generated code - do not modify
// Source:

// struct SignedTimeSlicedSurveyResponseMessage
// {
//     Signature responseSignature;
//     TimeSlicedSurveyResponseMessage response;
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
    public partial class SignedTimeSlicedSurveyResponseMessage
    {
        [ProtoMember(1)]
        public Signature responseSignature
        {
            get => _responseSignature;
            set
            {
                _responseSignature = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Response Signature")]
        #endif
        private Signature _responseSignature;

        [ProtoMember(2)]
        public TimeSlicedSurveyResponseMessage response
        {
            get => _response;
            set
            {
                _response = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Response")]
        #endif
        private TimeSlicedSurveyResponseMessage _response;

        public SignedTimeSlicedSurveyResponseMessage()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SignedTimeSlicedSurveyResponseMessageXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SignedTimeSlicedSurveyResponseMessage value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SignedTimeSlicedSurveyResponseMessageXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SignedTimeSlicedSurveyResponseMessage DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SignedTimeSlicedSurveyResponseMessageXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SignedTimeSlicedSurveyResponseMessage value)
        {
            value.Validate();
            SignatureXdr.Encode(stream, value.responseSignature);
            TimeSlicedSurveyResponseMessageXdr.Encode(stream, value.response);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SignedTimeSlicedSurveyResponseMessage Decode(XdrReader stream)
        {
            var result = new SignedTimeSlicedSurveyResponseMessage();
            result.responseSignature = SignatureXdr.Decode(stream);
            result.response = TimeSlicedSurveyResponseMessageXdr.Decode(stream);
            return result;
        }
    }
}
