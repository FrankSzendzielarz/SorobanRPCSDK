// Generated code - do not modify
// Source:

// struct ConfigSettingContractLedgerCostV0
// {
//     // Maximum number of ledger entry read operations per ledger
//     uint32 ledgerMaxReadLedgerEntries;
//     // Maximum number of bytes that can be read per ledger
//     uint32 ledgerMaxReadBytes;
//     // Maximum number of ledger entry write operations per ledger
//     uint32 ledgerMaxWriteLedgerEntries;
//     // Maximum number of bytes that can be written per ledger
//     uint32 ledgerMaxWriteBytes;
// 
//     // Maximum number of ledger entry read operations per transaction
//     uint32 txMaxReadLedgerEntries;
//     // Maximum number of bytes that can be read per transaction
//     uint32 txMaxReadBytes;
//     // Maximum number of ledger entry write operations per transaction
//     uint32 txMaxWriteLedgerEntries;
//     // Maximum number of bytes that can be written per transaction
//     uint32 txMaxWriteBytes;
// 
//     int64 feeReadLedgerEntry;  // Fee per ledger entry read
//     int64 feeWriteLedgerEntry; // Fee per ledger entry write
// 
//     int64 feeRead1KB;  // Fee for reading 1KB
// 
//     // The following parameters determine the write fee per 1KB.
//     // Write fee grows linearly until bucket list reaches this size
//     int64 bucketListTargetSizeBytes;
//     // Fee per 1KB write when the bucket list is empty
//     int64 writeFee1KBBucketListLow;
//     // Fee per 1KB write when the bucket list has reached `bucketListTargetSizeBytes` 
//     int64 writeFee1KBBucketListHigh;
//     // Write fee multiplier for any additional data past the first `bucketListTargetSizeBytes`
//     uint32 bucketListWriteFeeGrowthFactor;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    /// <summary>
    /// Ledger access settings for contracts.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class ConfigSettingContractLedgerCostV0
    {
        /// <summary>
        /// Maximum number of ledger entry read operations per ledger
        /// </summary>
        public uint32 ledgerMaxReadLedgerEntries
        {
            get => _ledgerMaxReadLedgerEntries;
            set
            {
                _ledgerMaxReadLedgerEntries = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Ledger Max Read Ledger Entries")]
        #endif
        private uint32 _ledgerMaxReadLedgerEntries;

        /// <summary>
        /// Maximum number of bytes that can be read per ledger
        /// </summary>
        public uint32 ledgerMaxReadBytes
        {
            get => _ledgerMaxReadBytes;
            set
            {
                _ledgerMaxReadBytes = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Ledger Max Read Bytes")]
        #endif
        private uint32 _ledgerMaxReadBytes;

        /// <summary>
        /// Maximum number of ledger entry write operations per ledger
        /// </summary>
        public uint32 ledgerMaxWriteLedgerEntries
        {
            get => _ledgerMaxWriteLedgerEntries;
            set
            {
                _ledgerMaxWriteLedgerEntries = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Ledger Max Write Ledger Entries")]
        #endif
        private uint32 _ledgerMaxWriteLedgerEntries;

        /// <summary>
        /// Maximum number of bytes that can be written per ledger
        /// </summary>
        public uint32 ledgerMaxWriteBytes
        {
            get => _ledgerMaxWriteBytes;
            set
            {
                _ledgerMaxWriteBytes = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Ledger Max Write Bytes")]
        #endif
        private uint32 _ledgerMaxWriteBytes;

        /// <summary>
        /// Maximum number of ledger entry read operations per transaction
        /// </summary>
        public uint32 txMaxReadLedgerEntries
        {
            get => _txMaxReadLedgerEntries;
            set
            {
                _txMaxReadLedgerEntries = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Tx Max Read Ledger Entries")]
        #endif
        private uint32 _txMaxReadLedgerEntries;

        /// <summary>
        /// Maximum number of bytes that can be read per transaction
        /// </summary>
        public uint32 txMaxReadBytes
        {
            get => _txMaxReadBytes;
            set
            {
                _txMaxReadBytes = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Tx Max Read Bytes")]
        #endif
        private uint32 _txMaxReadBytes;

        /// <summary>
        /// Maximum number of ledger entry write operations per transaction
        /// </summary>
        public uint32 txMaxWriteLedgerEntries
        {
            get => _txMaxWriteLedgerEntries;
            set
            {
                _txMaxWriteLedgerEntries = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Tx Max Write Ledger Entries")]
        #endif
        private uint32 _txMaxWriteLedgerEntries;

        /// <summary>
        /// Maximum number of bytes that can be written per transaction
        /// </summary>
        public uint32 txMaxWriteBytes
        {
            get => _txMaxWriteBytes;
            set
            {
                _txMaxWriteBytes = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Tx Max Write Bytes")]
        #endif
        private uint32 _txMaxWriteBytes;

        public int64 feeReadLedgerEntry
        {
            get => _feeReadLedgerEntry;
            set
            {
                _feeReadLedgerEntry = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Fee Read Ledger Entry")]
        #endif
        private int64 _feeReadLedgerEntry;

        /// <summary>
        /// Fee per ledger entry read
        /// </summary>
        public int64 feeWriteLedgerEntry
        {
            get => _feeWriteLedgerEntry;
            set
            {
                _feeWriteLedgerEntry = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Fee Write Ledger Entry")]
        #endif
        private int64 _feeWriteLedgerEntry;

        public int64 feeRead1KB
        {
            get => _feeRead1KB;
            set
            {
                _feeRead1KB = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Fee Read1 K B")]
        #endif
        private int64 _feeRead1KB;

        /// <summary>
        /// Write fee grows linearly until bucket list reaches this size
        /// </summary>
        public int64 bucketListTargetSizeBytes
        {
            get => _bucketListTargetSizeBytes;
            set
            {
                _bucketListTargetSizeBytes = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Bucket List Target Size Bytes")]
        #endif
        private int64 _bucketListTargetSizeBytes;

        /// <summary>
        /// Fee per 1KB write when the bucket list is empty
        /// </summary>
        public int64 writeFee1KBBucketListLow
        {
            get => _writeFee1KBBucketListLow;
            set
            {
                _writeFee1KBBucketListLow = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Write Fee1 K B Bucket List Low")]
        #endif
        private int64 _writeFee1KBBucketListLow;

        /// <summary>
        /// Fee per 1KB write when the bucket list has reached `bucketListTargetSizeBytes`
        /// </summary>
        public int64 writeFee1KBBucketListHigh
        {
            get => _writeFee1KBBucketListHigh;
            set
            {
                _writeFee1KBBucketListHigh = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Write Fee1 K B Bucket List High")]
        #endif
        private int64 _writeFee1KBBucketListHigh;

        /// <summary>
        /// Write fee multiplier for any additional data past the first `bucketListTargetSizeBytes`
        /// </summary>
        public uint32 bucketListWriteFeeGrowthFactor
        {
            get => _bucketListWriteFeeGrowthFactor;
            set
            {
                _bucketListWriteFeeGrowthFactor = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Bucket List Write Fee Growth Factor")]
        #endif
        private uint32 _bucketListWriteFeeGrowthFactor;

        public ConfigSettingContractLedgerCostV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ConfigSettingContractLedgerCostV0Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ConfigSettingContractLedgerCostV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ConfigSettingContractLedgerCostV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ConfigSettingContractLedgerCostV0 value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.ledgerMaxReadLedgerEntries);
            uint32Xdr.Encode(stream, value.ledgerMaxReadBytes);
            uint32Xdr.Encode(stream, value.ledgerMaxWriteLedgerEntries);
            uint32Xdr.Encode(stream, value.ledgerMaxWriteBytes);
            uint32Xdr.Encode(stream, value.txMaxReadLedgerEntries);
            uint32Xdr.Encode(stream, value.txMaxReadBytes);
            uint32Xdr.Encode(stream, value.txMaxWriteLedgerEntries);
            uint32Xdr.Encode(stream, value.txMaxWriteBytes);
            int64Xdr.Encode(stream, value.feeReadLedgerEntry);
            int64Xdr.Encode(stream, value.feeWriteLedgerEntry);
            int64Xdr.Encode(stream, value.feeRead1KB);
            int64Xdr.Encode(stream, value.bucketListTargetSizeBytes);
            int64Xdr.Encode(stream, value.writeFee1KBBucketListLow);
            int64Xdr.Encode(stream, value.writeFee1KBBucketListHigh);
            uint32Xdr.Encode(stream, value.bucketListWriteFeeGrowthFactor);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ConfigSettingContractLedgerCostV0 Decode(XdrReader stream)
        {
            var result = new ConfigSettingContractLedgerCostV0();
            result.ledgerMaxReadLedgerEntries = uint32Xdr.Decode(stream);
            result.ledgerMaxReadBytes = uint32Xdr.Decode(stream);
            result.ledgerMaxWriteLedgerEntries = uint32Xdr.Decode(stream);
            result.ledgerMaxWriteBytes = uint32Xdr.Decode(stream);
            result.txMaxReadLedgerEntries = uint32Xdr.Decode(stream);
            result.txMaxReadBytes = uint32Xdr.Decode(stream);
            result.txMaxWriteLedgerEntries = uint32Xdr.Decode(stream);
            result.txMaxWriteBytes = uint32Xdr.Decode(stream);
            result.feeReadLedgerEntry = int64Xdr.Decode(stream);
            result.feeWriteLedgerEntry = int64Xdr.Decode(stream);
            result.feeRead1KB = int64Xdr.Decode(stream);
            result.bucketListTargetSizeBytes = int64Xdr.Decode(stream);
            result.writeFee1KBBucketListLow = int64Xdr.Decode(stream);
            result.writeFee1KBBucketListHigh = int64Xdr.Decode(stream);
            result.bucketListWriteFeeGrowthFactor = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
