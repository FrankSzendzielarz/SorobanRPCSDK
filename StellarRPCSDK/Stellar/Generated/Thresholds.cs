// Generated code - do not modify
// Source:

// typedef opaque Thresholds[4];


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
    public partial class Thresholds
    {
        [ProtoMember(1, OverwriteList = true)]
        [MinLength(4)]
        [MaxLength(4)]
        public byte[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length != 4)
                	throw new ArgumentException($"Must be exactly 4 in length");
                _innerValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inner Value")]
        #endif
        private byte[] _innerValue = new byte[4];

        public Thresholds() { }

        public Thresholds(byte[] value)
        {
            InnerValue = value;
        }
        public static implicit operator byte[](Thresholds _thresholds) => _thresholds.InnerValue;
        public static implicit operator Thresholds(byte[] value) => new Thresholds(value);
    }
    public static partial class ThresholdsXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(Thresholds value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ThresholdsXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static Thresholds DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ThresholdsXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, Thresholds value)
        {
            stream.WriteFixedOpaque(value.InnerValue);
        }
        public static Thresholds Decode(XdrReader stream)
        {
            var result = new Thresholds();
            stream.ReadFixedOpaque(result.InnerValue);
            return result;
        }
    }
}
