// Generated code - do not modify
// Source:

// union LedgerCloseMetaExt switch (int v)
// {
// case 0:
//     void;
// case 1:
//     LedgerCloseMetaExtV1 v1;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public abstract partial class LedgerCloseMetaExt
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        public sealed partial class case_0 : LedgerCloseMetaExt
        {
            public override int Discriminator => 0;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class case_1 : LedgerCloseMetaExt
        {
            public override int Discriminator => 1;
            public LedgerCloseMetaExtV1 v1
            {
                get => _v1;
                set
                {
                    _v1 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"V1")]
            #endif
            private LedgerCloseMetaExtV1 _v1;

            public override void ValidateCase() {}
        }
    }
    public static partial class LedgerCloseMetaExtXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LedgerCloseMetaExt value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LedgerCloseMetaExtXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, LedgerCloseMetaExt value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case LedgerCloseMetaExt.case_0 case_0:
                break;
                case LedgerCloseMetaExt.case_1 case_1:
                LedgerCloseMetaExtV1Xdr.Encode(stream, case_1.v1);
                break;
            }
        }
        public static LedgerCloseMetaExt Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case 0:
                var result_0 = new LedgerCloseMetaExt.case_0();
                return result_0;
                case 1:
                var result_1 = new LedgerCloseMetaExt.case_1();
                result_1.v1 = LedgerCloseMetaExtV1Xdr.Decode(stream);
                return result_1;
                default:
                throw new Exception($"Unknown discriminator for LedgerCloseMetaExt: {discriminator}");
            }
        }
    }
}
