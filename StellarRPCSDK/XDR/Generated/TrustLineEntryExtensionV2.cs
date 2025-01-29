// Generated code - do not modify
// Source:

// struct TrustLineEntryExtensionV2
// {
//     int32 liquidityPoolUseCount;
// 
//     union switch (int v)
//     {
//     case 0:
//         void;
//     }
//     ext;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TrustLineEntryExtensionV2
    {
        private int32 _liquidityPoolUseCount;
        public int32 liquidityPoolUseCount
        {
            get => _liquidityPoolUseCount;
            set
            {
                _liquidityPoolUseCount = value;
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

        public TrustLineEntryExtensionV2()
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
            public override int Discriminator => 0;

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
    public static partial class TrustLineEntryExtensionV2Xdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TrustLineEntryExtensionV2 value)
        {
            value.Validate();
            int32Xdr.Encode(stream, value.liquidityPoolUseCount);
            TrustLineEntryExtensionV2.extUnionXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TrustLineEntryExtensionV2 Decode(XdrReader stream)
        {
            var result = new TrustLineEntryExtensionV2();
            result.liquidityPoolUseCount = int32Xdr.Decode(stream);
            result.ext = TrustLineEntryExtensionV2.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
