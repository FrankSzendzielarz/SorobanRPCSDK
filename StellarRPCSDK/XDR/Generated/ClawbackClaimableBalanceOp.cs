// Generated code - do not modify
// Source:

// struct ClawbackClaimableBalanceOp
// {
//     ClaimableBalanceID balanceID;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ClawbackClaimableBalanceOp
    {
        public ClaimableBalanceID balanceID
        {
            get => _balanceID;
            set
            {
                _balanceID = value;
            }
        }
        private ClaimableBalanceID _balanceID;

        public ClawbackClaimableBalanceOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ClawbackClaimableBalanceOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ClawbackClaimableBalanceOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ClawbackClaimableBalanceOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ClawbackClaimableBalanceOp value)
        {
            value.Validate();
            ClaimableBalanceIDXdr.Encode(stream, value.balanceID);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ClawbackClaimableBalanceOp Decode(XdrReader stream)
        {
            var result = new ClawbackClaimableBalanceOp();
            result.balanceID = ClaimableBalanceIDXdr.Decode(stream);
            return result;
        }
    }
}
