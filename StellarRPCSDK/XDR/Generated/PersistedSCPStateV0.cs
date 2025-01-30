// Generated code - do not modify
// Source:

// struct PersistedSCPStateV0
// {
// 	SCPEnvelope scpEnvelopes<>;
// 	SCPQuorumSet quorumSets<>;
// 	StoredTransactionSet txSets<>;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class PersistedSCPStateV0
    {
        private SCPEnvelope[] _scpEnvelopes;
        public SCPEnvelope[] scpEnvelopes
        {
            get => _scpEnvelopes;
            set
            {
                _scpEnvelopes = value;
            }
        }

        private SCPQuorumSet[] _quorumSets;
        public SCPQuorumSet[] quorumSets
        {
            get => _quorumSets;
            set
            {
                _quorumSets = value;
            }
        }

        private StoredTransactionSet[] _txSets;
        public StoredTransactionSet[] txSets
        {
            get => _txSets;
            set
            {
                _txSets = value;
            }
        }

        public PersistedSCPStateV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class PersistedSCPStateV0Xdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, PersistedSCPStateV0 value)
        {
            value.Validate();
            stream.WriteInt(value.scpEnvelopes.Length);
            foreach (var item in value.scpEnvelopes)
            {
                    SCPEnvelopeXdr.Encode(stream, item);
            }
            stream.WriteInt(value.quorumSets.Length);
            foreach (var item in value.quorumSets)
            {
                    SCPQuorumSetXdr.Encode(stream, item);
            }
            stream.WriteInt(value.txSets.Length);
            foreach (var item in value.txSets)
            {
                    StoredTransactionSetXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static PersistedSCPStateV0 Decode(XdrReader stream)
        {
            var result = new PersistedSCPStateV0();
            {
                var length = stream.ReadInt();
                result.scpEnvelopes = new SCPEnvelope[length];
                for (var i = 0; i < length; i++)
                {
                    result.scpEnvelopes[i] = SCPEnvelopeXdr.Decode(stream);
                }
            }
            {
                var length = stream.ReadInt();
                result.quorumSets = new SCPQuorumSet[length];
                for (var i = 0; i < length; i++)
                {
                    result.quorumSets[i] = SCPQuorumSetXdr.Decode(stream);
                }
            }
            {
                var length = stream.ReadInt();
                result.txSets = new StoredTransactionSet[length];
                for (var i = 0; i < length; i++)
                {
                    result.txSets[i] = StoredTransactionSetXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
