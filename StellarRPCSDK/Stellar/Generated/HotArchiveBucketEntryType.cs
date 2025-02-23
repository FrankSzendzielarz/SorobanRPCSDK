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
    public enum HotArchiveBucketEntryType
    {
        HOT_ARCHIVE_METAENTRY = -1,
        /// <summary>
        /// Bucket metadata, should come first.
        /// </summary>
        HOT_ARCHIVE_ARCHIVED = 0,
        /// <summary>
        /// Entry is Archived
        /// </summary>
        HOT_ARCHIVE_LIVE = 1,
        /// <summary>
        /// Does not need to be persisted.
        /// </summary>
        HOT_ARCHIVE_DELETED = 2,
    }

    public static partial class HotArchiveBucketEntryTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(HotArchiveBucketEntryType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                HotArchiveBucketEntryTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static HotArchiveBucketEntryType DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return HotArchiveBucketEntryTypeXdr.Decode(reader);
            }
        }
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
