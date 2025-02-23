// Generated code - do not modify
// Source:

// struct StateArchivalSettings {
//     uint32 maxEntryTTL;
//     uint32 minTemporaryTTL;
//     uint32 minPersistentTTL;
// 
//     // rent_fee = wfee_rate_average / rent_rate_denominator_for_type
//     int64 persistentRentRateDenominator;
//     int64 tempRentRateDenominator;
// 
//     // max number of entries that emit archival meta in a single ledger
//     uint32 maxEntriesToArchive;
// 
//     // Number of snapshots to use when calculating average BucketList size
//     uint32 bucketListSizeWindowSampleSize;
// 
//     // How often to sample the BucketList size for the average, in ledgers
//     uint32 bucketListWindowSamplePeriod;
// 
//     // Maximum number of bytes that we scan for eviction per ledger
//     uint32 evictionScanSize;
// 
//     // Lowest BucketList level to be scanned to evict entries
//     uint32 startingEvictionScanLevel;
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
    public partial class StateArchivalSettings
    {
        [ProtoMember(1)]
        public uint32 maxEntryTTL
        {
            get => _maxEntryTTL;
            set
            {
                _maxEntryTTL = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Max Entry T T L")]
        #endif
        private uint32 _maxEntryTTL;

        [ProtoMember(2)]
        public uint32 minTemporaryTTL
        {
            get => _minTemporaryTTL;
            set
            {
                _minTemporaryTTL = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Min Temporary T T L")]
        #endif
        private uint32 _minTemporaryTTL;

        [ProtoMember(3)]
        public uint32 minPersistentTTL
        {
            get => _minPersistentTTL;
            set
            {
                _minPersistentTTL = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Min Persistent T T L")]
        #endif
        private uint32 _minPersistentTTL;

        /// <summary>
        /// rent_fee = wfee_rate_average / rent_rate_denominator_for_type
        /// </summary>
        [ProtoMember(4)]
        public int64 persistentRentRateDenominator
        {
            get => _persistentRentRateDenominator;
            set
            {
                _persistentRentRateDenominator = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Persistent Rent Rate Denominator")]
        #endif
        private int64 _persistentRentRateDenominator;

        [ProtoMember(5)]
        public int64 tempRentRateDenominator
        {
            get => _tempRentRateDenominator;
            set
            {
                _tempRentRateDenominator = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Temp Rent Rate Denominator")]
        #endif
        private int64 _tempRentRateDenominator;

        /// <summary>
        /// max number of entries that emit archival meta in a single ledger
        /// </summary>
        [ProtoMember(6)]
        public uint32 maxEntriesToArchive
        {
            get => _maxEntriesToArchive;
            set
            {
                _maxEntriesToArchive = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Max Entries To Archive")]
        #endif
        private uint32 _maxEntriesToArchive;

        /// <summary>
        /// Number of snapshots to use when calculating average BucketList size
        /// </summary>
        [ProtoMember(7)]
        public uint32 bucketListSizeWindowSampleSize
        {
            get => _bucketListSizeWindowSampleSize;
            set
            {
                _bucketListSizeWindowSampleSize = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Bucket List Size Window Sample Size")]
        #endif
        private uint32 _bucketListSizeWindowSampleSize;

        /// <summary>
        /// How often to sample the BucketList size for the average, in ledgers
        /// </summary>
        [ProtoMember(8)]
        public uint32 bucketListWindowSamplePeriod
        {
            get => _bucketListWindowSamplePeriod;
            set
            {
                _bucketListWindowSamplePeriod = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Bucket List Window Sample Period")]
        #endif
        private uint32 _bucketListWindowSamplePeriod;

        /// <summary>
        /// Maximum number of bytes that we scan for eviction per ledger
        /// </summary>
        [ProtoMember(9)]
        public uint32 evictionScanSize
        {
            get => _evictionScanSize;
            set
            {
                _evictionScanSize = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Eviction Scan Size")]
        #endif
        private uint32 _evictionScanSize;

        /// <summary>
        /// Lowest BucketList level to be scanned to evict entries
        /// </summary>
        [ProtoMember(10)]
        public uint32 startingEvictionScanLevel
        {
            get => _startingEvictionScanLevel;
            set
            {
                _startingEvictionScanLevel = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Starting Eviction Scan Level")]
        #endif
        private uint32 _startingEvictionScanLevel;

        public StateArchivalSettings()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class StateArchivalSettingsXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(StateArchivalSettings value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                StateArchivalSettingsXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static StateArchivalSettings DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return StateArchivalSettingsXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, StateArchivalSettings value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.maxEntryTTL);
            uint32Xdr.Encode(stream, value.minTemporaryTTL);
            uint32Xdr.Encode(stream, value.minPersistentTTL);
            int64Xdr.Encode(stream, value.persistentRentRateDenominator);
            int64Xdr.Encode(stream, value.tempRentRateDenominator);
            uint32Xdr.Encode(stream, value.maxEntriesToArchive);
            uint32Xdr.Encode(stream, value.bucketListSizeWindowSampleSize);
            uint32Xdr.Encode(stream, value.bucketListWindowSamplePeriod);
            uint32Xdr.Encode(stream, value.evictionScanSize);
            uint32Xdr.Encode(stream, value.startingEvictionScanLevel);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static StateArchivalSettings Decode(XdrReader stream)
        {
            var result = new StateArchivalSettings();
            result.maxEntryTTL = uint32Xdr.Decode(stream);
            result.minTemporaryTTL = uint32Xdr.Decode(stream);
            result.minPersistentTTL = uint32Xdr.Decode(stream);
            result.persistentRentRateDenominator = int64Xdr.Decode(stream);
            result.tempRentRateDenominator = int64Xdr.Decode(stream);
            result.maxEntriesToArchive = uint32Xdr.Decode(stream);
            result.bucketListSizeWindowSampleSize = uint32Xdr.Decode(stream);
            result.bucketListWindowSamplePeriod = uint32Xdr.Decode(stream);
            result.evictionScanSize = uint32Xdr.Decode(stream);
            result.startingEvictionScanLevel = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
