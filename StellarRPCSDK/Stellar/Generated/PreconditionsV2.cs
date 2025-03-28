// Generated code - do not modify
// Source:

// struct PreconditionsV2
// {
//     TimeBounds* timeBounds;
// 
//     // Transaction only valid for ledger numbers n such that
//     // minLedger <= n < maxLedger (if maxLedger == 0, then
//     // only minLedger is checked)
//     LedgerBounds* ledgerBounds;
// 
//     // If NULL, only valid when sourceAccount's sequence number
//     // is seqNum - 1.  Otherwise, valid when sourceAccount's
//     // sequence number n satisfies minSeqNum <= n < tx.seqNum.
//     // Note that after execution the account's sequence number
//     // is always raised to tx.seqNum, and a transaction is not
//     // valid if tx.seqNum is too high to ensure replay protection.
//     SequenceNumber* minSeqNum;
// 
//     // For the transaction to be valid, the current ledger time must
//     // be at least minSeqAge greater than sourceAccount's seqTime.
//     Duration minSeqAge;
// 
//     // For the transaction to be valid, the current ledger number
//     // must be at least minSeqLedgerGap greater than sourceAccount's
//     // seqLedger.
//     uint32 minSeqLedgerGap;
// 
//     // For the transaction to be valid, there must be a signature
//     // corresponding to every Signer in this array, even if the
//     // signature is not otherwise required by the sourceAccount or
//     // operations.
//     SignerKey extraSigners<2>;
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
    public partial class PreconditionsV2
    {
        [ProtoMember(1)]
        public TimeBounds timeBounds
        {
            get => _timeBounds;
            set
            {
                _timeBounds = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Time Bounds")]
        #endif
        private TimeBounds _timeBounds;

        /// <summary>
        /// only minLedger is checked)
        /// </summary>
        [ProtoMember(2)]
        public LedgerBounds ledgerBounds
        {
            get => _ledgerBounds;
            set
            {
                _ledgerBounds = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Ledger Bounds")]
        #endif
        private LedgerBounds _ledgerBounds;

        /// <summary>
        /// valid if tx.seqNum is too high to ensure replay protection.
        /// </summary>
        [ProtoMember(3)]
        public SequenceNumber minSeqNum
        {
            get => _minSeqNum;
            set
            {
                _minSeqNum = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Min Seq Num")]
        #endif
        private SequenceNumber _minSeqNum;

        /// <summary>
        /// be at least minSeqAge greater than sourceAccount's seqTime.
        /// </summary>
        [ProtoMember(4)]
        public Duration minSeqAge
        {
            get => _minSeqAge;
            set
            {
                _minSeqAge = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Min Seq Age")]
        #endif
        private Duration _minSeqAge;

        /// <summary>
        /// seqLedger.
        /// </summary>
        [ProtoMember(5)]
        public uint32 minSeqLedgerGap
        {
            get => _minSeqLedgerGap;
            set
            {
                _minSeqLedgerGap = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Min Seq Ledger Gap")]
        #endif
        private uint32 _minSeqLedgerGap;

        /// <summary>
        /// operations.
        /// </summary>
        [ProtoMember(6, OverwriteList = true)]
        [MaxLength(2)]
        public SignerKey[] extraSigners
        {
            get => _extraSigners;
            set
            {
                if (value.Length > 2)
                	throw new ArgumentException($"Cannot exceed 2 in length");
                _extraSigners = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Extra Signers")]
        #endif
        private SignerKey[] _extraSigners;

        public PreconditionsV2()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (extraSigners.Length > 2)
            	throw new InvalidOperationException($"extraSigners cannot exceed 2 elements");
        }
    }
    public static partial class PreconditionsV2Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(PreconditionsV2 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                PreconditionsV2Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static PreconditionsV2 DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return PreconditionsV2Xdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, PreconditionsV2 value)
        {
            value.Validate();
            if (value.timeBounds==null){
            	stream.WriteInt(0);
            }
            else
            {
                stream.WriteInt(1);
                TimeBoundsXdr.Encode(stream, value.timeBounds);
            }
            if (value.ledgerBounds==null){
            	stream.WriteInt(0);
            }
            else
            {
                stream.WriteInt(1);
                LedgerBoundsXdr.Encode(stream, value.ledgerBounds);
            }
            if (value.minSeqNum==null){
            	stream.WriteInt(0);
            }
            else
            {
                stream.WriteInt(1);
                SequenceNumberXdr.Encode(stream, value.minSeqNum);
            }
            DurationXdr.Encode(stream, value.minSeqAge);
            uint32Xdr.Encode(stream, value.minSeqLedgerGap);
            stream.WriteInt(value.extraSigners.Length);
            foreach (var item in value.extraSigners)
            {
                    SignerKeyXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static PreconditionsV2 Decode(XdrReader stream)
        {
            var result = new PreconditionsV2();
            if (stream.ReadInt()==1)
            {
                result.timeBounds = TimeBoundsXdr.Decode(stream);
            }
            if (stream.ReadInt()==1)
            {
                result.ledgerBounds = LedgerBoundsXdr.Decode(stream);
            }
            if (stream.ReadInt()==1)
            {
                result.minSeqNum = SequenceNumberXdr.Decode(stream);
            }
            result.minSeqAge = DurationXdr.Decode(stream);
            result.minSeqLedgerGap = uint32Xdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.extraSigners = new SignerKey[length];
                for (var i = 0; i < length; i++)
                {
                    result.extraSigners[i] = SignerKeyXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
