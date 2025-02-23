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
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class ArchivalProof
    {
        [ProtoMember(1)]
        public uint32 epoch
        {
            get => _epoch;
            set
            {
                _epoch = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Epoch")]
        #endif
        private uint32 _epoch;

        [ProtoMember(2)]
        public bodyUnion body
        {
            get => _body;
            set
            {
                _body = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Body")]
        #endif
        private bodyUnion _body;

        public ArchivalProof()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "ArchivalProof.bodyUnion")]
        [ProtoInclude(100, typeof(Existence), DataFormat = DataFormat.Default)]
        [ProtoInclude(101, typeof(Nonexistence), DataFormat = DataFormat.Default)]
        public abstract partial class bodyUnion
        {
            public abstract ArchivalProofType Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.Serializable]
            [ProtoContract(Name = "ArchivalProof.bodyUnion.Existence")]
            public sealed partial class Existence : bodyUnion
            {
                public override ArchivalProofType Discriminator => ArchivalProofType.EXISTENCE;
                [ProtoMember(1)]
                public NonexistenceProofBody nonexistenceProof
                {
                    get => _nonexistenceProof;
                    set
                    {
                        _nonexistenceProof = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Nonexistence Proof")]
                #endif
                private NonexistenceProofBody _nonexistenceProof;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "ArchivalProof.bodyUnion.Nonexistence")]
            public sealed partial class Nonexistence : bodyUnion
            {
                public override ArchivalProofType Discriminator => ArchivalProofType.NONEXISTENCE;
                [ProtoMember(2)]
                public ExistenceProofBody existenceProof
                {
                    get => _existenceProof;
                    set
                    {
                        _existenceProof = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Existence Proof")]
                #endif
                private ExistenceProofBody _existenceProof;

                public override void ValidateCase() {}
            }
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
            /// <summary>Decodes value from XDR base64 string</summary>
            public static bodyUnion DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return bodyUnionXdr.Decode(reader);
                }
            }
            public static void Encode(XdrWriter stream, bodyUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case bodyUnion.Existence case_EXISTENCE:
                    NonexistenceProofBodyXdr.Encode(stream, case_EXISTENCE.nonexistenceProof);
                    break;
                    case bodyUnion.Nonexistence case_NONEXISTENCE:
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
                    var result_EXISTENCE = new bodyUnion.Existence();
                    result_EXISTENCE.nonexistenceProof = NonexistenceProofBodyXdr.Decode(stream);
                    return result_EXISTENCE;
                    case ArchivalProofType.NONEXISTENCE:
                    var result_NONEXISTENCE = new bodyUnion.Nonexistence();
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
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ArchivalProof DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ArchivalProofXdr.Decode(reader);
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
