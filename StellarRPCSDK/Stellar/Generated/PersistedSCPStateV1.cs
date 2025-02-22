// Generated code - do not modify
// Source:

// struct PersistedSCPStateV1
// {
// 	// Tx sets are saved separately
// 	SCPEnvelope scpEnvelopes<>;
// 	SCPQuorumSet quorumSets<>;
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
    public partial class PersistedSCPStateV1
    {
        /// <summary>
        /// Tx sets are saved separately
        /// </summary>
        [ProtoMember(1)]
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

        [ProtoMember(2)]
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

        public PersistedSCPStateV1()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class PersistedSCPStateV1Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(PersistedSCPStateV1 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                PersistedSCPStateV1Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, PersistedSCPStateV1 value)
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
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static PersistedSCPStateV1 Decode(XdrReader stream)
        {
            var result = new PersistedSCPStateV1();
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
            return result;
        }
    }
}
