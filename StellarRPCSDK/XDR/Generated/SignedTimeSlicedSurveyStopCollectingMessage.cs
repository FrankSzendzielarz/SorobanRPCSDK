// Generated code - do not modify
// Source:

// struct SignedTimeSlicedSurveyStopCollectingMessage
// {
//     Signature signature;
//     TimeSlicedSurveyStopCollectingMessage stopCollecting;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SignedTimeSlicedSurveyStopCollectingMessage
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

        private TimeSlicedSurveyStopCollectingMessage _stopCollecting;
        public TimeSlicedSurveyStopCollectingMessage stopCollecting
        {
            get => _stopCollecting;
            set
            {
                _stopCollecting = value;
            }
        }

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
