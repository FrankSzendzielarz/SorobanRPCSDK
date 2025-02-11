// Generated code - do not modify
// Source:

// typedef unsigned int uint32;


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class uint32
    {
        public uint InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Inner Value")]
        #endif
        private uint _innerValue;

        public uint32() { }

        public uint32(uint value)
        {
            InnerValue = value;
        }
        public static implicit operator uint(uint32 _uint32) => _uint32.InnerValue;
        public static implicit operator uint32(uint value) => new uint32(value);
    }
    public static partial class uint32Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(uint32 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                uint32Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, uint32 value)
        {
            stream.WriteUInt(value.InnerValue);
        }
        public static uint32 Decode(XdrReader stream)
        {
            var result = new uint32();
            result.InnerValue = stream.ReadUInt();
            return result;
        }
    }
}
