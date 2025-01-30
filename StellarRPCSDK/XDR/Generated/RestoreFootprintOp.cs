// Generated code - do not modify
// Source:

// struct RestoreFootprintOp
// {
//     ExtensionPoint ext;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class RestoreFootprintOp
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
