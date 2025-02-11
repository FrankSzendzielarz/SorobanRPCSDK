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
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class Hello
    {
        public uint32 ledgerVersion
        {
            get => _ledgerVersion;
            set
            {
                _ledgerVersion = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Ledger Version")]
        #endif
        private uint32 _ledgerVersion;

        public uint32 overlayVersion
        {
            get => _overlayVersion;
            set
            {
                _overlayVersion = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Overlay Version")]
        #endif
        private uint32 _overlayVersion;

        public uint32 overlayMinVersion
        {
            get => _overlayMinVersion;
            set
            {
                _overlayMinVersion = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Overlay Min Version")]
        #endif
        private uint32 _overlayMinVersion;

        public Hash networkID
        {
            get => _networkID;
            set
            {
                _networkID = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Network I D")]
        #endif
        private Hash _networkID;

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
        	[InspectorName(@"Version Str")]
        #endif
        private string _versionStr;

        public int listeningPort
        {
            get => _listeningPort;
            set
            {
                _listeningPort = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Listening Port")]
        #endif
        private int _listeningPort;

        public NodeID peerID
        {
            get => _peerID;
            set
            {
                _peerID = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Peer I D")]
        #endif
        private NodeID _peerID;

        public AuthCert cert
        {
            get => _cert;
            set
            {
                _cert = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Cert")]
        #endif
        private AuthCert _cert;

        public uint256 nonce
        {
            get => _nonce;
            set
            {
                _nonce = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Nonce")]
        #endif
        private uint256 _nonce;

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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(Hello value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                HelloXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
