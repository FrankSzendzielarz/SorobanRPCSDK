using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Stellar.RPC
{
    public partial class RestorePreamble
    {
        private SorobanTransactionData _sorobanTransactionData;
        [ProtoMember(100)]
#if NATIVE
        [System.Text.Json.Serialization.JsonIgnore]
#endif
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
    }
}
