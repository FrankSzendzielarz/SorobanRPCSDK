// Generated code - do not modify
// Source:

// typedef opaque AssetCode4[4];


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    /// <summary>
    /// 1-4 alphanumeric characters right-padded with 0 bytes
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class AssetCode4
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

        public AssetCode4() { }

        public AssetCode4(byte[] value)
        {
            InnerValue = value;
        }
        public static implicit operator byte[](AssetCode4 _assetcode4) => _assetcode4.InnerValue;
        public static implicit operator AssetCode4(byte[] value) => new AssetCode4(value);
    }
    public static partial class AssetCode4Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(AssetCode4 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                AssetCode4Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static AssetCode4 DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return AssetCode4Xdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, AssetCode4 value)
        {
            stream.WriteFixedOpaque(value.InnerValue);
        }
        public static AssetCode4 Decode(XdrReader stream)
        {
            var result = new AssetCode4();
            stream.ReadFixedOpaque(result.InnerValue);
            return result;
        }
    }
}
