// Generated code - do not modify
// Source:

// struct SurveyResponseMessage
// {
//     NodeID surveyorPeerID;
//     NodeID surveyedPeerID;
//     uint32 ledgerNum;
//     SurveyMessageCommandType commandType;
//     EncryptedBody encryptedBody;
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
    public partial class SurveyResponseMessage
    {
        [ProtoMember(1)]
        public NodeID surveyorPeerID
        {
            get => _surveyorPeerID;
            set
            {
                _surveyorPeerID = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Surveyor Peer I D")]
        #endif
        private NodeID _surveyorPeerID;

        [ProtoMember(2)]
        public NodeID surveyedPeerID
        {
            get => _surveyedPeerID;
            set
            {
                _surveyedPeerID = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Surveyed Peer I D")]
        #endif
        private NodeID _surveyedPeerID;

        [ProtoMember(3)]
        public uint32 ledgerNum
        {
            get => _ledgerNum;
            set
            {
                _ledgerNum = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Ledger Num")]
        #endif
        private uint32 _ledgerNum;

        [ProtoMember(4)]
        public SurveyMessageCommandType commandType
        {
            get => _commandType;
            set
            {
                _commandType = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Command Type")]
        #endif
        private SurveyMessageCommandType _commandType;

        [ProtoMember(5)]
        public EncryptedBody encryptedBody
        {
            get => _encryptedBody;
            set
            {
                _encryptedBody = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Encrypted Body")]
        #endif
        private EncryptedBody _encryptedBody;

        public SurveyResponseMessage()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SurveyResponseMessageXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SurveyResponseMessage value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SurveyResponseMessageXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SurveyResponseMessage DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SurveyResponseMessageXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SurveyResponseMessage value)
        {
            value.Validate();
            NodeIDXdr.Encode(stream, value.surveyorPeerID);
            NodeIDXdr.Encode(stream, value.surveyedPeerID);
            uint32Xdr.Encode(stream, value.ledgerNum);
            SurveyMessageCommandTypeXdr.Encode(stream, value.commandType);
            EncryptedBodyXdr.Encode(stream, value.encryptedBody);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SurveyResponseMessage Decode(XdrReader stream)
        {
            var result = new SurveyResponseMessage();
            result.surveyorPeerID = NodeIDXdr.Decode(stream);
            result.surveyedPeerID = NodeIDXdr.Decode(stream);
            result.ledgerNum = uint32Xdr.Decode(stream);
            result.commandType = SurveyMessageCommandTypeXdr.Decode(stream);
            result.encryptedBody = EncryptedBodyXdr.Decode(stream);
            return result;
        }
    }
}
