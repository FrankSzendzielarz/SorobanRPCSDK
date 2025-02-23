// Generated code - do not modify
// Source:

// struct SCPQuorumSet
// {
//     uint32 threshold;
//     NodeID validators<>;
//     SCPQuorumSet innerSets<>;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    /// <summary>
    /// only allows 2 levels of nesting
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class SCPQuorumSet
    {
        [ProtoMember(1)]
        public uint32 threshold
        {
            get => _threshold;
            set
            {
                _threshold = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Threshold")]
        #endif
        private uint32 _threshold;

        [ProtoMember(2)]
        public NodeID[] validators
        {
            get => _validators;
            set
            {
                _validators = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Validators")]
        #endif
        private NodeID[] _validators;

        [ProtoMember(3)]
        public SCPQuorumSet[] innerSets
        {
            get => _innerSets;
            set
            {
                _innerSets = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inner Sets")]
        #endif
        private SCPQuorumSet[] _innerSets;

        public SCPQuorumSet()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCPQuorumSetXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCPQuorumSet value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCPQuorumSetXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SCPQuorumSet DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SCPQuorumSetXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCPQuorumSet value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.threshold);
            stream.WriteInt(value.validators.Length);
            foreach (var item in value.validators)
            {
                    NodeIDXdr.Encode(stream, item);
            }
            stream.WriteInt(value.innerSets.Length);
            foreach (var item in value.innerSets)
            {
                    SCPQuorumSetXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCPQuorumSet Decode(XdrReader stream)
        {
            var result = new SCPQuorumSet();
            result.threshold = uint32Xdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.validators = new NodeID[length];
                for (var i = 0; i < length; i++)
                {
                    result.validators[i] = NodeIDXdr.Decode(stream);
                }
            }
            {
                var length = stream.ReadInt();
                result.innerSets = new SCPQuorumSet[length];
                for (var i = 0; i < length; i++)
                {
                    result.innerSets[i] = SCPQuorumSetXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
