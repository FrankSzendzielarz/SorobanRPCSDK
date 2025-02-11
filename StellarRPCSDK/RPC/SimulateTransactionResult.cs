using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Stellar.RPC
{
    public partial class SimulateTransactionResult
    {
        private SorobanTransactionData _sorobanTransactionData;
        public SorobanTransactionData SorobanTransactionData
        {
            get
            {
                if (_sorobanTransactionData == null)
                {
                    if (TransactionData != null)
                    {
                        byte[] bytes = Convert.FromBase64String(TransactionData);
                        using (MemoryStream stream = new MemoryStream(bytes))
                        {
                            _sorobanTransactionData = SorobanTransactionDataXdr.Decode(new XdrReader(stream));

                        }
                    }
                }
                return _sorobanTransactionData;
            }
        }
        private List<DiagnosticEvent> _events;
        public List<DiagnosticEvent> DiagnosticEvents
        {
            get
            {
                if (_events == null)
                {
                    _events = new List<DiagnosticEvent>();
                    if (Events != null)
                    {
                        foreach (var xdr in Events)
                        {
                            byte[] bytes = Convert.FromBase64String(xdr);
                            using (MemoryStream stream = new MemoryStream(bytes))
                            {
                                _events.Add(DiagnosticEventXdr.Decode(new XdrReader(stream)));

                            }
                        }
                    }
                }
                return _events;
            }
        }

    }
}
