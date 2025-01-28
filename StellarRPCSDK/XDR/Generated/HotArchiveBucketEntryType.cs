// Generated code - do not modify
// Source:

// enum HotArchiveBucketEntryType
// {
//     HOT_ARCHIVE_METAENTRY = -1, // Bucket metadata, should come first.
//     HOT_ARCHIVE_ARCHIVED = 0,   // Entry is Archived
//     HOT_ARCHIVE_LIVE = 1,       // Entry was previously HOT_ARCHIVE_ARCHIVED, or HOT_ARCHIVE_DELETED, but
//                                 // has been added back to the live BucketList.
//                                 // Does not need to be persisted.
//     HOT_ARCHIVE_DELETED = 2     // Entry deleted (Note: must be persisted in archive)
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum HotArchiveBucketEntryType
    {
        HOT_ARCHIVE_METAENTRY = -1,
        HOT_ARCHIVE_ARCHIVED = 0,
        HOT_ARCHIVE_LIVE = 1,
        HOT_ARCHIVE_DELETED = 2,
    }

    public static partial class HotArchiveBucketEntryTypeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, HotArchiveBucketEntryType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static HotArchiveBucketEntryType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(HotArchiveBucketEntryType), value))
              throw new InvalidOperationException($"Unknown HotArchiveBucketEntryType value: {value}");
            return (HotArchiveBucketEntryType)value;
        }
    }
}
