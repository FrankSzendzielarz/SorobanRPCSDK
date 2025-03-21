// Generated code - do not modify
// Source:

// typedef opaque EncryptedBody<64000>;


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
    public partial class EncryptedBody
    {
        [ProtoMember(1, OverwriteList = true)]
        [MaxLength(64000)]
        public byte[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length > 64000)
                	throw new ArgumentException($"Cannot exceed 64000 in length");
                _innerValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inner Value")]
        #endif
        private byte[] _innerValue;

        public EncryptedBody() { }

        public EncryptedBody(byte[] value)
        {
            InnerValue = value;
        }
        public static implicit operator byte[](EncryptedBody _encryptedbody) => _encryptedbody.InnerValue;
        public static implicit operator EncryptedBody(byte[] value) => new EncryptedBody(value);
    }
    public static partial class EncryptedBodyXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(EncryptedBody value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                EncryptedBodyXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static EncryptedBody DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return EncryptedBodyXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, EncryptedBody value)
        {
            stream.WriteOpaque(value.InnerValue);
        }
        public static EncryptedBody Decode(XdrReader stream)
        {
            var result = new EncryptedBody();
            result.InnerValue = stream.ReadOpaque();
            return result;
        }
    }
}
