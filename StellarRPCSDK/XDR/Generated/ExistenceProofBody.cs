// Generated code - do not modify
// Source:

// struct ExistenceProofBody
// {
//     LedgerKey keysToProve<>;
// 
//     // Bounds for each key being proved, where bound[n]
//     // corresponds to keysToProve[n]
//     ColdArchiveBucketEntry lowBoundEntries<>;
//     ColdArchiveBucketEntry highBoundEntries<>;
// 
//     // Vector of vectors, where proofLevels[level]
//     // contains all HashNodes that correspond with that level
//     ProofLevel proofLevels<>;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ExistenceProofBody
    {
        private LedgerKey[] _keysToProve;
        public LedgerKey[] keysToProve
        {
            get => _keysToProve;
            set
            {
                _keysToProve = value;
            }
        }

        private ColdArchiveBucketEntry[] _lowBoundEntries;
        public ColdArchiveBucketEntry[] lowBoundEntries
        {
            get => _lowBoundEntries;
            set
            {
                _lowBoundEntries = value;
            }
        }

        private ColdArchiveBucketEntry[] _highBoundEntries;
        public ColdArchiveBucketEntry[] highBoundEntries
        {
            get => _highBoundEntries;
            set
            {
                _highBoundEntries = value;
            }
        }

        private ProofLevel[] _proofLevels;
        public ProofLevel[] proofLevels
        {
            get => _proofLevels;
            set
            {
                _proofLevels = value;
            }
        }

        public ExistenceProofBody()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ExistenceProofBodyXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ExistenceProofBody value)
        {
            value.Validate();
            stream.WriteInt(value.keysToProve.Length);
            foreach (var item in value.keysToProve)
            {
                    LedgerKeyXdr.Encode(stream, item);
            }
            stream.WriteInt(value.lowBoundEntries.Length);
            foreach (var item in value.lowBoundEntries)
            {
                    ColdArchiveBucketEntryXdr.Encode(stream, item);
            }
            stream.WriteInt(value.highBoundEntries.Length);
            foreach (var item in value.highBoundEntries)
            {
                    ColdArchiveBucketEntryXdr.Encode(stream, item);
            }
            stream.WriteInt(value.proofLevels.Length);
            foreach (var item in value.proofLevels)
            {
                    ProofLevelXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ExistenceProofBody Decode(XdrReader stream)
        {
            var result = new ExistenceProofBody();
            {
                var length = stream.ReadInt();
                result.keysToProve = new LedgerKey[length];
                for (var i = 0; i < length; i++)
                {
                    result.keysToProve[i] = LedgerKeyXdr.Decode(stream);
                }
            }
            {
                var length = stream.ReadInt();
                result.lowBoundEntries = new ColdArchiveBucketEntry[length];
                for (var i = 0; i < length; i++)
                {
                    result.lowBoundEntries[i] = ColdArchiveBucketEntryXdr.Decode(stream);
                }
            }
            {
                var length = stream.ReadInt();
                result.highBoundEntries = new ColdArchiveBucketEntry[length];
                for (var i = 0; i < length; i++)
                {
                    result.highBoundEntries[i] = ColdArchiveBucketEntryXdr.Decode(stream);
                }
            }
            {
                var length = stream.ReadInt();
                result.proofLevels = new ProofLevel[length];
                for (var i = 0; i < length; i++)
                {
                    result.proofLevels[i] = ProofLevelXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
