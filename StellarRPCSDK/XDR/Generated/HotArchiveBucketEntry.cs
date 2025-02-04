// Generated code - do not modify
// Source:

// union HotArchiveBucketEntry switch (HotArchiveBucketEntryType type)
// {
// case HOT_ARCHIVE_ARCHIVED:
//     LedgerEntry archivedEntry;
// 
// case HOT_ARCHIVE_LIVE:
// case HOT_ARCHIVE_DELETED:
//     LedgerKey key;
// case HOT_ARCHIVE_METAENTRY:
//     BucketMetadata metaEntry;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class HotArchiveBucketEntry
    {
        public abstract HotArchiveBucketEntryType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        public sealed partial class HotArchiveArchived : HotArchiveBucketEntry
        {
            public override HotArchiveBucketEntryType Discriminator => HotArchiveBucketEntryType.HOT_ARCHIVE_ARCHIVED;
            public LedgerEntry archivedEntry
            {
                get => _archivedEntry;
                set
                {
                    _archivedEntry = value;
                }
            }
            private LedgerEntry _archivedEntry;

            public override void ValidateCase() {}
        }
        public sealed partial class HotArchiveLive : HotArchiveBucketEntry
        {
            public override HotArchiveBucketEntryType Discriminator => HotArchiveBucketEntryType.HOT_ARCHIVE_LIVE;
            public LedgerKey key
            {
                get => _key;
                set
                {
                    _key = value;
                }
            }
            private LedgerKey _key;

            public override void ValidateCase() {}
        }
        public sealed partial class HotArchiveDeleted : HotArchiveBucketEntry
        {
            public override HotArchiveBucketEntryType Discriminator => HotArchiveBucketEntryType.HOT_ARCHIVE_DELETED;
            public LedgerKey key
            {
                get => _key;
                set
                {
                    _key = value;
                }
            }
            private LedgerKey _key;

            public override void ValidateCase() {}
        }
        public sealed partial class HotArchiveMetaentry : HotArchiveBucketEntry
        {
            public override HotArchiveBucketEntryType Discriminator => HotArchiveBucketEntryType.HOT_ARCHIVE_METAENTRY;
            public BucketMetadata metaEntry
            {
                get => _metaEntry;
                set
                {
                    _metaEntry = value;
                }
            }
            private BucketMetadata _metaEntry;

            public override void ValidateCase() {}
        }
    }
    public static partial class HotArchiveBucketEntryXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(HotArchiveBucketEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                HotArchiveBucketEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, HotArchiveBucketEntry value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case HotArchiveBucketEntry.HotArchiveArchived case_HOT_ARCHIVE_ARCHIVED:
                LedgerEntryXdr.Encode(stream, case_HOT_ARCHIVE_ARCHIVED.archivedEntry);
                break;
                case HotArchiveBucketEntry.HotArchiveLive case_HOT_ARCHIVE_LIVE:
                LedgerKeyXdr.Encode(stream, case_HOT_ARCHIVE_LIVE.key);
                break;
                case HotArchiveBucketEntry.HotArchiveDeleted case_HOT_ARCHIVE_DELETED:
                LedgerKeyXdr.Encode(stream, case_HOT_ARCHIVE_DELETED.key);
                break;
                case HotArchiveBucketEntry.HotArchiveMetaentry case_HOT_ARCHIVE_METAENTRY:
                BucketMetadataXdr.Encode(stream, case_HOT_ARCHIVE_METAENTRY.metaEntry);
                break;
            }
        }
        public static HotArchiveBucketEntry Decode(XdrReader stream)
        {
            var discriminator = (HotArchiveBucketEntryType)stream.ReadInt();
            switch (discriminator)
            {
                case HotArchiveBucketEntryType.HOT_ARCHIVE_ARCHIVED:
                var result_HOT_ARCHIVE_ARCHIVED = new HotArchiveBucketEntry.HotArchiveArchived();
                result_HOT_ARCHIVE_ARCHIVED.archivedEntry = LedgerEntryXdr.Decode(stream);
                return result_HOT_ARCHIVE_ARCHIVED;
                case HotArchiveBucketEntryType.HOT_ARCHIVE_LIVE:
                var result_HOT_ARCHIVE_LIVE = new HotArchiveBucketEntry.HotArchiveLive();
                result_HOT_ARCHIVE_LIVE.key = LedgerKeyXdr.Decode(stream);
                return result_HOT_ARCHIVE_LIVE;
                case HotArchiveBucketEntryType.HOT_ARCHIVE_DELETED:
                var result_HOT_ARCHIVE_DELETED = new HotArchiveBucketEntry.HotArchiveDeleted();
                result_HOT_ARCHIVE_DELETED.key = LedgerKeyXdr.Decode(stream);
                return result_HOT_ARCHIVE_DELETED;
                case HotArchiveBucketEntryType.HOT_ARCHIVE_METAENTRY:
                var result_HOT_ARCHIVE_METAENTRY = new HotArchiveBucketEntry.HotArchiveMetaentry();
                result_HOT_ARCHIVE_METAENTRY.metaEntry = BucketMetadataXdr.Decode(stream);
                return result_HOT_ARCHIVE_METAENTRY;
                default:
                throw new Exception($"Unknown discriminator for HotArchiveBucketEntry: {discriminator}");
            }
        }
    }
}
