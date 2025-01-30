// Generated code - do not modify
// Source:

// struct ClawbackClaimableBalanceOp
// {
//     ClaimableBalanceID balanceID;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ClawbackClaimableBalanceOp
    {
        private ClaimableBalanceID _balanceID;
        public ClaimableBalanceID balanceID
        {
            get => _balanceID;
            set
            {
                _balanceID = value;
            }
        }

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
