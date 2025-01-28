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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class RevokeSponsorshipOp
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class RevokeSponsorshipOp_REVOKE_SPONSORSHIP_LEDGER_ENTRY : RevokeSponsorshipOp
    {
        public override int Discriminator => REVOKE_SPONSORSHIP_LEDGER_ENTRY;
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
        public override int Discriminator => REVOKE_SPONSORSHIP_SIGNER;
        private object _signer;
        public object signer
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
                Xdr.Encode(stream, case_REVOKE_SPONSORSHIP_SIGNER.signer);
                break;
            }
        }
        public static RevokeSponsorshipOp Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case REVOKE_SPONSORSHIP_LEDGER_ENTRY:
                var result_REVOKE_SPONSORSHIP_LEDGER_ENTRY = new RevokeSponsorshipOp_REVOKE_SPONSORSHIP_LEDGER_ENTRY();
                result_REVOKE_SPONSORSHIP_LEDGER_ENTRY.                 = LedgerKeyXdr.Decode(stream);
                return result_REVOKE_SPONSORSHIP_LEDGER_ENTRY;
                case REVOKE_SPONSORSHIP_SIGNER:
                var result_REVOKE_SPONSORSHIP_SIGNER = new RevokeSponsorshipOp_REVOKE_SPONSORSHIP_SIGNER();
                result_REVOKE_SPONSORSHIP_SIGNER.                 = Xdr.Decode(stream);
                return result_REVOKE_SPONSORSHIP_SIGNER;
                default:
                throw new Exception($"Unknown discriminator for RevokeSponsorshipOp: {discriminator}");
            }
        }
    }
}
