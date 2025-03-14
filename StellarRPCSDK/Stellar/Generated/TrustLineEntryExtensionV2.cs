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
    public partial class TrustLineEntryExtensionV2
    {
        [ProtoMember(1)]
        public int32 liquidityPoolUseCount
        {
            get => _liquidityPoolUseCount;
            set
            {
                _liquidityPoolUseCount = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Liquidity Pool Use Count")]
        #endif
        private int32 _liquidityPoolUseCount;

        [ProtoMember(2)]
        public extUnion ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Ext")]
        #endif
        private extUnion _ext;

        public TrustLineEntryExtensionV2()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "TrustLineEntryExtensionV2_extUnion")]
        [ProtoInclude(100, typeof(case_0), DataFormat = DataFormat.Default)]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.Serializable]
            [ProtoContract(Name = "TrustLineEntryExtensionV2_extUnion_case_0")]
            public sealed partial class case_0 : extUnion
            {
                public override int Discriminator => 0;

                public override void ValidateCase() {}
            }
        }
        public static partial class extUnionXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(extUnion value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    extUnionXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Decodes value from XDR base64 string</summary>
            public static extUnion DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return extUnionXdr.Decode(reader);
                }
            }
            public static void Encode(XdrWriter stream, extUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case extUnion.case_0 case_0:
                    break;
                }
            }
            public static extUnion Decode(XdrReader stream)
            {
                var discriminator = (int)stream.ReadInt();
                switch (discriminator)
                {
                    case 0:
                    var result_0 = new extUnion.case_0();
                    return result_0;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class TrustLineEntryExtensionV2Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TrustLineEntryExtensionV2 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TrustLineEntryExtensionV2Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static TrustLineEntryExtensionV2 DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return TrustLineEntryExtensionV2Xdr.Decode(reader);
            }
        }
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
