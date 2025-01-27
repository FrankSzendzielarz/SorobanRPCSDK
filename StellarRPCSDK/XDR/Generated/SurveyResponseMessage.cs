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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SurveyResponseMessage
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

        private SurveyMessageCommandType _commandType;
        public SurveyMessageCommandType commandType
        {
            get => _commandType;
            set
            {
                _commandType = value;
            }
        }

        private EncryptedBody _encryptedBody;
        public EncryptedBody encryptedBody
        {
            get => _encryptedBody;
            set
            {
                _encryptedBody = value;
            }
        }

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
