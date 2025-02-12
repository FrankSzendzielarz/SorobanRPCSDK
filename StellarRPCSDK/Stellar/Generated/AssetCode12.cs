// Generated code - do not modify
// Source:

// typedef opaque AssetCode12[12];


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    /// <summary>
    /// 5-12 alphanumeric characters right-padded with 0 bytes
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class AssetCode12
    {
        [MinLength(12)]
        [MaxLength(12)]
        public byte[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length != 12)
                	throw new ArgumentException($"Must be exactly 12 in length");
                _innerValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inner Value")]
        #endif
        private byte[] _innerValue = new byte[12];

        public AssetCode12() { }

        public AssetCode12(byte[] value)
        {
            InnerValue = value;
        }
        public static implicit operator byte[](AssetCode12 _assetcode12) => _assetcode12.InnerValue;
        public static implicit operator AssetCode12(byte[] value) => new AssetCode12(value);
    }
    public static partial class AssetCode12Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(AssetCode12 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                AssetCode12Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, AssetCode12 value)
        {
            stream.WriteFixedOpaque(value.InnerValue);
        }
        public static AssetCode12 Decode(XdrReader stream)
        {
            var result = new AssetCode12();
            stream.ReadFixedOpaque(result.InnerValue);
            return result;
        }
    }
}
