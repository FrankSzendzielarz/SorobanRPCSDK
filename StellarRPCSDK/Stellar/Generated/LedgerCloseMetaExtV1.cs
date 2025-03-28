// Generated code - do not modify
// Source:

// struct LedgerCloseMetaExtV1
// {
//     ExtensionPoint ext;
//     int64 sorobanFeeWrite1KB;
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
    public partial class LedgerCloseMetaExtV1
    {
        [ProtoMember(1)]
        public ExtensionPoint ext
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
        private ExtensionPoint _ext;

        [ProtoMember(2)]
        public int64 sorobanFeeWrite1KB
        {
            get => _sorobanFeeWrite1KB;
            set
            {
                _sorobanFeeWrite1KB = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Soroban Fee Write1 K B")]
        #endif
        private int64 _sorobanFeeWrite1KB;

        public LedgerCloseMetaExtV1()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class LedgerCloseMetaExtV1Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LedgerCloseMetaExtV1 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LedgerCloseMetaExtV1Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static LedgerCloseMetaExtV1 DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return LedgerCloseMetaExtV1Xdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, LedgerCloseMetaExtV1 value)
        {
            value.Validate();
            ExtensionPointXdr.Encode(stream, value.ext);
            int64Xdr.Encode(stream, value.sorobanFeeWrite1KB);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static LedgerCloseMetaExtV1 Decode(XdrReader stream)
        {
            var result = new LedgerCloseMetaExtV1();
            result.ext = ExtensionPointXdr.Decode(stream);
            result.sorobanFeeWrite1KB = int64Xdr.Decode(stream);
            return result;
        }
    }
}
