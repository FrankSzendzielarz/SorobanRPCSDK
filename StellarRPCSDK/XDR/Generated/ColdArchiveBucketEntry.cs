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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class ColdArchiveBucketEntry
    {
        public abstract ColdArchiveBucketEntryType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class ColdArchiveBucketEntry_COLD_ARCHIVE_METAENTRY : ColdArchiveBucketEntry
    {
        public override ColdArchiveBucketEntryType Discriminator => ColdArchiveBucketEntryType.COLD_ARCHIVE_METAENTRY;
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
    public sealed partial class ColdArchiveBucketEntry_COLD_ARCHIVE_ARCHIVED_LEAF : ColdArchiveBucketEntry
    {
        public override ColdArchiveBucketEntryType Discriminator => ColdArchiveBucketEntryType.COLD_ARCHIVE_ARCHIVED_LEAF;
        private ColdArchiveArchivedLeaf _archivedLeaf;
        public ColdArchiveArchivedLeaf archivedLeaf
        {
            get => _archivedLeaf;
            set
            {
                _archivedLeaf = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class ColdArchiveBucketEntry_COLD_ARCHIVE_DELETED_LEAF : ColdArchiveBucketEntry
    {
        public override ColdArchiveBucketEntryType Discriminator => ColdArchiveBucketEntryType.COLD_ARCHIVE_DELETED_LEAF;
        private ColdArchiveDeletedLeaf _deletedLeaf;
        public ColdArchiveDeletedLeaf deletedLeaf
        {
            get => _deletedLeaf;
            set
            {
                _deletedLeaf = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class ColdArchiveBucketEntry_COLD_ARCHIVE_BOUNDARY_LEAF : ColdArchiveBucketEntry
    {
        public override ColdArchiveBucketEntryType Discriminator => ColdArchiveBucketEntryType.COLD_ARCHIVE_BOUNDARY_LEAF;
        private ColdArchiveBoundaryLeaf _boundaryLeaf;
        public ColdArchiveBoundaryLeaf boundaryLeaf
        {
            get => _boundaryLeaf;
            set
            {
                _boundaryLeaf = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class ColdArchiveBucketEntry_COLD_ARCHIVE_HASH : ColdArchiveBucketEntry
    {
        public override ColdArchiveBucketEntryType Discriminator => ColdArchiveBucketEntryType.COLD_ARCHIVE_HASH;
        private ColdArchiveHashEntry _hashEntry;
        public ColdArchiveHashEntry hashEntry
        {
            get => _hashEntry;
            set
            {
                _hashEntry = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class ColdArchiveBucketEntryXdr
    {
        public static void Encode(XdrWriter stream, ColdArchiveBucketEntry value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ColdArchiveBucketEntry_COLD_ARCHIVE_METAENTRY case_COLD_ARCHIVE_METAENTRY:
                BucketMetadataXdr.Encode(stream, case_COLD_ARCHIVE_METAENTRY.metaEntry);
                break;
                case ColdArchiveBucketEntry_COLD_ARCHIVE_ARCHIVED_LEAF case_COLD_ARCHIVE_ARCHIVED_LEAF:
                ColdArchiveArchivedLeafXdr.Encode(stream, case_COLD_ARCHIVE_ARCHIVED_LEAF.archivedLeaf);
                break;
                case ColdArchiveBucketEntry_COLD_ARCHIVE_DELETED_LEAF case_COLD_ARCHIVE_DELETED_LEAF:
                ColdArchiveDeletedLeafXdr.Encode(stream, case_COLD_ARCHIVE_DELETED_LEAF.deletedLeaf);
                break;
                case ColdArchiveBucketEntry_COLD_ARCHIVE_BOUNDARY_LEAF case_COLD_ARCHIVE_BOUNDARY_LEAF:
                ColdArchiveBoundaryLeafXdr.Encode(stream, case_COLD_ARCHIVE_BOUNDARY_LEAF.boundaryLeaf);
                break;
                case ColdArchiveBucketEntry_COLD_ARCHIVE_HASH case_COLD_ARCHIVE_HASH:
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
                var result_COLD_ARCHIVE_METAENTRY = new ColdArchiveBucketEntry_COLD_ARCHIVE_METAENTRY();
                result_COLD_ARCHIVE_METAENTRY.metaEntry = BucketMetadataXdr.Decode(stream);
                return result_COLD_ARCHIVE_METAENTRY;
                case ColdArchiveBucketEntryType.COLD_ARCHIVE_ARCHIVED_LEAF:
                var result_COLD_ARCHIVE_ARCHIVED_LEAF = new ColdArchiveBucketEntry_COLD_ARCHIVE_ARCHIVED_LEAF();
                result_COLD_ARCHIVE_ARCHIVED_LEAF.archivedLeaf = ColdArchiveArchivedLeafXdr.Decode(stream);
                return result_COLD_ARCHIVE_ARCHIVED_LEAF;
                case ColdArchiveBucketEntryType.COLD_ARCHIVE_DELETED_LEAF:
                var result_COLD_ARCHIVE_DELETED_LEAF = new ColdArchiveBucketEntry_COLD_ARCHIVE_DELETED_LEAF();
                result_COLD_ARCHIVE_DELETED_LEAF.deletedLeaf = ColdArchiveDeletedLeafXdr.Decode(stream);
                return result_COLD_ARCHIVE_DELETED_LEAF;
                case ColdArchiveBucketEntryType.COLD_ARCHIVE_BOUNDARY_LEAF:
                var result_COLD_ARCHIVE_BOUNDARY_LEAF = new ColdArchiveBucketEntry_COLD_ARCHIVE_BOUNDARY_LEAF();
                result_COLD_ARCHIVE_BOUNDARY_LEAF.boundaryLeaf = ColdArchiveBoundaryLeafXdr.Decode(stream);
                return result_COLD_ARCHIVE_BOUNDARY_LEAF;
                case ColdArchiveBucketEntryType.COLD_ARCHIVE_HASH:
                var result_COLD_ARCHIVE_HASH = new ColdArchiveBucketEntry_COLD_ARCHIVE_HASH();
                result_COLD_ARCHIVE_HASH.hashEntry = ColdArchiveHashEntryXdr.Decode(stream);
                return result_COLD_ARCHIVE_HASH;
                default:
                throw new Exception($"Unknown discriminator for ColdArchiveBucketEntry: {discriminator}");
            }
        }
    }
}
