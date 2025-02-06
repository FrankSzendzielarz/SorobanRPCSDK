// Generated code - do not modify
// Source:

// struct TransactionResult
// {
//     int64 feeCharged; // actual fee charged for the transaction
// 
//     union switch (TransactionResultCode code)
//     {
//     case txFEE_BUMP_INNER_SUCCESS:
//     case txFEE_BUMP_INNER_FAILED:
//         InnerTransactionResultPair innerResultPair;
//     case txSUCCESS:
//     case txFAILED:
//         OperationResult results<>;
//     case txTOO_EARLY:
//     case txTOO_LATE:
//     case txMISSING_OPERATION:
//     case txBAD_SEQ:
//     case txBAD_AUTH:
//     case txINSUFFICIENT_BALANCE:
//     case txNO_ACCOUNT:
//     case txINSUFFICIENT_FEE:
//     case txBAD_AUTH_EXTRA:
//     case txINTERNAL_ERROR:
//     case txNOT_SUPPORTED:
//     // case txFEE_BUMP_INNER_FAILED: handled above
//     case txBAD_SPONSORSHIP:
//     case txBAD_MIN_SEQ_AGE_OR_GAP:
//     case txMALFORMED:
//     case txSOROBAN_INVALID:
//         void;
//     }
//     result;
// 
//     // reserved for future use
//     union switch (int v)
//     {
//     case 0:
//         void;
//     }
//     ext;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class TransactionResult
    {
        public int64 feeCharged
        {
            get => _feeCharged;
            set
            {
                _feeCharged = value;
            }
        }
        private int64 _feeCharged;

        public resultUnion result
        {
            get => _result;
            set
            {
                _result = value;
            }
        }
        private resultUnion _result;

        /// <summary>
        /// reserved for future use
        /// </summary>
        public extUnion ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }
        private extUnion _ext;

        public TransactionResult()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class resultUnion
        {
            public abstract TransactionResultCode Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            public sealed partial class TxfeeBumpInnerSuccess : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txFEE_BUMP_INNER_SUCCESS;
                public InnerTransactionResultPair innerResultPair
                {
                    get => _innerResultPair;
                    set
                    {
                        _innerResultPair = value;
                    }
                }
                private InnerTransactionResultPair _innerResultPair;

                public override void ValidateCase() {}
            }
            public sealed partial class TxfeeBumpInnerFailed : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txFEE_BUMP_INNER_FAILED;
                public InnerTransactionResultPair innerResultPair
                {
                    get => _innerResultPair;
                    set
                    {
                        _innerResultPair = value;
                    }
                }
                private InnerTransactionResultPair _innerResultPair;

                public override void ValidateCase() {}
            }
            public sealed partial class TxSUCCESS : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txSUCCESS;
                public OperationResult[] results
                {
                    get => _results;
                    set
                    {
                        _results = value;
                    }
                }
                private OperationResult[] _results;

                public override void ValidateCase() {}
            }
            public sealed partial class TxFAILED : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txFAILED;
                public OperationResult[] results
                {
                    get => _results;
                    set
                    {
                        _results = value;
                    }
                }
                private OperationResult[] _results;

                public override void ValidateCase() {}
            }
            public sealed partial class TxtooEarly : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txTOO_EARLY;

                public override void ValidateCase() {}
            }
            public sealed partial class TxtooLate : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txTOO_LATE;

                public override void ValidateCase() {}
            }
            public sealed partial class TxmissingOperation : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txMISSING_OPERATION;

                public override void ValidateCase() {}
            }
            public sealed partial class TxbadSeq : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txBAD_SEQ;

                public override void ValidateCase() {}
            }
            public sealed partial class TxbadAuth : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txBAD_AUTH;

                public override void ValidateCase() {}
            }
            public sealed partial class TxinsufficientBalance : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txINSUFFICIENT_BALANCE;

                public override void ValidateCase() {}
            }
            public sealed partial class TxnoAccount : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txNO_ACCOUNT;

                public override void ValidateCase() {}
            }
            public sealed partial class TxinsufficientFee : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txINSUFFICIENT_FEE;

                public override void ValidateCase() {}
            }
            public sealed partial class TxbadAuthExtra : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txBAD_AUTH_EXTRA;

                public override void ValidateCase() {}
            }
            public sealed partial class TxinternalError : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txINTERNAL_ERROR;

                public override void ValidateCase() {}
            }
            public sealed partial class TxnotSupported : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txNOT_SUPPORTED;

                public override void ValidateCase() {}
            }
            public sealed partial class TxbadSponsorship : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txBAD_SPONSORSHIP;

                public override void ValidateCase() {}
            }
            public sealed partial class TxbadMinSeqAgeOrGap : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txBAD_MIN_SEQ_AGE_OR_GAP;

                public override void ValidateCase() {}
            }
            public sealed partial class TxMALFORMED : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txMALFORMED;

                public override void ValidateCase() {}
            }
            public sealed partial class TxsorobanInvalid : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txSOROBAN_INVALID;

                public override void ValidateCase() {}
            }
        }
        public static partial class resultUnionXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(resultUnion value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    resultUnionXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            public static void Encode(XdrWriter stream, resultUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case resultUnion.TxfeeBumpInnerSuccess case_txFEE_BUMP_INNER_SUCCESS:
                    InnerTransactionResultPairXdr.Encode(stream, case_txFEE_BUMP_INNER_SUCCESS.innerResultPair);
                    break;
                    case resultUnion.TxfeeBumpInnerFailed case_txFEE_BUMP_INNER_FAILED:
                    InnerTransactionResultPairXdr.Encode(stream, case_txFEE_BUMP_INNER_FAILED.innerResultPair);
                    break;
                    case resultUnion.TxSUCCESS case_txSUCCESS:
                    stream.WriteInt(case_txSUCCESS.results.Length);
                    foreach (var item in case_txSUCCESS.results)
                    {
                            OperationResultXdr.Encode(stream, item);
                    }
                    break;
                    case resultUnion.TxFAILED case_txFAILED:
                    stream.WriteInt(case_txFAILED.results.Length);
                    foreach (var item in case_txFAILED.results)
                    {
                            OperationResultXdr.Encode(stream, item);
                    }
                    break;
                    case resultUnion.TxtooEarly case_txTOO_EARLY:
                    break;
                    case resultUnion.TxtooLate case_txTOO_LATE:
                    break;
                    case resultUnion.TxmissingOperation case_txMISSING_OPERATION:
                    break;
                    case resultUnion.TxbadSeq case_txBAD_SEQ:
                    break;
                    case resultUnion.TxbadAuth case_txBAD_AUTH:
                    break;
                    case resultUnion.TxinsufficientBalance case_txINSUFFICIENT_BALANCE:
                    break;
                    case resultUnion.TxnoAccount case_txNO_ACCOUNT:
                    break;
                    case resultUnion.TxinsufficientFee case_txINSUFFICIENT_FEE:
                    break;
                    case resultUnion.TxbadAuthExtra case_txBAD_AUTH_EXTRA:
                    break;
                    case resultUnion.TxinternalError case_txINTERNAL_ERROR:
                    break;
                    case resultUnion.TxnotSupported case_txNOT_SUPPORTED:
                    break;
                    case resultUnion.TxbadSponsorship case_txBAD_SPONSORSHIP:
                    break;
                    case resultUnion.TxbadMinSeqAgeOrGap case_txBAD_MIN_SEQ_AGE_OR_GAP:
                    break;
                    case resultUnion.TxMALFORMED case_txMALFORMED:
                    break;
                    case resultUnion.TxsorobanInvalid case_txSOROBAN_INVALID:
                    break;
                }
            }
            public static resultUnion Decode(XdrReader stream)
            {
                var discriminator = (TransactionResultCode)stream.ReadInt();
                switch (discriminator)
                {
                    case TransactionResultCode.txFEE_BUMP_INNER_SUCCESS:
                    var result_txFEE_BUMP_INNER_SUCCESS = new resultUnion.TxfeeBumpInnerSuccess();
                    result_txFEE_BUMP_INNER_SUCCESS.innerResultPair = InnerTransactionResultPairXdr.Decode(stream);
                    return result_txFEE_BUMP_INNER_SUCCESS;
                    case TransactionResultCode.txFEE_BUMP_INNER_FAILED:
                    var result_txFEE_BUMP_INNER_FAILED = new resultUnion.TxfeeBumpInnerFailed();
                    result_txFEE_BUMP_INNER_FAILED.innerResultPair = InnerTransactionResultPairXdr.Decode(stream);
                    return result_txFEE_BUMP_INNER_FAILED;
                    case TransactionResultCode.txSUCCESS:
                    var result_txSUCCESS = new resultUnion.TxSUCCESS();
                    {
                        var length = stream.ReadInt();
                        result_txSUCCESS.results = new OperationResult[length];
                        for (var i = 0; i < length; i++)
                        {
                            result_txSUCCESS.results[i] = OperationResultXdr.Decode(stream);
                        }
                    }
                    return result_txSUCCESS;
                    case TransactionResultCode.txFAILED:
                    var result_txFAILED = new resultUnion.TxFAILED();
                    {
                        var length = stream.ReadInt();
                        result_txFAILED.results = new OperationResult[length];
                        for (var i = 0; i < length; i++)
                        {
                            result_txFAILED.results[i] = OperationResultXdr.Decode(stream);
                        }
                    }
                    return result_txFAILED;
                    case TransactionResultCode.txTOO_EARLY:
                    var result_txTOO_EARLY = new resultUnion.TxtooEarly();
                    return result_txTOO_EARLY;
                    case TransactionResultCode.txTOO_LATE:
                    var result_txTOO_LATE = new resultUnion.TxtooLate();
                    return result_txTOO_LATE;
                    case TransactionResultCode.txMISSING_OPERATION:
                    var result_txMISSING_OPERATION = new resultUnion.TxmissingOperation();
                    return result_txMISSING_OPERATION;
                    case TransactionResultCode.txBAD_SEQ:
                    var result_txBAD_SEQ = new resultUnion.TxbadSeq();
                    return result_txBAD_SEQ;
                    case TransactionResultCode.txBAD_AUTH:
                    var result_txBAD_AUTH = new resultUnion.TxbadAuth();
                    return result_txBAD_AUTH;
                    case TransactionResultCode.txINSUFFICIENT_BALANCE:
                    var result_txINSUFFICIENT_BALANCE = new resultUnion.TxinsufficientBalance();
                    return result_txINSUFFICIENT_BALANCE;
                    case TransactionResultCode.txNO_ACCOUNT:
                    var result_txNO_ACCOUNT = new resultUnion.TxnoAccount();
                    return result_txNO_ACCOUNT;
                    case TransactionResultCode.txINSUFFICIENT_FEE:
                    var result_txINSUFFICIENT_FEE = new resultUnion.TxinsufficientFee();
                    return result_txINSUFFICIENT_FEE;
                    case TransactionResultCode.txBAD_AUTH_EXTRA:
                    var result_txBAD_AUTH_EXTRA = new resultUnion.TxbadAuthExtra();
                    return result_txBAD_AUTH_EXTRA;
                    case TransactionResultCode.txINTERNAL_ERROR:
                    var result_txINTERNAL_ERROR = new resultUnion.TxinternalError();
                    return result_txINTERNAL_ERROR;
                    case TransactionResultCode.txNOT_SUPPORTED:
                    var result_txNOT_SUPPORTED = new resultUnion.TxnotSupported();
                    return result_txNOT_SUPPORTED;
                    case TransactionResultCode.txBAD_SPONSORSHIP:
                    var result_txBAD_SPONSORSHIP = new resultUnion.TxbadSponsorship();
                    return result_txBAD_SPONSORSHIP;
                    case TransactionResultCode.txBAD_MIN_SEQ_AGE_OR_GAP:
                    var result_txBAD_MIN_SEQ_AGE_OR_GAP = new resultUnion.TxbadMinSeqAgeOrGap();
                    return result_txBAD_MIN_SEQ_AGE_OR_GAP;
                    case TransactionResultCode.txMALFORMED:
                    var result_txMALFORMED = new resultUnion.TxMALFORMED();
                    return result_txMALFORMED;
                    case TransactionResultCode.txSOROBAN_INVALID:
                    var result_txSOROBAN_INVALID = new resultUnion.TxsorobanInvalid();
                    return result_txSOROBAN_INVALID;
                    default:
                    throw new Exception($"Unknown discriminator for resultUnion: {discriminator}");
                }
            }
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            public sealed partial class case_0 : extUnion
            {
                public override int Discriminator => 0;

                public override void ValidateCase() {}
            }
        }
        public static partial class extUnionXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(extUnion value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    extUnionXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            public static void Encode(XdrWriter stream, extUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case extUnion.case_0 case_0:
                    break;
                }
            }
            public static extUnion Decode(XdrReader stream)
            {
                var discriminator = (int)stream.ReadInt();
                switch (discriminator)
                {
                    case 0:
                    var result_0 = new extUnion.case_0();
                    return result_0;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class TransactionResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TransactionResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TransactionResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TransactionResult value)
        {
            value.Validate();
            int64Xdr.Encode(stream, value.feeCharged);
            TransactionResult.resultUnionXdr.Encode(stream, value.result);
            TransactionResult.extUnionXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TransactionResult Decode(XdrReader stream)
        {
            var result = new TransactionResult();
            result.feeCharged = int64Xdr.Decode(stream);
            result.result = TransactionResult.resultUnionXdr.Decode(stream);
            result.ext = TransactionResult.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
