// Generated code - do not modify
// Source:

// struct LedgerCloseMetaV0
// {
//     LedgerHeaderHistoryEntry ledgerHeader;
//     // NB: txSet is sorted in "Hash order"
//     TransactionSet txSet;
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
    public partial class LedgerCloseMetaV0
    {
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

        /// <summary>
        /// NB: txSet is sorted in "Hash order"
        /// </summary>
        public TransactionSet txSet
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
        private TransactionSet _txSet;

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

        public LedgerCloseMetaV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class LedgerCloseMetaV0Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LedgerCloseMetaV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LedgerCloseMetaV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, LedgerCloseMetaV0 value)
        {
            value.Validate();
            LedgerHeaderHistoryEntryXdr.Encode(stream, value.ledgerHeader);
            TransactionSetXdr.Encode(stream, value.txSet);
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
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static LedgerCloseMetaV0 Decode(XdrReader stream)
        {
            var result = new LedgerCloseMetaV0();
            result.ledgerHeader = LedgerHeaderHistoryEntryXdr.Decode(stream);
            result.txSet = TransactionSetXdr.Decode(stream);
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
            return result;
        }
    }
}
