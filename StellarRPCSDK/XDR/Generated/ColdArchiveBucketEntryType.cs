// Generated code - do not modify
// Source:

// enum ColdArchiveBucketEntryType
// {
//     COLD_ARCHIVE_METAENTRY     = -1,  // Bucket metadata, should come first.
//     COLD_ARCHIVE_ARCHIVED_LEAF = 0,   // Full LedgerEntry that was archived during the epoch
//     COLD_ARCHIVE_DELETED_LEAF  = 1,   // LedgerKey that was deleted during the epoch
//     COLD_ARCHIVE_BOUNDARY_LEAF = 2,   // Dummy leaf representing low/high bound
//     COLD_ARCHIVE_HASH          = 3    // Intermediary Merkle hash entry
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum ColdArchiveBucketEntryType
    {
        COLD_ARCHIVE_METAENTRY = -1,
        COLD_ARCHIVE_ARCHIVED_LEAF = 0,
        COLD_ARCHIVE_DELETED_LEAF = 1,
        COLD_ARCHIVE_BOUNDARY_LEAF = 2,
        COLD_ARCHIVE_HASH = 3,
    }

    public static partial class ColdArchiveBucketEntryTypeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, ColdArchiveBucketEntryType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static ColdArchiveBucketEntryType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(ColdArchiveBucketEntryType), value))
              throw new InvalidOperationException($"Unknown ColdArchiveBucketEntryType value: {value}");
            return (ColdArchiveBucketEntryType)value;
        }
    }
}
