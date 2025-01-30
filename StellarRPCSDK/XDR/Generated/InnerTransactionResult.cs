// Generated code - do not modify
// Source:

// struct InnerTransactionResult
// {
//     // Always 0. Here for binary compatibility.
//     int64 feeCharged;
// 
//     union switch (TransactionResultCode code)
//     {
//     // txFEE_BUMP_INNER_SUCCESS is not included
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
//     // txFEE_BUMP_INNER_FAILED is not included
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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class InnerTransactionResult
    {
        private int64 _feeCharged;
        public int64 feeCharged
        {
            get => _feeCharged;
            set
            {
                _feeCharged = value;
            }
        }

        private resultUnion _result;
        public resultUnion result
        {
            get => _result;
            set
            {
                _result = value;
            }
        }

        private extUnion _ext;
        public extUnion ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }

        public InnerTransactionResult()
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

        }
        public sealed partial class resultUnion_txSUCCESS : resultUnion
        {
            public override TransactionResultCode Discriminator => TransactionResultCode.txSUCCESS;
            private OperationResult[] _results;
            public OperationResult[] results
            {
                get => _results;
                set
                {
                    _results = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class resultUnion_txFAILED : resultUnion
        {
            public override TransactionResultCode Discriminator => TransactionResultCode.txFAILED;
            private OperationResult[] _results;
            public OperationResult[] results
            {
                get => _results;
                set
                {
                    _results = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class resultUnion_txTOO_EARLY : resultUnion
        {
            public override TransactionResultCode Discriminator => TransactionResultCode.txTOO_EARLY;

            public override void ValidateCase() {}
        }
        public sealed partial class resultUnion_txTOO_LATE : resultUnion
        {
            public override TransactionResultCode Discriminator => TransactionResultCode.txTOO_LATE;

            public override void ValidateCase() {}
        }
        public sealed partial class resultUnion_txMISSING_OPERATION : resultUnion
        {
            public override TransactionResultCode Discriminator => TransactionResultCode.txMISSING_OPERATION;

            public override void ValidateCase() {}
        }
        public sealed partial class resultUnion_txBAD_SEQ : resultUnion
        {
            public override TransactionResultCode Discriminator => TransactionResultCode.txBAD_SEQ;

            public override void ValidateCase() {}
        }
        public sealed partial class resultUnion_txBAD_AUTH : resultUnion
        {
            public override TransactionResultCode Discriminator => TransactionResultCode.txBAD_AUTH;

            public override void ValidateCase() {}
        }
        public sealed partial class resultUnion_txINSUFFICIENT_BALANCE : resultUnion
        {
            public override TransactionResultCode Discriminator => TransactionResultCode.txINSUFFICIENT_BALANCE;

            public override void ValidateCase() {}
        }
        public sealed partial class resultUnion_txNO_ACCOUNT : resultUnion
        {
            public override TransactionResultCode Discriminator => TransactionResultCode.txNO_ACCOUNT;

            public override void ValidateCase() {}
        }
        public sealed partial class resultUnion_txINSUFFICIENT_FEE : resultUnion
        {
            public override TransactionResultCode Discriminator => TransactionResultCode.txINSUFFICIENT_FEE;

            public override void ValidateCase() {}
        }
        public sealed partial class resultUnion_txBAD_AUTH_EXTRA : resultUnion
        {
            public override TransactionResultCode Discriminator => TransactionResultCode.txBAD_AUTH_EXTRA;

            public override void ValidateCase() {}
        }
        public sealed partial class resultUnion_txINTERNAL_ERROR : resultUnion
        {
            public override TransactionResultCode Discriminator => TransactionResultCode.txINTERNAL_ERROR;

            public override void ValidateCase() {}
        }
        public sealed partial class resultUnion_txNOT_SUPPORTED : resultUnion
        {
            public override TransactionResultCode Discriminator => TransactionResultCode.txNOT_SUPPORTED;

            public override void ValidateCase() {}
        }
        public sealed partial class resultUnion_txBAD_SPONSORSHIP : resultUnion
        {
            public override TransactionResultCode Discriminator => TransactionResultCode.txBAD_SPONSORSHIP;

            public override void ValidateCase() {}
        }
        public sealed partial class resultUnion_txBAD_MIN_SEQ_AGE_OR_GAP : resultUnion
        {
            public override TransactionResultCode Discriminator => TransactionResultCode.txBAD_MIN_SEQ_AGE_OR_GAP;

            public override void ValidateCase() {}
        }
        public sealed partial class resultUnion_txMALFORMED : resultUnion
        {
            public override TransactionResultCode Discriminator => TransactionResultCode.txMALFORMED;

            public override void ValidateCase() {}
        }
        public sealed partial class resultUnion_txSOROBAN_INVALID : resultUnion
        {
            public override TransactionResultCode Discriminator => TransactionResultCode.txSOROBAN_INVALID;

            public override void ValidateCase() {}
        }
        public static partial class resultUnionXdr
        {
            public static void Encode(XdrWriter stream, resultUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case resultUnion_txSUCCESS case_txSUCCESS:
                    stream.WriteInt(case_txSUCCESS.results.Length);
                    foreach (var item in case_txSUCCESS.results)
                    {
                            OperationResultXdr.Encode(stream, item);
                    }
                    break;
                    case resultUnion_txFAILED case_txFAILED:
                    stream.WriteInt(case_txFAILED.results.Length);
                    foreach (var item in case_txFAILED.results)
                    {
                            OperationResultXdr.Encode(stream, item);
                    }
                    break;
                    case resultUnion_txTOO_EARLY case_txTOO_EARLY:
                    break;
                    case resultUnion_txTOO_LATE case_txTOO_LATE:
                    break;
                    case resultUnion_txMISSING_OPERATION case_txMISSING_OPERATION:
                    break;
                    case resultUnion_txBAD_SEQ case_txBAD_SEQ:
                    break;
                    case resultUnion_txBAD_AUTH case_txBAD_AUTH:
                    break;
                    case resultUnion_txINSUFFICIENT_BALANCE case_txINSUFFICIENT_BALANCE:
                    break;
                    case resultUnion_txNO_ACCOUNT case_txNO_ACCOUNT:
                    break;
                    case resultUnion_txINSUFFICIENT_FEE case_txINSUFFICIENT_FEE:
                    break;
                    case resultUnion_txBAD_AUTH_EXTRA case_txBAD_AUTH_EXTRA:
                    break;
                    case resultUnion_txINTERNAL_ERROR case_txINTERNAL_ERROR:
                    break;
                    case resultUnion_txNOT_SUPPORTED case_txNOT_SUPPORTED:
                    break;
                    case resultUnion_txBAD_SPONSORSHIP case_txBAD_SPONSORSHIP:
                    break;
                    case resultUnion_txBAD_MIN_SEQ_AGE_OR_GAP case_txBAD_MIN_SEQ_AGE_OR_GAP:
                    break;
                    case resultUnion_txMALFORMED case_txMALFORMED:
                    break;
                    case resultUnion_txSOROBAN_INVALID case_txSOROBAN_INVALID:
                    break;
                }
            }
            public static resultUnion Decode(XdrReader stream)
            {
                var discriminator = (TransactionResultCode)stream.ReadInt();
                switch (discriminator)
                {
                    case TransactionResultCode.txSUCCESS:
                    var result_txSUCCESS = new resultUnion_txSUCCESS();
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
                    var result_txFAILED = new resultUnion_txFAILED();
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
                    var result_txTOO_EARLY = new resultUnion_txTOO_EARLY();
                    return result_txTOO_EARLY;
                    case TransactionResultCode.txTOO_LATE:
                    var result_txTOO_LATE = new resultUnion_txTOO_LATE();
                    return result_txTOO_LATE;
                    case TransactionResultCode.txMISSING_OPERATION:
                    var result_txMISSING_OPERATION = new resultUnion_txMISSING_OPERATION();
                    return result_txMISSING_OPERATION;
                    case TransactionResultCode.txBAD_SEQ:
                    var result_txBAD_SEQ = new resultUnion_txBAD_SEQ();
                    return result_txBAD_SEQ;
                    case TransactionResultCode.txBAD_AUTH:
                    var result_txBAD_AUTH = new resultUnion_txBAD_AUTH();
                    return result_txBAD_AUTH;
                    case TransactionResultCode.txINSUFFICIENT_BALANCE:
                    var result_txINSUFFICIENT_BALANCE = new resultUnion_txINSUFFICIENT_BALANCE();
                    return result_txINSUFFICIENT_BALANCE;
                    case TransactionResultCode.txNO_ACCOUNT:
                    var result_txNO_ACCOUNT = new resultUnion_txNO_ACCOUNT();
                    return result_txNO_ACCOUNT;
                    case TransactionResultCode.txINSUFFICIENT_FEE:
                    var result_txINSUFFICIENT_FEE = new resultUnion_txINSUFFICIENT_FEE();
                    return result_txINSUFFICIENT_FEE;
                    case TransactionResultCode.txBAD_AUTH_EXTRA:
                    var result_txBAD_AUTH_EXTRA = new resultUnion_txBAD_AUTH_EXTRA();
                    return result_txBAD_AUTH_EXTRA;
                    case TransactionResultCode.txINTERNAL_ERROR:
                    var result_txINTERNAL_ERROR = new resultUnion_txINTERNAL_ERROR();
                    return result_txINTERNAL_ERROR;
                    case TransactionResultCode.txNOT_SUPPORTED:
                    var result_txNOT_SUPPORTED = new resultUnion_txNOT_SUPPORTED();
                    return result_txNOT_SUPPORTED;
                    case TransactionResultCode.txBAD_SPONSORSHIP:
                    var result_txBAD_SPONSORSHIP = new resultUnion_txBAD_SPONSORSHIP();
                    return result_txBAD_SPONSORSHIP;
                    case TransactionResultCode.txBAD_MIN_SEQ_AGE_OR_GAP:
                    var result_txBAD_MIN_SEQ_AGE_OR_GAP = new resultUnion_txBAD_MIN_SEQ_AGE_OR_GAP();
                    return result_txBAD_MIN_SEQ_AGE_OR_GAP;
                    case TransactionResultCode.txMALFORMED:
                    var result_txMALFORMED = new resultUnion_txMALFORMED();
                    return result_txMALFORMED;
                    case TransactionResultCode.txSOROBAN_INVALID:
                    var result_txSOROBAN_INVALID = new resultUnion_txSOROBAN_INVALID();
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

        }
        public sealed partial class extUnion_0 : extUnion
        {
            public override int Discriminator => 0;

            public override void ValidateCase() {}
        }
        public static partial class extUnionXdr
        {
            public static void Encode(XdrWriter stream, extUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case extUnion_0 case_0:
                    break;
                }
            }
            public static extUnion Decode(XdrReader stream)
            {
                var discriminator = (int)stream.ReadInt();
                switch (discriminator)
                {
                    case 0:
                    var result_0 = new extUnion_0();
                    return result_0;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class InnerTransactionResultXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, InnerTransactionResult value)
        {
            value.Validate();
            int64Xdr.Encode(stream, value.feeCharged);
            InnerTransactionResult.resultUnionXdr.Encode(stream, value.result);
            InnerTransactionResult.extUnionXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static InnerTransactionResult Decode(XdrReader stream)
        {
            var result = new InnerTransactionResult();
            result.feeCharged = int64Xdr.Decode(stream);
            result.result = InnerTransactionResult.resultUnionXdr.Decode(stream);
            result.ext = InnerTransactionResult.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
