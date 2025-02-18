// Generated code - do not modify
// Source:

// struct ClaimClaimableBalanceOp
// {
//     ClaimableBalanceID balanceID;
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
    public partial class ClaimClaimableBalanceOp
    {
        public ClaimableBalanceID balanceID
        {
            get => _balanceID;
            set
            {
                _balanceID = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Balance I D")]
        #endif
        private ClaimableBalanceID _balanceID;

        public ClaimClaimableBalanceOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ClaimClaimableBalanceOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ClaimClaimableBalanceOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ClaimClaimableBalanceOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ClaimClaimableBalanceOp value)
        {
            value.Validate();
            ClaimableBalanceIDXdr.Encode(stream, value.balanceID);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ClaimClaimableBalanceOp Decode(XdrReader stream)
        {
            var result = new ClaimClaimableBalanceOp();
            result.balanceID = ClaimableBalanceIDXdr.Decode(stream);
            return result;
        }
    }
}
