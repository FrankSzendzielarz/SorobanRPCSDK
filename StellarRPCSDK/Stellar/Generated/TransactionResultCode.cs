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
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public enum TransactionResultCode
    {
        txFEE_BUMP_INNER_SUCCESS = 1,
        /// <summary>
        /// fee bump inner transaction succeeded
        /// </summary>
        txSUCCESS = 0,
        txFAILED = -1,
        txTOO_EARLY = -2,
        /// <summary>
        /// ledger closeTime before minTime
        /// </summary>
        txTOO_LATE = -3,
        /// <summary>
        /// ledger closeTime after maxTime
        /// </summary>
        txMISSING_OPERATION = -4,
        /// <summary>
        /// no operation was specified
        /// </summary>
        txBAD_SEQ = -5,
        txBAD_AUTH = -6,
        /// <summary>
        /// too few valid signatures / wrong network
        /// </summary>
        txINSUFFICIENT_BALANCE = -7,
        /// <summary>
        /// fee would bring account below reserve
        /// </summary>
        txNO_ACCOUNT = -8,
        /// <summary>
        /// source account not found
        /// </summary>
        txINSUFFICIENT_FEE = -9,
        /// <summary>
        /// fee is too small
        /// </summary>
        txBAD_AUTH_EXTRA = -10,
        /// <summary>
        /// unused signatures attached to transaction
        /// </summary>
        txINTERNAL_ERROR = -11,
        txNOT_SUPPORTED = -12,
        /// <summary>
        /// transaction type not supported
        /// </summary>
        txFEE_BUMP_INNER_FAILED = -13,
        /// <summary>
        /// fee bump inner transaction failed
        /// </summary>
        txBAD_SPONSORSHIP = -14,
        /// <summary>
        /// sponsorship not confirmed
        /// </summary>
        txBAD_MIN_SEQ_AGE_OR_GAP = -15,
        /// <summary>
        /// minSeqAge or minSeqLedgerGap conditions not met
        /// </summary>
        txMALFORMED = -16,
        /// <summary>
        /// precondition is invalid
        /// </summary>
        txSOROBAN_INVALID = -17,
    }

    public static partial class TransactionResultCodeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TransactionResultCode value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TransactionResultCodeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
}
