// Generated code - do not modify
// Source:

// struct Curve25519Secret
// {
//     opaque key[32];
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class Curve25519Secret
    {
        private byte[] _key = new byte[32];
        public byte[] key
        {
            get => _key;
            set
            {
                if (value.Length != 32)
                	throw new ArgumentException($"Must be exactly 32 bytes");
                _key = value;
            }
        }

        public Curve25519Secret()
        {
            key = new byte[32];
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (key.Length != 32)
            	throw new InvalidOperationException($"key must be exactly 32 elements");
        }
    }
    public static partial class Curve25519SecretXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, Curve25519Secret value)
        {
            value.Validate();
            stream.WriteFixedOpaque(value.key);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static Curve25519Secret Decode(XdrReader stream)
        {
            var result = new Curve25519Secret();
            stream.ReadFixedOpaque(result.key);
            return result;
        }
    }
}
