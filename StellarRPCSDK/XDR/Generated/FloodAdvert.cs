// Generated code - do not modify
// Source:

// struct FloodAdvert
// {
//     TxAdvertVector txHashes;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class FloodAdvert
    {
        private TxAdvertVector _txHashes;
        public TxAdvertVector txHashes
        {
            get => _txHashes;
            set
            {
                _txHashes = value;
            }
        }

        public FloodAdvert()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class FloodAdvertXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, FloodAdvert value)
        {
            value.Validate();
            TxAdvertVectorXdr.Encode(stream, value.txHashes);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static FloodAdvert Decode(XdrReader stream)
        {
            var result = new FloodAdvert();
            result.txHashes = TxAdvertVectorXdr.Decode(stream);
            return result;
        }
    }
}
