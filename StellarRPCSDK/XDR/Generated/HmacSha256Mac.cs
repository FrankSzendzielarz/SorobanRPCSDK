// Generated code - do not modify
// Source:

// struct HmacSha256Mac
// {
//     opaque mac[32];
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class HmacSha256Mac
    {
        [MinLength(32)]
        [MaxLength(32)]
        public byte[] mac
        {
            get => _mac;
            set
            {
                if (value.Length != 32)
                	throw new ArgumentException($"Must be exactly 32 in length");
                _mac = value;
            }
        }
        private byte[] _mac = new byte[32];

        public HmacSha256Mac()
        {
            mac = new byte[32];
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (mac.Length != 32)
            	throw new InvalidOperationException($"mac must be exactly 32 elements");
        }
    }
    public static partial class HmacSha256MacXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(HmacSha256Mac value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                HmacSha256MacXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, HmacSha256Mac value)
        {
            value.Validate();
            stream.WriteFixedOpaque(value.mac);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static HmacSha256Mac Decode(XdrReader stream)
        {
            var result = new HmacSha256Mac();
            stream.ReadFixedOpaque(result.mac);
            return result;
        }
    }
}
