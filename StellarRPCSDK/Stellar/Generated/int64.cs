// Generated code - do not modify
// Source:

// typedef hyper int64;


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class int64
    {
        public long InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inner Value")]
        #endif
        private long _innerValue;

        public int64() { }

        public int64(long value)
        {
            InnerValue = value;
        }
        public static implicit operator long(int64 _int64) => _int64.InnerValue;
        public static implicit operator int64(long value) => new int64(value);
    }
    public static partial class int64Xdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(int64 value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                int64Xdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, int64 value)
        {
            stream.WriteLong(value.InnerValue);
        }
        public static int64 Decode(XdrReader stream)
        {
            var result = new int64();
            result.InnerValue = stream.ReadLong();
            return result;
        }
    }
}
