// Generated code - do not modify
// Source:

// struct SignedTimeSlicedSurveyStartCollectingMessage
// {
//     Signature signature;
//     TimeSlicedSurveyStartCollectingMessage startCollecting;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SignedTimeSlicedSurveyStartCollectingMessage
    {
        public Signature signature
        {
            get => _signature;
            set
            {
                _signature = value;
            }
        }
        private Signature _signature;

        public TimeSlicedSurveyStartCollectingMessage startCollecting
        {
            get => _startCollecting;
            set
            {
                _startCollecting = value;
            }
        }
        private TimeSlicedSurveyStartCollectingMessage _startCollecting;

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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SignedTimeSlicedSurveyStartCollectingMessage value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SignedTimeSlicedSurveyStartCollectingMessageXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
