// Generated code - do not modify
// Source:

// struct LedgerSCPMessages
// {
//     uint32 ledgerSeq;
//     SCPEnvelope messages<>;
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
    public partial class LedgerSCPMessages
    {
        [ProtoMember(1)]
        public uint32 ledgerSeq
        {
            get => _ledgerSeq;
            set
            {
                _ledgerSeq = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Ledger Seq")]
        #endif
        private uint32 _ledgerSeq;

        [ProtoMember(2, OverwriteList = true)]
        public SCPEnvelope[] messages
        {
            get => _messages;
            set
            {
                _messages = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Messages")]
        #endif
        private SCPEnvelope[] _messages;

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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LedgerSCPMessages value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LedgerSCPMessagesXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static LedgerSCPMessages DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return LedgerSCPMessagesXdr.Decode(reader);
            }
        }
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
            {
                var length = stream.ReadInt();
                result.messages = new SCPEnvelope[length];
                for (var i = 0; i < length; i++)
                {
                    result.messages[i] = SCPEnvelopeXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
