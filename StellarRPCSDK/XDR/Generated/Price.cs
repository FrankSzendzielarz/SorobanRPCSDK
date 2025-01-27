// Generated code - do not modify
// Source:

// struct Price
// {
//     int32 n; // numerator
//     int32 d; // denominator
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class Price
    {
        private int32 _n;
        public int32 n
        {
            get => _n;
            set
            {
                _n = value;
            }
        }

        private int32 _d;
        public int32 d
        {
            get => _d;
            set
            {
                _d = value;
            }
        }

        public Price()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class PriceXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, Price value)
        {
            value.Validate();
            int32Xdr.Encode(stream, value.n);
            int32Xdr.Encode(stream, value.d);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static Price Decode(XdrReader stream)
        {
            var result = new Price();
            result.n = int32Xdr.Decode(stream);
            result.d = int32Xdr.Decode(stream);
            return result;
        }
    }
}
