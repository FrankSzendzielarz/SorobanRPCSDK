// Generated code - do not modify
// Source:

// union AccountMergeResult switch (AccountMergeResultCode code)
// {
// case ACCOUNT_MERGE_SUCCESS:
//     int64 sourceAccountBalance; // how much got transferred from source account
// case ACCOUNT_MERGE_MALFORMED:
// case ACCOUNT_MERGE_NO_ACCOUNT:
// case ACCOUNT_MERGE_IMMUTABLE_SET:
// case ACCOUNT_MERGE_HAS_SUB_ENTRIES:
// case ACCOUNT_MERGE_SEQNUM_TOO_FAR:
// case ACCOUNT_MERGE_DEST_FULL:
// case ACCOUNT_MERGE_IS_SPONSOR:
//     void;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class AccountMergeResult
    {
        public abstract AccountMergeResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class AccountMergeResult_ACCOUNT_MERGE_SUCCESS : AccountMergeResult
    {
        public override AccountMergeResultCode Discriminator => ACCOUNT_MERGE_SUCCESS;
        private int64 _sourceAccountBalance;
        public int64 sourceAccountBalance
        {
            get => _sourceAccountBalance;
            set
            {
                _sourceAccountBalance = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class AccountMergeResult_ACCOUNT_MERGE_MALFORMED : AccountMergeResult
    {
        public override AccountMergeResultCode Discriminator => ACCOUNT_MERGE_MALFORMED;

        public override void ValidateCase() {}
    }
    public sealed partial class AccountMergeResult_ACCOUNT_MERGE_NO_ACCOUNT : AccountMergeResult
    {
        public override AccountMergeResultCode Discriminator => ACCOUNT_MERGE_NO_ACCOUNT;

        public override void ValidateCase() {}
    }
    public sealed partial class AccountMergeResult_ACCOUNT_MERGE_IMMUTABLE_SET : AccountMergeResult
    {
        public override AccountMergeResultCode Discriminator => ACCOUNT_MERGE_IMMUTABLE_SET;

        public override void ValidateCase() {}
    }
    public sealed partial class AccountMergeResult_ACCOUNT_MERGE_HAS_SUB_ENTRIES : AccountMergeResult
    {
        public override AccountMergeResultCode Discriminator => ACCOUNT_MERGE_HAS_SUB_ENTRIES;

        public override void ValidateCase() {}
    }
    public sealed partial class AccountMergeResult_ACCOUNT_MERGE_SEQNUM_TOO_FAR : AccountMergeResult
    {
        public override AccountMergeResultCode Discriminator => ACCOUNT_MERGE_SEQNUM_TOO_FAR;

        public override void ValidateCase() {}
    }
    public sealed partial class AccountMergeResult_ACCOUNT_MERGE_DEST_FULL : AccountMergeResult
    {
        public override AccountMergeResultCode Discriminator => ACCOUNT_MERGE_DEST_FULL;

        public override void ValidateCase() {}
    }
    public sealed partial class AccountMergeResult_ACCOUNT_MERGE_IS_SPONSOR : AccountMergeResult
    {
        public override AccountMergeResultCode Discriminator => ACCOUNT_MERGE_IS_SPONSOR;

        public override void ValidateCase() {}
    }
    public static partial class AccountMergeResultXdr
    {
        public static void Encode(XdrWriter stream, AccountMergeResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case AccountMergeResult_ACCOUNT_MERGE_SUCCESS case_ACCOUNT_MERGE_SUCCESS:
                int64Xdr.Encode(stream, case_ACCOUNT_MERGE_SUCCESS.sourceAccountBalance);
                break;
                case AccountMergeResult_ACCOUNT_MERGE_MALFORMED case_ACCOUNT_MERGE_MALFORMED:
                break;
                case AccountMergeResult_ACCOUNT_MERGE_NO_ACCOUNT case_ACCOUNT_MERGE_NO_ACCOUNT:
                break;
                case AccountMergeResult_ACCOUNT_MERGE_IMMUTABLE_SET case_ACCOUNT_MERGE_IMMUTABLE_SET:
                break;
                case AccountMergeResult_ACCOUNT_MERGE_HAS_SUB_ENTRIES case_ACCOUNT_MERGE_HAS_SUB_ENTRIES:
                break;
                case AccountMergeResult_ACCOUNT_MERGE_SEQNUM_TOO_FAR case_ACCOUNT_MERGE_SEQNUM_TOO_FAR:
                break;
                case AccountMergeResult_ACCOUNT_MERGE_DEST_FULL case_ACCOUNT_MERGE_DEST_FULL:
                break;
                case AccountMergeResult_ACCOUNT_MERGE_IS_SPONSOR case_ACCOUNT_MERGE_IS_SPONSOR:
                break;
            }
        }
        public static AccountMergeResult Decode(XdrReader stream)
        {
            var discriminator = (AccountMergeResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case ACCOUNT_MERGE_SUCCESS:
                var result_ACCOUNT_MERGE_SUCCESS = new AccountMergeResult_ACCOUNT_MERGE_SUCCESS();
                result_ACCOUNT_MERGE_SUCCESS.                 = int64Xdr.Decode(stream);
                return result_ACCOUNT_MERGE_SUCCESS;
                case ACCOUNT_MERGE_MALFORMED:
                var result_ACCOUNT_MERGE_MALFORMED = new AccountMergeResult_ACCOUNT_MERGE_MALFORMED();
                return result_ACCOUNT_MERGE_MALFORMED;
                case ACCOUNT_MERGE_NO_ACCOUNT:
                var result_ACCOUNT_MERGE_NO_ACCOUNT = new AccountMergeResult_ACCOUNT_MERGE_NO_ACCOUNT();
                return result_ACCOUNT_MERGE_NO_ACCOUNT;
                case ACCOUNT_MERGE_IMMUTABLE_SET:
                var result_ACCOUNT_MERGE_IMMUTABLE_SET = new AccountMergeResult_ACCOUNT_MERGE_IMMUTABLE_SET();
                return result_ACCOUNT_MERGE_IMMUTABLE_SET;
                case ACCOUNT_MERGE_HAS_SUB_ENTRIES:
                var result_ACCOUNT_MERGE_HAS_SUB_ENTRIES = new AccountMergeResult_ACCOUNT_MERGE_HAS_SUB_ENTRIES();
                return result_ACCOUNT_MERGE_HAS_SUB_ENTRIES;
                case ACCOUNT_MERGE_SEQNUM_TOO_FAR:
                var result_ACCOUNT_MERGE_SEQNUM_TOO_FAR = new AccountMergeResult_ACCOUNT_MERGE_SEQNUM_TOO_FAR();
                return result_ACCOUNT_MERGE_SEQNUM_TOO_FAR;
                case ACCOUNT_MERGE_DEST_FULL:
                var result_ACCOUNT_MERGE_DEST_FULL = new AccountMergeResult_ACCOUNT_MERGE_DEST_FULL();
                return result_ACCOUNT_MERGE_DEST_FULL;
                case ACCOUNT_MERGE_IS_SPONSOR:
                var result_ACCOUNT_MERGE_IS_SPONSOR = new AccountMergeResult_ACCOUNT_MERGE_IS_SPONSOR();
                return result_ACCOUNT_MERGE_IS_SPONSOR;
                default:
                throw new Exception($"Unknown discriminator for AccountMergeResult: {discriminator}");
            }
        }
    }
}
