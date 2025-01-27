// Generated code - do not modify
// Source:

// typedef TimeSlicedPeerData TimeSlicedPeerDataList<25>;


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TimeSlicedPeerDataList
    {
        private TimeSlicedPeerData[] _innerValue;
        public TimeSlicedPeerData[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length > 25)
                	throw new ArgumentException($"Cannot exceed 25 bytes");
                _innerValue = value;
            }
        }

        public TimeSlicedPeerDataList() { }

        public TimeSlicedPeerDataList(TimeSlicedPeerData[] value)
        {
            InnerValue = value;
        }
    }
    public static partial class TimeSlicedPeerDataListXdr
    {
            public static void Encode(XdrWriter stream, TimeSlicedPeerDataList value)
        {
            stream.WriteInt(value.InnerValue.Length);
            foreach (var item in value.InnerValue)
            {
                    TimeSlicedPeerDataXdr.Encode(stream, item);
            }
        }
        public static TimeSlicedPeerDataList Decode(XdrReader stream)
        {
            var result = new TimeSlicedPeerDataList();
            var length = stream.ReadInt();
            result.InnerValue = new TimeSlicedPeerData[length];
            for (var i = 0; i < length; i++)
            {
                result.InnerValue[i] = TimeSlicedPeerDataXdr.Decode(stream);
            }
            return result;
        }
    }
}
