// Generated code - do not modify
// Source:

// struct AlphaNum12
// {
//     AssetCode12 assetCode;
//     AccountID issuer;
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
    public partial class AlphaNum12
    {
        [ProtoMember(1)]
        public AssetCode12 assetCode
        {
            get => _assetCode;
            set
            {
                _assetCode = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Asset Code")]
        #endif
        private AssetCode12 _assetCode;

        [ProtoMember(2)]
        public AccountID issuer
        {
            get => _issuer;
            set
            {
                _issuer = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Issuer")]
        #endif
        private AccountID _issuer;

        public AlphaNum12()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class AlphaNum12Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(AlphaNum12 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                AlphaNum12Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static AlphaNum12 DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return AlphaNum12Xdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, AlphaNum12 value)
        {
            value.Validate();
            AssetCode12Xdr.Encode(stream, value.assetCode);
            AccountIDXdr.Encode(stream, value.issuer);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static AlphaNum12 Decode(XdrReader stream)
        {
            var result = new AlphaNum12();
            result.assetCode = AssetCode12Xdr.Decode(stream);
            result.issuer = AccountIDXdr.Decode(stream);
            return result;
        }
    }
}
