// Generated code - do not modify
// Source:

// struct SCPHistoryEntryV0
// {
//     SCPQuorumSet quorumSets<>; // additional quorum sets used by ledgerMessages
//     LedgerSCPMessages ledgerMessages;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    /// <summary>
    /// in the file so far, not just the one from this entry
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SCPHistoryEntryV0
    {
        public SCPQuorumSet[] quorumSets
        {
            get => _quorumSets;
            set
            {
                _quorumSets = value;
            }
        }
        private SCPQuorumSet[] _quorumSets;

        /// <summary>
        /// additional quorum sets used by ledgerMessages
        /// </summary>
        public LedgerSCPMessages ledgerMessages
        {
            get => _ledgerMessages;
            set
            {
                _ledgerMessages = value;
            }
        }
        private LedgerSCPMessages _ledgerMessages;

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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCPHistoryEntryV0 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCPHistoryEntryV0Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
