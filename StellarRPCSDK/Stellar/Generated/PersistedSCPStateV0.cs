// Generated code - do not modify
// Source:

// struct PersistedSCPStateV0
// {
// 	SCPEnvelope scpEnvelopes<>;
// 	SCPQuorumSet quorumSets<>;
// 	StoredTransactionSet txSets<>;
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
    public partial class PersistedSCPStateV0
    {
        [ProtoMember(1, OverwriteList = true)]
        public SCPEnvelope[] scpEnvelopes
        {
            get => _scpEnvelopes;
            set
            {
                _scpEnvelopes = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Scp Envelopes")]
        #endif
        private SCPEnvelope[] _scpEnvelopes;

        [ProtoMember(2, OverwriteList = true)]
        public SCPQuorumSet[] quorumSets
        {
            get => _quorumSets;
            set
            {
                _quorumSets = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Quorum Sets")]
        #endif
        private SCPQuorumSet[] _quorumSets;

        [ProtoMember(3, OverwriteList = true)]
        public StoredTransactionSet[] txSets
        {
            get => _txSets;
            set
            {
                _txSets = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Tx Sets")]
        #endif
        private StoredTransactionSet[] _txSets;

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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(PersistedSCPStateV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                PersistedSCPStateV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static PersistedSCPStateV0 DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return PersistedSCPStateV0Xdr.Decode(reader);
            }
        }
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
