// Generated code - do not modify
// Source:

// typedef opaque SCBytes<>;


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class SCBytes
    {
        public byte[] InnerValue
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
        private byte[] _innerValue;

        public SCBytes() { }

        public SCBytes(byte[] value)
        {
            InnerValue = value;
        }
        public static implicit operator byte[](SCBytes _scbytes) => _scbytes.InnerValue;
        public static implicit operator SCBytes(byte[] value) => new SCBytes(value);
    }
    public static partial class SCBytesXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCBytes value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCBytesXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, SCBytes value)
        {
            stream.WriteOpaque(value.InnerValue);
        }
        public static SCBytes Decode(XdrReader stream)
        {
            var result = new SCBytes();
            result.InnerValue = stream.ReadOpaque();
            return result;
        }
    }
}
