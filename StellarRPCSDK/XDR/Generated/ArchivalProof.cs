// Generated code - do not modify
// Source:

// struct ArchivalProof
// {
//     uint32 epoch; // AST Subtree for this proof
// 
//     union switch (ArchivalProofType t)
//     {
//     case EXISTENCE:
//         NonexistenceProofBody nonexistenceProof;
//     case NONEXISTENCE:
//         ExistenceProofBody existenceProof;
//     } body;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ArchivalProof
    {
        private uint32 _epoch;
        public uint32 epoch
        {
            get => _epoch;
            set
            {
                _epoch = value;
            }
        }

        private bodyUnion _body;
        public bodyUnion body
        {
            get => _body;
            set
            {
                _body = value;
            }
        }

        public ArchivalProof()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class bodyUnion
        {
            public abstract ArchivalProofType Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

        }
        public sealed partial class bodyUnion_EXISTENCE : bodyUnion
        {
            public override ArchivalProofType Discriminator => ArchivalProofType.EXISTENCE;
            private NonexistenceProofBody _nonexistenceProof;
            public NonexistenceProofBody nonexistenceProof
            {
                get => _nonexistenceProof;
                set
                {
                    _nonexistenceProof = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class bodyUnion_NONEXISTENCE : bodyUnion
        {
            public override ArchivalProofType Discriminator => ArchivalProofType.NONEXISTENCE;
            private ExistenceProofBody _existenceProof;
            public ExistenceProofBody existenceProof
            {
                get => _existenceProof;
                set
                {
                    _existenceProof = value;
                }
            }

            public override void ValidateCase() {}
        }
        public static partial class bodyUnionXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(bodyUnion value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    bodyUnionXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            public static void Encode(XdrWriter stream, bodyUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case bodyUnion_EXISTENCE case_EXISTENCE:
                    NonexistenceProofBodyXdr.Encode(stream, case_EXISTENCE.nonexistenceProof);
                    break;
                    case bodyUnion_NONEXISTENCE case_NONEXISTENCE:
                    ExistenceProofBodyXdr.Encode(stream, case_NONEXISTENCE.existenceProof);
                    break;
                }
            }
            public static bodyUnion Decode(XdrReader stream)
            {
                var discriminator = (ArchivalProofType)stream.ReadInt();
                switch (discriminator)
                {
                    case ArchivalProofType.EXISTENCE:
                    var result_EXISTENCE = new bodyUnion_EXISTENCE();
                    result_EXISTENCE.nonexistenceProof = NonexistenceProofBodyXdr.Decode(stream);
                    return result_EXISTENCE;
                    case ArchivalProofType.NONEXISTENCE:
                    var result_NONEXISTENCE = new bodyUnion_NONEXISTENCE();
                    result_NONEXISTENCE.existenceProof = ExistenceProofBodyXdr.Decode(stream);
                    return result_NONEXISTENCE;
                    default:
                    throw new Exception($"Unknown discriminator for bodyUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class ArchivalProofXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ArchivalProof value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ArchivalProofXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ArchivalProof value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.epoch);
            ArchivalProof.bodyUnionXdr.Encode(stream, value.body);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ArchivalProof Decode(XdrReader stream)
        {
            var result = new ArchivalProof();
            result.epoch = uint32Xdr.Decode(stream);
            result.body = ArchivalProof.bodyUnionXdr.Decode(stream);
            return result;
        }
    }
}
