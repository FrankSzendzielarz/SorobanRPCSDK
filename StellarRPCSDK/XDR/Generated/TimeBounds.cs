// Generated code - do not modify
// Source:

// struct TimeBounds
// {
//     TimePoint minTime;
//     TimePoint maxTime; // 0 here means no maxTime
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TimeBounds
    {
        private TimePoint _minTime;
        public TimePoint minTime
        {
            get => _minTime;
            set
            {
                _minTime = value;
            }
        }

        private TimePoint _maxTime;
        public TimePoint maxTime
        {
            get => _maxTime;
            set
            {
                _maxTime = value;
            }
        }

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
