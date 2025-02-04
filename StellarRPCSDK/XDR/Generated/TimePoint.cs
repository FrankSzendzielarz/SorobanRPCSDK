// Generated code - do not modify
// Source:

// typedef uint64 TimePoint;


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TimePoint
    {
        private uint64 _innerValue;
        public uint64 InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }

        public TimePoint() { }

        public TimePoint(uint64 value)
        {
            InnerValue = value;
        }
        public static implicit operator uint64(TimePoint _timepoint) => _timepoint.InnerValue;
        public static implicit operator TimePoint(uint64 value) => new TimePoint(value);
    }
    public static partial class TimePointXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TimePoint value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TimePointXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, TimePoint value)
        {
            uint64Xdr.Encode(stream, value.InnerValue);
        }
        public static TimePoint Decode(XdrReader stream)
        {
            var result = new TimePoint();
            result.InnerValue = uint64Xdr.Decode(stream);
            return result;
        }
    }
}
