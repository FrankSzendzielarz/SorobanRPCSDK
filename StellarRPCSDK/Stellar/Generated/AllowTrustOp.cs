// Generated code - do not modify
// Source:

// struct AllowTrustOp
// {
//     AccountID trustor;
//     AssetCode asset;
// 
//     // One of 0, AUTHORIZED_FLAG, or AUTHORIZED_TO_MAINTAIN_LIABILITIES_FLAG
//     uint32 authorize;
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
    public partial class AllowTrustOp
    {
        [ProtoMember(1)]
        public AccountID trustor
        {
            get => _trustor;
            set
            {
                _trustor = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Trustor")]
        #endif
        private AccountID _trustor;

        [ProtoMember(2)]
        public AssetCode asset
        {
            get => _asset;
            set
            {
                _asset = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Asset")]
        #endif
        private AssetCode _asset;

        /// <summary>
        /// One of 0, AUTHORIZED_FLAG, or AUTHORIZED_TO_MAINTAIN_LIABILITIES_FLAG
        /// </summary>
        [ProtoMember(3)]
        public uint32 authorize
        {
            get => _authorize;
            set
            {
                _authorize = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Authorize")]
        #endif
        private uint32 _authorize;

        public AllowTrustOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class AllowTrustOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(AllowTrustOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                AllowTrustOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, AllowTrustOp value)
        {
            value.Validate();
            AccountIDXdr.Encode(stream, value.trustor);
            AssetCodeXdr.Encode(stream, value.asset);
            uint32Xdr.Encode(stream, value.authorize);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static AllowTrustOp Decode(XdrReader stream)
        {
            var result = new AllowTrustOp();
            result.trustor = AccountIDXdr.Decode(stream);
            result.asset = AssetCodeXdr.Decode(stream);
            result.authorize = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
