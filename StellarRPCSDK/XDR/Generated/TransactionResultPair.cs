// Generated code - do not modify
// Source:

// struct TransactionResultPair
// {
//     Hash transactionHash;
//     TransactionResult result; // result for the transaction
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TransactionResultPair
    {
        private Hash _transactionHash;
        public Hash transactionHash
        {
            get => _transactionHash;
            set
            {
                _transactionHash = value;
            }
        }

        private TransactionResult _result;
        public TransactionResult result
        {
            get => _result;
            set
            {
                _result = value;
            }
        }

        public TransactionResultPair()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class TransactionResultPairXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TransactionResultPair value)
        {
            value.Validate();
            HashXdr.Encode(stream, value.transactionHash);
            TransactionResultXdr.Encode(stream, value.result);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TransactionResultPair Decode(XdrReader stream)
        {
            var result = new TransactionResultPair();
            result.transactionHash = HashXdr.Decode(stream);
            result.result = TransactionResultXdr.Decode(stream);
            return result;
        }
    }
}
