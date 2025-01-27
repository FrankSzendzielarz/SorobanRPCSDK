// Generated code - do not modify
// Source:

// enum SurveyMessageResponseType
// {
//     SURVEY_TOPOLOGY_RESPONSE_V0 = 0,
//     SURVEY_TOPOLOGY_RESPONSE_V1 = 1,
//     SURVEY_TOPOLOGY_RESPONSE_V2 = 2
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum SurveyMessageResponseType
    {
        SURVEY_TOPOLOGY_RESPONSE_V0 = 0,
        SURVEY_TOPOLOGY_RESPONSE_V1 = 1,
        SURVEY_TOPOLOGY_RESPONSE_V2 = 2,
    }

    public static partial class SurveyMessageResponseTypeXdr
    {
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
