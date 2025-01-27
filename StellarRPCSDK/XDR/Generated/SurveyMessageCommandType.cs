// Generated code - do not modify
// Source:

// enum SurveyMessageCommandType
// {
//     SURVEY_TOPOLOGY = 0,
//     TIME_SLICED_SURVEY_TOPOLOGY = 1
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum SurveyMessageCommandType
    {
        SURVEY_TOPOLOGY = 0,
        TIME_SLICED_SURVEY_TOPOLOGY = 1,
    }

    public static partial class SurveyMessageCommandTypeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, SurveyMessageCommandType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static SurveyMessageCommandType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(SurveyMessageCommandType), value))
              throw new InvalidOperationException($"Unknown SurveyMessageCommandType value: {value}");
            return (SurveyMessageCommandType)value;
        }
    }
