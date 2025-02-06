// Generated code - do not modify
// Source:

// union LedgerCloseMeta switch (int v)
// {
// case 0:
//     LedgerCloseMetaV0 v0;
// case 1:
//     LedgerCloseMetaV1 v1;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class LedgerCloseMeta
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        public sealed partial class case_0 : LedgerCloseMeta
        {
            public override int Discriminator => 0;
            public LedgerCloseMetaV0 v0
            {
                get => _v0;
                set
                {
                    _v0 = value;
                }
            }
            private LedgerCloseMetaV0 _v0;

            public override void ValidateCase() {}
        }
        public sealed partial class case_1 : LedgerCloseMeta
        {
            public override int Discriminator => 1;
            public LedgerCloseMetaV1 v1
            {
                get => _v1;
                set
                {
                    _v1 = value;
                }
            }
            private LedgerCloseMetaV1 _v1;

            public override void ValidateCase() {}
        }
    }
    public static partial class LedgerCloseMetaXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LedgerCloseMeta value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LedgerCloseMetaXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, LedgerCloseMeta value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case LedgerCloseMeta.case_0 case_0:
                LedgerCloseMetaV0Xdr.Encode(stream, case_0.v0);
                break;
                case LedgerCloseMeta.case_1 case_1:
                LedgerCloseMetaV1Xdr.Encode(stream, case_1.v1);
                break;
            }
        }
        public static LedgerCloseMeta Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case 0:
                var result_0 = new LedgerCloseMeta.case_0();
                result_0.v0 = LedgerCloseMetaV0Xdr.Decode(stream);
                return result_0;
                case 1:
                var result_1 = new LedgerCloseMeta.case_1();
                result_1.v1 = LedgerCloseMetaV1Xdr.Decode(stream);
                return result_1;
                default:
                throw new Exception($"Unknown discriminator for LedgerCloseMeta: {discriminator}");
            }
        }
    }
}
