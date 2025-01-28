// Generated code - do not modify
// Source:

// struct ClaimableBalanceEntryExtensionV1
// {
//     union switch (int v)
//     {
//     case 0:
//         void;
//     }
//     ext;
// 
//     uint32 flags; // see ClaimableBalanceFlags
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ClaimableBalanceEntryExtensionV1
    {
        private object _ext;
        public object ext
        {
            get => _ext;
            set
            {
                _ext = value;
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

        public ClaimableBalanceEntryExtensionV1()
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
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class ClaimableBalanceEntryExtensionV1Xdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ClaimableBalanceEntryExtensionV1 value)
        {
            value.Validate();
            Xdr.Encode(stream, value.ext);
            uint32Xdr.Encode(stream, value.flags);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ClaimableBalanceEntryExtensionV1 Decode(XdrReader stream)
        {
            var result = new ClaimableBalanceEntryExtensionV1();
            result.ext = Xdr.Decode(stream);
            result.flags = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
