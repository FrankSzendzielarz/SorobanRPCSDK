// Generated code - do not modify
// Source:

// union RevokeSponsorshipOp switch (RevokeSponsorshipType type)
// {
// case REVOKE_SPONSORSHIP_LEDGER_ENTRY:
//     LedgerKey ledgerKey;
// case REVOKE_SPONSORSHIP_SIGNER:
//     struct
//     {
//         AccountID accountID;
//         SignerKey signerKey;
//     } signer;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class RevokeSponsorshipOp
    {
        public abstract RevokeSponsorshipType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public partial class signerStruct
        {
            private AccountID _accountID;
            public AccountID accountID
            {
                get => _accountID;
                set
                {
                    _accountID = value;
                }
            }

            private SignerKey _signerKey;
            public SignerKey signerKey
            {
                get => _signerKey;
                set
                {
                    _signerKey = value;
                }
            }

            public signerStruct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class signerStructXdr
        {
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, signerStruct value)
            {
                value.Validate();
                AccountIDXdr.Encode(stream, value.accountID);
                SignerKeyXdr.Encode(stream, value.signerKey);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static signerStruct Decode(XdrReader stream)
            {
                var result = new signerStruct();
                result.accountID = AccountIDXdr.Decode(stream);
                result.signerKey = SignerKeyXdr.Decode(stream);
                return result;
            }
        }
    }
    public sealed partial class RevokeSponsorshipOp_REVOKE_SPONSORSHIP_LEDGER_ENTRY : RevokeSponsorshipOp
    {
        public override RevokeSponsorshipType Discriminator => RevokeSponsorshipType.REVOKE_SPONSORSHIP_LEDGER_ENTRY;
        private LedgerKey _ledgerKey;
        public LedgerKey ledgerKey
        {
            get => _ledgerKey;
            set
            {
                _ledgerKey = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class RevokeSponsorshipOp_REVOKE_SPONSORSHIP_SIGNER : RevokeSponsorshipOp
    {
        public override RevokeSponsorshipType Discriminator => RevokeSponsorshipType.REVOKE_SPONSORSHIP_SIGNER;
        private signerStruct _signer;
        public signerStruct signer
        {
            get => _signer;
            set
            {
                _signer = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class RevokeSponsorshipOpXdr
    {
        public static void Encode(XdrWriter stream, RevokeSponsorshipOp value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case RevokeSponsorshipOp_REVOKE_SPONSORSHIP_LEDGER_ENTRY case_REVOKE_SPONSORSHIP_LEDGER_ENTRY:
                LedgerKeyXdr.Encode(stream, case_REVOKE_SPONSORSHIP_LEDGER_ENTRY.ledgerKey);
                break;
                case RevokeSponsorshipOp_REVOKE_SPONSORSHIP_SIGNER case_REVOKE_SPONSORSHIP_SIGNER:
                RevokeSponsorshipOp.signerStructXdr.Encode(stream, case_REVOKE_SPONSORSHIP_SIGNER.signer);
                break;
            }
        }
        public static RevokeSponsorshipOp Decode(XdrReader stream)
        {
            var discriminator = (RevokeSponsorshipType)stream.ReadInt();
            switch (discriminator)
            {
                case RevokeSponsorshipType.REVOKE_SPONSORSHIP_LEDGER_ENTRY:
                var result_REVOKE_SPONSORSHIP_LEDGER_ENTRY = new RevokeSponsorshipOp_REVOKE_SPONSORSHIP_LEDGER_ENTRY();
                result_REVOKE_SPONSORSHIP_LEDGER_ENTRY.ledgerKey = LedgerKeyXdr.Decode(stream);
                return result_REVOKE_SPONSORSHIP_LEDGER_ENTRY;
                case RevokeSponsorshipType.REVOKE_SPONSORSHIP_SIGNER:
                var result_REVOKE_SPONSORSHIP_SIGNER = new RevokeSponsorshipOp_REVOKE_SPONSORSHIP_SIGNER();
                result_REVOKE_SPONSORSHIP_SIGNER.signer = RevokeSponsorshipOp.signerStructXdr.Decode(stream);
                return result_REVOKE_SPONSORSHIP_SIGNER;
                default:
                throw new Exception($"Unknown discriminator for RevokeSponsorshipOp: {discriminator}");
            }
        }
    }
}
