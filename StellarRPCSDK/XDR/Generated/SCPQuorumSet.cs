// Generated code - do not modify
// Source:

// struct SCPQuorumSet
// {
//     uint32 threshold;
//     NodeID validators<>;
//     SCPQuorumSet innerSets<>;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCPQuorumSet
    {
        private uint32 _threshold;
        public uint32 threshold
        {
            get => _threshold;
            set
            {
                _threshold = value;
            }
        }

        private NodeID[] _validators;
        public NodeID[] validators
        {
            get => _validators;
            set
            {
                _validators = value;
            }
        }

        private SCPQuorumSet[] _innerSets;
        public SCPQuorumSet[] innerSets
        {
            get => _innerSets;
            set
            {
                _innerSets = value;
            }
        }

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
            var length = stream.ReadInt();
            result.validators = new NodeID[length];
            for (var i = 0; i < length; i++)
            {
                result.validators[i] = NodeIDXdr.Decode(stream);
            }
            var length = stream.ReadInt();
            result.innerSets = new SCPQuorumSet[length];
            for (var i = 0; i < length; i++)
            {
                result.innerSets[i] = SCPQuorumSetXdr.Decode(stream);
            }
            return result;
        }
    }
}
