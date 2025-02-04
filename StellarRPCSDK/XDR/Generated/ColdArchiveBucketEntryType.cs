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
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum ColdArchiveBucketEntryType
    {
        COLD_ARCHIVE_METAENTRY = -1,
        /// <summary>
        /// Bucket metadata, should come first.
        /// </summary>
        COLD_ARCHIVE_ARCHIVED_LEAF = 0,
        /// <summary>
        /// Full LedgerEntry that was archived during the epoch
        /// </summary>
        COLD_ARCHIVE_DELETED_LEAF = 1,
        /// <summary>
        /// LedgerKey that was deleted during the epoch
        /// </summary>
        COLD_ARCHIVE_BOUNDARY_LEAF = 2,
        /// <summary>
        /// Dummy leaf representing low/high bound
        /// </summary>
        COLD_ARCHIVE_HASH = 3,
    }

    public static partial class ColdArchiveBucketEntryTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ColdArchiveBucketEntryType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ColdArchiveBucketEntryTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
