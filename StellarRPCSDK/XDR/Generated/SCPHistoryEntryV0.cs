// Generated code - do not modify
// Source:

// struct SCPHistoryEntryV0
// {
//     SCPQuorumSet quorumSets<>; // additional quorum sets used by ledgerMessages
//     LedgerSCPMessages ledgerMessages;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCPHistoryEntryV0
    {
        private SCPQuorumSet[] _quorumSets;
        public SCPQuorumSet[] quorumSets
        {
            get => _quorumSets;
            set
            {
                _quorumSets = value;
            }
        }

        private LedgerSCPMessages _ledgerMessages;
        public LedgerSCPMessages ledgerMessages
        {
            get => _ledgerMessages;
            set
            {
                _ledgerMessages = value;
            }
        }

        public SCPHistoryEntryV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SCPHistoryEntryV0Xdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SCPHistoryEntryV0 value)
        {
            value.Validate();
            stream.WriteInt(value.quorumSets.Length);
            foreach (var item in value.quorumSets)
            {
                    SCPQuorumSetXdr.Encode(stream, item);
            }
            LedgerSCPMessagesXdr.Encode(stream, value.ledgerMessages);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SCPHistoryEntryV0 Decode(XdrReader stream)
        {
            var result = new SCPHistoryEntryV0();
            {
                var length = stream.ReadInt();
                result.quorumSets = new SCPQuorumSet[length];
                for (var i = 0; i < length; i++)
                {
                    result.quorumSets[i] = SCPQuorumSetXdr.Decode(stream);
                }
            }
            result.ledgerMessages = LedgerSCPMessagesXdr.Decode(stream);
            return result;
        }
    }
}
