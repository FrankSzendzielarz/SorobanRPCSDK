// Generated code - do not modify
// Source:

// struct RestoreFootprintOp
// {
//     ExtensionPoint ext;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class RestoreFootprintOp
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

        public RestoreFootprintOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class RestoreFootprintOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(RestoreFootprintOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                RestoreFootprintOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, RestoreFootprintOp value)
        {
            value.Validate();
            ExtensionPointXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static RestoreFootprintOp Decode(XdrReader stream)
        {
            var result = new RestoreFootprintOp();
            result.ext = ExtensionPointXdr.Decode(stream);
            return result;
        }
    }
}
