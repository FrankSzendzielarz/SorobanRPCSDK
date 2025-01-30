// Generated code - do not modify
// Source:

// struct SignedTimeSlicedSurveyStartCollectingMessage
// {
//     Signature signature;
//     TimeSlicedSurveyStartCollectingMessage startCollecting;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SignedTimeSlicedSurveyStartCollectingMessage
    {
        private Signature _signature;
        public Signature signature
        {
            get => _signature;
            set
            {
                _signature = value;
            }
        }

        private TimeSlicedSurveyStartCollectingMessage _startCollecting;
        public TimeSlicedSurveyStartCollectingMessage startCollecting
        {
            get => _startCollecting;
            set
            {
                _startCollecting = value;
            }
        }

        public SignedTimeSlicedSurveyStartCollectingMessage()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SignedTimeSlicedSurveyStartCollectingMessageXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SignedTimeSlicedSurveyStartCollectingMessage value)
        {
            value.Validate();
            SignatureXdr.Encode(stream, value.signature);
            TimeSlicedSurveyStartCollectingMessageXdr.Encode(stream, value.startCollecting);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SignedTimeSlicedSurveyStartCollectingMessage Decode(XdrReader stream)
        {
            var result = new SignedTimeSlicedSurveyStartCollectingMessage();
            result.signature = SignatureXdr.Decode(stream);
            result.startCollecting = TimeSlicedSurveyStartCollectingMessageXdr.Decode(stream);
            return result;
        }
    }
}
