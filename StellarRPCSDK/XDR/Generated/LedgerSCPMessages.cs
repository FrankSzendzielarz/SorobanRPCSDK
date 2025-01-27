// Generated code - do not modify
// Source:

// struct LedgerSCPMessages
// {
//     uint32 ledgerSeq;
//     SCPEnvelope messages<>;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class LedgerSCPMessages
    {
        private uint32 _ledgerSeq;
        public uint32 ledgerSeq
        {
            get => _ledgerSeq;
            set
            {
                _ledgerSeq = value;
            }
        }

        private SCPEnvelope[] _messages;
        public SCPEnvelope[] messages
        {
            get => _messages;
            set
            {
                _messages = value;
            }
        }

        public LedgerSCPMessages()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class LedgerSCPMessagesXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, LedgerSCPMessages value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.ledgerSeq);
            stream.WriteInt(value.messages.Length);
            foreach (var item in value.messages)
            {
                    SCPEnvelopeXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static LedgerSCPMessages Decode(XdrReader stream)
        {
            var result = new LedgerSCPMessages();
            result.ledgerSeq = uint32Xdr.Decode(stream);
            var length = stream.ReadInt();
            result.messages = new SCPEnvelope[length];
            for (var i = 0; i < length; i++)
            {
                result.messages[i] = SCPEnvelopeXdr.Decode(stream);
            }
            return result;
        }
    }
}
