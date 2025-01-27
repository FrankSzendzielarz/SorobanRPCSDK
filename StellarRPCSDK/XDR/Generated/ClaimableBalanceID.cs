// Generated code - do not modify
// Source:

// union ClaimableBalanceID switch (ClaimableBalanceIDType type)
// {
// case CLAIMABLE_BALANCE_ID_TYPE_V0:
//     Hash v0;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class ClaimableBalanceID
    {
        public abstract ClaimableBalanceIDType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class ClaimableBalanceID_CLAIMABLE_BALANCE_ID_TYPE_V0 : ClaimableBalanceID
    {
        public override ClaimableBalanceIDType Discriminator => CLAIMABLE_BALANCE_ID_TYPE_V0;
        private Hash _v0;
        public Hash v0
        {
            get => _v0;
            set
            {
                _v0 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class ClaimableBalanceIDXdr
    {
        public static void Encode(XdrWriter stream, ClaimableBalanceID value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ClaimableBalanceID_CLAIMABLE_BALANCE_ID_TYPE_V0 case_CLAIMABLE_BALANCE_ID_TYPE_V0:
                HashXdr.Encode(stream, case_CLAIMABLE_BALANCE_ID_TYPE_V0.v0);
                break;
            }
        }
        public static ClaimableBalanceID Decode(XdrReader stream)
        {
            var discriminator = (ClaimableBalanceIDType)stream.ReadInt();
            switch (discriminator)
            {
                case CLAIMABLE_BALANCE_ID_TYPE_V0:
                var result_CLAIMABLE_BALANCE_ID_TYPE_V0 = new ClaimableBalanceID_CLAIMABLE_BALANCE_ID_TYPE_V0();
                result_CLAIMABLE_BALANCE_ID_TYPE_V0.                 = HashXdr.Decode(stream);
                return result_CLAIMABLE_BALANCE_ID_TYPE_V0;
                default:
                throw new Exception($"Unknown discriminator for ClaimableBalanceID: {discriminator}");
            }
        }
    }
}
