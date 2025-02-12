// Generated code - do not modify
// Source:

// typedef uint64 Duration;


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class Duration
    {
        public uint64 InnerValue
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
        private uint64 _innerValue;

        public Duration() { }

        public Duration(uint64 value)
        {
            InnerValue = value;
        }
        public static implicit operator uint64(Duration _duration) => _duration.InnerValue;
        public static implicit operator Duration(uint64 value) => new Duration(value);
    }
    public static partial class DurationXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(Duration value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                DurationXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, Duration value)
        {
            uint64Xdr.Encode(stream, value.InnerValue);
        }
        public static Duration Decode(XdrReader stream)
        {
            var result = new Duration();
            result.InnerValue = uint64Xdr.Decode(stream);
            return result;
        }
    }
}
