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
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    [ProtoInclude(100, typeof(HotArchiveArchived), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(HotArchiveLive), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(HotArchiveDeleted), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(HotArchiveMetaentry), DataFormat = DataFormat.Default)]
    public abstract partial class HotArchiveBucketEntry
    {
        public abstract HotArchiveBucketEntryType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "HotArchiveBucketEntry.HotArchiveArchived")]
        public sealed partial class HotArchiveArchived : HotArchiveBucketEntry
        {
            public override HotArchiveBucketEntryType Discriminator => HotArchiveBucketEntryType.HOT_ARCHIVE_ARCHIVED;
            [ProtoMember(1)]
            public LedgerEntry archivedEntry
            {
                get => _archivedEntry;
                set
                {
                    _archivedEntry = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Archived Entry")]
            #endif
            private LedgerEntry _archivedEntry;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "HotArchiveBucketEntry.HotArchiveLive")]
        public sealed partial class HotArchiveLive : HotArchiveBucketEntry
        {
            public override HotArchiveBucketEntryType Discriminator => HotArchiveBucketEntryType.HOT_ARCHIVE_LIVE;
            [ProtoMember(2)]
            public LedgerKey key
            {
                get => _key;
                set
                {
                    _key = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Key")]
            #endif
            private LedgerKey _key;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "HotArchiveBucketEntry.HotArchiveDeleted")]
        public sealed partial class HotArchiveDeleted : HotArchiveBucketEntry
        {
            public override HotArchiveBucketEntryType Discriminator => HotArchiveBucketEntryType.HOT_ARCHIVE_DELETED;
            [ProtoMember(3)]
            public LedgerKey key
            {
                get => _key;
                set
                {
                    _key = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Key")]
            #endif
            private LedgerKey _key;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "HotArchiveBucketEntry.HotArchiveMetaentry")]
        public sealed partial class HotArchiveMetaentry : HotArchiveBucketEntry
        {
            public override HotArchiveBucketEntryType Discriminator => HotArchiveBucketEntryType.HOT_ARCHIVE_METAENTRY;
            [ProtoMember(4)]
            public BucketMetadata metaEntry
            {
                get => _metaEntry;
                set
                {
                    _metaEntry = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Meta Entry")]
            #endif
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
        /// <summary>Decodes value from XDR base64 string</summary>
        public static HotArchiveBucketEntry DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return HotArchiveBucketEntryXdr.Decode(reader);
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
