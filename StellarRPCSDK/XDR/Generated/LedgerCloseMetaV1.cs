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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class LedgerCloseMetaV1
    {
        private LedgerCloseMetaExt _ext;
        public LedgerCloseMetaExt ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }

        private LedgerHeaderHistoryEntry _ledgerHeader;
        public LedgerHeaderHistoryEntry ledgerHeader
        {
            get => _ledgerHeader;
            set
            {
                _ledgerHeader = value;
            }
        }

        private GeneralizedTransactionSet _txSet;
        public GeneralizedTransactionSet txSet
        {
            get => _txSet;
            set
            {
                _txSet = value;
            }
        }

        private TransactionResultMeta[] _txProcessing;
        public TransactionResultMeta[] txProcessing
        {
            get => _txProcessing;
            set
            {
                _txProcessing = value;
            }
        }

        private UpgradeEntryMeta[] _upgradesProcessing;
        public UpgradeEntryMeta[] upgradesProcessing
        {
            get => _upgradesProcessing;
            set
            {
                _upgradesProcessing = value;
            }
        }

        private SCPHistoryEntry[] _scpInfo;
        public SCPHistoryEntry[] scpInfo
        {
            get => _scpInfo;
            set
            {
                _scpInfo = value;
            }
        }

        private uint64 _totalByteSizeOfBucketList;
        public uint64 totalByteSizeOfBucketList
        {
            get => _totalByteSizeOfBucketList;
            set
            {
                _totalByteSizeOfBucketList = value;
            }
        }

        private LedgerKey[] _evictedTemporaryLedgerKeys;
        public LedgerKey[] evictedTemporaryLedgerKeys
        {
            get => _evictedTemporaryLedgerKeys;
            set
            {
                _evictedTemporaryLedgerKeys = value;
            }
        }

        private LedgerEntry[] _evictedPersistentLedgerEntries;
        public LedgerEntry[] evictedPersistentLedgerEntries
        {
            get => _evictedPersistentLedgerEntries;
            set
            {
                _evictedPersistentLedgerEntries = value;
            }
        }

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
