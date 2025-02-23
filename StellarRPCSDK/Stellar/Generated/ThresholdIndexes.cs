// Generated code - do not modify
// Source:

// enum ThresholdIndexes
// {
//     THRESHOLD_MASTER_WEIGHT = 0,
//     THRESHOLD_LOW = 1,
//     THRESHOLD_MED = 2,
//     THRESHOLD_HIGH = 3
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    /// <summary>
    /// defined by these indexes
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public enum ThresholdIndexes
    {
        THRESHOLD_MASTER_WEIGHT = 0,
        THRESHOLD_LOW = 1,
        THRESHOLD_MED = 2,
        THRESHOLD_HIGH = 3,
    }

    public static partial class ThresholdIndexesXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ThresholdIndexes value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ThresholdIndexesXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ThresholdIndexes DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ThresholdIndexesXdr.Decode(reader);
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ThresholdIndexes value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ThresholdIndexes Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ThresholdIndexes), value))
              throw new InvalidOperationException($"Unknown ThresholdIndexes value: {value}");
            return (ThresholdIndexes)value;
        }
    }
}
