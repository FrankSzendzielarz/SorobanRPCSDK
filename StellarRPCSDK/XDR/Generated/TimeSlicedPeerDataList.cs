// Generated code - do not modify
// Source:

// typedef TimeSlicedPeerData TimeSlicedPeerDataList<25>;


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TimeSlicedPeerDataList
    {
        [MaxLength(25)]
        public TimeSlicedPeerData[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length > 25)
                	throw new ArgumentException($"Cannot exceed 25 in length");
                _innerValue = value;
            }
        }
        private TimeSlicedPeerData[] _innerValue;

        public TimeSlicedPeerDataList() { }

        public TimeSlicedPeerDataList(TimeSlicedPeerData[] value)
        {
            InnerValue = value;
        }
        public static implicit operator TimeSlicedPeerData[](TimeSlicedPeerDataList _timeslicedpeerdatalist) => _timeslicedpeerdatalist.InnerValue;
        public static implicit operator TimeSlicedPeerDataList(TimeSlicedPeerData[] value) => new TimeSlicedPeerDataList(value);
    }
    public static partial class TimeSlicedPeerDataListXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TimeSlicedPeerDataList value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TimeSlicedPeerDataListXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
            {
                var length = stream.ReadInt();
                result.InnerValue = new TimeSlicedPeerData[length];
                for (var i = 0; i < length; i++)
                {
                    result.InnerValue[i] = TimeSlicedPeerDataXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
