// Generated code - do not modify
// Source:

// struct LedgerHeader
// {
//     uint32 ledgerVersion;    // the protocol version of the ledger
//     Hash previousLedgerHash; // hash of the previous ledger header
//     StellarValue scpValue;   // what consensus agreed to
//     Hash txSetResultHash;    // the TransactionResultSet that led to this ledger
//     Hash bucketListHash;     // hash of the ledger state
// 
//     uint32 ledgerSeq; // sequence number of this ledger
// 
//     int64 totalCoins; // total number of stroops in existence.
//                       // 10,000,000 stroops in 1 XLM
// 
//     int64 feePool;       // fees burned since last inflation run
//     uint32 inflationSeq; // inflation sequence number
// 
//     uint64 idPool; // last used global ID, used for generating objects
// 
//     uint32 baseFee;     // base fee per operation in stroops
//     uint32 baseReserve; // account base reserve in stroops
// 
//     uint32 maxTxSetSize; // maximum size a transaction set can be
// 
//     Hash skipList[4]; // hashes of ledgers in the past. allows you to jump back
//                       // in time without walking the chain back ledger by ledger
//                       // each slot contains the oldest ledger that is mod of
//                       // either 50  5000  50000 or 500000 depending on index
//                       // skipList[0] mod(50), skipList[1] mod(5000), etc
// 
//     // reserved for future use
//     union switch (int v)
//     {
//     case 0:
//         void;
//     case 1:
//         LedgerHeaderExtensionV1 v1;
//     }
//     ext;
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
    public partial class LedgerHeader
    {
        [ProtoMember(1)]
        public uint32 ledgerVersion
        {
            get => _ledgerVersion;
            set
            {
                _ledgerVersion = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Ledger Version")]
        #endif
        private uint32 _ledgerVersion;

        /// <summary>
        /// the protocol version of the ledger
        /// </summary>
        [ProtoMember(2)]
        public Hash previousLedgerHash
        {
            get => _previousLedgerHash;
            set
            {
                _previousLedgerHash = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Previous Ledger Hash")]
        #endif
        private Hash _previousLedgerHash;

        /// <summary>
        /// hash of the previous ledger header
        /// </summary>
        [ProtoMember(3)]
        public StellarValue scpValue
        {
            get => _scpValue;
            set
            {
                _scpValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Scp Value")]
        #endif
        private StellarValue _scpValue;

        /// <summary>
        /// what consensus agreed to
        /// </summary>
        [ProtoMember(4)]
        public Hash txSetResultHash
        {
            get => _txSetResultHash;
            set
            {
                _txSetResultHash = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Tx Set Result Hash")]
        #endif
        private Hash _txSetResultHash;

        /// <summary>
        /// the TransactionResultSet that led to this ledger
        /// </summary>
        [ProtoMember(5)]
        public Hash bucketListHash
        {
            get => _bucketListHash;
            set
            {
                _bucketListHash = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Bucket List Hash")]
        #endif
        private Hash _bucketListHash;

        [ProtoMember(6)]
        public uint32 ledgerSeq
        {
            get => _ledgerSeq;
            set
            {
                _ledgerSeq = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Ledger Seq")]
        #endif
        private uint32 _ledgerSeq;

        [ProtoMember(7)]
        public int64 totalCoins
        {
            get => _totalCoins;
            set
            {
                _totalCoins = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Total Coins")]
        #endif
        private int64 _totalCoins;

        [ProtoMember(8)]
        public int64 feePool
        {
            get => _feePool;
            set
            {
                _feePool = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Fee Pool")]
        #endif
        private int64 _feePool;

        /// <summary>
        /// fees burned since last inflation run
        /// </summary>
        [ProtoMember(9)]
        public uint32 inflationSeq
        {
            get => _inflationSeq;
            set
            {
                _inflationSeq = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inflation Seq")]
        #endif
        private uint32 _inflationSeq;

        [ProtoMember(10)]
        public uint64 idPool
        {
            get => _idPool;
            set
            {
                _idPool = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Id Pool")]
        #endif
        private uint64 _idPool;

        [ProtoMember(11)]
        public uint32 baseFee
        {
            get => _baseFee;
            set
            {
                _baseFee = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Base Fee")]
        #endif
        private uint32 _baseFee;

        /// <summary>
        /// base fee per operation in stroops
        /// </summary>
        [ProtoMember(12)]
        public uint32 baseReserve
        {
            get => _baseReserve;
            set
            {
                _baseReserve = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Base Reserve")]
        #endif
        private uint32 _baseReserve;

        [ProtoMember(13)]
        public uint32 maxTxSetSize
        {
            get => _maxTxSetSize;
            set
            {
                _maxTxSetSize = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Max Tx Set Size")]
        #endif
        private uint32 _maxTxSetSize;

        [ProtoMember(14, OverwriteList = true)]
        [MinLength(4)]
        [MaxLength(4)]
        public Hash[] skipList
        {
            get => _skipList;
            set
            {
                if (value.Length != 4)
                	throw new ArgumentException($"Must be exactly 4 in length");
                _skipList = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Skip List")]
        #endif
        private Hash[] _skipList = new Hash[4];

        /// <summary>
        /// reserved for future use
        /// </summary>
        [ProtoMember(15)]
        public extUnion ext
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
        private extUnion _ext;

        public LedgerHeader()
        {
            skipList = new Hash[4];
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (skipList.Length != 4)
            	throw new InvalidOperationException($"skipList must be exactly 4 elements");
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "LedgerHeader.extUnion")]
        [ProtoInclude(100, typeof(case_0), DataFormat = DataFormat.Default)]
        [ProtoInclude(101, typeof(case_1), DataFormat = DataFormat.Default)]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.Serializable]
            [ProtoContract(Name = "LedgerHeader.extUnion.case_0")]
            public sealed partial class case_0 : extUnion
            {
                public override int Discriminator => 0;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "LedgerHeader.extUnion.case_1")]
            public sealed partial class case_1 : extUnion
            {
                public override int Discriminator => 1;
                [ProtoMember(1)]
                public LedgerHeaderExtensionV1 v1
                {
                    get => _v1;
                    set
                    {
                        _v1 = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"V1")]
                #endif
                private LedgerHeaderExtensionV1 _v1;

                public override void ValidateCase() {}
            }
        }
        public static partial class extUnionXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(extUnion value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    extUnionXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Decodes value from XDR base64 string</summary>
            public static extUnion DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return extUnionXdr.Decode(reader);
                }
            }
            public static void Encode(XdrWriter stream, extUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case extUnion.case_0 case_0:
                    break;
                    case extUnion.case_1 case_1:
                    LedgerHeaderExtensionV1Xdr.Encode(stream, case_1.v1);
                    break;
                }
            }
            public static extUnion Decode(XdrReader stream)
            {
                var discriminator = (int)stream.ReadInt();
                switch (discriminator)
                {
                    case 0:
                    var result_0 = new extUnion.case_0();
                    return result_0;
                    case 1:
                    var result_1 = new extUnion.case_1();
                    result_1.v1 = LedgerHeaderExtensionV1Xdr.Decode(stream);
                    return result_1;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class LedgerHeaderXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LedgerHeader value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LedgerHeaderXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static LedgerHeader DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return LedgerHeaderXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, LedgerHeader value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.ledgerVersion);
            HashXdr.Encode(stream, value.previousLedgerHash);
            StellarValueXdr.Encode(stream, value.scpValue);
            HashXdr.Encode(stream, value.txSetResultHash);
            HashXdr.Encode(stream, value.bucketListHash);
            uint32Xdr.Encode(stream, value.ledgerSeq);
            int64Xdr.Encode(stream, value.totalCoins);
            int64Xdr.Encode(stream, value.feePool);
            uint32Xdr.Encode(stream, value.inflationSeq);
            uint64Xdr.Encode(stream, value.idPool);
            uint32Xdr.Encode(stream, value.baseFee);
            uint32Xdr.Encode(stream, value.baseReserve);
            uint32Xdr.Encode(stream, value.maxTxSetSize);
            foreach (var item in value.skipList)
            {
                    HashXdr.Encode(stream, item);
            }
            LedgerHeader.extUnionXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static LedgerHeader Decode(XdrReader stream)
        {
            var result = new LedgerHeader();
            result.ledgerVersion = uint32Xdr.Decode(stream);
            result.previousLedgerHash = HashXdr.Decode(stream);
            result.scpValue = StellarValueXdr.Decode(stream);
            result.txSetResultHash = HashXdr.Decode(stream);
            result.bucketListHash = HashXdr.Decode(stream);
            result.ledgerSeq = uint32Xdr.Decode(stream);
            result.totalCoins = int64Xdr.Decode(stream);
            result.feePool = int64Xdr.Decode(stream);
            result.inflationSeq = uint32Xdr.Decode(stream);
            result.idPool = uint64Xdr.Decode(stream);
            result.baseFee = uint32Xdr.Decode(stream);
            result.baseReserve = uint32Xdr.Decode(stream);
            result.maxTxSetSize = uint32Xdr.Decode(stream);
            {
                result.skipList = new Hash[4];
                for (var i = 0; i < 4; i++)
                {
                    result.skipList[i] = HashXdr.Decode(stream);
                }
            }
            result.ext = LedgerHeader.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
