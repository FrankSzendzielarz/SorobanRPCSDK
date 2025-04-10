// Generated code - do not modify
// Source:

// union Claimant switch (ClaimantType type)
// {
// case CLAIMANT_TYPE_V0:
//     struct
//     {
//         AccountID destination;    // The account that can use this condition
//         ClaimPredicate predicate; // Claimable if predicate is true
//     } v0;
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
    [ProtoInclude(100, typeof(ClaimantTypeV0), DataFormat = DataFormat.Default)]
    public abstract partial class Claimant
    {
        public abstract ClaimantType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "Claimant_v0Struct")]
        public partial class v0Struct
        {
            [ProtoMember(1)]
            public AccountID destination
            {
                get => _destination;
                set
                {
                    _destination = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Destination")]
            #endif
            private AccountID _destination;

            /// <summary>
            /// The account that can use this condition
            /// </summary>
            [ProtoMember(2)]
            public ClaimPredicate predicate
            {
                get => _predicate;
                set
                {
                    _predicate = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Predicate")]
            #endif
            private ClaimPredicate _predicate;

            public v0Struct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class v0StructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(v0Struct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    v0StructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Decodes value from XDR base64 string</summary>
            public static v0Struct DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return v0StructXdr.Decode(reader);
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, v0Struct value)
            {
                value.Validate();
                AccountIDXdr.Encode(stream, value.destination);
                ClaimPredicateXdr.Encode(stream, value.predicate);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static v0Struct Decode(XdrReader stream)
            {
                var result = new v0Struct();
                result.destination = AccountIDXdr.Decode(stream);
                result.predicate = ClaimPredicateXdr.Decode(stream);
                return result;
            }
        }
        [System.Serializable]
        [ProtoContract(Name = "Claimant_ClaimantTypeV0")]
        public sealed partial class ClaimantTypeV0 : Claimant
        {
            public override ClaimantType Discriminator => ClaimantType.CLAIMANT_TYPE_V0;
            [ProtoMember(1)]
            public v0Struct v0
            {
                get => _v0;
                set
                {
                    _v0 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"V0")]
            #endif
            private v0Struct _v0;

            public override void ValidateCase() {}
        }
    }
    public static partial class ClaimantXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(Claimant value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ClaimantXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static Claimant DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ClaimantXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, Claimant value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case Claimant.ClaimantTypeV0 case_CLAIMANT_TYPE_V0:
                Claimant.v0StructXdr.Encode(stream, case_CLAIMANT_TYPE_V0.v0);
                break;
            }
        }
        public static Claimant Decode(XdrReader stream)
        {
            var discriminator = (ClaimantType)stream.ReadInt();
            switch (discriminator)
            {
                case ClaimantType.CLAIMANT_TYPE_V0:
                var result_CLAIMANT_TYPE_V0 = new Claimant.ClaimantTypeV0();
                result_CLAIMANT_TYPE_V0.v0 = Claimant.v0StructXdr.Decode(stream);
                return result_CLAIMANT_TYPE_V0;
                default:
                throw new Exception($"Unknown discriminator for Claimant: {discriminator}");
            }
        }
    }
}
