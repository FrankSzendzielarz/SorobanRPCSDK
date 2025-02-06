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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class PeerStats
    {
        public NodeID id
        {
            get => _id;
            set
            {
                _id = value;
            }
        }
        private NodeID _id;

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
        private string _versionStr;

        public uint64 messagesRead
        {
            get => _messagesRead;
            set
            {
                _messagesRead = value;
            }
        }
        private uint64 _messagesRead;

        public uint64 messagesWritten
        {
            get => _messagesWritten;
            set
            {
                _messagesWritten = value;
            }
        }
        private uint64 _messagesWritten;

        public uint64 bytesRead
        {
            get => _bytesRead;
            set
            {
                _bytesRead = value;
            }
        }
        private uint64 _bytesRead;

        public uint64 bytesWritten
        {
            get => _bytesWritten;
            set
            {
                _bytesWritten = value;
            }
        }
        private uint64 _bytesWritten;

        public uint64 secondsConnected
        {
            get => _secondsConnected;
            set
            {
                _secondsConnected = value;
            }
        }
        private uint64 _secondsConnected;

        public uint64 uniqueFloodBytesRecv
        {
            get => _uniqueFloodBytesRecv;
            set
            {
                _uniqueFloodBytesRecv = value;
            }
        }
        private uint64 _uniqueFloodBytesRecv;

        public uint64 duplicateFloodBytesRecv
        {
            get => _duplicateFloodBytesRecv;
            set
            {
                _duplicateFloodBytesRecv = value;
            }
        }
        private uint64 _duplicateFloodBytesRecv;

        public uint64 uniqueFetchBytesRecv
        {
            get => _uniqueFetchBytesRecv;
            set
            {
                _uniqueFetchBytesRecv = value;
            }
        }
        private uint64 _uniqueFetchBytesRecv;

        public uint64 duplicateFetchBytesRecv
        {
            get => _duplicateFetchBytesRecv;
            set
            {
                _duplicateFetchBytesRecv = value;
            }
        }
        private uint64 _duplicateFetchBytesRecv;

        public uint64 uniqueFloodMessageRecv
        {
            get => _uniqueFloodMessageRecv;
            set
            {
                _uniqueFloodMessageRecv = value;
            }
        }
        private uint64 _uniqueFloodMessageRecv;

        public uint64 duplicateFloodMessageRecv
        {
            get => _duplicateFloodMessageRecv;
            set
            {
                _duplicateFloodMessageRecv = value;
            }
        }
        private uint64 _duplicateFloodMessageRecv;

        public uint64 uniqueFetchMessageRecv
        {
            get => _uniqueFetchMessageRecv;
            set
            {
                _uniqueFetchMessageRecv = value;
            }
        }
        private uint64 _uniqueFetchMessageRecv;

        public uint64 duplicateFetchMessageRecv
        {
            get => _duplicateFetchMessageRecv;
            set
            {
                _duplicateFetchMessageRecv = value;
            }
        }
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
