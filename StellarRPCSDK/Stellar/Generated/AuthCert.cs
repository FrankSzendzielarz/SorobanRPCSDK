// Generated code - do not modify
// Source:

// struct AuthCert
// {
//     Curve25519Public pubkey;
//     uint64 expiration;
//     Signature sig;
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
    public partial class AuthCert
    {
        [ProtoMember(1)]
        public Curve25519Public pubkey
        {
            get => _pubkey;
            set
            {
                _pubkey = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Pubkey")]
        #endif
        private Curve25519Public _pubkey;

        [ProtoMember(2)]
        public uint64 expiration
        {
            get => _expiration;
            set
            {
                _expiration = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Expiration")]
        #endif
        private uint64 _expiration;

        [ProtoMember(3)]
        public Signature sig
        {
            get => _sig;
            set
            {
                _sig = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Sig")]
        #endif
        private Signature _sig;

        public AuthCert()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class AuthCertXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(AuthCert value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                AuthCertXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static AuthCert DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return AuthCertXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, AuthCert value)
        {
            value.Validate();
            Curve25519PublicXdr.Encode(stream, value.pubkey);
            uint64Xdr.Encode(stream, value.expiration);
            SignatureXdr.Encode(stream, value.sig);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static AuthCert Decode(XdrReader stream)
        {
            var result = new AuthCert();
            result.pubkey = Curve25519PublicXdr.Decode(stream);
            result.expiration = uint64Xdr.Decode(stream);
            result.sig = SignatureXdr.Decode(stream);
            return result;
        }
    }
}
