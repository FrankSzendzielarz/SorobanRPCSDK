// Generated code - do not modify
// Source:

// union SorobanCredentials switch (SorobanCredentialsType type)
// {
// case SOROBAN_CREDENTIALS_SOURCE_ACCOUNT:
//     void;
// case SOROBAN_CREDENTIALS_ADDRESS:
//     SorobanAddressCredentials address;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class SorobanCredentials
    {
        public abstract SorobanCredentialsType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class SorobanCredentials_SOROBAN_CREDENTIALS_SOURCE_ACCOUNT : SorobanCredentials
    {
        public override SorobanCredentialsType Discriminator => SorobanCredentialsType.SOROBAN_CREDENTIALS_SOURCE_ACCOUNT;

        public override void ValidateCase() {}
    }
    public sealed partial class SorobanCredentials_SOROBAN_CREDENTIALS_ADDRESS : SorobanCredentials
    {
        public override SorobanCredentialsType Discriminator => SorobanCredentialsType.SOROBAN_CREDENTIALS_ADDRESS;
        private SorobanAddressCredentials _address;
        public SorobanAddressCredentials address
        {
            get => _address;
            set
            {
                _address = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class SorobanCredentialsXdr
    {
        public static void Encode(XdrWriter stream, SorobanCredentials value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SorobanCredentials_SOROBAN_CREDENTIALS_SOURCE_ACCOUNT case_SOROBAN_CREDENTIALS_SOURCE_ACCOUNT:
                break;
                case SorobanCredentials_SOROBAN_CREDENTIALS_ADDRESS case_SOROBAN_CREDENTIALS_ADDRESS:
                SorobanAddressCredentialsXdr.Encode(stream, case_SOROBAN_CREDENTIALS_ADDRESS.address);
                break;
            }
        }
        public static SorobanCredentials Decode(XdrReader stream)
        {
            var discriminator = (SorobanCredentialsType)stream.ReadInt();
            switch (discriminator)
            {
                case SorobanCredentialsType.SOROBAN_CREDENTIALS_SOURCE_ACCOUNT:
                var result_SOROBAN_CREDENTIALS_SOURCE_ACCOUNT = new SorobanCredentials_SOROBAN_CREDENTIALS_SOURCE_ACCOUNT();
                return result_SOROBAN_CREDENTIALS_SOURCE_ACCOUNT;
                case SorobanCredentialsType.SOROBAN_CREDENTIALS_ADDRESS:
                var result_SOROBAN_CREDENTIALS_ADDRESS = new SorobanCredentials_SOROBAN_CREDENTIALS_ADDRESS();
                result_SOROBAN_CREDENTIALS_ADDRESS.address = SorobanAddressCredentialsXdr.Decode(stream);
                return result_SOROBAN_CREDENTIALS_ADDRESS;
                default:
                throw new Exception($"Unknown discriminator for SorobanCredentials: {discriminator}");
            }
        }
    }
}
