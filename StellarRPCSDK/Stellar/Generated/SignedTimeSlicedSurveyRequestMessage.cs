// Generated code - do not modify
// Source:

// struct SignedTimeSlicedSurveyRequestMessage
// {
//     Signature requestSignature;
//     TimeSlicedSurveyRequestMessage request;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SignedTimeSlicedSurveyRequestMessage
    {
        public Signature requestSignature
        {
            get => _requestSignature;
            set
            {
                _requestSignature = value;
            }
        }
        private Signature _requestSignature;

        public TimeSlicedSurveyRequestMessage request
        {
            get => _request;
            set
            {
                _request = value;
            }
        }
        private TimeSlicedSurveyRequestMessage _request;

        public SignedTimeSlicedSurveyRequestMessage()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SignedTimeSlicedSurveyRequestMessageXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SignedTimeSlicedSurveyRequestMessage value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SignedTimeSlicedSurveyRequestMessageXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SignedTimeSlicedSurveyRequestMessage value)
        {
            value.Validate();
            SignatureXdr.Encode(stream, value.requestSignature);
            TimeSlicedSurveyRequestMessageXdr.Encode(stream, value.request);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SignedTimeSlicedSurveyRequestMessage Decode(XdrReader stream)
        {
            var result = new SignedTimeSlicedSurveyRequestMessage();
            result.requestSignature = SignatureXdr.Decode(stream);
            result.request = TimeSlicedSurveyRequestMessageXdr.Decode(stream);
            return result;
        }
    }
}
