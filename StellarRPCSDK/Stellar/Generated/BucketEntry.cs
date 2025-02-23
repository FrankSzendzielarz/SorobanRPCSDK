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
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    [ProtoInclude(100, typeof(Liveentry), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(Initentry), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(Deadentry), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(Metaentry), DataFormat = DataFormat.Default)]
    public abstract partial class BucketEntry
    {
        public abstract BucketEntryType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "BucketEntry_Liveentry")]
        public sealed partial class Liveentry : BucketEntry
        {
            public override BucketEntryType Discriminator => BucketEntryType.LIVEENTRY;
            [ProtoMember(1)]
            public LedgerEntry liveEntry
            {
                get => _liveEntry;
                set
                {
                    _liveEntry = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Live Entry")]
            #endif
            private LedgerEntry _liveEntry;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "BucketEntry_Initentry")]
        public sealed partial class Initentry : BucketEntry
        {
            public override BucketEntryType Discriminator => BucketEntryType.INITENTRY;
            [ProtoMember(2)]
            public LedgerEntry liveEntry
            {
                get => _liveEntry;
                set
                {
                    _liveEntry = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Live Entry")]
            #endif
            private LedgerEntry _liveEntry;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "BucketEntry_Deadentry")]
        public sealed partial class Deadentry : BucketEntry
        {
            public override BucketEntryType Discriminator => BucketEntryType.DEADENTRY;
            [ProtoMember(3)]
            public LedgerKey deadEntry
            {
                get => _deadEntry;
                set
                {
                    _deadEntry = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Dead Entry")]
            #endif
            private LedgerKey _deadEntry;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "BucketEntry_Metaentry")]
        public sealed partial class Metaentry : BucketEntry
        {
            public override BucketEntryType Discriminator => BucketEntryType.METAENTRY;
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
        /// <summary>Decodes value from XDR base64 string</summary>
        public static BucketEntry DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return BucketEntryXdr.Decode(reader);
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
