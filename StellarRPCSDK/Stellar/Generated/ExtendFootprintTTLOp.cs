// Generated code - do not modify
// Source:

// struct ExtendFootprintTTLOp
// {
//     ExtensionPoint ext;
//     uint32 extendTo;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ExtendFootprintTTLOp
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

        public uint32 extendTo
        {
            get => _extendTo;
            set
            {
                _extendTo = value;
            }
        }
        private uint32 _extendTo;

        public ExtendFootprintTTLOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ExtendFootprintTTLOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ExtendFootprintTTLOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ExtendFootprintTTLOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ExtendFootprintTTLOp value)
        {
            value.Validate();
            ExtensionPointXdr.Encode(stream, value.ext);
            uint32Xdr.Encode(stream, value.extendTo);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ExtendFootprintTTLOp Decode(XdrReader stream)
        {
            var result = new ExtendFootprintTTLOp();
            result.ext = ExtensionPointXdr.Decode(stream);
            result.extendTo = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
