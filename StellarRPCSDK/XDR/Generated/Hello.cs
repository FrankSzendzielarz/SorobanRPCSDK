// Generated code - do not modify
// Source:

// struct Hello
// {
//     uint32 ledgerVersion;
//     uint32 overlayVersion;
//     uint32 overlayMinVersion;
//     Hash networkID;
//     string versionStr<100>;
//     int listeningPort;
//     NodeID peerID;
//     AuthCert cert;
//     uint256 nonce;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class Hello
    {
        private uint32 _ledgerVersion;
        public uint32 ledgerVersion
        {
            get => _ledgerVersion;
            set
            {
                _ledgerVersion = value;
            }
        }

        private uint32 _overlayVersion;
        public uint32 overlayVersion
        {
            get => _overlayVersion;
            set
            {
                _overlayVersion = value;
            }
        }

        private uint32 _overlayMinVersion;
        public uint32 overlayMinVersion
        {
            get => _overlayMinVersion;
            set
            {
                _overlayMinVersion = value;
            }
        }

        private Hash _networkID;
        public Hash networkID
        {
            get => _networkID;
            set
            {
                _networkID = value;
            }
        }

        private string _versionStr;
        public string versionStr
        {
            get => _versionStr;
            set
            {
                if (System.Text.Encoding.UTF8.GetByteCount(value) > 100)
                	throw new ArgumentException($"String exceeds 100 bytes when UTF8 encoded");
                _versionStr = value;
            }
        }

        private int _listeningPort;
        public int listeningPort
        {
            get => _listeningPort;
            set
            {
                _listeningPort = value;
            }
        }

        private NodeID _peerID;
        public NodeID peerID
        {
            get => _peerID;
            set
            {
                _peerID = value;
            }
        }

        private AuthCert _cert;
        public AuthCert cert
        {
            get => _cert;
            set
            {
                _cert = value;
            }
        }

        private uint256 _nonce;
        public uint256 nonce
        {
            get => _nonce;
            set
            {
                _nonce = value;
            }
        }

        public Hello()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class HelloXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, Hello value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.ledgerVersion);
            uint32Xdr.Encode(stream, value.overlayVersion);
            uint32Xdr.Encode(stream, value.overlayMinVersion);
            HashXdr.Encode(stream, value.networkID);
            stream.WriteString(value.versionStr);
            stream.WriteInt(value.listeningPort);
            NodeIDXdr.Encode(stream, value.peerID);
            AuthCertXdr.Encode(stream, value.cert);
            uint256Xdr.Encode(stream, value.nonce);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static Hello Decode(XdrReader stream)
        {
            var result = new Hello();
            result.ledgerVersion = uint32Xdr.Decode(stream);
            result.overlayVersion = uint32Xdr.Decode(stream);
            result.overlayMinVersion = uint32Xdr.Decode(stream);
            result.networkID = HashXdr.Decode(stream);
            result.versionStr = stream.ReadString();
            result.listeningPort = stream.ReadInt();
            result.peerID = NodeIDXdr.Decode(stream);
            result.cert = AuthCertXdr.Decode(stream);
            result.nonce = uint256Xdr.Decode(stream);
            return result;
        }
    }
}
