// Generated code - do not modify
// Source:

// struct Curve25519Secret
// {
//     opaque key[32];
// };


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
    public partial class Curve25519Secret
    {
        [ProtoMember(1, OverwriteList = true)]
        [MinLength(32)]
        [MaxLength(32)]
        public byte[] key
        {
            get => _key;
            set
            {
                if (value.Length != 32)
                	throw new ArgumentException($"Must be exactly 32 in length");
                _key = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Key")]
        #endif
        private byte[] _key = new byte[32];

        public Curve25519Secret()
        {
            key = new byte[32];
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (key.Length != 32)
            	throw new InvalidOperationException($"key must be exactly 32 elements");
        }
    }
    public static partial class Curve25519SecretXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(Curve25519Secret value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                Curve25519SecretXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static Curve25519Secret DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return Curve25519SecretXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, Curve25519Secret value)
        {
            value.Validate();
            stream.WriteFixedOpaque(value.key);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static Curve25519Secret Decode(XdrReader stream)
        {
            var result = new Curve25519Secret();
            stream.ReadFixedOpaque(result.key);
            return result;
        }
    }
}
