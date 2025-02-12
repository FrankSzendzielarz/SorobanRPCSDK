// Generated code - do not modify
// Source:

// struct LedgerCloseMetaV1
// {
//     LedgerCloseMetaExt ext;
// 
//     LedgerHeaderHistoryEntry ledgerHeader;
// 
//     GeneralizedTransactionSet txSet;
// 
//     // NB: transactions are sorted in apply order here
//     // fees for all transactions are processed first
//     // followed by applying transactions
//     TransactionResultMeta txProcessing<>;
// 
//     // upgrades are applied last
//     UpgradeEntryMeta upgradesProcessing<>;
// 
//     // other misc information attached to the ledger close
//     SCPHistoryEntry scpInfo<>;
// 
//     // Size in bytes of BucketList, to support downstream
//     // systems calculating storage fees correctly.
//     uint64 totalByteSizeOfBucketList;
// 
//     // Temp keys that are being evicted at this ledger.
//     LedgerKey evictedTemporaryLedgerKeys<>;
// 
//     // Archived restorable ledger entries that are being
//     // evicted at this ledger.
//     LedgerEntry evictedPersistentLedgerEntries<>;
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
    public partial class LedgerCloseMetaV1
    {
        public LedgerCloseMetaExt ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Ext")]
        #endif
        private LedgerCloseMetaExt _ext;

        public LedgerHeaderHistoryEntry ledgerHeader
        {
            get => _ledgerHeader;
            set
            {
                _ledgerHeader = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Ledger Header")]
        #endif
        private LedgerHeaderHistoryEntry _ledgerHeader;

        public GeneralizedTransactionSet txSet
        {
            get => _txSet;
            set
            {
                _txSet = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Tx Set")]
        #endif
        private GeneralizedTransactionSet _txSet;

        /// <summary>
        /// followed by applying transactions
        /// </summary>
        public TransactionResultMeta[] txProcessing
        {
            get => _txProcessing;
            set
            {
                _txProcessing = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Tx Processing")]
        #endif
        private TransactionResultMeta[] _txProcessing;

        /// <summary>
        /// upgrades are applied last
        /// </summary>
        public UpgradeEntryMeta[] upgradesProcessing
        {
            get => _upgradesProcessing;
            set
            {
                _upgradesProcessing = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Upgrades Processing")]
        #endif
        private UpgradeEntryMeta[] _upgradesProcessing;

        /// <summary>
        /// other misc information attached to the ledger close
        /// </summary>
        public SCPHistoryEntry[] scpInfo
        {
            get => _scpInfo;
            set
            {
                _scpInfo = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Scp Info")]
        #endif
        private SCPHistoryEntry[] _scpInfo;

        /// <summary>
        /// systems calculating storage fees correctly.
        /// </summary>
        public uint64 totalByteSizeOfBucketList
        {
            get => _totalByteSizeOfBucketList;
            set
            {
                _totalByteSizeOfBucketList = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Total Byte Size Of Bucket List")]
        #endif
        private uint64 _totalByteSizeOfBucketList;

        /// <summary>
        /// Temp keys that are being evicted at this ledger.
        /// </summary>
        public LedgerKey[] evictedTemporaryLedgerKeys
        {
            get => _evictedTemporaryLedgerKeys;
            set
            {
                _evictedTemporaryLedgerKeys = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Evicted Temporary Ledger Keys")]
        #endif
        private LedgerKey[] _evictedTemporaryLedgerKeys;

        /// <summary>
        /// evicted at this ledger.
        /// </summary>
        public LedgerEntry[] evictedPersistentLedgerEntries
        {
            get => _evictedPersistentLedgerEntries;
            set
            {
                _evictedPersistentLedgerEntries = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Evicted Persistent Ledger Entries")]
        #endif
        private LedgerEntry[] _evictedPersistentLedgerEntries;

        public LedgerCloseMetaV1()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class LedgerCloseMetaV1Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LedgerCloseMetaV1 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LedgerCloseMetaV1Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, LedgerCloseMetaV1 value)
        {
            value.Validate();
            LedgerCloseMetaExtXdr.Encode(stream, value.ext);
            LedgerHeaderHistoryEntryXdr.Encode(stream, value.ledgerHeader);
            GeneralizedTransactionSetXdr.Encode(stream, value.txSet);
            stream.WriteInt(value.txProcessing.Length);
            foreach (var item in value.txProcessing)
            {
                    TransactionResultMetaXdr.Encode(stream, item);
            }
            stream.WriteInt(value.upgradesProcessing.Length);
            foreach (var item in value.upgradesProcessing)
            {
                    UpgradeEntryMetaXdr.Encode(stream, item);
            }
            stream.WriteInt(value.scpInfo.Length);
            foreach (var item in value.scpInfo)
            {
                    SCPHistoryEntryXdr.Encode(stream, item);
            }
            uint64Xdr.Encode(stream, value.totalByteSizeOfBucketList);
            stream.WriteInt(value.evictedTemporaryLedgerKeys.Length);
            foreach (var item in value.evictedTemporaryLedgerKeys)
            {
                    LedgerKeyXdr.Encode(stream, item);
            }
            stream.WriteInt(value.evictedPersistentLedgerEntries.Length);
            foreach (var item in value.evictedPersistentLedgerEntries)
            {
                    LedgerEntryXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static LedgerCloseMetaV1 Decode(XdrReader stream)
        {
            var result = new LedgerCloseMetaV1();
            result.ext = LedgerCloseMetaExtXdr.Decode(stream);
            result.ledgerHeader = LedgerHeaderHistoryEntryXdr.Decode(stream);
            result.txSet = GeneralizedTransactionSetXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.txProcessing = new TransactionResultMeta[length];
                for (var i = 0; i < length; i++)
                {
                    result.txProcessing[i] = TransactionResultMetaXdr.Decode(stream);
                }
            }
            {
                var length = stream.ReadInt();
                result.upgradesProcessing = new UpgradeEntryMeta[length];
                for (var i = 0; i < length; i++)
                {
                    result.upgradesProcessing[i] = UpgradeEntryMetaXdr.Decode(stream);
                }
            }
            {
                var length = stream.ReadInt();
                result.scpInfo = new SCPHistoryEntry[length];
                for (var i = 0; i < length; i++)
                {
                    result.scpInfo[i] = SCPHistoryEntryXdr.Decode(stream);
                }
            }
            result.totalByteSizeOfBucketList = uint64Xdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.evictedTemporaryLedgerKeys = new LedgerKey[length];
                for (var i = 0; i < length; i++)
                {
                    result.evictedTemporaryLedgerKeys[i] = LedgerKeyXdr.Decode(stream);
                }
            }
            {
                var length = stream.ReadInt();
                result.evictedPersistentLedgerEntries = new LedgerEntry[length];
                for (var i = 0; i < length; i++)
                {
                    result.evictedPersistentLedgerEntries[i] = LedgerEntryXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
