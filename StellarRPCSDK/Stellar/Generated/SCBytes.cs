// Generated code - do not modify
// Source:

// typedef opaque SCBytes<>;


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
    public partial class SCBytes
    {
        [ProtoMember(1, OverwriteList = true)]
        public byte[] InnerValue
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
        private byte[] _innerValue;

        public SCBytes() { }

        public SCBytes(byte[] value)
        {
            InnerValue = value;
        }
        public static implicit operator byte[](SCBytes _scbytes) => _scbytes.InnerValue;
        public static implicit operator SCBytes(byte[] value) => new SCBytes(value);
    }
    public static partial class SCBytesXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCBytes value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCBytesXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SCBytes DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SCBytesXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, SCBytes value)
        {
            stream.WriteOpaque(value.InnerValue);
        }
        public static SCBytes Decode(XdrReader stream)
        {
            var result = new SCBytes();
            result.InnerValue = stream.ReadOpaque();
            return result;
        }
    }
}
