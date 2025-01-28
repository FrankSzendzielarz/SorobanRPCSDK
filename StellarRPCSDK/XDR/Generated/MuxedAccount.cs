// Generated code - do not modify
// Source:

// union MuxedAccount switch (CryptoKeyType type)
// {
// case KEY_TYPE_ED25519:
//     uint256 ed25519;
// case KEY_TYPE_MUXED_ED25519:
//     struct
//     {
//         uint64 id;
//         uint256 ed25519;
//     } med25519;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class MuxedAccount
    {
        public abstract CryptoKeyType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class MuxedAccount_KEY_TYPE_ED25519 : MuxedAccount
    {
        public override CryptoKeyType Discriminator => CryptoKeyType.KEY_TYPE_ED25519;
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
    public sealed partial class MuxedAccount_KEY_TYPE_MUXED_ED25519 : MuxedAccount
    {
        public override CryptoKeyType Discriminator => CryptoKeyType.KEY_TYPE_MUXED_ED25519;
        private object _med25519;
        public object med25519
        {
            get => _med25519;
            set
            {
                _med25519 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class MuxedAccountXdr
    {
        public static void Encode(XdrWriter stream, MuxedAccount value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case MuxedAccount_KEY_TYPE_ED25519 case_KEY_TYPE_ED25519:
                uint256Xdr.Encode(stream, case_KEY_TYPE_ED25519.ed25519);
                break;
                case MuxedAccount_KEY_TYPE_MUXED_ED25519 case_KEY_TYPE_MUXED_ED25519:
                Xdr.Encode(stream, case_KEY_TYPE_MUXED_ED25519.med25519);
                break;
            }
        }
        public static MuxedAccount Decode(XdrReader stream)
        {
            var discriminator = (CryptoKeyType)stream.ReadInt();
            switch (discriminator)
            {
                case KEY_TYPE_ED25519:
                var result_KEY_TYPE_ED25519 = new MuxedAccount_KEY_TYPE_ED25519();
                result_KEY_TYPE_ED25519.                 = uint256Xdr.Decode(stream);
                return result_KEY_TYPE_ED25519;
                case KEY_TYPE_MUXED_ED25519:
                var result_KEY_TYPE_MUXED_ED25519 = new MuxedAccount_KEY_TYPE_MUXED_ED25519();
                result_KEY_TYPE_MUXED_ED25519.                 = Xdr.Decode(stream);
                return result_KEY_TYPE_MUXED_ED25519;
                default:
                throw new Exception($"Unknown discriminator for MuxedAccount: {discriminator}");
            }
        }
    }
}
