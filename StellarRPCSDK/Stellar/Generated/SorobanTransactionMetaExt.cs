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
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    [ProtoInclude(100, typeof(case_0), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(case_1), DataFormat = DataFormat.Default)]
    public abstract partial class SorobanTransactionMetaExt
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "SorobanTransactionMetaExt_case_0")]
        public sealed partial class case_0 : SorobanTransactionMetaExt
        {
            public override int Discriminator => 0;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SorobanTransactionMetaExt_case_1")]
        public sealed partial class case_1 : SorobanTransactionMetaExt
        {
            public override int Discriminator => 1;
            [ProtoMember(1)]
            public SorobanTransactionMetaExtV1 v1
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
            private SorobanTransactionMetaExtV1 _v1;

            public override void ValidateCase() {}
        }
    }
    public static partial class SorobanTransactionMetaExtXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SorobanTransactionMetaExt value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SorobanTransactionMetaExtXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SorobanTransactionMetaExt DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SorobanTransactionMetaExtXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, SorobanTransactionMetaExt value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SorobanTransactionMetaExt.case_0 case_0:
                break;
                case SorobanTransactionMetaExt.case_1 case_1:
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
                var result_0 = new SorobanTransactionMetaExt.case_0();
                return result_0;
                case 1:
                var result_1 = new SorobanTransactionMetaExt.case_1();
                result_1.v1 = SorobanTransactionMetaExtV1Xdr.Decode(stream);
                return result_1;
                default:
                throw new Exception($"Unknown discriminator for SorobanTransactionMetaExt: {discriminator}");
            }
        }
    }
}
