// Generated code - do not modify
// Source:

// struct InnerTransactionResultPair
// {
//     Hash transactionHash;          // hash of the inner transaction
//     InnerTransactionResult result; // result for the inner transaction
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class InnerTransactionResultPair
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

        /// <summary>
        /// hash of the inner transaction
        /// </summary>
        public InnerTransactionResult result
        {
            get => _result;
            set
            {
                _result = value;
            }
        }
        private InnerTransactionResult _result;

        public InnerTransactionResultPair()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class InnerTransactionResultPairXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(InnerTransactionResultPair value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                InnerTransactionResultPairXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, InnerTransactionResultPair value)
        {
            value.Validate();
            HashXdr.Encode(stream, value.transactionHash);
            InnerTransactionResultXdr.Encode(stream, value.result);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static InnerTransactionResultPair Decode(XdrReader stream)
        {
            var result = new InnerTransactionResultPair();
            result.transactionHash = HashXdr.Decode(stream);
            result.result = InnerTransactionResultXdr.Decode(stream);
            return result;
        }
    }
}
