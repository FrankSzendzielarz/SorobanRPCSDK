// Generated code - do not modify
// Source:

// typedef opaque UpgradeType<128>;


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
    public partial class UpgradeType
    {
        [ProtoMember(1, OverwriteList = true)]
        [MaxLength(128)]
        public byte[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length > 128)
                	throw new ArgumentException($"Cannot exceed 128 in length");
                _innerValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inner Value")]
        #endif
        private byte[] _innerValue;

        public UpgradeType() { }

        public UpgradeType(byte[] value)
        {
            InnerValue = value;
        }
        public static implicit operator byte[](UpgradeType _upgradetype) => _upgradetype.InnerValue;
        public static implicit operator UpgradeType(byte[] value) => new UpgradeType(value);
    }
    public static partial class UpgradeTypeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(UpgradeType value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                UpgradeTypeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static UpgradeType DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return UpgradeTypeXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, UpgradeType value)
        {
            stream.WriteOpaque(value.InnerValue);
        }
        public static UpgradeType Decode(XdrReader stream)
        {
            var result = new UpgradeType();
            result.InnerValue = stream.ReadOpaque();
            return result;
        }
    }
}
