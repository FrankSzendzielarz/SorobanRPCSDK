// Generated code - do not modify
// Source:

// typedef Hash PoolID;


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
    public partial class PoolID
    {
        [ProtoMember(1)]
        public Hash InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inner Value")]
        #endif
        private Hash _innerValue;

        public PoolID() { }

        public PoolID(Hash value)
        {
            InnerValue = value;
        }
        public static implicit operator Hash(PoolID _poolid) => _poolid.InnerValue;
        public static implicit operator PoolID(Hash value) => new PoolID(value);
    }
    public static partial class PoolIDXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(PoolID value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                PoolIDXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static PoolID DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return PoolIDXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, PoolID value)
        {
            HashXdr.Encode(stream, value.InnerValue);
        }
        public static PoolID Decode(XdrReader stream)
        {
            var result = new PoolID();
            result.InnerValue = HashXdr.Decode(stream);
            return result;
        }
    }
}
