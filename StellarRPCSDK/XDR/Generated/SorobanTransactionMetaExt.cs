// Generated code - do not modify
// Source:

// union SorobanTransactionMetaExt switch (int v)
// {
// case 0:
//     void;
// case 1:
//     SorobanTransactionMetaExtV1 v1;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class SorobanTransactionMetaExt
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class SorobanTransactionMetaExt_0 : SorobanTransactionMetaExt
    {
        public override int Discriminator => int.0;

        public override void ValidateCase() {}
    }
    public sealed partial class SorobanTransactionMetaExt_1 : SorobanTransactionMetaExt
    {
        public override int Discriminator => int.1;
        private SorobanTransactionMetaExtV1 _v1;
        public SorobanTransactionMetaExtV1 v1
        {
            get => _v1;
            set
            {
                _v1 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class SorobanTransactionMetaExtXdr
    {
        public static void Encode(XdrWriter stream, SorobanTransactionMetaExt value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SorobanTransactionMetaExt_0 case_0:
                break;
                case SorobanTransactionMetaExt_1 case_1:
                SorobanTransactionMetaExtV1Xdr.Encode(stream, case_1.v1);
                break;
            }
        }
        public static SorobanTransactionMetaExt Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case 0:
                var result_0 = new SorobanTransactionMetaExt_0();
                return result_0;
                case 1:
                var result_1 = new SorobanTransactionMetaExt_1();
                result_1.                 = SorobanTransactionMetaExtV1Xdr.Decode(stream);
                return result_1;
                default:
                throw new Exception($"Unknown discriminator for SorobanTransactionMetaExt: {discriminator}");
            }
        }
    }
}
