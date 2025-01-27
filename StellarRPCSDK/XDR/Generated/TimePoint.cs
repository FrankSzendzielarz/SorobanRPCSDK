// Generated code - do not modify
// Source:

// typedef uint64 TimePoint;


using System;

namespace stellar {

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
    }
    public static partial class TimePointXdr
    {
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
