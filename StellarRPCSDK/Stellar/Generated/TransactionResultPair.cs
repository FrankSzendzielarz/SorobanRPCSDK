// Generated code - do not modify
// Source:

// struct TransactionResultPair
// {
//     Hash transactionHash;
//     TransactionResult result; // result for the transaction
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TransactionResultPair
    {
        public Hash transactionHash
        {
            get => _transactionHash;
            set
            {
                _transactionHash = value;
            }
        }
        private Hash _transactionHash;

        public TransactionResult result
        {
            get => _result;
            set
            {
                _result = value;
            }
        }
        private TransactionResult _result;

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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TransactionResultPair value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TransactionResultPairXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
