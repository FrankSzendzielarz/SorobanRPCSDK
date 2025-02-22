// Generated code - do not modify
// Source:

// enum SurveyMessageCommandType
// {
//     SURVEY_TOPOLOGY = 0,
//     TIME_SLICED_SURVEY_TOPOLOGY = 1
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public enum SurveyMessageCommandType
    {
        SURVEY_TOPOLOGY = 0,
        TIME_SLICED_SURVEY_TOPOLOGY = 1,
    }

    public static partial class SurveyMessageCommandTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SurveyMessageCommandType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SurveyMessageCommandTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
}
