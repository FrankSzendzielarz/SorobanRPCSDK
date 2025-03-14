// Generated code - do not modify
// Source:

// typedef opaque uint256[32];


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
    public partial class uint256
    {
        [ProtoMember(1, OverwriteList = true)]
        [MinLength(32)]
        [MaxLength(32)]
        public byte[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length != 32)
                	throw new ArgumentException($"Must be exactly 32 in length");
                _innerValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inner Value")]
        #endif
        private byte[] _innerValue = new byte[32];

        public uint256() { }

        public uint256(byte[] value)
        {
            InnerValue = value;
        }
        public static implicit operator byte[](uint256 _uint256) => _uint256.InnerValue;
        public static implicit operator uint256(byte[] value) => new uint256(value);
    }
    public static partial class uint256Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(uint256 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                uint256Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static uint256 DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return uint256Xdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, uint256 value)
        {
            stream.WriteFixedOpaque(value.InnerValue);
        }
        public static uint256 Decode(XdrReader stream)
        {
            var result = new uint256();
            stream.ReadFixedOpaque(result.InnerValue);
            return result;
        }
    }
}
