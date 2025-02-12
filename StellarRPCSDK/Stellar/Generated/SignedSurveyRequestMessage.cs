// Generated code - do not modify
// Source:

// struct SignedSurveyRequestMessage
// {
//     Signature requestSignature;
//     SurveyRequestMessage request;
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
    public partial class SignedSurveyRequestMessage
    {
        public Signature requestSignature
        {
            get => _requestSignature;
            set
            {
                _requestSignature = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Request Signature")]
        #endif
        private Signature _requestSignature;

        public SurveyRequestMessage request
        {
            get => _request;
            set
            {
                _request = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Request")]
        #endif
        private SurveyRequestMessage _request;

        public SignedSurveyRequestMessage()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SignedSurveyRequestMessageXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SignedSurveyRequestMessage value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SignedSurveyRequestMessageXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SignedSurveyRequestMessage value)
        {
            value.Validate();
            SignatureXdr.Encode(stream, value.requestSignature);
            SurveyRequestMessageXdr.Encode(stream, value.request);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SignedSurveyRequestMessage Decode(XdrReader stream)
        {
            var result = new SignedSurveyRequestMessage();
            result.requestSignature = SignatureXdr.Decode(stream);
            result.request = SurveyRequestMessageXdr.Decode(stream);
            return result;
        }
    }
}
