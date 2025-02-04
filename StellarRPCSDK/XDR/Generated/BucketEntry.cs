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
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class BucketEntry
    {
        public abstract BucketEntryType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        public sealed partial class Liveentry : BucketEntry
        {
            public override BucketEntryType Discriminator => BucketEntryType.LIVEENTRY;
            public LedgerEntry liveEntry
            {
                get => _liveEntry;
                set
                {
                    _liveEntry = value;
                }
            }
            private LedgerEntry _liveEntry;

            public override void ValidateCase() {}
        }
        public sealed partial class Initentry : BucketEntry
        {
            public override BucketEntryType Discriminator => BucketEntryType.INITENTRY;
            public LedgerEntry liveEntry
            {
                get => _liveEntry;
                set
                {
                    _liveEntry = value;
                }
            }
            private LedgerEntry _liveEntry;

            public override void ValidateCase() {}
        }
        public sealed partial class Deadentry : BucketEntry
        {
            public override BucketEntryType Discriminator => BucketEntryType.DEADENTRY;
            public LedgerKey deadEntry
            {
                get => _deadEntry;
                set
                {
                    _deadEntry = value;
                }
            }
            private LedgerKey _deadEntry;

            public override void ValidateCase() {}
        }
        public sealed partial class Metaentry : BucketEntry
        {
            public override BucketEntryType Discriminator => BucketEntryType.METAENTRY;
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
    public static partial class BucketEntryXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(BucketEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                BucketEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, BucketEntry value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case BucketEntry.Liveentry case_LIVEENTRY:
                LedgerEntryXdr.Encode(stream, case_LIVEENTRY.liveEntry);
                break;
                case BucketEntry.Initentry case_INITENTRY:
                LedgerEntryXdr.Encode(stream, case_INITENTRY.liveEntry);
                break;
                case BucketEntry.Deadentry case_DEADENTRY:
                LedgerKeyXdr.Encode(stream, case_DEADENTRY.deadEntry);
                break;
                case BucketEntry.Metaentry case_METAENTRY:
                BucketMetadataXdr.Encode(stream, case_METAENTRY.metaEntry);
                break;
            }
        }
        public static BucketEntry Decode(XdrReader stream)
        {
            var discriminator = (BucketEntryType)stream.ReadInt();
            switch (discriminator)
            {
                case BucketEntryType.LIVEENTRY:
                var result_LIVEENTRY = new BucketEntry.Liveentry();
                result_LIVEENTRY.liveEntry = LedgerEntryXdr.Decode(stream);
                return result_LIVEENTRY;
                case BucketEntryType.INITENTRY:
                var result_INITENTRY = new BucketEntry.Initentry();
                result_INITENTRY.liveEntry = LedgerEntryXdr.Decode(stream);
                return result_INITENTRY;
                case BucketEntryType.DEADENTRY:
                var result_DEADENTRY = new BucketEntry.Deadentry();
                result_DEADENTRY.deadEntry = LedgerKeyXdr.Decode(stream);
                return result_DEADENTRY;
                case BucketEntryType.METAENTRY:
                var result_METAENTRY = new BucketEntry.Metaentry();
                result_METAENTRY.metaEntry = BucketMetadataXdr.Decode(stream);
                return result_METAENTRY;
                default:
                throw new Exception($"Unknown discriminator for BucketEntry: {discriminator}");
            }
        }
    }
}
