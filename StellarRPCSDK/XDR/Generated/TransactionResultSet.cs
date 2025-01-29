// Generated code - do not modify
// Source:

// struct TransactionResultSet
// {
//     TransactionResultPair results<>;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TransactionResultSet
    {
        private TransactionResultPair[] _results;
        public TransactionResultPair[] results
        {
            get => _results;
            set
            {
                _results = value;
            }
        }

        public TransactionResultSet()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class TransactionResultSetXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TransactionResultSet value)
        {
            value.Validate();
            stream.WriteInt(value.results.Length);
            foreach (var item in value.results)
            {
                    TransactionResultPairXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TransactionResultSet Decode(XdrReader stream)
        {
            var result = new TransactionResultSet();
            {
                var length = stream.ReadInt();
                result.results = new TransactionResultPair[length];
                for (var i = 0; i < length; i++)
                {
                    result.results[i] = TransactionResultPairXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
