// Generated code - do not modify
// Source:

// struct AccountEntryExtensionV1
// {
//     Liabilities liabilities;
// 
//     union switch (int v)
//     {
//     case 0:
//         void;
//     case 2:
//         AccountEntryExtensionV2 v2;
//     }
//     ext;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class AccountEntryExtensionV1
    {
        private Liabilities _liabilities;
        public Liabilities liabilities
        {
            get => _liabilities;
            set
            {
                _liabilities = value;
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

        public AccountEntryExtensionV1()
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
        public sealed partial class extUnion_2 : extUnion
        {
            public override int Discriminator => int.2;
            private AccountEntryExtensionV2 _v2;
            public AccountEntryExtensionV2 v2
            {
                get => _v2;
                set
                {
                    _v2 = value;
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
                    case extUnion_2 case_2:
                    AccountEntryExtensionV2Xdr.Encode(stream, case_2.v2);
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
                    case 2:
                    var result_2 = new extUnion_2();
                    result_2.                 = AccountEntryExtensionV2Xdr.Decode(stream);
                    return result_2;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class AccountEntryExtensionV1Xdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, AccountEntryExtensionV1 value)
        {
            value.Validate();
            LiabilitiesXdr.Encode(stream, value.liabilities);
            Xdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static AccountEntryExtensionV1 Decode(XdrReader stream)
        {
            var result = new AccountEntryExtensionV1();
            result.liabilities = LiabilitiesXdr.Decode(stream);
            result.ext = Xdr.Decode(stream);
            return result;
        }
    }
}
