// Generated code - do not modify
// Source:

// struct LedgerHeaderExtensionV1
// {
//     uint32 flags; // LedgerHeaderFlags
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
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class LedgerHeaderExtensionV1
    {
        public uint32 flags
        {
            get => _flags;
            set
            {
                _flags = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Flags")]
        #endif
        private uint32 _flags;

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

        public LedgerHeaderExtensionV1()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.Serializable]
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
    public static partial class LedgerHeaderExtensionV1Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LedgerHeaderExtensionV1 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LedgerHeaderExtensionV1Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, LedgerHeaderExtensionV1 value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.flags);
            LedgerHeaderExtensionV1.extUnionXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static LedgerHeaderExtensionV1 Decode(XdrReader stream)
        {
            var result = new LedgerHeaderExtensionV1();
            result.flags = uint32Xdr.Decode(stream);
            result.ext = LedgerHeaderExtensionV1.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
