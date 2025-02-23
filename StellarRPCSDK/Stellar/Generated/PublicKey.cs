// Generated code - do not modify
// Source:

// union PublicKey switch (PublicKeyType type)
// {
// case PUBLIC_KEY_TYPE_ED25519:
//     uint256 ed25519;
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
    [ProtoInclude(100, typeof(PublicKeyTypeEd25519), DataFormat = DataFormat.Default)]
    public abstract partial class PublicKey
    {
        public abstract PublicKeyType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "PublicKey_PublicKeyTypeEd25519")]
        public sealed partial class PublicKeyTypeEd25519 : PublicKey
        {
            public override PublicKeyType Discriminator => PublicKeyType.PUBLIC_KEY_TYPE_ED25519;
            [ProtoMember(1)]
            public uint256 ed25519
            {
                get => _ed25519;
                set
                {
                    _ed25519 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Ed25519")]
            #endif
            private uint256 _ed25519;

            public override void ValidateCase() {}
        }
    }
    public static partial class PublicKeyXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(PublicKey value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                PublicKeyXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static PublicKey DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return PublicKeyXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, PublicKey value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case PublicKey.PublicKeyTypeEd25519 case_PUBLIC_KEY_TYPE_ED25519:
                uint256Xdr.Encode(stream, case_PUBLIC_KEY_TYPE_ED25519.ed25519);
                break;
            }
        }
        public static PublicKey Decode(XdrReader stream)
        {
            var discriminator = (PublicKeyType)stream.ReadInt();
            switch (discriminator)
            {
                case PublicKeyType.PUBLIC_KEY_TYPE_ED25519:
                var result_PUBLIC_KEY_TYPE_ED25519 = new PublicKey.PublicKeyTypeEd25519();
                result_PUBLIC_KEY_TYPE_ED25519.ed25519 = uint256Xdr.Decode(stream);
                return result_PUBLIC_KEY_TYPE_ED25519;
                default:
                throw new Exception($"Unknown discriminator for PublicKey: {discriminator}");
            }
        }
    }
}
