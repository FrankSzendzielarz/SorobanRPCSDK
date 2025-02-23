// Generated code - do not modify
// Source:

// typedef opaque DataValue<64>;


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
    public partial class DataValue
    {
        [ProtoMember(1, OverwriteList = true)]
        [MaxLength(64)]
        public byte[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length > 64)
                	throw new ArgumentException($"Cannot exceed 64 in length");
                _innerValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inner Value")]
        #endif
        private byte[] _innerValue;

        public DataValue() { }

        public DataValue(byte[] value)
        {
            InnerValue = value;
        }
        public static implicit operator byte[](DataValue _datavalue) => _datavalue.InnerValue;
        public static implicit operator DataValue(byte[] value) => new DataValue(value);
    }
    public static partial class DataValueXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(DataValue value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                DataValueXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static DataValue DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return DataValueXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, DataValue value)
        {
            stream.WriteOpaque(value.InnerValue);
        }
        public static DataValue Decode(XdrReader stream)
        {
            var result = new DataValue();
            result.InnerValue = stream.ReadOpaque();
            return result;
        }
    }
}
