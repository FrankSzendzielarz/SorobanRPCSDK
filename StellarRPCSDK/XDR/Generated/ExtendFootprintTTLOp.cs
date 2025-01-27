// Generated code - do not modify
// Source:

// struct ExtendFootprintTTLOp
// {
//     ExtensionPoint ext;
//     uint32 extendTo;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ExtendFootprintTTLOp
    {
        private ExtensionPoint _ext;
        public ExtensionPoint ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }

        private uint32 _extendTo;
        public uint32 extendTo
        {
            get => _extendTo;
            set
            {
                _extendTo = value;
            }
        }

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
