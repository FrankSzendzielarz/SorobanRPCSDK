// Generated code - do not modify
// Source:

// typedef int int32;


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
    [ProtoContract(Name = "Stellar_int32")]
    public partial class int32
    {
        [ProtoMember(1, DataFormat = ProtoBuf.DataFormat.Default)]
        public int InnerValue
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
        private int _innerValue;

        public int32() { }

        public int32(int value)
        {
            InnerValue = value;
        }
        public static implicit operator int(int32 _int32) => _int32.InnerValue;
        public static implicit operator int32(int value) => new int32(value);
    }
    public static partial class int32Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(int32 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                int32Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static int32 DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return int32Xdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, int32 value)
        {
            stream.WriteInt(value.InnerValue);
        }
        public static int32 Decode(XdrReader stream)
        {
            var result = new int32();
            result.InnerValue = stream.ReadInt();
            return result;
        }
    }
}
