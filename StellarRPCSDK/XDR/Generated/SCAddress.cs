// Generated code - do not modify
// Source:

// union SCAddress switch (SCAddressType type)
// {
// case SC_ADDRESS_TYPE_ACCOUNT:
//     AccountID accountId;
// case SC_ADDRESS_TYPE_CONTRACT:
//     Hash contractId;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class SCAddress
    {
        public abstract SCAddressType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class SCAddress_SC_ADDRESS_TYPE_ACCOUNT : SCAddress
    {
        public override SCAddressType Discriminator => SCAddressType.SC_ADDRESS_TYPE_ACCOUNT;
        private AccountID _accountId;
        public AccountID accountId
        {
            get => _accountId;
            set
            {
                _accountId = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCAddress_SC_ADDRESS_TYPE_CONTRACT : SCAddress
    {
        public override SCAddressType Discriminator => SCAddressType.SC_ADDRESS_TYPE_CONTRACT;
        private Hash _contractId;
        public Hash contractId
        {
            get => _contractId;
            set
            {
                _contractId = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class SCAddressXdr
    {
        public static void Encode(XdrWriter stream, SCAddress value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SCAddress_SC_ADDRESS_TYPE_ACCOUNT case_SC_ADDRESS_TYPE_ACCOUNT:
                AccountIDXdr.Encode(stream, case_SC_ADDRESS_TYPE_ACCOUNT.accountId);
                break;
                case SCAddress_SC_ADDRESS_TYPE_CONTRACT case_SC_ADDRESS_TYPE_CONTRACT:
                HashXdr.Encode(stream, case_SC_ADDRESS_TYPE_CONTRACT.contractId);
                break;
            }
        }
        public static SCAddress Decode(XdrReader stream)
        {
            var discriminator = (SCAddressType)stream.ReadInt();
            switch (discriminator)
            {
                case SCAddressType.SC_ADDRESS_TYPE_ACCOUNT:
                var result_SC_ADDRESS_TYPE_ACCOUNT = new SCAddress_SC_ADDRESS_TYPE_ACCOUNT();
                result_SC_ADDRESS_TYPE_ACCOUNT.accountId = AccountIDXdr.Decode(stream);
                return result_SC_ADDRESS_TYPE_ACCOUNT;
                case SCAddressType.SC_ADDRESS_TYPE_CONTRACT:
                var result_SC_ADDRESS_TYPE_CONTRACT = new SCAddress_SC_ADDRESS_TYPE_CONTRACT();
                result_SC_ADDRESS_TYPE_CONTRACT.contractId = HashXdr.Decode(stream);
                return result_SC_ADDRESS_TYPE_CONTRACT;
                default:
                throw new Exception($"Unknown discriminator for SCAddress: {discriminator}");
            }
        }
    }
}
