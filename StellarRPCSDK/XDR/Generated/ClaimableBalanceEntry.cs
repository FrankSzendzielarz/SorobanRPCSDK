// Generated code - do not modify
// Source:

// struct ClaimableBalanceEntry
// {
//     // Unique identifier for this ClaimableBalanceEntry
//     ClaimableBalanceID balanceID;
// 
//     // List of claimants with associated predicate
//     Claimant claimants<10>;
// 
//     // Any asset including native
//     Asset asset;
// 
//     // Amount of asset
//     int64 amount;
// 
//     // reserved for future use
//     union switch (int v)
//     {
//     case 0:
//         void;
//     case 1:
//         ClaimableBalanceEntryExtensionV1 v1;
//     }
//     ext;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ClaimableBalanceEntry
    {
        private ClaimableBalanceID _balanceID;
        public ClaimableBalanceID balanceID
        {
            get => _balanceID;
            set
            {
                _balanceID = value;
            }
        }

        private Claimant[] _claimants;
        public Claimant[] claimants
        {
            get => _claimants;
            set
            {
                if (value.Length > 10)
                	throw new ArgumentException($"Cannot exceed 10 bytes");
                _claimants = value;
            }
        }

        private Asset _asset;
        public Asset asset
        {
            get => _asset;
            set
            {
                _asset = value;
            }
        }

        private int64 _amount;
        public int64 amount
        {
            get => _amount;
            set
            {
                _amount = value;
            }
        }

        private extUnion _ext;
        public extUnion ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }

        public ClaimableBalanceEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (claimants.Length > 10)
            	throw new InvalidOperationException($"claimants cannot exceed 10 elements");
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

        }
        public sealed partial class extUnion_0 : extUnion
        {
            public override int Discriminator => 0;

            public override void ValidateCase() {}
        }
        public sealed partial class extUnion_1 : extUnion
        {
            public override int Discriminator => 1;
            private ClaimableBalanceEntryExtensionV1 _v1;
            public ClaimableBalanceEntryExtensionV1 v1
            {
                get => _v1;
                set
                {
                    _v1 = value;
                }
            }

            public override void ValidateCase() {}
        }
        public static partial class extUnionXdr
        {
            public static void Encode(XdrWriter stream, extUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case extUnion_0 case_0:
                    break;
                    case extUnion_1 case_1:
                    ClaimableBalanceEntryExtensionV1Xdr.Encode(stream, case_1.v1);
                    break;
                }
            }
            public static extUnion Decode(XdrReader stream)
            {
                var discriminator = (int)stream.ReadInt();
                switch (discriminator)
                {
                    case 0:
                    var result_0 = new extUnion_0();
                    return result_0;
                    case 1:
                    var result_1 = new extUnion_1();
                    result_1.v1 = ClaimableBalanceEntryExtensionV1Xdr.Decode(stream);
                    return result_1;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class ClaimableBalanceEntryXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ClaimableBalanceEntry value)
        {
            value.Validate();
            ClaimableBalanceIDXdr.Encode(stream, value.balanceID);
            stream.WriteInt(value.claimants.Length);
            foreach (var item in value.claimants)
            {
                    ClaimantXdr.Encode(stream, item);
            }
            AssetXdr.Encode(stream, value.asset);
            int64Xdr.Encode(stream, value.amount);
            ClaimableBalanceEntry.extUnionXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ClaimableBalanceEntry Decode(XdrReader stream)
        {
            var result = new ClaimableBalanceEntry();
            result.balanceID = ClaimableBalanceIDXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.claimants = new Claimant[length];
                for (var i = 0; i < length; i++)
                {
                    result.claimants[i] = ClaimantXdr.Decode(stream);
                }
            }
            result.asset = AssetXdr.Decode(stream);
            result.amount = int64Xdr.Decode(stream);
            result.ext = ClaimableBalanceEntry.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
