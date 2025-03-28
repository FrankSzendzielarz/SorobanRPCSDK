// Generated code - do not modify
// Source:

// typedef opaque Signature<64>;


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    /// <summary>
    /// variable size as the size depends on the signature scheme used
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class Signature
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

        public Signature() { }

        public Signature(byte[] value)
        {
            InnerValue = value;
        }
        public static implicit operator byte[](Signature _signature) => _signature.InnerValue;
        public static implicit operator Signature(byte[] value) => new Signature(value);
    }
    public static partial class SignatureXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(Signature value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SignatureXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static Signature DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SignatureXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, Signature value)
        {
            stream.WriteOpaque(value.InnerValue);
        }
        public static Signature Decode(XdrReader stream)
        {
            var result = new Signature();
            result.InnerValue = stream.ReadOpaque();
            return result;
        }
    }
}
