// Generated code - do not modify
// Source:

// union PublicKey switch (PublicKeyType type)
// {
// case PUBLIC_KEY_TYPE_ED25519:
//     uint256 ed25519;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class PublicKey
    {
        public abstract PublicKeyType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class PublicKey_PUBLIC_KEY_TYPE_ED25519 : PublicKey
    {
        public override PublicKeyType Discriminator => PUBLIC_KEY_TYPE_ED25519;
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
    public static partial class PublicKeyXdr
    {
        public static void Encode(XdrWriter stream, PublicKey value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case PublicKey_PUBLIC_KEY_TYPE_ED25519 case_PUBLIC_KEY_TYPE_ED25519:
                uint256Xdr.Encode(stream, case_PUBLIC_KEY_TYPE_ED25519.ed25519);
                break;
            }
        }
        public static PublicKey Decode(XdrReader stream)
        {
            var discriminator = (PublicKeyType)stream.ReadInt();
            switch (discriminator)
            {
                case PUBLIC_KEY_TYPE_ED25519:
                var result_PUBLIC_KEY_TYPE_ED25519 = new PublicKey_PUBLIC_KEY_TYPE_ED25519();
                result_PUBLIC_KEY_TYPE_ED25519.                 = uint256Xdr.Decode(stream);
                return result_PUBLIC_KEY_TYPE_ED25519;
                default:
                throw new Exception($"Unknown discriminator for PublicKey: {discriminator}");
            }
        }
    }
}
