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
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    /// <summary>
    /// Source or destination of a payment operation
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class MuxedAccount
    {
        public abstract CryptoKeyType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public partial class med25519Struct
        {
            public uint64 id
            {
                get => _id;
                set
                {
                    _id = value;
                }
            }
            private uint64 _id;

            public uint256 ed25519
            {
                get => _ed25519;
                set
                {
                    _ed25519 = value;
                }
            }
            private uint256 _ed25519;

            public med25519Struct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class med25519StructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(med25519Struct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    med25519StructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, med25519Struct value)
            {
                value.Validate();
                uint64Xdr.Encode(stream, value.id);
                uint256Xdr.Encode(stream, value.ed25519);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static med25519Struct Decode(XdrReader stream)
            {
                var result = new med25519Struct();
                result.id = uint64Xdr.Decode(stream);
                result.ed25519 = uint256Xdr.Decode(stream);
                return result;
            }
        }
        public sealed partial class KeyTypeEd25519 : MuxedAccount
        {
            public override CryptoKeyType Discriminator => CryptoKeyType.KEY_TYPE_ED25519;
            public uint256 ed25519
            {
                get => _ed25519;
                set
                {
                    _ed25519 = value;
                }
            }
            private uint256 _ed25519;

            public override void ValidateCase() {}
        }
        public sealed partial class KeyTypeMuxedEd25519 : MuxedAccount
        {
            public override CryptoKeyType Discriminator => CryptoKeyType.KEY_TYPE_MUXED_ED25519;
            public med25519Struct med25519
            {
                get => _med25519;
                set
                {
                    _med25519 = value;
                }
            }
            private med25519Struct _med25519;

            public override void ValidateCase() {}
        }
    }
    public static partial class MuxedAccountXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(MuxedAccount value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                MuxedAccountXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, MuxedAccount value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case MuxedAccount.KeyTypeEd25519 case_KEY_TYPE_ED25519:
                uint256Xdr.Encode(stream, case_KEY_TYPE_ED25519.ed25519);
                break;
                case MuxedAccount.KeyTypeMuxedEd25519 case_KEY_TYPE_MUXED_ED25519:
                MuxedAccount.med25519StructXdr.Encode(stream, case_KEY_TYPE_MUXED_ED25519.med25519);
                break;
            }
        }
        public static MuxedAccount Decode(XdrReader stream)
        {
            var discriminator = (CryptoKeyType)stream.ReadInt();
            switch (discriminator)
            {
                case CryptoKeyType.KEY_TYPE_ED25519:
                var result_KEY_TYPE_ED25519 = new MuxedAccount.KeyTypeEd25519();
                result_KEY_TYPE_ED25519.ed25519 = uint256Xdr.Decode(stream);
                return result_KEY_TYPE_ED25519;
                case CryptoKeyType.KEY_TYPE_MUXED_ED25519:
                var result_KEY_TYPE_MUXED_ED25519 = new MuxedAccount.KeyTypeMuxedEd25519();
                result_KEY_TYPE_MUXED_ED25519.med25519 = MuxedAccount.med25519StructXdr.Decode(stream);
                return result_KEY_TYPE_MUXED_ED25519;
                default:
                throw new Exception($"Unknown discriminator for MuxedAccount: {discriminator}");
            }
        }
    }
}
