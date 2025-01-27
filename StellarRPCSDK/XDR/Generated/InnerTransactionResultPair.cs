// Generated code - do not modify
// Source:

// struct InnerTransactionResultPair
// {
//     Hash transactionHash;          // hash of the inner transaction
//     InnerTransactionResult result; // result for the inner transaction
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class InnerTransactionResultPair
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

        private InnerTransactionResult _result;
        public InnerTransactionResult result
        {
            get => _result;
            set
            {
                _result = value;
            }
        }

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
