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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class LedgerCloseMetaExtV1
    {
        public ExtensionPoint ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }
        private ExtensionPoint _ext;

        public int64 sorobanFeeWrite1KB
        {
            get => _sorobanFeeWrite1KB;
            set
            {
                _sorobanFeeWrite1KB = value;
            }
        }
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
