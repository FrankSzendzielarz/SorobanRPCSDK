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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum ThresholdIndexes
    {
        THRESHOLD_MASTER_WEIGHT = 0,
        THRESHOLD_LOW = 1,
        THRESHOLD_MED = 2,
        THRESHOLD_HIGH = 3,
    }

    public static partial class ThresholdIndexesXdr
    {
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
