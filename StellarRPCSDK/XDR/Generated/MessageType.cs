// Generated code - do not modify
// Source:

// enum MessageType
// {
//     ERROR_MSG = 0,
//     AUTH = 2,
//     DONT_HAVE = 3,
//     // GET_PEERS (4) is deprecated
// 
//     PEERS = 5,
// 
//     GET_TX_SET = 6, // gets a particular txset by hash
//     TX_SET = 7,
//     GENERALIZED_TX_SET = 17,
// 
//     TRANSACTION = 8, // pass on a tx you have heard about
// 
//     // SCP
//     GET_SCP_QUORUMSET = 9,
//     SCP_QUORUMSET = 10,
//     SCP_MESSAGE = 11,
//     GET_SCP_STATE = 12,
// 
//     // new messages
//     HELLO = 13,
// 
//     SURVEY_REQUEST = 14,
//     SURVEY_RESPONSE = 15,
// 
//     SEND_MORE = 16,
//     SEND_MORE_EXTENDED = 20,
// 
//     FLOOD_ADVERT = 18,
//     FLOOD_DEMAND = 19,
// 
//     TIME_SLICED_SURVEY_REQUEST = 21,
//     TIME_SLICED_SURVEY_RESPONSE = 22,
//     TIME_SLICED_SURVEY_START_COLLECTING = 23,
//     TIME_SLICED_SURVEY_STOP_COLLECTING = 24
// };


using System;
using System.IO;

namespace Stellar.XDR {

    /// <summary>
    /// Next ID: 25
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum MessageType
    {
        ERROR_MSG = 0,
        AUTH = 2,
        DONT_HAVE = 3,
        PEERS = 5,
        GET_TX_SET = 6,
        /// <summary>
        /// gets a particular txset by hash
        /// </summary>
        TX_SET = 7,
        GENERALIZED_TX_SET = 17,
        TRANSACTION = 8,
        /// <summary>
        /// SCP
        /// </summary>
        GET_SCP_QUORUMSET = 9,
        SCP_QUORUMSET = 10,
        SCP_MESSAGE = 11,
        GET_SCP_STATE = 12,
        /// <summary>
        /// new messages
        /// </summary>
        HELLO = 13,
        SURVEY_REQUEST = 14,
        SURVEY_RESPONSE = 15,
        SEND_MORE = 16,
        SEND_MORE_EXTENDED = 20,
        FLOOD_ADVERT = 18,
        FLOOD_DEMAND = 19,
        TIME_SLICED_SURVEY_REQUEST = 21,
        TIME_SLICED_SURVEY_RESPONSE = 22,
        TIME_SLICED_SURVEY_START_COLLECTING = 23,
        TIME_SLICED_SURVEY_STOP_COLLECTING = 24,
    }

    public static partial class MessageTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(MessageType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                MessageTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, MessageType value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static MessageType Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(MessageType), value))
              throw new InvalidOperationException($"Unknown MessageType value: {value}");
            return (MessageType)value;
        }
    }
}
