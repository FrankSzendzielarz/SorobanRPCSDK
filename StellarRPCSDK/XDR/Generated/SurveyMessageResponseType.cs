// Generated code - do not modify
// Source:

// enum SurveyMessageResponseType
// {
//     SURVEY_TOPOLOGY_RESPONSE_V0 = 0,
//     SURVEY_TOPOLOGY_RESPONSE_V1 = 1,
//     SURVEY_TOPOLOGY_RESPONSE_V2 = 2
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum SurveyMessageResponseType
    {
        SURVEY_TOPOLOGY_RESPONSE_V0 = 0,
        SURVEY_TOPOLOGY_RESPONSE_V1 = 1,
        SURVEY_TOPOLOGY_RESPONSE_V2 = 2,
    }

    public static partial class SurveyMessageResponseTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SurveyMessageResponseType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SurveyMessageResponseTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, SurveyMessageResponseType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static SurveyMessageResponseType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(SurveyMessageResponseType), value))
              throw new InvalidOperationException($"Unknown SurveyMessageResponseType value: {value}");
            return (SurveyMessageResponseType)value;
        }
    }
}
