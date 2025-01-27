// Generated code - do not modify
// Source:

// enum AccountMergeResultCode
// {
//     // codes considered as "success" for the operation
//     ACCOUNT_MERGE_SUCCESS = 0,
//     // codes considered as "failure" for the operation
//     ACCOUNT_MERGE_MALFORMED = -1,       // can't merge onto itself
//     ACCOUNT_MERGE_NO_ACCOUNT = -2,      // destination does not exist
//     ACCOUNT_MERGE_IMMUTABLE_SET = -3,   // source account has AUTH_IMMUTABLE set
//     ACCOUNT_MERGE_HAS_SUB_ENTRIES = -4, // account has trust lines/offers
//     ACCOUNT_MERGE_SEQNUM_TOO_FAR = -5,  // sequence number is over max allowed
//     ACCOUNT_MERGE_DEST_FULL = -6,       // can't add source balance to
//                                         // destination balance
//     ACCOUNT_MERGE_IS_SPONSOR = -7       // can't merge account that is a sponsor
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum AccountMergeResultCode
    {
        ACCOUNT_MERGE_SUCCESS = 0,
        ACCOUNT_MERGE_MALFORMED = -1,
        ACCOUNT_MERGE_NO_ACCOUNT = -2,
        ACCOUNT_MERGE_IMMUTABLE_SET = -3,
        ACCOUNT_MERGE_HAS_SUB_ENTRIES = -4,
        ACCOUNT_MERGE_SEQNUM_TOO_FAR = -5,
        ACCOUNT_MERGE_DEST_FULL = -6,
        ACCOUNT_MERGE_IS_SPONSOR = -7,
    }

    public static partial class AccountMergeResultCodeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, AccountMergeResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static AccountMergeResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(AccountMergeResultCode), value))
              throw new InvalidOperationException($"Unknown AccountMergeResultCode value: {value}");
            return (AccountMergeResultCode)value;
        }
    }
