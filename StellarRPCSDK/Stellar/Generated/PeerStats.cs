// Generated code - do not modify
// Source:

// struct PeerStats
// {
//     NodeID id;
//     string versionStr<100>;
//     uint64 messagesRead;
//     uint64 messagesWritten;
//     uint64 bytesRead;
//     uint64 bytesWritten;
//     uint64 secondsConnected;
// 
//     uint64 uniqueFloodBytesRecv;
//     uint64 duplicateFloodBytesRecv;
//     uint64 uniqueFetchBytesRecv;
//     uint64 duplicateFetchBytesRecv;
// 
//     uint64 uniqueFloodMessageRecv;
//     uint64 duplicateFloodMessageRecv;
//     uint64 uniqueFetchMessageRecv;
//     uint64 duplicateFetchMessageRecv;
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
    public partial class PeerStats
    {
        [ProtoMember(1)]
        public NodeID id
        {
            get => _id;
            set
            {
                _id = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Id")]
        #endif
        private NodeID _id;

        [ProtoMember(2)]
        [MaxLength(100)]
        public string versionStr
        {
            get => _versionStr;
            set
            {
                if (System.Text.Encoding.ASCII.GetByteCount(value) > 100)
                	throw new ArgumentException($"String exceeds 100 bytes when ASCII encoded");
                _versionStr = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Version Str")]
        #endif
        private string _versionStr;

        [ProtoMember(3)]
        public uint64 messagesRead
        {
            get => _messagesRead;
            set
            {
                _messagesRead = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Messages Read")]
        #endif
        private uint64 _messagesRead;

        [ProtoMember(4)]
        public uint64 messagesWritten
        {
            get => _messagesWritten;
            set
            {
                _messagesWritten = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Messages Written")]
        #endif
        private uint64 _messagesWritten;

        [ProtoMember(5)]
        public uint64 bytesRead
        {
            get => _bytesRead;
            set
            {
                _bytesRead = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Bytes Read")]
        #endif
        private uint64 _bytesRead;

        [ProtoMember(6)]
        public uint64 bytesWritten
        {
            get => _bytesWritten;
            set
            {
                _bytesWritten = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Bytes Written")]
        #endif
        private uint64 _bytesWritten;

        [ProtoMember(7)]
        public uint64 secondsConnected
        {
            get => _secondsConnected;
            set
            {
                _secondsConnected = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Seconds Connected")]
        #endif
        private uint64 _secondsConnected;

        [ProtoMember(8)]
        public uint64 uniqueFloodBytesRecv
        {
            get => _uniqueFloodBytesRecv;
            set
            {
                _uniqueFloodBytesRecv = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Unique Flood Bytes Recv")]
        #endif
        private uint64 _uniqueFloodBytesRecv;

        [ProtoMember(9)]
        public uint64 duplicateFloodBytesRecv
        {
            get => _duplicateFloodBytesRecv;
            set
            {
                _duplicateFloodBytesRecv = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Duplicate Flood Bytes Recv")]
        #endif
        private uint64 _duplicateFloodBytesRecv;

        [ProtoMember(10)]
        public uint64 uniqueFetchBytesRecv
        {
            get => _uniqueFetchBytesRecv;
            set
            {
                _uniqueFetchBytesRecv = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Unique Fetch Bytes Recv")]
        #endif
        private uint64 _uniqueFetchBytesRecv;

        [ProtoMember(11)]
        public uint64 duplicateFetchBytesRecv
        {
            get => _duplicateFetchBytesRecv;
            set
            {
                _duplicateFetchBytesRecv = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Duplicate Fetch Bytes Recv")]
        #endif
        private uint64 _duplicateFetchBytesRecv;

        [ProtoMember(12)]
        public uint64 uniqueFloodMessageRecv
        {
            get => _uniqueFloodMessageRecv;
            set
            {
                _uniqueFloodMessageRecv = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Unique Flood Message Recv")]
        #endif
        private uint64 _uniqueFloodMessageRecv;

        [ProtoMember(13)]
        public uint64 duplicateFloodMessageRecv
        {
            get => _duplicateFloodMessageRecv;
            set
            {
                _duplicateFloodMessageRecv = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Duplicate Flood Message Recv")]
        #endif
        private uint64 _duplicateFloodMessageRecv;

        [ProtoMember(14)]
        public uint64 uniqueFetchMessageRecv
        {
            get => _uniqueFetchMessageRecv;
            set
            {
                _uniqueFetchMessageRecv = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Unique Fetch Message Recv")]
        #endif
        private uint64 _uniqueFetchMessageRecv;

        [ProtoMember(15)]
        public uint64 duplicateFetchMessageRecv
        {
            get => _duplicateFetchMessageRecv;
            set
            {
                _duplicateFetchMessageRecv = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Duplicate Fetch Message Recv")]
        #endif
        private uint64 _duplicateFetchMessageRecv;

        public PeerStats()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class PeerStatsXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(PeerStats value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                PeerStatsXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static PeerStats DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return PeerStatsXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, PeerStats value)
        {
            value.Validate();
            NodeIDXdr.Encode(stream, value.id);
            stream.WriteString(value.versionStr);
            uint64Xdr.Encode(stream, value.messagesRead);
            uint64Xdr.Encode(stream, value.messagesWritten);
            uint64Xdr.Encode(stream, value.bytesRead);
            uint64Xdr.Encode(stream, value.bytesWritten);
            uint64Xdr.Encode(stream, value.secondsConnected);
            uint64Xdr.Encode(stream, value.uniqueFloodBytesRecv);
            uint64Xdr.Encode(stream, value.duplicateFloodBytesRecv);
            uint64Xdr.Encode(stream, value.uniqueFetchBytesRecv);
            uint64Xdr.Encode(stream, value.duplicateFetchBytesRecv);
            uint64Xdr.Encode(stream, value.uniqueFloodMessageRecv);
            uint64Xdr.Encode(stream, value.duplicateFloodMessageRecv);
            uint64Xdr.Encode(stream, value.uniqueFetchMessageRecv);
            uint64Xdr.Encode(stream, value.duplicateFetchMessageRecv);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static PeerStats Decode(XdrReader stream)
        {
            var result = new PeerStats();
            result.id = NodeIDXdr.Decode(stream);
            result.versionStr = stream.ReadString();
            result.messagesRead = uint64Xdr.Decode(stream);
            result.messagesWritten = uint64Xdr.Decode(stream);
            result.bytesRead = uint64Xdr.Decode(stream);
            result.bytesWritten = uint64Xdr.Decode(stream);
            result.secondsConnected = uint64Xdr.Decode(stream);
            result.uniqueFloodBytesRecv = uint64Xdr.Decode(stream);
            result.duplicateFloodBytesRecv = uint64Xdr.Decode(stream);
            result.uniqueFetchBytesRecv = uint64Xdr.Decode(stream);
            result.duplicateFetchBytesRecv = uint64Xdr.Decode(stream);
            result.uniqueFloodMessageRecv = uint64Xdr.Decode(stream);
            result.duplicateFloodMessageRecv = uint64Xdr.Decode(stream);
            result.uniqueFetchMessageRecv = uint64Xdr.Decode(stream);
            result.duplicateFetchMessageRecv = uint64Xdr.Decode(stream);
            return result;
        }
    }
}
