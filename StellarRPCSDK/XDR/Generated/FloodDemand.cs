// Generated code - do not modify
// Source:

// struct FloodDemand
// {
//     TxDemandVector txHashes;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class FloodDemand
    {
        public TxDemandVector txHashes
        {
            get => _txHashes;
            set
            {
                _txHashes = value;
            }
        }
        private TxDemandVector _txHashes;

        public FloodDemand()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class FloodDemandXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(FloodDemand value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                FloodDemandXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, FloodDemand value)
        {
            value.Validate();
            TxDemandVectorXdr.Encode(stream, value.txHashes);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static FloodDemand Decode(XdrReader stream)
        {
            var result = new FloodDemand();
            result.txHashes = TxDemandVectorXdr.Decode(stream);
            return result;
        }
    }
}
