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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class PreconditionsV2
    {
        private TimeBounds _timeBounds;
        public TimeBounds timeBounds
        {
            get => _timeBounds;
            set
            {
                _timeBounds = value;
            }
        }

        private LedgerBounds _ledgerBounds;
        public LedgerBounds ledgerBounds
        {
            get => _ledgerBounds;
            set
            {
                _ledgerBounds = value;
            }
        }

        private SequenceNumber _minSeqNum;
        public SequenceNumber minSeqNum
        {
            get => _minSeqNum;
            set
            {
                _minSeqNum = value;
            }
        }

        private Duration _minSeqAge;
        public Duration minSeqAge
        {
            get => _minSeqAge;
            set
            {
                _minSeqAge = value;
            }
        }

        private uint32 _minSeqLedgerGap;
        public uint32 minSeqLedgerGap
        {
            get => _minSeqLedgerGap;
            set
            {
                _minSeqLedgerGap = value;
            }
        }

        private SignerKey[] _extraSigners;
        public SignerKey[] extraSigners
        {
            get => _extraSigners;
            set
            {
                if (value.Length > 2)
                	throw new ArgumentException($"Cannot exceed 2 bytes");
                _extraSigners = value;
            }
        }

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
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, PreconditionsV2 value)
        {
            value.Validate();
            TimeBoundsXdr.Encode(stream, value.timeBounds);
            LedgerBoundsXdr.Encode(stream, value.ledgerBounds);
            SequenceNumberXdr.Encode(stream, value.minSeqNum);
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
            result.timeBounds = TimeBoundsXdr.Decode(stream);
            result.ledgerBounds = LedgerBoundsXdr.Decode(stream);
            result.minSeqNum = SequenceNumberXdr.Decode(stream);
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
