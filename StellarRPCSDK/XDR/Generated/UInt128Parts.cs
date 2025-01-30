// Generated code - do not modify
// Source:

// struct UInt128Parts {
//     uint64 hi;
//     uint64 lo;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class UInt128Parts
    {
        private uint64 _hi;
        public uint64 hi
        {
            get => _hi;
            set
            {
                _hi = value;
            }
        }

        private uint64 _lo;
        public uint64 lo
        {
            get => _lo;
            set
            {
                _lo = value;
            }
        }

        public UInt128Parts()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class UInt128PartsXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, UInt128Parts value)
        {
            value.Validate();
            uint64Xdr.Encode(stream, value.hi);
            uint64Xdr.Encode(stream, value.lo);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static UInt128Parts Decode(XdrReader stream)
        {
            var result = new UInt128Parts();
            result.hi = uint64Xdr.Decode(stream);
            result.lo = uint64Xdr.Decode(stream);
            return result;
        }
    }
}
