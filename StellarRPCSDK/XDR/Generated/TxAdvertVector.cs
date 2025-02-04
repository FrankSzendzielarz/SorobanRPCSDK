// Generated code - do not modify
// Source:

// typedef Hash TxAdvertVector<TX_ADVERT_VECTOR_MAX_SIZE>;


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TxAdvertVector
    {
        public Hash[] InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }
        private Hash[] _innerValue;

        public TxAdvertVector() { }

        public TxAdvertVector(Hash[] value)
        {
            InnerValue = value;
        }
        public static implicit operator Hash[](TxAdvertVector _txadvertvector) => _txadvertvector.InnerValue;
        public static implicit operator TxAdvertVector(Hash[] value) => new TxAdvertVector(value);
    }
    public static partial class TxAdvertVectorXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TxAdvertVector value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TxAdvertVectorXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, TxAdvertVector value)
        {
            stream.WriteInt(value.InnerValue.Length);
            foreach (var item in value.InnerValue)
            {
                    HashXdr.Encode(stream, item);
            }
        }
        public static TxAdvertVector Decode(XdrReader stream)
        {
            var result = new TxAdvertVector();
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
