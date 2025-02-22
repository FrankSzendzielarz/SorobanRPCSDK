// Generated code - do not modify
// Source:

// struct SetTrustLineFlagsOp
// {
//     AccountID trustor;
//     Asset asset;
// 
//     uint32 clearFlags; // which flags to clear
//     uint32 setFlags;   // which flags to set
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
    public partial class SetTrustLineFlagsOp
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
        public Asset asset
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
        private Asset _asset;

        [ProtoMember(3)]
        public uint32 clearFlags
        {
            get => _clearFlags;
            set
            {
                _clearFlags = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Clear Flags")]
        #endif
        private uint32 _clearFlags;

        /// <summary>
        /// which flags to clear
        /// </summary>
        [ProtoMember(4)]
        public uint32 setFlags
        {
            get => _setFlags;
            set
            {
                _setFlags = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Set Flags")]
        #endif
        private uint32 _setFlags;

        public SetTrustLineFlagsOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SetTrustLineFlagsOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SetTrustLineFlagsOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SetTrustLineFlagsOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SetTrustLineFlagsOp value)
        {
            value.Validate();
            AccountIDXdr.Encode(stream, value.trustor);
            AssetXdr.Encode(stream, value.asset);
            uint32Xdr.Encode(stream, value.clearFlags);
            uint32Xdr.Encode(stream, value.setFlags);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SetTrustLineFlagsOp Decode(XdrReader stream)
        {
            var result = new SetTrustLineFlagsOp();
            result.trustor = AccountIDXdr.Decode(stream);
            result.asset = AssetXdr.Decode(stream);
            result.clearFlags = uint32Xdr.Decode(stream);
            result.setFlags = uint32Xdr.Decode(stream);
            return result;
        }
    }
}
