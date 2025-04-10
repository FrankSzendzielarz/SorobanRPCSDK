// Generated code - do not modify
// Source:

// struct ShortHashSeed
// {
//     opaque seed[16];
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class ShortHashSeed
    {
        [ProtoMember(1, OverwriteList = true)]
        [MinLength(16)]
        [MaxLength(16)]
        public byte[] seed
        {
            get => _seed;
            set
            {
                if (value.Length != 16)
                	throw new ArgumentException($"Must be exactly 16 in length");
                _seed = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Seed")]
        #endif
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
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ShortHashSeed DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ShortHashSeedXdr.Decode(reader);
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
