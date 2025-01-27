// Generated code - do not modify
// Source:

// enum BucketListType
// {
//     LIVE = 0,
//     HOT_ARCHIVE = 1,
//     COLD_ARCHIVE = 2
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum BucketListType
    {
        LIVE = 0,
        HOT_ARCHIVE = 1,
        COLD_ARCHIVE = 2,
    }

    public static partial class BucketListTypeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, BucketListType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static BucketListType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(BucketListType), value))
              throw new InvalidOperationException($"Unknown BucketListType value: {value}");
            return (BucketListType)value;
        }
    }
