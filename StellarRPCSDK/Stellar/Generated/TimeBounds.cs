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
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class TimeBounds
    {
        [ProtoMember(1)]
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
        	[SerializeReference]
        	[InspectorName(@"Min Time")]
        #endif
        private TimePoint _minTime;

        [ProtoMember(2)]
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
        	[SerializeReference]
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
        /// <summary>Decodes value from XDR base64 string</summary>
        public static TimeBounds DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return TimeBoundsXdr.Decode(reader);
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
