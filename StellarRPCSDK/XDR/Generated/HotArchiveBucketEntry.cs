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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class HotArchiveBucketEntry
    {
        public abstract HotArchiveBucketEntryType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class HotArchiveBucketEntry_HOT_ARCHIVE_ARCHIVED : HotArchiveBucketEntry
    {
        public override HotArchiveBucketEntryType Discriminator => HotArchiveBucketEntryType.HOT_ARCHIVE_ARCHIVED;
        private LedgerEntry _archivedEntry;
        public LedgerEntry archivedEntry
        {
            get => _archivedEntry;
            set
            {
                _archivedEntry = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class HotArchiveBucketEntry_HOT_ARCHIVE_LIVE : HotArchiveBucketEntry
    {
        public override HotArchiveBucketEntryType Discriminator => HotArchiveBucketEntryType.HOT_ARCHIVE_LIVE;
        private LedgerKey _key;
        public LedgerKey key
        {
            get => _key;
            set
            {
                _key = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class HotArchiveBucketEntry_HOT_ARCHIVE_DELETED : HotArchiveBucketEntry
    {
        public override HotArchiveBucketEntryType Discriminator => HotArchiveBucketEntryType.HOT_ARCHIVE_DELETED;
        private LedgerKey _key;
        public LedgerKey key
        {
            get => _key;
            set
            {
                _key = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class HotArchiveBucketEntry_HOT_ARCHIVE_METAENTRY : HotArchiveBucketEntry
    {
        public override HotArchiveBucketEntryType Discriminator => HotArchiveBucketEntryType.HOT_ARCHIVE_METAENTRY;
        private BucketMetadata _metaEntry;
        public BucketMetadata metaEntry
        {
            get => _metaEntry;
            set
            {
                _metaEntry = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class HotArchiveBucketEntryXdr
    {
        public static void Encode(XdrWriter stream, HotArchiveBucketEntry value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case HotArchiveBucketEntry_HOT_ARCHIVE_ARCHIVED case_HOT_ARCHIVE_ARCHIVED:
                LedgerEntryXdr.Encode(stream, case_HOT_ARCHIVE_ARCHIVED.archivedEntry);
                break;
                case HotArchiveBucketEntry_HOT_ARCHIVE_LIVE case_HOT_ARCHIVE_LIVE:
                LedgerKeyXdr.Encode(stream, case_HOT_ARCHIVE_LIVE.key);
                break;
                case HotArchiveBucketEntry_HOT_ARCHIVE_DELETED case_HOT_ARCHIVE_DELETED:
                LedgerKeyXdr.Encode(stream, case_HOT_ARCHIVE_DELETED.key);
                break;
                case HotArchiveBucketEntry_HOT_ARCHIVE_METAENTRY case_HOT_ARCHIVE_METAENTRY:
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
                var result_HOT_ARCHIVE_ARCHIVED = new HotArchiveBucketEntry_HOT_ARCHIVE_ARCHIVED();
                result_HOT_ARCHIVE_ARCHIVED.archivedEntry = LedgerEntryXdr.Decode(stream);
                return result_HOT_ARCHIVE_ARCHIVED;
                case HotArchiveBucketEntryType.HOT_ARCHIVE_LIVE:
                var result_HOT_ARCHIVE_LIVE = new HotArchiveBucketEntry_HOT_ARCHIVE_LIVE();
                result_HOT_ARCHIVE_LIVE.key = LedgerKeyXdr.Decode(stream);
                return result_HOT_ARCHIVE_LIVE;
                case HotArchiveBucketEntryType.HOT_ARCHIVE_DELETED:
                var result_HOT_ARCHIVE_DELETED = new HotArchiveBucketEntry_HOT_ARCHIVE_DELETED();
                result_HOT_ARCHIVE_DELETED.key = LedgerKeyXdr.Decode(stream);
                return result_HOT_ARCHIVE_DELETED;
                case HotArchiveBucketEntryType.HOT_ARCHIVE_METAENTRY:
                var result_HOT_ARCHIVE_METAENTRY = new HotArchiveBucketEntry_HOT_ARCHIVE_METAENTRY();
                result_HOT_ARCHIVE_METAENTRY.metaEntry = BucketMetadataXdr.Decode(stream);
                return result_HOT_ARCHIVE_METAENTRY;
                default:
                throw new Exception($"Unknown discriminator for HotArchiveBucketEntry: {discriminator}");
            }
        }
    }
}
