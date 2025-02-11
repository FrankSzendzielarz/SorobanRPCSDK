// Generated code - do not modify
// Source:

// struct TimeBounds
// {
//     TimePoint minTime;
//     TimePoint maxTime; // 0 here means no maxTime
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class TimeBounds
    {
        public TimePoint minTime
        {
            get => _minTime;
            set
            {
                _minTime = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Min Time")]
        #endif
        private TimePoint _minTime;

        public TimePoint maxTime
        {
            get => _maxTime;
            set
            {
                _maxTime = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Max Time")]
        #endif
        private TimePoint _maxTime;

        public TimeBounds()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class TimeBoundsXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TimeBounds value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TimeBoundsXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TimeBounds value)
        {
            value.Validate();
            TimePointXdr.Encode(stream, value.minTime);
            TimePointXdr.Encode(stream, value.maxTime);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TimeBounds Decode(XdrReader stream)
        {
            var result = new TimeBounds();
            result.minTime = TimePointXdr.Decode(stream);
            result.maxTime = TimePointXdr.Decode(stream);
            return result;
        }
    }
}
