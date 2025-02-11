using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Stellar.RPC
{
    public partial class GetTransactionResult
    {
        private TransactionResult _transactionResult;
        public TransactionResult TransactionResult
        {
            get
            {
                if (_transactionResult == null)
                {
                    if (ResultXdr != null)
                    {
                        byte[] bytes = Convert.FromBase64String(ResultXdr);
                        using (MemoryStream stream = new MemoryStream(bytes))
                        {
                            _transactionResult = TransactionResultXdr.Decode(new XdrReader(stream));

                        }
                    }
                }
                return _transactionResult;
            }

        }

        private TransactionMeta _transactionResultMeta;
        public TransactionMeta TransactionResultMeta
        {
            get
            {
                if (_transactionResultMeta == null)
                {
                    if (ResultMetaXdr != null)
                    {
                        byte[] bytes = Convert.FromBase64String(ResultMetaXdr);
                        using (MemoryStream stream = new MemoryStream(bytes))
                        {
                            _transactionResultMeta = TransactionMetaXdr.Decode(new XdrReader(stream));

                        }
                    }
                }
                return _transactionResultMeta;
            }

        }
        private TransactionEnvelope _transactionEnvelope;
        public TransactionEnvelope TransactionEnvelope
        {
            get
            {
                if (_transactionEnvelope == null)
                {
                    if (EnvelopeXdr != null)
                    {
                        byte[] bytes = Convert.FromBase64String(EnvelopeXdr);
                        using (MemoryStream stream = new MemoryStream(bytes))
                        {
                            _transactionEnvelope = TransactionEnvelopeXdr.Decode(new XdrReader(stream));

                        }
                    }
                }
                return _transactionEnvelope;
            }

        }

    }
}
