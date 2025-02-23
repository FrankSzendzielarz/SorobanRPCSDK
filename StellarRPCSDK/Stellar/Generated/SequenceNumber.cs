// Generated code - do not modify
// Source:

// typedef int64 SequenceNumber;


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
    public partial class SequenceNumber
    {
        [ProtoMember(1)]
        public int64 InnerValue
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
        private int64 _innerValue;

        public SequenceNumber() { }

        public SequenceNumber(int64 value)
        {
            InnerValue = value;
        }
        public static implicit operator int64(SequenceNumber _sequencenumber) => _sequencenumber.InnerValue;
        public static implicit operator SequenceNumber(int64 value) => new SequenceNumber(value);
    }
    public static partial class SequenceNumberXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SequenceNumber value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SequenceNumberXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SequenceNumber DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SequenceNumberXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, SequenceNumber value)
        {
            int64Xdr.Encode(stream, value.InnerValue);
        }
        public static SequenceNumber Decode(XdrReader stream)
        {
            var result = new SequenceNumber();
            result.InnerValue = int64Xdr.Decode(stream);
            return result;
        }
    }
}
