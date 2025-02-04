// Generated code - do not modify
// Source:

// struct SurveyRequestMessage
// {
//     NodeID surveyorPeerID;
//     NodeID surveyedPeerID;
//     uint32 ledgerNum;
//     Curve25519Public encryptionKey;
//     SurveyMessageCommandType commandType;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SurveyRequestMessage
    {
        private NodeID _surveyorPeerID;
        public NodeID surveyorPeerID
        {
            get => _surveyorPeerID;
            set
            {
                _surveyorPeerID = value;
            }
        }

        private NodeID _surveyedPeerID;
        public NodeID surveyedPeerID
        {
            get => _surveyedPeerID;
            set
            {
                _surveyedPeerID = value;
            }
        }

        private uint32 _ledgerNum;
        public uint32 ledgerNum
        {
            get => _ledgerNum;
            set
            {
                _ledgerNum = value;
            }
        }

        private Curve25519Public _encryptionKey;
        public Curve25519Public encryptionKey
        {
            get => _encryptionKey;
            set
            {
                _encryptionKey = value;
            }
        }

        private SurveyMessageCommandType _commandType;
        public SurveyMessageCommandType commandType
        {
            get => _commandType;
            set
            {
                _commandType = value;
            }
        }

        public SurveyRequestMessage()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SurveyRequestMessageXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SurveyRequestMessage value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SurveyRequestMessageXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SurveyRequestMessage value)
        {
            value.Validate();
            NodeIDXdr.Encode(stream, value.surveyorPeerID);
            NodeIDXdr.Encode(stream, value.surveyedPeerID);
            uint32Xdr.Encode(stream, value.ledgerNum);
            Curve25519PublicXdr.Encode(stream, value.encryptionKey);
            SurveyMessageCommandTypeXdr.Encode(stream, value.commandType);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SurveyRequestMessage Decode(XdrReader stream)
        {
            var result = new SurveyRequestMessage();
            result.surveyorPeerID = NodeIDXdr.Decode(stream);
            result.surveyedPeerID = NodeIDXdr.Decode(stream);
            result.ledgerNum = uint32Xdr.Decode(stream);
            result.encryptionKey = Curve25519PublicXdr.Decode(stream);
            result.commandType = SurveyMessageCommandTypeXdr.Decode(stream);
            return result;
        }
    }
}
