// Generated code - do not modify
// Source:

// typedef PeerStats PeerStatList<25>;


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class PeerStatList
    {
        private PeerStats[] _innerValue;
        public PeerStats[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length > 25)
                	throw new ArgumentException($"Cannot exceed 25 bytes");
                _innerValue = value;
            }
        }

        public PeerStatList() { }

        public PeerStatList(PeerStats[] value)
        {
            InnerValue = value;
        }
    }
    public static partial class PeerStatListXdr
    {
            public static void Encode(XdrWriter stream, PeerStatList value)
        {
            stream.WriteInt(value.InnerValue.Length);
            foreach (var item in value.InnerValue)
            {
                    PeerStatsXdr.Encode(stream, item);
            }
        }
        public static PeerStatList Decode(XdrReader stream)
        {
            var result = new PeerStatList();
            {
                var length = stream.ReadInt();
                result.InnerValue = new PeerStats[length];
                for (var i = 0; i < length; i++)
                {
                    result.InnerValue[i] = PeerStatsXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
