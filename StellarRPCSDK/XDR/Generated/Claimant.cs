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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class Claimant
    {
        public abstract ClaimantType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class Claimant_CLAIMANT_TYPE_V0 : Claimant
    {
        public override ClaimantType Discriminator => CLAIMANT_TYPE_V0;
        private object _v0;
        public object v0
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
                Xdr.Encode(stream, case_CLAIMANT_TYPE_V0.v0);
                break;
            }
        }
        public static Claimant Decode(XdrReader stream)
        {
            var discriminator = (ClaimantType)stream.ReadInt();
            switch (discriminator)
            {
                case CLAIMANT_TYPE_V0:
                var result_CLAIMANT_TYPE_V0 = new Claimant_CLAIMANT_TYPE_V0();
                result_CLAIMANT_TYPE_V0.                 = Xdr.Decode(stream);
                return result_CLAIMANT_TYPE_V0;
                default:
                throw new Exception($"Unknown discriminator for Claimant: {discriminator}");
            }
        }
    }
}
