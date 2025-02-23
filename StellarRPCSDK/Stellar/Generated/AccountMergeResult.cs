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
    [ProtoInclude(100, typeof(AccountMergeSuccess), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(AccountMergeMalformed), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(AccountMergeNoAccount), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(AccountMergeImmutableSet), DataFormat = DataFormat.Default)]
    [ProtoInclude(104, typeof(AccountMergeHasSubEntries), DataFormat = DataFormat.Default)]
    [ProtoInclude(105, typeof(AccountMergeSeqnumTooFar), DataFormat = DataFormat.Default)]
    [ProtoInclude(106, typeof(AccountMergeDestFull), DataFormat = DataFormat.Default)]
    [ProtoInclude(107, typeof(AccountMergeIsSponsor), DataFormat = DataFormat.Default)]
    public abstract partial class AccountMergeResult
    {
        public abstract AccountMergeResultCode Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "AccountMergeResult.AccountMergeSuccess")]
        public sealed partial class AccountMergeSuccess : AccountMergeResult
        {
            public override AccountMergeResultCode Discriminator => AccountMergeResultCode.ACCOUNT_MERGE_SUCCESS;
            [ProtoMember(1)]
            public int64 sourceAccountBalance
            {
                get => _sourceAccountBalance;
                set
                {
                    _sourceAccountBalance = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Source Account Balance")]
            #endif
            private int64 _sourceAccountBalance;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// how much got transferred from source account
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "AccountMergeResult.AccountMergeMalformed")]
        public sealed partial class AccountMergeMalformed : AccountMergeResult
        {
            public override AccountMergeResultCode Discriminator => AccountMergeResultCode.ACCOUNT_MERGE_MALFORMED;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// how much got transferred from source account
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "AccountMergeResult.AccountMergeNoAccount")]
        public sealed partial class AccountMergeNoAccount : AccountMergeResult
        {
            public override AccountMergeResultCode Discriminator => AccountMergeResultCode.ACCOUNT_MERGE_NO_ACCOUNT;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// how much got transferred from source account
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "AccountMergeResult.AccountMergeImmutableSet")]
        public sealed partial class AccountMergeImmutableSet : AccountMergeResult
        {
            public override AccountMergeResultCode Discriminator => AccountMergeResultCode.ACCOUNT_MERGE_IMMUTABLE_SET;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// how much got transferred from source account
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "AccountMergeResult.AccountMergeHasSubEntries")]
        public sealed partial class AccountMergeHasSubEntries : AccountMergeResult
        {
            public override AccountMergeResultCode Discriminator => AccountMergeResultCode.ACCOUNT_MERGE_HAS_SUB_ENTRIES;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// how much got transferred from source account
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "AccountMergeResult.AccountMergeSeqnumTooFar")]
        public sealed partial class AccountMergeSeqnumTooFar : AccountMergeResult
        {
            public override AccountMergeResultCode Discriminator => AccountMergeResultCode.ACCOUNT_MERGE_SEQNUM_TOO_FAR;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// how much got transferred from source account
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "AccountMergeResult.AccountMergeDestFull")]
        public sealed partial class AccountMergeDestFull : AccountMergeResult
        {
            public override AccountMergeResultCode Discriminator => AccountMergeResultCode.ACCOUNT_MERGE_DEST_FULL;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// how much got transferred from source account
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "AccountMergeResult.AccountMergeIsSponsor")]
        public sealed partial class AccountMergeIsSponsor : AccountMergeResult
        {
            public override AccountMergeResultCode Discriminator => AccountMergeResultCode.ACCOUNT_MERGE_IS_SPONSOR;

            public override void ValidateCase() {}
        }
    }
    public static partial class AccountMergeResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(AccountMergeResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                AccountMergeResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static AccountMergeResult DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return AccountMergeResultXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, AccountMergeResult value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case AccountMergeResult.AccountMergeSuccess case_ACCOUNT_MERGE_SUCCESS:
                int64Xdr.Encode(stream, case_ACCOUNT_MERGE_SUCCESS.sourceAccountBalance);
                break;
                case AccountMergeResult.AccountMergeMalformed case_ACCOUNT_MERGE_MALFORMED:
                break;
                case AccountMergeResult.AccountMergeNoAccount case_ACCOUNT_MERGE_NO_ACCOUNT:
                break;
                case AccountMergeResult.AccountMergeImmutableSet case_ACCOUNT_MERGE_IMMUTABLE_SET:
                break;
                case AccountMergeResult.AccountMergeHasSubEntries case_ACCOUNT_MERGE_HAS_SUB_ENTRIES:
                break;
                case AccountMergeResult.AccountMergeSeqnumTooFar case_ACCOUNT_MERGE_SEQNUM_TOO_FAR:
                break;
                case AccountMergeResult.AccountMergeDestFull case_ACCOUNT_MERGE_DEST_FULL:
                break;
                case AccountMergeResult.AccountMergeIsSponsor case_ACCOUNT_MERGE_IS_SPONSOR:
                break;
            }
        }
        public static AccountMergeResult Decode(XdrReader stream)
        {
            var discriminator = (AccountMergeResultCode)stream.ReadInt();
            switch (discriminator)
            {
                case AccountMergeResultCode.ACCOUNT_MERGE_SUCCESS:
                var result_ACCOUNT_MERGE_SUCCESS = new AccountMergeResult.AccountMergeSuccess();
                result_ACCOUNT_MERGE_SUCCESS.sourceAccountBalance = int64Xdr.Decode(stream);
                return result_ACCOUNT_MERGE_SUCCESS;
                case AccountMergeResultCode.ACCOUNT_MERGE_MALFORMED:
                var result_ACCOUNT_MERGE_MALFORMED = new AccountMergeResult.AccountMergeMalformed();
                return result_ACCOUNT_MERGE_MALFORMED;
                case AccountMergeResultCode.ACCOUNT_MERGE_NO_ACCOUNT:
                var result_ACCOUNT_MERGE_NO_ACCOUNT = new AccountMergeResult.AccountMergeNoAccount();
                return result_ACCOUNT_MERGE_NO_ACCOUNT;
                case AccountMergeResultCode.ACCOUNT_MERGE_IMMUTABLE_SET:
                var result_ACCOUNT_MERGE_IMMUTABLE_SET = new AccountMergeResult.AccountMergeImmutableSet();
                return result_ACCOUNT_MERGE_IMMUTABLE_SET;
                case AccountMergeResultCode.ACCOUNT_MERGE_HAS_SUB_ENTRIES:
                var result_ACCOUNT_MERGE_HAS_SUB_ENTRIES = new AccountMergeResult.AccountMergeHasSubEntries();
                return result_ACCOUNT_MERGE_HAS_SUB_ENTRIES;
                case AccountMergeResultCode.ACCOUNT_MERGE_SEQNUM_TOO_FAR:
                var result_ACCOUNT_MERGE_SEQNUM_TOO_FAR = new AccountMergeResult.AccountMergeSeqnumTooFar();
                return result_ACCOUNT_MERGE_SEQNUM_TOO_FAR;
                case AccountMergeResultCode.ACCOUNT_MERGE_DEST_FULL:
                var result_ACCOUNT_MERGE_DEST_FULL = new AccountMergeResult.AccountMergeDestFull();
                return result_ACCOUNT_MERGE_DEST_FULL;
                case AccountMergeResultCode.ACCOUNT_MERGE_IS_SPONSOR:
                var result_ACCOUNT_MERGE_IS_SPONSOR = new AccountMergeResult.AccountMergeIsSponsor();
                return result_ACCOUNT_MERGE_IS_SPONSOR;
                default:
                throw new Exception($"Unknown discriminator for AccountMergeResult: {discriminator}");
            }
        }
    }
}
