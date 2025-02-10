using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Stellar.RPC
{
    public partial class SendTransactionResult
    {
        private TransactionResult _transactionResult;
        public TransactionResult ErrorResult
        {
            get
            {
                if (_transactionResult == null)
                {
                    if (ErrorResultXdr != null)
                    {
                        byte[] bytes = Convert.FromBase64String(ErrorResultXdr);
                        using (MemoryStream stream = new MemoryStream(bytes))
                        {
                            _transactionResult = TransactionResultXdr.Decode(new XdrReader(stream));

                        }
                    }
                }
                return _transactionResult;
            }

        }

        private List<DiagnosticEvent> _diagnosticEvents = new List<DiagnosticEvent>();
        public List<DiagnosticEvent> DiagnosticEvents
        {
            get
            {
                if (_diagnosticEvents == null)
                {
                    if (DiagnosticEventsXdr != null)
                    {
                        foreach (var d in DiagnosticEventsXdr)
                        {
                            byte[] bytes = Convert.FromBase64String(ErrorResultXdr);
                            using (MemoryStream stream = new MemoryStream(bytes))
                            {
                                _diagnosticEvents.Add(DiagnosticEventXdr.Decode(new XdrReader(stream)));

                            }
                        }
                    }
                }
                return _diagnosticEvents;
            }

        }
    }
}
