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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SurveyResponseMessage
    {
        public NodeID surveyorPeerID
        {
            get => _surveyorPeerID;
            set
            {
                _surveyorPeerID = value;
            }
        }
        private NodeID _surveyorPeerID;

        public NodeID surveyedPeerID
        {
            get => _surveyedPeerID;
            set
            {
                _surveyedPeerID = value;
            }
        }
        private NodeID _surveyedPeerID;

        public uint32 ledgerNum
        {
            get => _ledgerNum;
            set
            {
                _ledgerNum = value;
            }
        }
        private uint32 _ledgerNum;

        public SurveyMessageCommandType commandType
        {
            get => _commandType;
            set
            {
                _commandType = value;
            }
        }
        private SurveyMessageCommandType _commandType;

        public EncryptedBody encryptedBody
        {
            get => _encryptedBody;
            set
            {
                _encryptedBody = value;
            }
        }
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
