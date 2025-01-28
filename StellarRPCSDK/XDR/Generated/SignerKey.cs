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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class SignerKey
    {
        public abstract SignerKeyType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class SignerKey_SIGNER_KEY_TYPE_ED25519 : SignerKey
    {
        public override SignerKeyType Discriminator => SignerKeyType.SIGNER_KEY_TYPE_ED25519;
        private uint256 _ed25519;
        public uint256 ed25519
        {
            get => _ed25519;
            set
            {
                _ed25519 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SignerKey_SIGNER_KEY_TYPE_PRE_AUTH_TX : SignerKey
    {
        public override SignerKeyType Discriminator => SignerKeyType.SIGNER_KEY_TYPE_PRE_AUTH_TX;
        private uint256 _preAuthTx;
        public uint256 preAuthTx
        {
            get => _preAuthTx;
            set
            {
                _preAuthTx = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SignerKey_SIGNER_KEY_TYPE_HASH_X : SignerKey
    {
        public override SignerKeyType Discriminator => SignerKeyType.SIGNER_KEY_TYPE_HASH_X;
        private uint256 _hashX;
        public uint256 hashX
        {
            get => _hashX;
            set
            {
                _hashX = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SignerKey_SIGNER_KEY_TYPE_ED25519_SIGNED_PAYLOAD : SignerKey
    {
        public override SignerKeyType Discriminator => SignerKeyType.SIGNER_KEY_TYPE_ED25519_SIGNED_PAYLOAD;
        private object _ed25519SignedPayload;
        public object ed25519SignedPayload
        {
            get => _ed25519SignedPayload;
            set
            {
                _ed25519SignedPayload = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class SignerKeyXdr
    {
        public static void Encode(XdrWriter stream, SignerKey value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SignerKey_SIGNER_KEY_TYPE_ED25519 case_SIGNER_KEY_TYPE_ED25519:
                uint256Xdr.Encode(stream, case_SIGNER_KEY_TYPE_ED25519.ed25519);
                break;
                case SignerKey_SIGNER_KEY_TYPE_PRE_AUTH_TX case_SIGNER_KEY_TYPE_PRE_AUTH_TX:
                uint256Xdr.Encode(stream, case_SIGNER_KEY_TYPE_PRE_AUTH_TX.preAuthTx);
                break;
                case SignerKey_SIGNER_KEY_TYPE_HASH_X case_SIGNER_KEY_TYPE_HASH_X:
                uint256Xdr.Encode(stream, case_SIGNER_KEY_TYPE_HASH_X.hashX);
                break;
                case SignerKey_SIGNER_KEY_TYPE_ED25519_SIGNED_PAYLOAD case_SIGNER_KEY_TYPE_ED25519_SIGNED_PAYLOAD:
                Xdr.Encode(stream, case_SIGNER_KEY_TYPE_ED25519_SIGNED_PAYLOAD.ed25519SignedPayload);
                break;
            }
        }
        public static SignerKey Decode(XdrReader stream)
        {
            var discriminator = (SignerKeyType)stream.ReadInt();
            switch (discriminator)
            {
                case SIGNER_KEY_TYPE_ED25519:
                var result_SIGNER_KEY_TYPE_ED25519 = new SignerKey_SIGNER_KEY_TYPE_ED25519();
                result_SIGNER_KEY_TYPE_ED25519.                 = uint256Xdr.Decode(stream);
                return result_SIGNER_KEY_TYPE_ED25519;
                case SIGNER_KEY_TYPE_PRE_AUTH_TX:
                var result_SIGNER_KEY_TYPE_PRE_AUTH_TX = new SignerKey_SIGNER_KEY_TYPE_PRE_AUTH_TX();
                result_SIGNER_KEY_TYPE_PRE_AUTH_TX.                 = uint256Xdr.Decode(stream);
                return result_SIGNER_KEY_TYPE_PRE_AUTH_TX;
                case SIGNER_KEY_TYPE_HASH_X:
                var result_SIGNER_KEY_TYPE_HASH_X = new SignerKey_SIGNER_KEY_TYPE_HASH_X();
                result_SIGNER_KEY_TYPE_HASH_X.                 = uint256Xdr.Decode(stream);
                return result_SIGNER_KEY_TYPE_HASH_X;
                case SIGNER_KEY_TYPE_ED25519_SIGNED_PAYLOAD:
                var result_SIGNER_KEY_TYPE_ED25519_SIGNED_PAYLOAD = new SignerKey_SIGNER_KEY_TYPE_ED25519_SIGNED_PAYLOAD();
                result_SIGNER_KEY_TYPE_ED25519_SIGNED_PAYLOAD.                 = Xdr.Decode(stream);
                return result_SIGNER_KEY_TYPE_ED25519_SIGNED_PAYLOAD;
                default:
                throw new Exception($"Unknown discriminator for SignerKey: {discriminator}");
            }
        }
    }
}
