// Generated code - do not modify
// Source:

// union StellarMessage switch (MessageType type)
// {
// case ERROR_MSG:
//     Error error;
// case HELLO:
//     Hello hello;
// case AUTH:
//     Auth auth;
// case DONT_HAVE:
//     DontHave dontHave;
// case PEERS:
//     PeerAddress peers<100>;
// 
// case GET_TX_SET:
//     uint256 txSetHash;
// case TX_SET:
//     TransactionSet txSet;
// case GENERALIZED_TX_SET:
//     GeneralizedTransactionSet generalizedTxSet;
// 
// case TRANSACTION:
//     TransactionEnvelope transaction;
// 
// case SURVEY_REQUEST:
//     SignedSurveyRequestMessage signedSurveyRequestMessage;
// 
// case SURVEY_RESPONSE:
//     SignedSurveyResponseMessage signedSurveyResponseMessage;
// 
// case TIME_SLICED_SURVEY_REQUEST:
//     SignedTimeSlicedSurveyRequestMessage signedTimeSlicedSurveyRequestMessage;
// 
// case TIME_SLICED_SURVEY_RESPONSE:
//     SignedTimeSlicedSurveyResponseMessage signedTimeSlicedSurveyResponseMessage;
// 
// case TIME_SLICED_SURVEY_START_COLLECTING:
//     SignedTimeSlicedSurveyStartCollectingMessage
//         signedTimeSlicedSurveyStartCollectingMessage;
// 
// case TIME_SLICED_SURVEY_STOP_COLLECTING:
//     SignedTimeSlicedSurveyStopCollectingMessage
//         signedTimeSlicedSurveyStopCollectingMessage;
// 
// // SCP
// case GET_SCP_QUORUMSET:
//     uint256 qSetHash;
// case SCP_QUORUMSET:
//     SCPQuorumSet qSet;
// case SCP_MESSAGE:
//     SCPEnvelope envelope;
// case GET_SCP_STATE:
//     uint32 getSCPLedgerSeq; // ledger seq requested ; if 0, requests the latest
// case SEND_MORE:
//     SendMore sendMoreMessage;
// case SEND_MORE_EXTENDED:
//     SendMoreExtended sendMoreExtendedMessage;
// // Pull mode
// case FLOOD_ADVERT:
//      FloodAdvert floodAdvert;
// case FLOOD_DEMAND:
//      FloodDemand floodDemand;
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
    [ProtoInclude(100, typeof(ErrorMsg), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(HelloCase), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(AuthCase), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(DontHaveCase), DataFormat = DataFormat.Default)]
    [ProtoInclude(104, typeof(Peers), DataFormat = DataFormat.Default)]
    [ProtoInclude(105, typeof(GetTxSet), DataFormat = DataFormat.Default)]
    [ProtoInclude(106, typeof(TxSet), DataFormat = DataFormat.Default)]
    [ProtoInclude(107, typeof(GeneralizedTxSet), DataFormat = DataFormat.Default)]
    [ProtoInclude(108, typeof(TransactionCase), DataFormat = DataFormat.Default)]
    [ProtoInclude(109, typeof(SurveyRequest), DataFormat = DataFormat.Default)]
    [ProtoInclude(110, typeof(SurveyResponse), DataFormat = DataFormat.Default)]
    [ProtoInclude(111, typeof(TimeSlicedSurveyRequest), DataFormat = DataFormat.Default)]
    [ProtoInclude(112, typeof(TimeSlicedSurveyResponse), DataFormat = DataFormat.Default)]
    [ProtoInclude(113, typeof(TimeSlicedSurveyStartCollecting), DataFormat = DataFormat.Default)]
    [ProtoInclude(114, typeof(TimeSlicedSurveyStopCollecting), DataFormat = DataFormat.Default)]
    [ProtoInclude(115, typeof(GetScpQuorumset), DataFormat = DataFormat.Default)]
    [ProtoInclude(116, typeof(ScpQuorumset), DataFormat = DataFormat.Default)]
    [ProtoInclude(117, typeof(ScpMessage), DataFormat = DataFormat.Default)]
    [ProtoInclude(118, typeof(GetScpState), DataFormat = DataFormat.Default)]
    [ProtoInclude(119, typeof(SendMoreCase), DataFormat = DataFormat.Default)]
    [ProtoInclude(120, typeof(SendMoreExtendedCase), DataFormat = DataFormat.Default)]
    [ProtoInclude(121, typeof(FloodAdvertCase), DataFormat = DataFormat.Default)]
    [ProtoInclude(122, typeof(FloodDemandCase), DataFormat = DataFormat.Default)]
    public abstract partial class StellarMessage
    {
        public abstract MessageType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.ErrorMsg")]
        public sealed partial class ErrorMsg : StellarMessage
        {
            public override MessageType Discriminator => MessageType.ERROR_MSG;
            [ProtoMember(1)]
            public Error error
            {
                get => _error;
                set
                {
                    _error = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Error")]
            #endif
            private Error _error;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.HelloCase")]
        public sealed partial class HelloCase : StellarMessage
        {
            public override MessageType Discriminator => MessageType.HELLO;
            [ProtoMember(2)]
            public Hello hello
            {
                get => _hello;
                set
                {
                    _hello = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Hello")]
            #endif
            private Hello _hello;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.AuthCase")]
        public sealed partial class AuthCase : StellarMessage
        {
            public override MessageType Discriminator => MessageType.AUTH;
            [ProtoMember(3)]
            public Auth auth
            {
                get => _auth;
                set
                {
                    _auth = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Auth")]
            #endif
            private Auth _auth;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.DontHaveCase")]
        public sealed partial class DontHaveCase : StellarMessage
        {
            public override MessageType Discriminator => MessageType.DONT_HAVE;
            [ProtoMember(4)]
            public DontHave dontHave
            {
                get => _dontHave;
                set
                {
                    _dontHave = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Dont Have")]
            #endif
            private DontHave _dontHave;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.Peers")]
        public sealed partial class Peers : StellarMessage
        {
            public override MessageType Discriminator => MessageType.PEERS;
            [ProtoMember(5)]
            [MaxLength(100)]
            public PeerAddress[] peers
            {
                get => _peers;
                set
                {
                    if (value.Length > 100)
                    	throw new ArgumentException($"Cannot exceed 100 in length");
                    _peers = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Peers")]
            #endif
            private PeerAddress[] _peers;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.GetTxSet")]
        public sealed partial class GetTxSet : StellarMessage
        {
            public override MessageType Discriminator => MessageType.GET_TX_SET;
            [ProtoMember(6)]
            public uint256 txSetHash
            {
                get => _txSetHash;
                set
                {
                    _txSetHash = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Tx Set Hash")]
            #endif
            private uint256 _txSetHash;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.TxSet")]
        public sealed partial class TxSet : StellarMessage
        {
            public override MessageType Discriminator => MessageType.TX_SET;
            [ProtoMember(7)]
            public TransactionSet txSet
            {
                get => _txSet;
                set
                {
                    _txSet = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Tx Set")]
            #endif
            private TransactionSet _txSet;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.GeneralizedTxSet")]
        public sealed partial class GeneralizedTxSet : StellarMessage
        {
            public override MessageType Discriminator => MessageType.GENERALIZED_TX_SET;
            [ProtoMember(8)]
            public GeneralizedTransactionSet generalizedTxSet
            {
                get => _generalizedTxSet;
                set
                {
                    _generalizedTxSet = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Generalized Tx Set")]
            #endif
            private GeneralizedTransactionSet _generalizedTxSet;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.TransactionCase")]
        public sealed partial class TransactionCase : StellarMessage
        {
            public override MessageType Discriminator => MessageType.TRANSACTION;
            [ProtoMember(9)]
            public TransactionEnvelope transaction
            {
                get => _transaction;
                set
                {
                    _transaction = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Transaction")]
            #endif
            private TransactionEnvelope _transaction;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.SurveyRequest")]
        public sealed partial class SurveyRequest : StellarMessage
        {
            public override MessageType Discriminator => MessageType.SURVEY_REQUEST;
            [ProtoMember(10)]
            public SignedSurveyRequestMessage signedSurveyRequestMessage
            {
                get => _signedSurveyRequestMessage;
                set
                {
                    _signedSurveyRequestMessage = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Signed Survey Request Message")]
            #endif
            private SignedSurveyRequestMessage _signedSurveyRequestMessage;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.SurveyResponse")]
        public sealed partial class SurveyResponse : StellarMessage
        {
            public override MessageType Discriminator => MessageType.SURVEY_RESPONSE;
            [ProtoMember(11)]
            public SignedSurveyResponseMessage signedSurveyResponseMessage
            {
                get => _signedSurveyResponseMessage;
                set
                {
                    _signedSurveyResponseMessage = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Signed Survey Response Message")]
            #endif
            private SignedSurveyResponseMessage _signedSurveyResponseMessage;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.TimeSlicedSurveyRequest")]
        public sealed partial class TimeSlicedSurveyRequest : StellarMessage
        {
            public override MessageType Discriminator => MessageType.TIME_SLICED_SURVEY_REQUEST;
            [ProtoMember(12)]
            public SignedTimeSlicedSurveyRequestMessage signedTimeSlicedSurveyRequestMessage
            {
                get => _signedTimeSlicedSurveyRequestMessage;
                set
                {
                    _signedTimeSlicedSurveyRequestMessage = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Signed Time Sliced Survey Request Message")]
            #endif
            private SignedTimeSlicedSurveyRequestMessage _signedTimeSlicedSurveyRequestMessage;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.TimeSlicedSurveyResponse")]
        public sealed partial class TimeSlicedSurveyResponse : StellarMessage
        {
            public override MessageType Discriminator => MessageType.TIME_SLICED_SURVEY_RESPONSE;
            [ProtoMember(13)]
            public SignedTimeSlicedSurveyResponseMessage signedTimeSlicedSurveyResponseMessage
            {
                get => _signedTimeSlicedSurveyResponseMessage;
                set
                {
                    _signedTimeSlicedSurveyResponseMessage = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Signed Time Sliced Survey Response Message")]
            #endif
            private SignedTimeSlicedSurveyResponseMessage _signedTimeSlicedSurveyResponseMessage;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.TimeSlicedSurveyStartCollecting")]
        public sealed partial class TimeSlicedSurveyStartCollecting : StellarMessage
        {
            public override MessageType Discriminator => MessageType.TIME_SLICED_SURVEY_START_COLLECTING;
            [ProtoMember(14)]
            public SignedTimeSlicedSurveyStartCollectingMessage signedTimeSlicedSurveyStartCollectingMessage
            {
                get => _signedTimeSlicedSurveyStartCollectingMessage;
                set
                {
                    _signedTimeSlicedSurveyStartCollectingMessage = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Signed Time Sliced Survey Start Collecting Message")]
            #endif
            private SignedTimeSlicedSurveyStartCollectingMessage _signedTimeSlicedSurveyStartCollectingMessage;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.TimeSlicedSurveyStopCollecting")]
        public sealed partial class TimeSlicedSurveyStopCollecting : StellarMessage
        {
            public override MessageType Discriminator => MessageType.TIME_SLICED_SURVEY_STOP_COLLECTING;
            [ProtoMember(15)]
            public SignedTimeSlicedSurveyStopCollectingMessage signedTimeSlicedSurveyStopCollectingMessage
            {
                get => _signedTimeSlicedSurveyStopCollectingMessage;
                set
                {
                    _signedTimeSlicedSurveyStopCollectingMessage = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Signed Time Sliced Survey Stop Collecting Message")]
            #endif
            private SignedTimeSlicedSurveyStopCollectingMessage _signedTimeSlicedSurveyStopCollectingMessage;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// SCP
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.GetScpQuorumset")]
        public sealed partial class GetScpQuorumset : StellarMessage
        {
            public override MessageType Discriminator => MessageType.GET_SCP_QUORUMSET;
            [ProtoMember(16)]
            public uint256 qSetHash
            {
                get => _qSetHash;
                set
                {
                    _qSetHash = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Q Set Hash")]
            #endif
            private uint256 _qSetHash;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.ScpQuorumset")]
        public sealed partial class ScpQuorumset : StellarMessage
        {
            public override MessageType Discriminator => MessageType.SCP_QUORUMSET;
            [ProtoMember(17)]
            public SCPQuorumSet qSet
            {
                get => _qSet;
                set
                {
                    _qSet = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Q Set")]
            #endif
            private SCPQuorumSet _qSet;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.ScpMessage")]
        public sealed partial class ScpMessage : StellarMessage
        {
            public override MessageType Discriminator => MessageType.SCP_MESSAGE;
            [ProtoMember(18)]
            public SCPEnvelope envelope
            {
                get => _envelope;
                set
                {
                    _envelope = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Envelope")]
            #endif
            private SCPEnvelope _envelope;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.GetScpState")]
        public sealed partial class GetScpState : StellarMessage
        {
            public override MessageType Discriminator => MessageType.GET_SCP_STATE;
            [ProtoMember(19)]
            public uint32 getSCPLedgerSeq
            {
                get => _getSCPLedgerSeq;
                set
                {
                    _getSCPLedgerSeq = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Get S C P Ledger Seq")]
            #endif
            private uint32 _getSCPLedgerSeq;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// ledger seq requested ; if 0, requests the latest
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.SendMoreCase")]
        public sealed partial class SendMoreCase : StellarMessage
        {
            public override MessageType Discriminator => MessageType.SEND_MORE;
            [ProtoMember(20)]
            public SendMore sendMoreMessage
            {
                get => _sendMoreMessage;
                set
                {
                    _sendMoreMessage = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Send More Message")]
            #endif
            private SendMore _sendMoreMessage;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.SendMoreExtendedCase")]
        public sealed partial class SendMoreExtendedCase : StellarMessage
        {
            public override MessageType Discriminator => MessageType.SEND_MORE_EXTENDED;
            [ProtoMember(21)]
            public SendMoreExtended sendMoreExtendedMessage
            {
                get => _sendMoreExtendedMessage;
                set
                {
                    _sendMoreExtendedMessage = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Send More Extended Message")]
            #endif
            private SendMoreExtended _sendMoreExtendedMessage;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// Pull mode
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.FloodAdvertCase")]
        public sealed partial class FloodAdvertCase : StellarMessage
        {
            public override MessageType Discriminator => MessageType.FLOOD_ADVERT;
            [ProtoMember(22)]
            public FloodAdvert floodAdvert
            {
                get => _floodAdvert;
                set
                {
                    _floodAdvert = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Flood Advert")]
            #endif
            private FloodAdvert _floodAdvert;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "StellarMessage.FloodDemandCase")]
        public sealed partial class FloodDemandCase : StellarMessage
        {
            public override MessageType Discriminator => MessageType.FLOOD_DEMAND;
            [ProtoMember(23)]
            public FloodDemand floodDemand
            {
                get => _floodDemand;
                set
                {
                    _floodDemand = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Flood Demand")]
            #endif
            private FloodDemand _floodDemand;

            public override void ValidateCase() {}
        }
    }
    public static partial class StellarMessageXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(StellarMessage value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                StellarMessageXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, StellarMessage value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case StellarMessage.ErrorMsg case_ERROR_MSG:
                ErrorXdr.Encode(stream, case_ERROR_MSG.error);
                break;
                case StellarMessage.HelloCase case_HELLO:
                HelloXdr.Encode(stream, case_HELLO.hello);
                break;
                case StellarMessage.AuthCase case_AUTH:
                AuthXdr.Encode(stream, case_AUTH.auth);
                break;
                case StellarMessage.DontHaveCase case_DONT_HAVE:
                DontHaveXdr.Encode(stream, case_DONT_HAVE.dontHave);
                break;
                case StellarMessage.Peers case_PEERS:
                stream.WriteInt(case_PEERS.peers.Length);
                foreach (var item in case_PEERS.peers)
                {
                        PeerAddressXdr.Encode(stream, item);
                }
                break;
                case StellarMessage.GetTxSet case_GET_TX_SET:
                uint256Xdr.Encode(stream, case_GET_TX_SET.txSetHash);
                break;
                case StellarMessage.TxSet case_TX_SET:
                TransactionSetXdr.Encode(stream, case_TX_SET.txSet);
                break;
                case StellarMessage.GeneralizedTxSet case_GENERALIZED_TX_SET:
                GeneralizedTransactionSetXdr.Encode(stream, case_GENERALIZED_TX_SET.generalizedTxSet);
                break;
                case StellarMessage.TransactionCase case_TRANSACTION:
                TransactionEnvelopeXdr.Encode(stream, case_TRANSACTION.transaction);
                break;
                case StellarMessage.SurveyRequest case_SURVEY_REQUEST:
                SignedSurveyRequestMessageXdr.Encode(stream, case_SURVEY_REQUEST.signedSurveyRequestMessage);
                break;
                case StellarMessage.SurveyResponse case_SURVEY_RESPONSE:
                SignedSurveyResponseMessageXdr.Encode(stream, case_SURVEY_RESPONSE.signedSurveyResponseMessage);
                break;
                case StellarMessage.TimeSlicedSurveyRequest case_TIME_SLICED_SURVEY_REQUEST:
                SignedTimeSlicedSurveyRequestMessageXdr.Encode(stream, case_TIME_SLICED_SURVEY_REQUEST.signedTimeSlicedSurveyRequestMessage);
                break;
                case StellarMessage.TimeSlicedSurveyResponse case_TIME_SLICED_SURVEY_RESPONSE:
                SignedTimeSlicedSurveyResponseMessageXdr.Encode(stream, case_TIME_SLICED_SURVEY_RESPONSE.signedTimeSlicedSurveyResponseMessage);
                break;
                case StellarMessage.TimeSlicedSurveyStartCollecting case_TIME_SLICED_SURVEY_START_COLLECTING:
                SignedTimeSlicedSurveyStartCollectingMessageXdr.Encode(stream, case_TIME_SLICED_SURVEY_START_COLLECTING.signedTimeSlicedSurveyStartCollectingMessage);
                break;
                case StellarMessage.TimeSlicedSurveyStopCollecting case_TIME_SLICED_SURVEY_STOP_COLLECTING:
                SignedTimeSlicedSurveyStopCollectingMessageXdr.Encode(stream, case_TIME_SLICED_SURVEY_STOP_COLLECTING.signedTimeSlicedSurveyStopCollectingMessage);
                break;
                case StellarMessage.GetScpQuorumset case_GET_SCP_QUORUMSET:
                uint256Xdr.Encode(stream, case_GET_SCP_QUORUMSET.qSetHash);
                break;
                case StellarMessage.ScpQuorumset case_SCP_QUORUMSET:
                SCPQuorumSetXdr.Encode(stream, case_SCP_QUORUMSET.qSet);
                break;
                case StellarMessage.ScpMessage case_SCP_MESSAGE:
                SCPEnvelopeXdr.Encode(stream, case_SCP_MESSAGE.envelope);
                break;
                case StellarMessage.GetScpState case_GET_SCP_STATE:
                uint32Xdr.Encode(stream, case_GET_SCP_STATE.getSCPLedgerSeq);
                break;
                case StellarMessage.SendMoreCase case_SEND_MORE:
                SendMoreXdr.Encode(stream, case_SEND_MORE.sendMoreMessage);
                break;
                case StellarMessage.SendMoreExtendedCase case_SEND_MORE_EXTENDED:
                SendMoreExtendedXdr.Encode(stream, case_SEND_MORE_EXTENDED.sendMoreExtendedMessage);
                break;
                case StellarMessage.FloodAdvertCase case_FLOOD_ADVERT:
                FloodAdvertXdr.Encode(stream, case_FLOOD_ADVERT.floodAdvert);
                break;
                case StellarMessage.FloodDemandCase case_FLOOD_DEMAND:
                FloodDemandXdr.Encode(stream, case_FLOOD_DEMAND.floodDemand);
                break;
            }
        }
        public static StellarMessage Decode(XdrReader stream)
        {
            var discriminator = (MessageType)stream.ReadInt();
            switch (discriminator)
            {
                case MessageType.ERROR_MSG:
                var result_ERROR_MSG = new StellarMessage.ErrorMsg();
                result_ERROR_MSG.error = ErrorXdr.Decode(stream);
                return result_ERROR_MSG;
                case MessageType.HELLO:
                var result_HELLO = new StellarMessage.HelloCase();
                result_HELLO.hello = HelloXdr.Decode(stream);
                return result_HELLO;
                case MessageType.AUTH:
                var result_AUTH = new StellarMessage.AuthCase();
                result_AUTH.auth = AuthXdr.Decode(stream);
                return result_AUTH;
                case MessageType.DONT_HAVE:
                var result_DONT_HAVE = new StellarMessage.DontHaveCase();
                result_DONT_HAVE.dontHave = DontHaveXdr.Decode(stream);
                return result_DONT_HAVE;
                case MessageType.PEERS:
                var result_PEERS = new StellarMessage.Peers();
                {
                    var length = stream.ReadInt();
                    result_PEERS.peers = new PeerAddress[length];
                    for (var i = 0; i < length; i++)
                    {
                        result_PEERS.peers[i] = PeerAddressXdr.Decode(stream);
                    }
                }
                return result_PEERS;
                case MessageType.GET_TX_SET:
                var result_GET_TX_SET = new StellarMessage.GetTxSet();
                result_GET_TX_SET.txSetHash = uint256Xdr.Decode(stream);
                return result_GET_TX_SET;
                case MessageType.TX_SET:
                var result_TX_SET = new StellarMessage.TxSet();
                result_TX_SET.txSet = TransactionSetXdr.Decode(stream);
                return result_TX_SET;
                case MessageType.GENERALIZED_TX_SET:
                var result_GENERALIZED_TX_SET = new StellarMessage.GeneralizedTxSet();
                result_GENERALIZED_TX_SET.generalizedTxSet = GeneralizedTransactionSetXdr.Decode(stream);
                return result_GENERALIZED_TX_SET;
                case MessageType.TRANSACTION:
                var result_TRANSACTION = new StellarMessage.TransactionCase();
                result_TRANSACTION.transaction = TransactionEnvelopeXdr.Decode(stream);
                return result_TRANSACTION;
                case MessageType.SURVEY_REQUEST:
                var result_SURVEY_REQUEST = new StellarMessage.SurveyRequest();
                result_SURVEY_REQUEST.signedSurveyRequestMessage = SignedSurveyRequestMessageXdr.Decode(stream);
                return result_SURVEY_REQUEST;
                case MessageType.SURVEY_RESPONSE:
                var result_SURVEY_RESPONSE = new StellarMessage.SurveyResponse();
                result_SURVEY_RESPONSE.signedSurveyResponseMessage = SignedSurveyResponseMessageXdr.Decode(stream);
                return result_SURVEY_RESPONSE;
                case MessageType.TIME_SLICED_SURVEY_REQUEST:
                var result_TIME_SLICED_SURVEY_REQUEST = new StellarMessage.TimeSlicedSurveyRequest();
                result_TIME_SLICED_SURVEY_REQUEST.signedTimeSlicedSurveyRequestMessage = SignedTimeSlicedSurveyRequestMessageXdr.Decode(stream);
                return result_TIME_SLICED_SURVEY_REQUEST;
                case MessageType.TIME_SLICED_SURVEY_RESPONSE:
                var result_TIME_SLICED_SURVEY_RESPONSE = new StellarMessage.TimeSlicedSurveyResponse();
                result_TIME_SLICED_SURVEY_RESPONSE.signedTimeSlicedSurveyResponseMessage = SignedTimeSlicedSurveyResponseMessageXdr.Decode(stream);
                return result_TIME_SLICED_SURVEY_RESPONSE;
                case MessageType.TIME_SLICED_SURVEY_START_COLLECTING:
                var result_TIME_SLICED_SURVEY_START_COLLECTING = new StellarMessage.TimeSlicedSurveyStartCollecting();
                result_TIME_SLICED_SURVEY_START_COLLECTING.signedTimeSlicedSurveyStartCollectingMessage = SignedTimeSlicedSurveyStartCollectingMessageXdr.Decode(stream);
                return result_TIME_SLICED_SURVEY_START_COLLECTING;
                case MessageType.TIME_SLICED_SURVEY_STOP_COLLECTING:
                var result_TIME_SLICED_SURVEY_STOP_COLLECTING = new StellarMessage.TimeSlicedSurveyStopCollecting();
                result_TIME_SLICED_SURVEY_STOP_COLLECTING.signedTimeSlicedSurveyStopCollectingMessage = SignedTimeSlicedSurveyStopCollectingMessageXdr.Decode(stream);
                return result_TIME_SLICED_SURVEY_STOP_COLLECTING;
                case MessageType.GET_SCP_QUORUMSET:
                var result_GET_SCP_QUORUMSET = new StellarMessage.GetScpQuorumset();
                result_GET_SCP_QUORUMSET.qSetHash = uint256Xdr.Decode(stream);
                return result_GET_SCP_QUORUMSET;
                case MessageType.SCP_QUORUMSET:
                var result_SCP_QUORUMSET = new StellarMessage.ScpQuorumset();
                result_SCP_QUORUMSET.qSet = SCPQuorumSetXdr.Decode(stream);
                return result_SCP_QUORUMSET;
                case MessageType.SCP_MESSAGE:
                var result_SCP_MESSAGE = new StellarMessage.ScpMessage();
                result_SCP_MESSAGE.envelope = SCPEnvelopeXdr.Decode(stream);
                return result_SCP_MESSAGE;
                case MessageType.GET_SCP_STATE:
                var result_GET_SCP_STATE = new StellarMessage.GetScpState();
                result_GET_SCP_STATE.getSCPLedgerSeq = uint32Xdr.Decode(stream);
                return result_GET_SCP_STATE;
                case MessageType.SEND_MORE:
                var result_SEND_MORE = new StellarMessage.SendMoreCase();
                result_SEND_MORE.sendMoreMessage = SendMoreXdr.Decode(stream);
                return result_SEND_MORE;
                case MessageType.SEND_MORE_EXTENDED:
                var result_SEND_MORE_EXTENDED = new StellarMessage.SendMoreExtendedCase();
                result_SEND_MORE_EXTENDED.sendMoreExtendedMessage = SendMoreExtendedXdr.Decode(stream);
                return result_SEND_MORE_EXTENDED;
                case MessageType.FLOOD_ADVERT:
                var result_FLOOD_ADVERT = new StellarMessage.FloodAdvertCase();
                result_FLOOD_ADVERT.floodAdvert = FloodAdvertXdr.Decode(stream);
                return result_FLOOD_ADVERT;
                case MessageType.FLOOD_DEMAND:
                var result_FLOOD_DEMAND = new StellarMessage.FloodDemandCase();
                result_FLOOD_DEMAND.floodDemand = FloodDemandXdr.Decode(stream);
                return result_FLOOD_DEMAND;
                default:
                throw new Exception($"Unknown discriminator for StellarMessage: {discriminator}");
            }
        }
    }
}
