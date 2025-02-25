
using ProtoBuf;
using System;
using System.IO;
using System.Linq;
using System.ServiceModel;

namespace Stellar.RPC
{


    public partial class Transactions
    {
        private TransactionResult _transactionResult;
        [ProtoMember(100)]
#if NATIVE
        [System.Text.Json.Serialization.JsonIgnore]
#endif
        public TransactionResult TransactionResult
        {
            get
            {
                if (_transactionResult == null)
                {
                    byte[] bytes = Convert.FromBase64String(ResultXdr);
                    using (MemoryStream stream = new MemoryStream(bytes))
                    {
                        _transactionResult = TransactionResultXdr.Decode(new XdrReader(stream));

                    }
                }
                return _transactionResult;
            }

        }

        private TransactionMeta _transactionResultMeta;
        [ProtoMember(101)]
#if NATIVE
        [System.Text.Json.Serialization.JsonIgnore]
#endif
        public TransactionMeta TransactionResultMeta
        {
            get
            {
                if (_transactionResultMeta == null)
                {
                    byte[] bytes = Convert.FromBase64String(ResultMetaXdr);
                    using (MemoryStream stream = new MemoryStream(bytes))
                    {
                        _transactionResultMeta = TransactionMetaXdr.Decode(new XdrReader(stream));

                    }
                }
                return _transactionResultMeta;
            }

        }

        private TransactionEnvelope _transactionEnvelope;
        [ProtoMember(102)]
#if NATIVE
        [System.Text.Json.Serialization.JsonIgnore]
#endif
        public TransactionEnvelope TransactionEnvelope
        {
            get
            {

                if (_transactionEnvelope == null)
                {
                    byte[] bytes = Convert.FromBase64String(EnvelopeXdr);
                    using (MemoryStream stream = new MemoryStream(bytes))
                    {
                        _transactionEnvelope = TransactionEnvelopeXdr.Decode(new XdrReader(stream));

                    }
                }
                return _transactionEnvelope;
            }
        }

        private DiagnosticEvent[] _diagnosticEvents;
        [ProtoMember(103)]
#if NATIVE
        [System.Text.Json.Serialization.JsonIgnore]
#endif
        public DiagnosticEvent[] DiagnosticEvents
        {
            get
            {
                if (_diagnosticEvents == null)
                {
                    _diagnosticEvents = DiagnosticEventsXdr?
                        .Select(de =>
                        {
                            byte[] bytes = Convert.FromBase64String(de);
                            using (MemoryStream stream = new MemoryStream(bytes))
                            {
                                return DiagnosticEventXdr.Decode(new XdrReader(stream));

                            };
                        }
                        ).ToArray();

                }
                return _diagnosticEvents;
            }
        }
    }
}
