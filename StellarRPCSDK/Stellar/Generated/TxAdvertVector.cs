// Generated code - do not modify
// Source:

// typedef Hash TxAdvertVector<TX_ADVERT_VECTOR_MAX_SIZE>;


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class TxAdvertVector
    {
        [ProtoMember(1)]
        [MaxLength(1000)]
        public Hash[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length > Constants.TX_ADVERT_VECTOR_MAX_SIZE)
                	throw new ArgumentException($"Cannot exceed Constants.TX_ADVERT_VECTOR_MAX_SIZE in length");
                _innerValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inner Value")]
        #endif
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
        /// <summary>Decodes value from XDR base64 string</summary>
        public static TxAdvertVector DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return TxAdvertVectorXdr.Decode(reader);
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
