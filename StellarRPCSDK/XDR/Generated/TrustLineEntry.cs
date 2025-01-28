// Generated code - do not modify
// Source:

// struct TrustLineEntry
// {
//     AccountID accountID;  // account this trustline belongs to
//     TrustLineAsset asset; // type of asset (with issuer)
//     int64 balance;        // how much of this asset the user has.
//                           // Asset defines the unit for this;
// 
//     int64 limit;  // balance cannot be above this
//     uint32 flags; // see TrustLineFlags
// 
//     // reserved for future use
//     union switch (int v)
//     {
//     case 0:
//         void;
//     case 1:
//         struct
//         {
//             Liabilities liabilities;
// 
//             union switch (int v)
//             {
//             case 0:
//                 void;
//             case 2:
//                 TrustLineEntryExtensionV2 v2;
//             }
//             ext;
//         } v1;
//     }
//     ext;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TrustLineEntry
    {
        private AccountID _accountID;
        public AccountID accountID
        {
            get => _accountID;
            set
            {
                _accountID = value;
            }
        }

        private TrustLineAsset _asset;
        public TrustLineAsset asset
        {
            get => _asset;
            set
            {
                _asset = value;
            }
        }

        private int64 _balance;
        public int64 balance
        {
            get => _balance;
            set
            {
                _balance = value;
            }
        }

        private int64 _limit;
        public int64 limit
        {
            get => _limit;
            set
            {
                _limit = value;
            }
        }

        private uint32 _flags;
        public uint32 flags
        {
            get => _flags;
            set
            {
                _flags = value;
            }
        }

        private object _ext;
        public object ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }

        public TrustLineEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
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
            public override int Discriminator => int.0;

            public override void ValidateCase() {}
        }
        public sealed partial class extUnion_1 : extUnion
        {
            public override int Discriminator => int.1;
            private object _v1;
            public object v1
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
                    Xdr.Encode(stream, case_1.v1);
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
                    result_1.                 = Xdr.Decode(stream);
                    return result_1;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class TrustLineEntryXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TrustLineEntry value)
        {
            value.Validate();
            AccountIDXdr.Encode(stream, value.accountID);
            TrustLineAssetXdr.Encode(stream, value.asset);
            int64Xdr.Encode(stream, value.balance);
            int64Xdr.Encode(stream, value.limit);
            uint32Xdr.Encode(stream, value.flags);
            Xdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TrustLineEntry Decode(XdrReader stream)
        {
            var result = new TrustLineEntry();
            result.accountID = AccountIDXdr.Decode(stream);
            result.asset = TrustLineAssetXdr.Decode(stream);
            result.balance = int64Xdr.Decode(stream);
            result.limit = int64Xdr.Decode(stream);
            result.flags = uint32Xdr.Decode(stream);
            result.ext = Xdr.Decode(stream);
            return result;
        }
    }
}
