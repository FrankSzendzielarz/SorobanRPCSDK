// Generated code - do not modify
// Source:

// struct TransactionSet
// {
//     Hash previousLedgerHash;
//     TransactionEnvelope txs<>;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    /// <summary>
    /// between ledgers
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class TransactionSet
    {
        public Hash previousLedgerHash
        {
            get => _previousLedgerHash;
            set
            {
                _previousLedgerHash = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Previous Ledger Hash")]
        #endif
        private Hash _previousLedgerHash;

        public TransactionEnvelope[] txs
        {
            get => _txs;
            set
            {
                _txs = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Txs")]
        #endif
        private TransactionEnvelope[] _txs;

        public TransactionSet()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class TransactionSetXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TransactionSet value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TransactionSetXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TransactionSet value)
        {
            value.Validate();
            HashXdr.Encode(stream, value.previousLedgerHash);
            stream.WriteInt(value.txs.Length);
            foreach (var item in value.txs)
            {
                    TransactionEnvelopeXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TransactionSet Decode(XdrReader stream)
        {
            var result = new TransactionSet();
            result.previousLedgerHash = HashXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.txs = new TransactionEnvelope[length];
                for (var i = 0; i < length; i++)
                {
                    result.txs[i] = TransactionEnvelopeXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
