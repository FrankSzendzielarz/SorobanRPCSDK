// Generated code - do not modify
// Source:

// enum TransactionResultCode
// {
//     txFEE_BUMP_INNER_SUCCESS = 1, // fee bump inner transaction succeeded
//     txSUCCESS = 0,                // all operations succeeded
// 
//     txFAILED = -1, // one of the operations failed (none were applied)
// 
//     txTOO_EARLY = -2,         // ledger closeTime before minTime
//     txTOO_LATE = -3,          // ledger closeTime after maxTime
//     txMISSING_OPERATION = -4, // no operation was specified
//     txBAD_SEQ = -5,           // sequence number does not match source account
// 
//     txBAD_AUTH = -6,             // too few valid signatures / wrong network
//     txINSUFFICIENT_BALANCE = -7, // fee would bring account below reserve
//     txNO_ACCOUNT = -8,           // source account not found
//     txINSUFFICIENT_FEE = -9,     // fee is too small
//     txBAD_AUTH_EXTRA = -10,      // unused signatures attached to transaction
//     txINTERNAL_ERROR = -11,      // an unknown error occurred
// 
//     txNOT_SUPPORTED = -12,          // transaction type not supported
//     txFEE_BUMP_INNER_FAILED = -13,  // fee bump inner transaction failed
//     txBAD_SPONSORSHIP = -14,        // sponsorship not confirmed
//     txBAD_MIN_SEQ_AGE_OR_GAP = -15, // minSeqAge or minSeqLedgerGap conditions not met
//     txMALFORMED = -16,              // precondition is invalid
//     txSOROBAN_INVALID = -17         // soroban-specific preconditions were not met
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum TransactionResultCode
    {
        txFEE_BUMP_INNER_SUCCESS = 1,
        txSUCCESS = 0,
        txFAILED = -1,
        txTOO_EARLY = -2,
        txTOO_LATE = -3,
        txMISSING_OPERATION = -4,
        txBAD_SEQ = -5,
        txBAD_AUTH = -6,
        txINSUFFICIENT_BALANCE = -7,
        txNO_ACCOUNT = -8,
        txINSUFFICIENT_FEE = -9,
        txBAD_AUTH_EXTRA = -10,
        txINTERNAL_ERROR = -11,
        txNOT_SUPPORTED = -12,
        txFEE_BUMP_INNER_FAILED = -13,
        txBAD_SPONSORSHIP = -14,
        txBAD_MIN_SEQ_AGE_OR_GAP = -15,
        txMALFORMED = -16,
        txSOROBAN_INVALID = -17,
    }

    public static partial class TransactionResultCodeXdr
    {
        /// <summary>Encodes enum value to XDR stream</summary>
        public static void Encode(XdrWriter stream, TransactionResultCode value)
        {
            stream.WriteInt((int)value);
        }
        /// <summary>Decodes enum value from XDR stream</summary>
        public static TransactionResultCode Decode(XdrReader stream)
        {
            var value = stream.ReadInt();
            if (!Enum.IsDefined(typeof(TransactionResultCode), value))
              throw new InvalidOperationException($"Unknown TransactionResultCode value: {value}");
            return (TransactionResultCode)value;
        }
    }
