// Generated code - do not modify
// Source:

// struct ShortHashSeed
// {
//     opaque seed[16];
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ShortHashSeed
    {
        public byte[] seed
        {
            get => _seed;
            set
            {
                if (value.Length != 16)
                	throw new ArgumentException($"Must be exactly 16 bytes");
                _seed = value;
            }
        }
        private byte[] _seed = new byte[16];

        public ShortHashSeed()
        {
            seed = new byte[16];
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (seed.Length != 16)
            	throw new InvalidOperationException($"seed must be exactly 16 elements");
        }
    }
    public static partial class ShortHashSeedXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ShortHashSeed value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ShortHashSeedXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ShortHashSeed value)
        {
            value.Validate();
            stream.WriteFixedOpaque(value.seed);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ShortHashSeed Decode(XdrReader stream)
        {
            var result = new ShortHashSeed();
            stream.ReadFixedOpaque(result.seed);
            return result;
        }
    }
}
