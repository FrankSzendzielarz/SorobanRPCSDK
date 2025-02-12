// Generated code - do not modify
// Source:

// struct SignedSurveyResponseMessage
// {
//     Signature responseSignature;
//     SurveyResponseMessage response;
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
    public partial class SignedSurveyResponseMessage
    {
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
        	[SerializeReference]
        	[InspectorName(@"Response")]
        #endif
        private SurveyResponseMessage _response;

        public SignedSurveyResponseMessage()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SignedSurveyResponseMessageXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SignedSurveyResponseMessage value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SignedSurveyResponseMessageXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SignedSurveyResponseMessage value)
        {
            value.Validate();
            SignatureXdr.Encode(stream, value.responseSignature);
            SurveyResponseMessageXdr.Encode(stream, value.response);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SignedSurveyResponseMessage Decode(XdrReader stream)
        {
            var result = new SignedSurveyResponseMessage();
            result.responseSignature = SignatureXdr.Decode(stream);
            result.response = SurveyResponseMessageXdr.Decode(stream);
            return result;
        }
    }
}
