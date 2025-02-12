// Generated code - do not modify
// Source:

// union ColdArchiveBucketEntry switch (ColdArchiveBucketEntryType type)
// {
// case COLD_ARCHIVE_METAENTRY:
//     BucketMetadata metaEntry;
// case COLD_ARCHIVE_ARCHIVED_LEAF:
//     ColdArchiveArchivedLeaf archivedLeaf;
// case COLD_ARCHIVE_DELETED_LEAF:
//     ColdArchiveDeletedLeaf deletedLeaf;
// case COLD_ARCHIVE_BOUNDARY_LEAF:
//     ColdArchiveBoundaryLeaf boundaryLeaf;
// case COLD_ARCHIVE_HASH:
//     ColdArchiveHashEntry hashEntry;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public abstract partial class ColdArchiveBucketEntry
    {
        public abstract ColdArchiveBucketEntryType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        public sealed partial class ColdArchiveMetaentry : ColdArchiveBucketEntry
        {
            public override ColdArchiveBucketEntryType Discriminator => ColdArchiveBucketEntryType.COLD_ARCHIVE_METAENTRY;
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
        [System.Serializable]
        public sealed partial class ColdArchiveArchivedLeafCase : ColdArchiveBucketEntry
        {
            public override ColdArchiveBucketEntryType Discriminator => ColdArchiveBucketEntryType.COLD_ARCHIVE_ARCHIVED_LEAF;
            public ColdArchiveArchivedLeaf archivedLeaf
            {
                get => _archivedLeaf;
                set
                {
                    _archivedLeaf = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Archived Leaf")]
            #endif
            private ColdArchiveArchivedLeaf _archivedLeaf;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ColdArchiveDeletedLeafCase : ColdArchiveBucketEntry
        {
            public override ColdArchiveBucketEntryType Discriminator => ColdArchiveBucketEntryType.COLD_ARCHIVE_DELETED_LEAF;
            public ColdArchiveDeletedLeaf deletedLeaf
            {
                get => _deletedLeaf;
                set
                {
                    _deletedLeaf = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Deleted Leaf")]
            #endif
            private ColdArchiveDeletedLeaf _deletedLeaf;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ColdArchiveBoundaryLeafCase : ColdArchiveBucketEntry
        {
            public override ColdArchiveBucketEntryType Discriminator => ColdArchiveBucketEntryType.COLD_ARCHIVE_BOUNDARY_LEAF;
            public ColdArchiveBoundaryLeaf boundaryLeaf
            {
                get => _boundaryLeaf;
                set
                {
                    _boundaryLeaf = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Boundary Leaf")]
            #endif
            private ColdArchiveBoundaryLeaf _boundaryLeaf;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ColdArchiveHash : ColdArchiveBucketEntry
        {
            public override ColdArchiveBucketEntryType Discriminator => ColdArchiveBucketEntryType.COLD_ARCHIVE_HASH;
            public ColdArchiveHashEntry hashEntry
            {
                get => _hashEntry;
                set
                {
                    _hashEntry = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Hash Entry")]
            #endif
            private ColdArchiveHashEntry _hashEntry;

            public override void ValidateCase() {}
        }
    }
    public static partial class ColdArchiveBucketEntryXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ColdArchiveBucketEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ColdArchiveBucketEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, ColdArchiveBucketEntry value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ColdArchiveBucketEntry.ColdArchiveMetaentry case_COLD_ARCHIVE_METAENTRY:
                BucketMetadataXdr.Encode(stream, case_COLD_ARCHIVE_METAENTRY.metaEntry);
                break;
                case ColdArchiveBucketEntry.ColdArchiveArchivedLeafCase case_COLD_ARCHIVE_ARCHIVED_LEAF:
                ColdArchiveArchivedLeafXdr.Encode(stream, case_COLD_ARCHIVE_ARCHIVED_LEAF.archivedLeaf);
                break;
                case ColdArchiveBucketEntry.ColdArchiveDeletedLeafCase case_COLD_ARCHIVE_DELETED_LEAF:
                ColdArchiveDeletedLeafXdr.Encode(stream, case_COLD_ARCHIVE_DELETED_LEAF.deletedLeaf);
                break;
                case ColdArchiveBucketEntry.ColdArchiveBoundaryLeafCase case_COLD_ARCHIVE_BOUNDARY_LEAF:
                ColdArchiveBoundaryLeafXdr.Encode(stream, case_COLD_ARCHIVE_BOUNDARY_LEAF.boundaryLeaf);
                break;
                case ColdArchiveBucketEntry.ColdArchiveHash case_COLD_ARCHIVE_HASH:
                ColdArchiveHashEntryXdr.Encode(stream, case_COLD_ARCHIVE_HASH.hashEntry);
                break;
            }
        }
        public static ColdArchiveBucketEntry Decode(XdrReader stream)
        {
            var discriminator = (ColdArchiveBucketEntryType)stream.ReadInt();
            switch (discriminator)
            {
                case ColdArchiveBucketEntryType.COLD_ARCHIVE_METAENTRY:
                var result_COLD_ARCHIVE_METAENTRY = new ColdArchiveBucketEntry.ColdArchiveMetaentry();
                result_COLD_ARCHIVE_METAENTRY.metaEntry = BucketMetadataXdr.Decode(stream);
                return result_COLD_ARCHIVE_METAENTRY;
                case ColdArchiveBucketEntryType.COLD_ARCHIVE_ARCHIVED_LEAF:
                var result_COLD_ARCHIVE_ARCHIVED_LEAF = new ColdArchiveBucketEntry.ColdArchiveArchivedLeafCase();
                result_COLD_ARCHIVE_ARCHIVED_LEAF.archivedLeaf = ColdArchiveArchivedLeafXdr.Decode(stream);
                return result_COLD_ARCHIVE_ARCHIVED_LEAF;
                case ColdArchiveBucketEntryType.COLD_ARCHIVE_DELETED_LEAF:
                var result_COLD_ARCHIVE_DELETED_LEAF = new ColdArchiveBucketEntry.ColdArchiveDeletedLeafCase();
                result_COLD_ARCHIVE_DELETED_LEAF.deletedLeaf = ColdArchiveDeletedLeafXdr.Decode(stream);
                return result_COLD_ARCHIVE_DELETED_LEAF;
                case ColdArchiveBucketEntryType.COLD_ARCHIVE_BOUNDARY_LEAF:
                var result_COLD_ARCHIVE_BOUNDARY_LEAF = new ColdArchiveBucketEntry.ColdArchiveBoundaryLeafCase();
                result_COLD_ARCHIVE_BOUNDARY_LEAF.boundaryLeaf = ColdArchiveBoundaryLeafXdr.Decode(stream);
                return result_COLD_ARCHIVE_BOUNDARY_LEAF;
                case ColdArchiveBucketEntryType.COLD_ARCHIVE_HASH:
                var result_COLD_ARCHIVE_HASH = new ColdArchiveBucketEntry.ColdArchiveHash();
                result_COLD_ARCHIVE_HASH.hashEntry = ColdArchiveHashEntryXdr.Decode(stream);
                return result_COLD_ARCHIVE_HASH;
                default:
                throw new Exception($"Unknown discriminator for ColdArchiveBucketEntry: {discriminator}");
            }
        }
    }
}
