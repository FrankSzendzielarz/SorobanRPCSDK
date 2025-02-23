// Generated code - do not modify
// Source:

// union SignerKey switch (SignerKeyType type)
// {
// case SIGNER_KEY_TYPE_ED25519:
//     uint256 ed25519;
// case SIGNER_KEY_TYPE_PRE_AUTH_TX:
//     /* SHA-256 Hash of TransactionSignaturePayload structure */
//     uint256 preAuthTx;
// case SIGNER_KEY_TYPE_HASH_X:
//     /* Hash of random 256 bit preimage X */
//     uint256 hashX;
// case SIGNER_KEY_TYPE_ED25519_SIGNED_PAYLOAD:
//     struct
//     {
//         /* Public key that must sign the payload. */
//         uint256 ed25519;
//         /* Payload to be raw signed by ed25519. */
//         opaque payload<64>;
//     } ed25519SignedPayload;
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
    [ProtoInclude(100, typeof(SignerKeyTypeEd25519), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(SignerKeyTypePreAuthTx), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(SignerKeyTypeHashX), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(SignerKeyTypeEd25519SignedPayload), DataFormat = DataFormat.Default)]
    public abstract partial class SignerKey
    {
        public abstract SignerKeyType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "SignerKey.ed25519SignedPayloadStruct")]
        public partial class ed25519SignedPayloadStruct
        {
            /// <summary>
            /// Public key that must sign the payload.
            /// </summary>
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

            /// <summary>
            /// Payload to be raw signed by ed25519.
            /// </summary>
            [ProtoMember(2)]
            [MaxLength(64)]
            public byte[] payload
            {
                get => _payload;
                set
                {
                    if (value.Length > 64)
                    	throw new ArgumentException($"Cannot exceed 64 in length");
                    _payload = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Payload")]
            #endif
            private byte[] _payload;

            public ed25519SignedPayloadStruct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
                if (payload.Length > 64)
                	throw new InvalidOperationException($"payload cannot exceed 64 elements");
            }
        }
        public static partial class ed25519SignedPayloadStructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(ed25519SignedPayloadStruct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    ed25519SignedPayloadStructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Decodes value from XDR base64 string</summary>
            public static ed25519SignedPayloadStruct DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return ed25519SignedPayloadStructXdr.Decode(reader);
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, ed25519SignedPayloadStruct value)
            {
                value.Validate();
                uint256Xdr.Encode(stream, value.ed25519);
                stream.WriteOpaque(value.payload);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static ed25519SignedPayloadStruct Decode(XdrReader stream)
            {
                var result = new ed25519SignedPayloadStruct();
                result.ed25519 = uint256Xdr.Decode(stream);
                result.payload = stream.ReadOpaque();
                return result;
            }
        }
        [System.Serializable]
        [ProtoContract(Name = "SignerKey.SignerKeyTypeEd25519")]
        public sealed partial class SignerKeyTypeEd25519 : SignerKey
        {
            public override SignerKeyType Discriminator => SignerKeyType.SIGNER_KEY_TYPE_ED25519;
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
        [System.Serializable]
        [ProtoContract(Name = "SignerKey.SignerKeyTypePreAuthTx")]
        public sealed partial class SignerKeyTypePreAuthTx : SignerKey
        {
            public override SignerKeyType Discriminator => SignerKeyType.SIGNER_KEY_TYPE_PRE_AUTH_TX;
            [ProtoMember(2)]
            public uint256 preAuthTx
            {
                get => _preAuthTx;
                set
                {
                    _preAuthTx = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Pre Auth Tx")]
            #endif
            private uint256 _preAuthTx;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SignerKey.SignerKeyTypeHashX")]
        public sealed partial class SignerKeyTypeHashX : SignerKey
        {
            public override SignerKeyType Discriminator => SignerKeyType.SIGNER_KEY_TYPE_HASH_X;
            [ProtoMember(3)]
            public uint256 hashX
            {
                get => _hashX;
                set
                {
                    _hashX = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Hash X")]
            #endif
            private uint256 _hashX;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SignerKey.SignerKeyTypeEd25519SignedPayload")]
        public sealed partial class SignerKeyTypeEd25519SignedPayload : SignerKey
        {
            public override SignerKeyType Discriminator => SignerKeyType.SIGNER_KEY_TYPE_ED25519_SIGNED_PAYLOAD;
            [ProtoMember(4)]
            public ed25519SignedPayloadStruct ed25519SignedPayload
            {
                get => _ed25519SignedPayload;
                set
                {
                    _ed25519SignedPayload = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Ed25519 Signed Payload")]
            #endif
            private ed25519SignedPayloadStruct _ed25519SignedPayload;

            public override void ValidateCase() {}
        }
    }
    public static partial class SignerKeyXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SignerKey value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SignerKeyXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SignerKey DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SignerKeyXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, SignerKey value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SignerKey.SignerKeyTypeEd25519 case_SIGNER_KEY_TYPE_ED25519:
                uint256Xdr.Encode(stream, case_SIGNER_KEY_TYPE_ED25519.ed25519);
                break;
                case SignerKey.SignerKeyTypePreAuthTx case_SIGNER_KEY_TYPE_PRE_AUTH_TX:
                uint256Xdr.Encode(stream, case_SIGNER_KEY_TYPE_PRE_AUTH_TX.preAuthTx);
                break;
                case SignerKey.SignerKeyTypeHashX case_SIGNER_KEY_TYPE_HASH_X:
                uint256Xdr.Encode(stream, case_SIGNER_KEY_TYPE_HASH_X.hashX);
                break;
                case SignerKey.SignerKeyTypeEd25519SignedPayload case_SIGNER_KEY_TYPE_ED25519_SIGNED_PAYLOAD:
                SignerKey.ed25519SignedPayloadStructXdr.Encode(stream, case_SIGNER_KEY_TYPE_ED25519_SIGNED_PAYLOAD.ed25519SignedPayload);
                break;
            }
        }
        public static SignerKey Decode(XdrReader stream)
        {
            var discriminator = (SignerKeyType)stream.ReadInt();
            switch (discriminator)
            {
                case SignerKeyType.SIGNER_KEY_TYPE_ED25519:
                var result_SIGNER_KEY_TYPE_ED25519 = new SignerKey.SignerKeyTypeEd25519();
                result_SIGNER_KEY_TYPE_ED25519.ed25519 = uint256Xdr.Decode(stream);
                return result_SIGNER_KEY_TYPE_ED25519;
                case SignerKeyType.SIGNER_KEY_TYPE_PRE_AUTH_TX:
                var result_SIGNER_KEY_TYPE_PRE_AUTH_TX = new SignerKey.SignerKeyTypePreAuthTx();
                result_SIGNER_KEY_TYPE_PRE_AUTH_TX.preAuthTx = uint256Xdr.Decode(stream);
                return result_SIGNER_KEY_TYPE_PRE_AUTH_TX;
                case SignerKeyType.SIGNER_KEY_TYPE_HASH_X:
                var result_SIGNER_KEY_TYPE_HASH_X = new SignerKey.SignerKeyTypeHashX();
                result_SIGNER_KEY_TYPE_HASH_X.hashX = uint256Xdr.Decode(stream);
                return result_SIGNER_KEY_TYPE_HASH_X;
                case SignerKeyType.SIGNER_KEY_TYPE_ED25519_SIGNED_PAYLOAD:
                var result_SIGNER_KEY_TYPE_ED25519_SIGNED_PAYLOAD = new SignerKey.SignerKeyTypeEd25519SignedPayload();
                result_SIGNER_KEY_TYPE_ED25519_SIGNED_PAYLOAD.ed25519SignedPayload = SignerKey.ed25519SignedPayloadStructXdr.Decode(stream);
                return result_SIGNER_KEY_TYPE_ED25519_SIGNED_PAYLOAD;
                default:
                throw new Exception($"Unknown discriminator for SignerKey: {discriminator}");
            }
        }
    }
}
