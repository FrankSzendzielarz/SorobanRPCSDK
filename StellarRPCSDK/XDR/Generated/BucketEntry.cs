// Generated code - do not modify
// Source:

// union BucketEntry switch (BucketEntryType type)
// {
// case LIVEENTRY:
// case INITENTRY:
//     LedgerEntry liveEntry;
// 
// case DEADENTRY:
//     LedgerKey deadEntry;
// case METAENTRY:
//     BucketMetadata metaEntry;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class BucketEntry
    {
        public abstract BucketEntryType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class BucketEntry_LIVEENTRY : BucketEntry
    {
        public override BucketEntryType Discriminator => LIVEENTRY;
        private LedgerEntry _liveEntry;
        public LedgerEntry liveEntry
        {
            get => _liveEntry;
            set
            {
                _liveEntry = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class BucketEntry_INITENTRY : BucketEntry
    {
        public override BucketEntryType Discriminator => INITENTRY;
        private LedgerEntry _liveEntry;
        public LedgerEntry liveEntry
        {
            get => _liveEntry;
            set
            {
                _liveEntry = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class BucketEntry_DEADENTRY : BucketEntry
    {
        public override BucketEntryType Discriminator => DEADENTRY;
        private LedgerKey _deadEntry;
        public LedgerKey deadEntry
        {
            get => _deadEntry;
            set
            {
                _deadEntry = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class BucketEntry_METAENTRY : BucketEntry
    {
        public override BucketEntryType Discriminator => METAENTRY;
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
    public static partial class BucketEntryXdr
    {
        public static void Encode(XdrWriter stream, BucketEntry value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case BucketEntry_LIVEENTRY case_LIVEENTRY:
                LedgerEntryXdr.Encode(stream, case_LIVEENTRY.liveEntry);
                break;
                case BucketEntry_INITENTRY case_INITENTRY:
                LedgerEntryXdr.Encode(stream, case_INITENTRY.liveEntry);
                break;
                case BucketEntry_DEADENTRY case_DEADENTRY:
                LedgerKeyXdr.Encode(stream, case_DEADENTRY.deadEntry);
                break;
                case BucketEntry_METAENTRY case_METAENTRY:
                BucketMetadataXdr.Encode(stream, case_METAENTRY.metaEntry);
                break;
            }
        }
        public static BucketEntry Decode(XdrReader stream)
        {
            var discriminator = (BucketEntryType)stream.ReadInt();
            switch (discriminator)
            {
                case LIVEENTRY:
                var result_LIVEENTRY = new BucketEntry_LIVEENTRY();
                result_LIVEENTRY.                 = LedgerEntryXdr.Decode(stream);
                return result_LIVEENTRY;
                case INITENTRY:
                var result_INITENTRY = new BucketEntry_INITENTRY();
                result_INITENTRY.                 = LedgerEntryXdr.Decode(stream);
                return result_INITENTRY;
                case DEADENTRY:
                var result_DEADENTRY = new BucketEntry_DEADENTRY();
                result_DEADENTRY.                 = LedgerKeyXdr.Decode(stream);
                return result_DEADENTRY;
                case METAENTRY:
                var result_METAENTRY = new BucketEntry_METAENTRY();
                result_METAENTRY.                 = BucketMetadataXdr.Decode(stream);
                return result_METAENTRY;
                default:
                throw new Exception($"Unknown discriminator for BucketEntry: {discriminator}");
            }
        }
    }
}
