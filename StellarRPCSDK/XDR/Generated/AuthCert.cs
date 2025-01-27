// Generated code - do not modify
// Source:

// struct AuthCert
// {
//     Curve25519Public pubkey;
//     uint64 expiration;
//     Signature sig;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class AuthCert
    {
        private Curve25519Public _pubkey;
        public Curve25519Public pubkey
        {
            get => _pubkey;
            set
            {
                _pubkey = value;
            }
        }

        private uint64 _expiration;
        public uint64 expiration
        {
            get => _expiration;
            set
            {
                _expiration = value;
            }
        }

        private Signature _sig;
        public Signature sig
        {
            get => _sig;
            set
            {
                _sig = value;
            }
        }

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
