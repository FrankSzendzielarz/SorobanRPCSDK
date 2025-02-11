// Generated code - do not modify
// Source:

// struct TimeSlicedSurveyResponseMessage
// {
//     SurveyResponseMessage response;
//     uint32 nonce;
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
    public partial class TimeSlicedSurveyResponseMessage
    {
        public SurveyResponseMessage response
        {
            get => _response;
            set
            {
                _response = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Response")]
        #endif
        private SurveyResponseMessage _response;

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

        public TimeSlicedSurveyResponseMessage()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class TimeSlicedSurveyResponseMessageXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TimeSlicedSurveyResponseMessage value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TimeSlicedSurveyResponseMessageXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TimeSlicedSurveyResponseMessage value)
        {
            value.Validate();
            SurveyResponseMessageXdr.Encode(stream, value.response);
            uint32Xdr.Encode(stream, value.nonce);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TimeSlicedSurveyResponseMessage Decode(XdrReader stream)
        {
            var result = new TimeSlicedSurveyResponseMessage();
            result.response = SurveyResponseMessageXdr.Decode(stream);
            result.nonce = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
