// Generated code - do not modify
// Source:

// struct SignedTimeSlicedSurveyRequestMessage
// {
//     Signature requestSignature;
//     TimeSlicedSurveyRequestMessage request;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SignedTimeSlicedSurveyRequestMessage
    {
        private Signature _requestSignature;
        public Signature requestSignature
        {
            get => _requestSignature;
            set
            {
                _requestSignature = value;
            }
        }

        private TimeSlicedSurveyRequestMessage _request;
        public TimeSlicedSurveyRequestMessage request
        {
            get => _request;
            set
            {
                _request = value;
            }
        }

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
