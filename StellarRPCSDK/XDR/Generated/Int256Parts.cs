// Generated code - do not modify
// Source:

// struct Int256Parts {
//     int64 hi_hi;
//     uint64 hi_lo;
//     uint64 lo_hi;
//     uint64 lo_lo;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class Int256Parts
    {
        private int64 _hi_hi;
        public int64 hi_hi
        {
            get => _hi_hi;
            set
            {
                _hi_hi = value;
            }
        }

        private uint64 _hi_lo;
        public uint64 hi_lo
        {
            get => _hi_lo;
            set
            {
                _hi_lo = value;
            }
        }

        private uint64 _lo_hi;
        public uint64 lo_hi
        {
            get => _lo_hi;
            set
            {
                _lo_hi = value;
            }
        }

        private uint64 _lo_lo;
        public uint64 lo_lo
        {
            get => _lo_lo;
            set
            {
                _lo_lo = value;
            }
        }

        public Int256Parts()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class Int256PartsXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, Int256Parts value)
        {
            value.Validate();
            int64Xdr.Encode(stream, value.hi_hi);
            uint64Xdr.Encode(stream, value.hi_lo);
            uint64Xdr.Encode(stream, value.lo_hi);
            uint64Xdr.Encode(stream, value.lo_lo);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static Int256Parts Decode(XdrReader stream)
        {
            var result = new Int256Parts();
            result.hi_hi = int64Xdr.Decode(stream);
            result.hi_lo = uint64Xdr.Decode(stream);
            result.lo_hi = uint64Xdr.Decode(stream);
            result.lo_lo = uint64Xdr.Decode(stream);
            return result;
        }
    }
}
