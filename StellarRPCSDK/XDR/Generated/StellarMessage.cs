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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class StellarMessage
    {
        public abstract MessageType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class StellarMessage_ERROR_MSG : StellarMessage
    {
        public override MessageType Discriminator => MessageType.ERROR_MSG;
        private Error _error;
        public Error error
        {
            get => _error;
            set
            {
                _error = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_HELLO : StellarMessage
    {
        public override MessageType Discriminator => MessageType.HELLO;
        private Hello _hello;
        public Hello hello
        {
            get => _hello;
            set
            {
                _hello = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_AUTH : StellarMessage
    {
        public override MessageType Discriminator => MessageType.AUTH;
        private Auth _auth;
        public Auth auth
        {
            get => _auth;
            set
            {
                _auth = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_DONT_HAVE : StellarMessage
    {
        public override MessageType Discriminator => MessageType.DONT_HAVE;
        private DontHave _dontHave;
        public DontHave dontHave
        {
            get => _dontHave;
            set
            {
                _dontHave = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_PEERS : StellarMessage
    {
        public override MessageType Discriminator => MessageType.PEERS;
        private PeerAddress[] _peers;
        public PeerAddress[] peers
        {
            get => _peers;
            set
            {
                if (value.Length > 100)
                	throw new ArgumentException($"Cannot exceed 100 bytes");
                _peers = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_GET_TX_SET : StellarMessage
    {
        public override MessageType Discriminator => MessageType.GET_TX_SET;
        private uint256 _txSetHash;
        public uint256 txSetHash
        {
            get => _txSetHash;
            set
            {
                _txSetHash = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_TX_SET : StellarMessage
    {
        public override MessageType Discriminator => MessageType.TX_SET;
        private TransactionSet _txSet;
        public TransactionSet txSet
        {
            get => _txSet;
            set
            {
                _txSet = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_GENERALIZED_TX_SET : StellarMessage
    {
        public override MessageType Discriminator => MessageType.GENERALIZED_TX_SET;
        private GeneralizedTransactionSet _generalizedTxSet;
        public GeneralizedTransactionSet generalizedTxSet
        {
            get => _generalizedTxSet;
            set
            {
                _generalizedTxSet = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_TRANSACTION : StellarMessage
    {
        public override MessageType Discriminator => MessageType.TRANSACTION;
        private TransactionEnvelope _transaction;
        public TransactionEnvelope transaction
        {
            get => _transaction;
            set
            {
                _transaction = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_SURVEY_REQUEST : StellarMessage
    {
        public override MessageType Discriminator => MessageType.SURVEY_REQUEST;
        private SignedSurveyRequestMessage _signedSurveyRequestMessage;
        public SignedSurveyRequestMessage signedSurveyRequestMessage
        {
            get => _signedSurveyRequestMessage;
            set
            {
                _signedSurveyRequestMessage = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_SURVEY_RESPONSE : StellarMessage
    {
        public override MessageType Discriminator => MessageType.SURVEY_RESPONSE;
        private SignedSurveyResponseMessage _signedSurveyResponseMessage;
        public SignedSurveyResponseMessage signedSurveyResponseMessage
        {
            get => _signedSurveyResponseMessage;
            set
            {
                _signedSurveyResponseMessage = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_TIME_SLICED_SURVEY_REQUEST : StellarMessage
    {
        public override MessageType Discriminator => MessageType.TIME_SLICED_SURVEY_REQUEST;
        private SignedTimeSlicedSurveyRequestMessage _signedTimeSlicedSurveyRequestMessage;
        public SignedTimeSlicedSurveyRequestMessage signedTimeSlicedSurveyRequestMessage
        {
            get => _signedTimeSlicedSurveyRequestMessage;
            set
            {
                _signedTimeSlicedSurveyRequestMessage = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_TIME_SLICED_SURVEY_RESPONSE : StellarMessage
    {
        public override MessageType Discriminator => MessageType.TIME_SLICED_SURVEY_RESPONSE;
        private SignedTimeSlicedSurveyResponseMessage _signedTimeSlicedSurveyResponseMessage;
        public SignedTimeSlicedSurveyResponseMessage signedTimeSlicedSurveyResponseMessage
        {
            get => _signedTimeSlicedSurveyResponseMessage;
            set
            {
                _signedTimeSlicedSurveyResponseMessage = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_TIME_SLICED_SURVEY_START_COLLECTING : StellarMessage
    {
        public override MessageType Discriminator => MessageType.TIME_SLICED_SURVEY_START_COLLECTING;
        private SignedTimeSlicedSurveyStartCollectingMessage _signedTimeSlicedSurveyStartCollectingMessage;
        public SignedTimeSlicedSurveyStartCollectingMessage signedTimeSlicedSurveyStartCollectingMessage
        {
            get => _signedTimeSlicedSurveyStartCollectingMessage;
            set
            {
                _signedTimeSlicedSurveyStartCollectingMessage = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_TIME_SLICED_SURVEY_STOP_COLLECTING : StellarMessage
    {
        public override MessageType Discriminator => MessageType.TIME_SLICED_SURVEY_STOP_COLLECTING;
        private SignedTimeSlicedSurveyStopCollectingMessage _signedTimeSlicedSurveyStopCollectingMessage;
        public SignedTimeSlicedSurveyStopCollectingMessage signedTimeSlicedSurveyStopCollectingMessage
        {
            get => _signedTimeSlicedSurveyStopCollectingMessage;
            set
            {
                _signedTimeSlicedSurveyStopCollectingMessage = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_GET_SCP_QUORUMSET : StellarMessage
    {
        public override MessageType Discriminator => MessageType.GET_SCP_QUORUMSET;
        private uint256 _qSetHash;
        public uint256 qSetHash
        {
            get => _qSetHash;
            set
            {
                _qSetHash = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_SCP_QUORUMSET : StellarMessage
    {
        public override MessageType Discriminator => MessageType.SCP_QUORUMSET;
        private SCPQuorumSet _qSet;
        public SCPQuorumSet qSet
        {
            get => _qSet;
            set
            {
                _qSet = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_SCP_MESSAGE : StellarMessage
    {
        public override MessageType Discriminator => MessageType.SCP_MESSAGE;
        private SCPEnvelope _envelope;
        public SCPEnvelope envelope
        {
            get => _envelope;
            set
            {
                _envelope = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_GET_SCP_STATE : StellarMessage
    {
        public override MessageType Discriminator => MessageType.GET_SCP_STATE;
        private uint32 _getSCPLedgerSeq;
        public uint32 getSCPLedgerSeq
        {
            get => _getSCPLedgerSeq;
            set
            {
                _getSCPLedgerSeq = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_SEND_MORE : StellarMessage
    {
        public override MessageType Discriminator => MessageType.SEND_MORE;
        private SendMore _sendMoreMessage;
        public SendMore sendMoreMessage
        {
            get => _sendMoreMessage;
            set
            {
                _sendMoreMessage = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_SEND_MORE_EXTENDED : StellarMessage
    {
        public override MessageType Discriminator => MessageType.SEND_MORE_EXTENDED;
        private SendMoreExtended _sendMoreExtendedMessage;
        public SendMoreExtended sendMoreExtendedMessage
        {
            get => _sendMoreExtendedMessage;
            set
            {
                _sendMoreExtendedMessage = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_FLOOD_ADVERT : StellarMessage
    {
        public override MessageType Discriminator => MessageType.FLOOD_ADVERT;
        private FloodAdvert _floodAdvert;
        public FloodAdvert floodAdvert
        {
            get => _floodAdvert;
            set
            {
                _floodAdvert = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class StellarMessage_FLOOD_DEMAND : StellarMessage
    {
        public override MessageType Discriminator => MessageType.FLOOD_DEMAND;
        private FloodDemand _floodDemand;
        public FloodDemand floodDemand
        {
            get => _floodDemand;
            set
            {
                _floodDemand = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class StellarMessageXdr
    {
        public static void Encode(XdrWriter stream, StellarMessage value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case StellarMessage_ERROR_MSG case_ERROR_MSG:
                ErrorXdr.Encode(stream, case_ERROR_MSG.error);
                break;
                case StellarMessage_HELLO case_HELLO:
                HelloXdr.Encode(stream, case_HELLO.hello);
                break;
                case StellarMessage_AUTH case_AUTH:
                AuthXdr.Encode(stream, case_AUTH.auth);
                break;
                case StellarMessage_DONT_HAVE case_DONT_HAVE:
                DontHaveXdr.Encode(stream, case_DONT_HAVE.dontHave);
                break;
                case StellarMessage_PEERS case_PEERS:
                stream.WriteInt(case_PEERS.peers.Length);
                foreach (var item in case_PEERS.peers)
                {
                        PeerAddressXdr.Encode(stream, item);
                }
                break;
                case StellarMessage_GET_TX_SET case_GET_TX_SET:
                uint256Xdr.Encode(stream, case_GET_TX_SET.txSetHash);
                break;
                case StellarMessage_TX_SET case_TX_SET:
                TransactionSetXdr.Encode(stream, case_TX_SET.txSet);
                break;
                case StellarMessage_GENERALIZED_TX_SET case_GENERALIZED_TX_SET:
                GeneralizedTransactionSetXdr.Encode(stream, case_GENERALIZED_TX_SET.generalizedTxSet);
                break;
                case StellarMessage_TRANSACTION case_TRANSACTION:
                TransactionEnvelopeXdr.Encode(stream, case_TRANSACTION.transaction);
                break;
                case StellarMessage_SURVEY_REQUEST case_SURVEY_REQUEST:
                SignedSurveyRequestMessageXdr.Encode(stream, case_SURVEY_REQUEST.signedSurveyRequestMessage);
                break;
                case StellarMessage_SURVEY_RESPONSE case_SURVEY_RESPONSE:
                SignedSurveyResponseMessageXdr.Encode(stream, case_SURVEY_RESPONSE.signedSurveyResponseMessage);
                break;
                case StellarMessage_TIME_SLICED_SURVEY_REQUEST case_TIME_SLICED_SURVEY_REQUEST:
                SignedTimeSlicedSurveyRequestMessageXdr.Encode(stream, case_TIME_SLICED_SURVEY_REQUEST.signedTimeSlicedSurveyRequestMessage);
                break;
                case StellarMessage_TIME_SLICED_SURVEY_RESPONSE case_TIME_SLICED_SURVEY_RESPONSE:
                SignedTimeSlicedSurveyResponseMessageXdr.Encode(stream, case_TIME_SLICED_SURVEY_RESPONSE.signedTimeSlicedSurveyResponseMessage);
                break;
                case StellarMessage_TIME_SLICED_SURVEY_START_COLLECTING case_TIME_SLICED_SURVEY_START_COLLECTING:
                SignedTimeSlicedSurveyStartCollectingMessageXdr.Encode(stream, case_TIME_SLICED_SURVEY_START_COLLECTING.signedTimeSlicedSurveyStartCollectingMessage);
                break;
                case StellarMessage_TIME_SLICED_SURVEY_STOP_COLLECTING case_TIME_SLICED_SURVEY_STOP_COLLECTING:
                SignedTimeSlicedSurveyStopCollectingMessageXdr.Encode(stream, case_TIME_SLICED_SURVEY_STOP_COLLECTING.signedTimeSlicedSurveyStopCollectingMessage);
                break;
                case StellarMessage_GET_SCP_QUORUMSET case_GET_SCP_QUORUMSET:
                uint256Xdr.Encode(stream, case_GET_SCP_QUORUMSET.qSetHash);
                break;
                case StellarMessage_SCP_QUORUMSET case_SCP_QUORUMSET:
                SCPQuorumSetXdr.Encode(stream, case_SCP_QUORUMSET.qSet);
                break;
                case StellarMessage_SCP_MESSAGE case_SCP_MESSAGE:
                SCPEnvelopeXdr.Encode(stream, case_SCP_MESSAGE.envelope);
                break;
                case StellarMessage_GET_SCP_STATE case_GET_SCP_STATE:
                uint32Xdr.Encode(stream, case_GET_SCP_STATE.getSCPLedgerSeq);
                break;
                case StellarMessage_SEND_MORE case_SEND_MORE:
                SendMoreXdr.Encode(stream, case_SEND_MORE.sendMoreMessage);
                break;
                case StellarMessage_SEND_MORE_EXTENDED case_SEND_MORE_EXTENDED:
                SendMoreExtendedXdr.Encode(stream, case_SEND_MORE_EXTENDED.sendMoreExtendedMessage);
                break;
                case StellarMessage_FLOOD_ADVERT case_FLOOD_ADVERT:
                FloodAdvertXdr.Encode(stream, case_FLOOD_ADVERT.floodAdvert);
                break;
                case StellarMessage_FLOOD_DEMAND case_FLOOD_DEMAND:
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
                var result_ERROR_MSG = new StellarMessage_ERROR_MSG();
                result_ERROR_MSG.error = ErrorXdr.Decode(stream);
                return result_ERROR_MSG;
                case MessageType.HELLO:
                var result_HELLO = new StellarMessage_HELLO();
                result_HELLO.hello = HelloXdr.Decode(stream);
                return result_HELLO;
                case MessageType.AUTH:
                var result_AUTH = new StellarMessage_AUTH();
                result_AUTH.auth = AuthXdr.Decode(stream);
                return result_AUTH;
                case MessageType.DONT_HAVE:
                var result_DONT_HAVE = new StellarMessage_DONT_HAVE();
                result_DONT_HAVE.dontHave = DontHaveXdr.Decode(stream);
                return result_DONT_HAVE;
                case MessageType.PEERS:
                var result_PEERS = new StellarMessage_PEERS();
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
                var result_GET_TX_SET = new StellarMessage_GET_TX_SET();
                result_GET_TX_SET.txSetHash = uint256Xdr.Decode(stream);
                return result_GET_TX_SET;
                case MessageType.TX_SET:
                var result_TX_SET = new StellarMessage_TX_SET();
                result_TX_SET.txSet = TransactionSetXdr.Decode(stream);
                return result_TX_SET;
                case MessageType.GENERALIZED_TX_SET:
                var result_GENERALIZED_TX_SET = new StellarMessage_GENERALIZED_TX_SET();
                result_GENERALIZED_TX_SET.generalizedTxSet = GeneralizedTransactionSetXdr.Decode(stream);
                return result_GENERALIZED_TX_SET;
                case MessageType.TRANSACTION:
                var result_TRANSACTION = new StellarMessage_TRANSACTION();
                result_TRANSACTION.transaction = TransactionEnvelopeXdr.Decode(stream);
                return result_TRANSACTION;
                case MessageType.SURVEY_REQUEST:
                var result_SURVEY_REQUEST = new StellarMessage_SURVEY_REQUEST();
                result_SURVEY_REQUEST.signedSurveyRequestMessage = SignedSurveyRequestMessageXdr.Decode(stream);
                return result_SURVEY_REQUEST;
                case MessageType.SURVEY_RESPONSE:
                var result_SURVEY_RESPONSE = new StellarMessage_SURVEY_RESPONSE();
                result_SURVEY_RESPONSE.signedSurveyResponseMessage = SignedSurveyResponseMessageXdr.Decode(stream);
                return result_SURVEY_RESPONSE;
                case MessageType.TIME_SLICED_SURVEY_REQUEST:
                var result_TIME_SLICED_SURVEY_REQUEST = new StellarMessage_TIME_SLICED_SURVEY_REQUEST();
                result_TIME_SLICED_SURVEY_REQUEST.signedTimeSlicedSurveyRequestMessage = SignedTimeSlicedSurveyRequestMessageXdr.Decode(stream);
                return result_TIME_SLICED_SURVEY_REQUEST;
                case MessageType.TIME_SLICED_SURVEY_RESPONSE:
                var result_TIME_SLICED_SURVEY_RESPONSE = new StellarMessage_TIME_SLICED_SURVEY_RESPONSE();
                result_TIME_SLICED_SURVEY_RESPONSE.signedTimeSlicedSurveyResponseMessage = SignedTimeSlicedSurveyResponseMessageXdr.Decode(stream);
                return result_TIME_SLICED_SURVEY_RESPONSE;
                case MessageType.TIME_SLICED_SURVEY_START_COLLECTING:
                var result_TIME_SLICED_SURVEY_START_COLLECTING = new StellarMessage_TIME_SLICED_SURVEY_START_COLLECTING();
                result_TIME_SLICED_SURVEY_START_COLLECTING.signedTimeSlicedSurveyStartCollectingMessage = SignedTimeSlicedSurveyStartCollectingMessageXdr.Decode(stream);
                return result_TIME_SLICED_SURVEY_START_COLLECTING;
                case MessageType.TIME_SLICED_SURVEY_STOP_COLLECTING:
                var result_TIME_SLICED_SURVEY_STOP_COLLECTING = new StellarMessage_TIME_SLICED_SURVEY_STOP_COLLECTING();
                result_TIME_SLICED_SURVEY_STOP_COLLECTING.signedTimeSlicedSurveyStopCollectingMessage = SignedTimeSlicedSurveyStopCollectingMessageXdr.Decode(stream);
                return result_TIME_SLICED_SURVEY_STOP_COLLECTING;
                case MessageType.GET_SCP_QUORUMSET:
                var result_GET_SCP_QUORUMSET = new StellarMessage_GET_SCP_QUORUMSET();
                result_GET_SCP_QUORUMSET.qSetHash = uint256Xdr.Decode(stream);
                return result_GET_SCP_QUORUMSET;
                case MessageType.SCP_QUORUMSET:
                var result_SCP_QUORUMSET = new StellarMessage_SCP_QUORUMSET();
                result_SCP_QUORUMSET.qSet = SCPQuorumSetXdr.Decode(stream);
                return result_SCP_QUORUMSET;
                case MessageType.SCP_MESSAGE:
                var result_SCP_MESSAGE = new StellarMessage_SCP_MESSAGE();
                result_SCP_MESSAGE.envelope = SCPEnvelopeXdr.Decode(stream);
                return result_SCP_MESSAGE;
                case MessageType.GET_SCP_STATE:
                var result_GET_SCP_STATE = new StellarMessage_GET_SCP_STATE();
                result_GET_SCP_STATE.getSCPLedgerSeq = uint32Xdr.Decode(stream);
                return result_GET_SCP_STATE;
                case MessageType.SEND_MORE:
                var result_SEND_MORE = new StellarMessage_SEND_MORE();
                result_SEND_MORE.sendMoreMessage = SendMoreXdr.Decode(stream);
                return result_SEND_MORE;
                case MessageType.SEND_MORE_EXTENDED:
                var result_SEND_MORE_EXTENDED = new StellarMessage_SEND_MORE_EXTENDED();
                result_SEND_MORE_EXTENDED.sendMoreExtendedMessage = SendMoreExtendedXdr.Decode(stream);
                return result_SEND_MORE_EXTENDED;
                case MessageType.FLOOD_ADVERT:
                var result_FLOOD_ADVERT = new StellarMessage_FLOOD_ADVERT();
                result_FLOOD_ADVERT.floodAdvert = FloodAdvertXdr.Decode(stream);
                return result_FLOOD_ADVERT;
                case MessageType.FLOOD_DEMAND:
                var result_FLOOD_DEMAND = new StellarMessage_FLOOD_DEMAND();
                result_FLOOD_DEMAND.floodDemand = FloodDemandXdr.Decode(stream);
                return result_FLOOD_DEMAND;
                default:
                throw new Exception($"Unknown discriminator for StellarMessage: {discriminator}");
            }
        }
    }
}
