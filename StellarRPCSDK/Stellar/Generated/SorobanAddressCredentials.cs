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
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class SorobanAddressCredentials
    {
        public SCAddress address
        {
            get => _address;
            set
            {
                _address = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Address")]
        #endif
        private SCAddress _address;

        public int64 nonce
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
        private int64 _nonce;

        public uint32 signatureExpirationLedger
        {
            get => _signatureExpirationLedger;
            set
            {
                _signatureExpirationLedger = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Signature Expiration Ledger")]
        #endif
        private uint32 _signatureExpirationLedger;

        public SCVal signature
        {
            get => _signature;
            set
            {
                _signature = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Signature")]
        #endif
        private SCVal _signature;

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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SorobanAddressCredentials value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SorobanAddressCredentialsXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
