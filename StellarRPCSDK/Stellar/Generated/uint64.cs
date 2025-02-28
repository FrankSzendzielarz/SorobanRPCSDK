// Generated code - do not modify
// Source:

// typedef unsigned hyper uint64;


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
    [ProtoContract(Name = "Stellar_uint64")]
    public partial class uint64
    {
        [ProtoMember(1, DataFormat = ProtoBuf.DataFormat.Default)]
        public ulong InnerValue
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
        private ulong _innerValue;

        public uint64() { }

        public uint64(ulong value)
        {
            InnerValue = value;
        }
        public static implicit operator ulong(uint64 _uint64) => _uint64.InnerValue;
        public static implicit operator uint64(ulong value) => new uint64(value);
    }
    public static partial class uint64Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(uint64 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                uint64Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static uint64 DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return uint64Xdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, uint64 value)
        {
            stream.WriteULong(value.InnerValue);
        }
        public static uint64 Decode(XdrReader stream)
        {
            var result = new uint64();
            result.InnerValue = stream.ReadULong();
            return result;
        }
    }
}
