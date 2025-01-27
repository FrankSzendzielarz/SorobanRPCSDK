// Generated code - do not modify
// Source:

// struct SorobanAddressCredentials
// {
//     SCAddress address;
//     int64 nonce;
//     uint32 signatureExpirationLedger;    
//     SCVal signature;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SorobanAddressCredentials
    {
        private SCAddress _address;
        public SCAddress address
        {
            get => _address;
            set
            {
                _address = value;
            }
        }

        private int64 _nonce;
        public int64 nonce
        {
            get => _nonce;
            set
            {
                _nonce = value;
            }
        }

        private uint32 _signatureExpirationLedger;
        public uint32 signatureExpirationLedger
        {
            get => _signatureExpirationLedger;
            set
            {
                _signatureExpirationLedger = value;
            }
        }

        private SCVal _signature;
        public SCVal signature
        {
            get => _signature;
            set
            {
                _signature = value;
            }
        }

        public SorobanAddressCredentials()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SorobanAddressCredentialsXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SorobanAddressCredentials value)
        {
            value.Validate();
            SCAddressXdr.Encode(stream, value.address);
            int64Xdr.Encode(stream, value.nonce);
            uint32Xdr.Encode(stream, value.signatureExpirationLedger);
            SCValXdr.Encode(stream, value.signature);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SorobanAddressCredentials Decode(XdrReader stream)
        {
            var result = new SorobanAddressCredentials();
            result.address = SCAddressXdr.Decode(stream);
            result.nonce = int64Xdr.Decode(stream);
            result.signatureExpirationLedger = uint32Xdr.Decode(stream);
            result.signature = SCValXdr.Decode(stream);
            return result;
        }
    }
}
