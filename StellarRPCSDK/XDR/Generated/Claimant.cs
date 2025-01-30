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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class Claimant
    {
        public abstract ClaimantType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public partial class v0Struct
        {
            private AccountID _destination;
            public AccountID destination
            {
                get => _destination;
                set
                {
                    _destination = value;
                }
            }

            private ClaimPredicate _predicate;
            public ClaimPredicate predicate
            {
                get => _predicate;
                set
                {
                    _predicate = value;
                }
            }

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
    }
    public sealed partial class Claimant_CLAIMANT_TYPE_V0 : Claimant
    {
        public override ClaimantType Discriminator => ClaimantType.CLAIMANT_TYPE_V0;
        private v0Struct _v0;
        public v0Struct v0
        {
            get => _v0;
            set
            {
                _v0 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class ClaimantXdr
    {
        public static void Encode(XdrWriter stream, Claimant value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case Claimant_CLAIMANT_TYPE_V0 case_CLAIMANT_TYPE_V0:
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
                var result_CLAIMANT_TYPE_V0 = new Claimant_CLAIMANT_TYPE_V0();
                result_CLAIMANT_TYPE_V0.v0 = Claimant.v0StructXdr.Decode(stream);
                return result_CLAIMANT_TYPE_V0;
                default:
                throw new Exception($"Unknown discriminator for Claimant: {discriminator}");
            }
        }
    }
}
