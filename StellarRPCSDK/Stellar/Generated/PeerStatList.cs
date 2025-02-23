// Generated code - do not modify
// Source:

// typedef PeerStats PeerStatList<25>;


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
    public partial class PeerStatList
    {
        [ProtoMember(1, OverwriteList = true)]
        [MaxLength(25)]
        public PeerStats[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length > 25)
                	throw new ArgumentException($"Cannot exceed 25 in length");
                _innerValue = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Inner Value")]
        #endif
        private PeerStats[] _innerValue;

        public PeerStatList() { }

        public PeerStatList(PeerStats[] value)
        {
            InnerValue = value;
        }
        public static implicit operator PeerStats[](PeerStatList _peerstatlist) => _peerstatlist.InnerValue;
        public static implicit operator PeerStatList(PeerStats[] value) => new PeerStatList(value);
    }
    public static partial class PeerStatListXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(PeerStatList value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                PeerStatListXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static PeerStatList DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return PeerStatListXdr.Decode(reader);
            }
        }
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
