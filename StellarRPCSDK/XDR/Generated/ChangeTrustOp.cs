// Generated code - do not modify
// Source:

// struct ChangeTrustOp
// {
//     ChangeTrustAsset line;
// 
//     // if limit is set to 0, deletes the trust line
//     int64 limit;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ChangeTrustOp
    {
        private ChangeTrustAsset _line;
        public ChangeTrustAsset line
        {
            get => _line;
            set
            {
                _line = value;
            }
        }

        private int64 _limit;
        public int64 limit
        {
            get => _limit;
            set
            {
                _limit = value;
            }
        }

        public ChangeTrustOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ChangeTrustOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ChangeTrustOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ChangeTrustOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ChangeTrustOp value)
        {
            value.Validate();
            ChangeTrustAssetXdr.Encode(stream, value.line);
            int64Xdr.Encode(stream, value.limit);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ChangeTrustOp Decode(XdrReader stream)
        {
            var result = new ChangeTrustOp();
            result.line = ChangeTrustAssetXdr.Decode(stream);
            result.limit = int64Xdr.Decode(stream);
            return result;
        }
    }
}
