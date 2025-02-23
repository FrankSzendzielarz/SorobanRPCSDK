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
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    /// <summary>
    /// because it is be used to represent the result of a Transaction.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    public partial class InnerTransactionResult
    {
        /// <summary>
        /// Always 0. Here for binary compatibility.
        /// </summary>
        [ProtoMember(1)]
        public int64 feeCharged
        {
            get => _feeCharged;
            set
            {
                _feeCharged = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Fee Charged")]
        #endif
        private int64 _feeCharged;

        [ProtoMember(2)]
        public resultUnion result
        {
            get => _result;
            set
            {
                _result = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Result")]
        #endif
        private resultUnion _result;

        /// <summary>
        /// reserved for future use
        /// </summary>
        [ProtoMember(3)]
        public extUnion ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Ext")]
        #endif
        private extUnion _ext;

        public InnerTransactionResult()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "InnerTransactionResult.resultUnion")]
        [ProtoInclude(100, typeof(TxSUCCESS), DataFormat = DataFormat.Default)]
        [ProtoInclude(101, typeof(TxFAILED), DataFormat = DataFormat.Default)]
        [ProtoInclude(102, typeof(TxtooEarly), DataFormat = DataFormat.Default)]
        [ProtoInclude(103, typeof(TxtooLate), DataFormat = DataFormat.Default)]
        [ProtoInclude(104, typeof(TxmissingOperation), DataFormat = DataFormat.Default)]
        [ProtoInclude(105, typeof(TxbadSeq), DataFormat = DataFormat.Default)]
        [ProtoInclude(106, typeof(TxbadAuth), DataFormat = DataFormat.Default)]
        [ProtoInclude(107, typeof(TxinsufficientBalance), DataFormat = DataFormat.Default)]
        [ProtoInclude(108, typeof(TxnoAccount), DataFormat = DataFormat.Default)]
        [ProtoInclude(109, typeof(TxinsufficientFee), DataFormat = DataFormat.Default)]
        [ProtoInclude(110, typeof(TxbadAuthExtra), DataFormat = DataFormat.Default)]
        [ProtoInclude(111, typeof(TxinternalError), DataFormat = DataFormat.Default)]
        [ProtoInclude(112, typeof(TxnotSupported), DataFormat = DataFormat.Default)]
        [ProtoInclude(113, typeof(TxbadSponsorship), DataFormat = DataFormat.Default)]
        [ProtoInclude(114, typeof(TxbadMinSeqAgeOrGap), DataFormat = DataFormat.Default)]
        [ProtoInclude(115, typeof(TxMALFORMED), DataFormat = DataFormat.Default)]
        [ProtoInclude(116, typeof(TxsorobanInvalid), DataFormat = DataFormat.Default)]
        public abstract partial class resultUnion
        {
            public abstract TransactionResultCode Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            /// <summary>
            /// txFEE_BUMP_INNER_SUCCESS is not included
            /// </summary>
            [System.Serializable]
            [ProtoContract(Name = "InnerTransactionResult.resultUnion.TxSUCCESS")]
            public sealed partial class TxSUCCESS : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txSUCCESS;
                [ProtoMember(1)]
                public OperationResult[] results
                {
                    get => _results;
                    set
                    {
                        _results = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Results")]
                #endif
                private OperationResult[] _results;

                public override void ValidateCase() {}
            }
            /// <summary>
            /// txFEE_BUMP_INNER_SUCCESS is not included
            /// </summary>
            [System.Serializable]
            [ProtoContract(Name = "InnerTransactionResult.resultUnion.TxFAILED")]
            public sealed partial class TxFAILED : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txFAILED;
                [ProtoMember(2)]
                public OperationResult[] results
                {
                    get => _results;
                    set
                    {
                        _results = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Results")]
                #endif
                private OperationResult[] _results;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "InnerTransactionResult.resultUnion.TxtooEarly")]
            public sealed partial class TxtooEarly : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txTOO_EARLY;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "InnerTransactionResult.resultUnion.TxtooLate")]
            public sealed partial class TxtooLate : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txTOO_LATE;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "InnerTransactionResult.resultUnion.TxmissingOperation")]
            public sealed partial class TxmissingOperation : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txMISSING_OPERATION;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "InnerTransactionResult.resultUnion.TxbadSeq")]
            public sealed partial class TxbadSeq : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txBAD_SEQ;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "InnerTransactionResult.resultUnion.TxbadAuth")]
            public sealed partial class TxbadAuth : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txBAD_AUTH;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "InnerTransactionResult.resultUnion.TxinsufficientBalance")]
            public sealed partial class TxinsufficientBalance : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txINSUFFICIENT_BALANCE;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "InnerTransactionResult.resultUnion.TxnoAccount")]
            public sealed partial class TxnoAccount : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txNO_ACCOUNT;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "InnerTransactionResult.resultUnion.TxinsufficientFee")]
            public sealed partial class TxinsufficientFee : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txINSUFFICIENT_FEE;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "InnerTransactionResult.resultUnion.TxbadAuthExtra")]
            public sealed partial class TxbadAuthExtra : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txBAD_AUTH_EXTRA;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "InnerTransactionResult.resultUnion.TxinternalError")]
            public sealed partial class TxinternalError : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txINTERNAL_ERROR;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "InnerTransactionResult.resultUnion.TxnotSupported")]
            public sealed partial class TxnotSupported : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txNOT_SUPPORTED;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "InnerTransactionResult.resultUnion.TxbadSponsorship")]
            public sealed partial class TxbadSponsorship : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txBAD_SPONSORSHIP;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "InnerTransactionResult.resultUnion.TxbadMinSeqAgeOrGap")]
            public sealed partial class TxbadMinSeqAgeOrGap : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txBAD_MIN_SEQ_AGE_OR_GAP;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "InnerTransactionResult.resultUnion.TxMALFORMED")]
            public sealed partial class TxMALFORMED : resultUnion
            {
                public override TransactionResultCode Discriminator => TransactionResultCode.txMALFORMED;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "InnerTransactionResult.resultUnion.TxsorobanInvalid")]
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
            /// <summary>Decodes value from XDR base64 string</summary>
            public static resultUnion DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return resultUnionXdr.Decode(reader);
                }
            }
            public static void Encode(XdrWriter stream, resultUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
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
        [System.Serializable]
        [ProtoContract(Name = "InnerTransactionResult.extUnion")]
        [ProtoInclude(100, typeof(case_0), DataFormat = DataFormat.Default)]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.Serializable]
            [ProtoContract(Name = "InnerTransactionResult.extUnion.case_0")]
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
            /// <summary>Decodes value from XDR base64 string</summary>
            public static extUnion DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return extUnionXdr.Decode(reader);
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
    public static partial class InnerTransactionResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(InnerTransactionResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                InnerTransactionResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static InnerTransactionResult DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return InnerTransactionResultXdr.Decode(reader);
            }
        }
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
