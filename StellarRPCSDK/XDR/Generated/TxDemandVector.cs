// Generated code - do not modify
// Source:

// typedef Hash TxDemandVector<TX_DEMAND_VECTOR_MAX_SIZE>;


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TxDemandVector
    {
        private Hash[] _innerValue;
        public Hash[] InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }

        public TxDemandVector() { }

        public TxDemandVector(Hash[] value)
        {
            InnerValue = value;
        }
    }
    public static partial class TxDemandVectorXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TxDemandVector value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TxDemandVectorXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, TxDemandVector value)
        {
            stream.WriteInt(value.InnerValue.Length);
            foreach (var item in value.InnerValue)
            {
                    HashXdr.Encode(stream, item);
            }
        }
        public static TxDemandVector Decode(XdrReader stream)
        {
            var result = new TxDemandVector();
            {
                var length = stream.ReadInt();
                result.InnerValue = new Hash[length];
                for (var i = 0; i < length; i++)
                {
                    result.InnerValue[i] = HashXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
