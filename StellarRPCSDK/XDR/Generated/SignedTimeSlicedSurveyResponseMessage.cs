// Generated code - do not modify
// Source:

// struct SignedTimeSlicedSurveyResponseMessage
// {
//     Signature responseSignature;
//     TimeSlicedSurveyResponseMessage response;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SignedTimeSlicedSurveyResponseMessage
    {
        private Signature _responseSignature;
        public Signature responseSignature
        {
            get => _responseSignature;
            set
            {
                _responseSignature = value;
            }
        }

        private TimeSlicedSurveyResponseMessage _response;
        public TimeSlicedSurveyResponseMessage response
        {
            get => _response;
            set
            {
                _response = value;
            }
        }

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
