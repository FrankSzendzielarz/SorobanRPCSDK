// Generated code - do not modify
// Source:

// union SCVal switch (SCValType type)
// {
// 
// case SCV_BOOL:
//     bool b;
// case SCV_VOID:
//     void;
// case SCV_ERROR:
//     SCError error;
// 
// case SCV_U32:
//     uint32 u32;
// case SCV_I32:
//     int32 i32;
// 
// case SCV_U64:
//     uint64 u64;
// case SCV_I64:
//     int64 i64;
// case SCV_TIMEPOINT:
//     TimePoint timepoint;
// case SCV_DURATION:
//     Duration duration;
// 
// case SCV_U128:
//     UInt128Parts u128;
// case SCV_I128:
//     Int128Parts i128;
// 
// case SCV_U256:
//     UInt256Parts u256;
// case SCV_I256:
//     Int256Parts i256;
// 
// case SCV_BYTES:
//     SCBytes bytes;
// case SCV_STRING:
//     SCString str;
// case SCV_SYMBOL:
//     SCSymbol sym;
// 
// // Vec and Map are recursive so need to live
// // behind an option, due to xdrpp limitations.
// case SCV_VEC:
//     SCVec *vec;
// case SCV_MAP:
//     SCMap *map;
// 
// case SCV_ADDRESS:
//     SCAddress address;
// 
// // Special SCVals reserved for system-constructed contract-data
// // ledger keys, not generally usable elsewhere.
// case SCV_LEDGER_KEY_CONTRACT_INSTANCE:
//     void;
// case SCV_LEDGER_KEY_NONCE:
//     SCNonceKey nonce_key;
// 
// case SCV_CONTRACT_INSTANCE:
//     SCContractInstance instance;
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
    [ProtoInclude(100, typeof(ScvBool), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(ScvVoid), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(ScvError), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(ScvU32), DataFormat = DataFormat.Default)]
    [ProtoInclude(104, typeof(ScvI32), DataFormat = DataFormat.Default)]
    [ProtoInclude(105, typeof(ScvU64), DataFormat = DataFormat.Default)]
    [ProtoInclude(106, typeof(ScvI64), DataFormat = DataFormat.Default)]
    [ProtoInclude(107, typeof(ScvTimepoint), DataFormat = DataFormat.Default)]
    [ProtoInclude(108, typeof(ScvDuration), DataFormat = DataFormat.Default)]
    [ProtoInclude(109, typeof(ScvU128), DataFormat = DataFormat.Default)]
    [ProtoInclude(110, typeof(ScvI128), DataFormat = DataFormat.Default)]
    [ProtoInclude(111, typeof(ScvU256), DataFormat = DataFormat.Default)]
    [ProtoInclude(112, typeof(ScvI256), DataFormat = DataFormat.Default)]
    [ProtoInclude(113, typeof(ScvBytes), DataFormat = DataFormat.Default)]
    [ProtoInclude(114, typeof(ScvString), DataFormat = DataFormat.Default)]
    [ProtoInclude(115, typeof(ScvSymbol), DataFormat = DataFormat.Default)]
    [ProtoInclude(116, typeof(ScvVec), DataFormat = DataFormat.Default)]
    [ProtoInclude(117, typeof(ScvMap), DataFormat = DataFormat.Default)]
    [ProtoInclude(118, typeof(ScvAddress), DataFormat = DataFormat.Default)]
    [ProtoInclude(119, typeof(ScvLedgerKeyContractInstance), DataFormat = DataFormat.Default)]
    [ProtoInclude(120, typeof(ScvLedgerKeyNonce), DataFormat = DataFormat.Default)]
    [ProtoInclude(121, typeof(ScvContractInstance), DataFormat = DataFormat.Default)]
    public abstract partial class SCVal
    {
        public abstract SCValType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvBool")]
        public sealed partial class ScvBool : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_BOOL;
            [ProtoMember(1)]
            public bool b
            {
                get => _b;
                set
                {
                    _b = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"B")]
            #endif
            private bool _b;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvVoid")]
        public sealed partial class ScvVoid : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_VOID;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvError")]
        public sealed partial class ScvError : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_ERROR;
            [ProtoMember(2)]
            public SCError error
            {
                get => _error;
                set
                {
                    _error = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Error")]
            #endif
            private SCError _error;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvU32")]
        public sealed partial class ScvU32 : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_U32;
            [ProtoMember(3)]
            public uint32 u32
            {
                get => _u32;
                set
                {
                    _u32 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"U32")]
            #endif
            private uint32 _u32;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvI32")]
        public sealed partial class ScvI32 : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_I32;
            [ProtoMember(4)]
            public int32 i32
            {
                get => _i32;
                set
                {
                    _i32 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"I32")]
            #endif
            private int32 _i32;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvU64")]
        public sealed partial class ScvU64 : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_U64;
            [ProtoMember(5)]
            public uint64 u64
            {
                get => _u64;
                set
                {
                    _u64 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"U64")]
            #endif
            private uint64 _u64;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvI64")]
        public sealed partial class ScvI64 : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_I64;
            [ProtoMember(6)]
            public int64 i64
            {
                get => _i64;
                set
                {
                    _i64 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"I64")]
            #endif
            private int64 _i64;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvTimepoint")]
        public sealed partial class ScvTimepoint : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_TIMEPOINT;
            [ProtoMember(7)]
            public TimePoint timepoint
            {
                get => _timepoint;
                set
                {
                    _timepoint = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Timepoint")]
            #endif
            private TimePoint _timepoint;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvDuration")]
        public sealed partial class ScvDuration : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_DURATION;
            [ProtoMember(8)]
            public Duration duration
            {
                get => _duration;
                set
                {
                    _duration = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Duration")]
            #endif
            private Duration _duration;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvU128")]
        public sealed partial class ScvU128 : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_U128;
            [ProtoMember(9)]
            public UInt128Parts u128
            {
                get => _u128;
                set
                {
                    _u128 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"U128")]
            #endif
            private UInt128Parts _u128;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvI128")]
        public sealed partial class ScvI128 : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_I128;
            [ProtoMember(10)]
            public Int128Parts i128
            {
                get => _i128;
                set
                {
                    _i128 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"I128")]
            #endif
            private Int128Parts _i128;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvU256")]
        public sealed partial class ScvU256 : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_U256;
            [ProtoMember(11)]
            public UInt256Parts u256
            {
                get => _u256;
                set
                {
                    _u256 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"U256")]
            #endif
            private UInt256Parts _u256;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvI256")]
        public sealed partial class ScvI256 : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_I256;
            [ProtoMember(12)]
            public Int256Parts i256
            {
                get => _i256;
                set
                {
                    _i256 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"I256")]
            #endif
            private Int256Parts _i256;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvBytes")]
        public sealed partial class ScvBytes : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_BYTES;
            [ProtoMember(13)]
            public SCBytes bytes
            {
                get => _bytes;
                set
                {
                    _bytes = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Bytes")]
            #endif
            private SCBytes _bytes;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvString")]
        public sealed partial class ScvString : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_STRING;
            [ProtoMember(14)]
            public SCString str
            {
                get => _str;
                set
                {
                    _str = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Str")]
            #endif
            private SCString _str;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvSymbol")]
        public sealed partial class ScvSymbol : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_SYMBOL;
            [ProtoMember(15)]
            public SCSymbol sym
            {
                get => _sym;
                set
                {
                    _sym = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Sym")]
            #endif
            private SCSymbol _sym;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// behind an option, due to xdrpp limitations.
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvVec")]
        public sealed partial class ScvVec : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_VEC;
            [ProtoMember(16)]
            public SCVec vec
            {
                get => _vec;
                set
                {
                    _vec = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Vec")]
            #endif
            private SCVec _vec;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvMap")]
        public sealed partial class ScvMap : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_MAP;
            [ProtoMember(17)]
            public SCMap map
            {
                get => _map;
                set
                {
                    _map = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Map")]
            #endif
            private SCMap _map;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvAddress")]
        public sealed partial class ScvAddress : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_ADDRESS;
            [ProtoMember(18)]
            public SCAddress address
            {
                get => _address;
                set
                {
                    _address = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Address")]
            #endif
            private SCAddress _address;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// ledger keys, not generally usable elsewhere.
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvLedgerKeyContractInstance")]
        public sealed partial class ScvLedgerKeyContractInstance : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_LEDGER_KEY_CONTRACT_INSTANCE;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvLedgerKeyNonce")]
        public sealed partial class ScvLedgerKeyNonce : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_LEDGER_KEY_NONCE;
            [ProtoMember(19)]
            public SCNonceKey nonce_key
            {
                get => _nonce_key;
                set
                {
                    _nonce_key = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Nonce_key")]
            #endif
            private SCNonceKey _nonce_key;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "SCVal_ScvContractInstance")]
        public sealed partial class ScvContractInstance : SCVal
        {
            public override SCValType Discriminator => SCValType.SCV_CONTRACT_INSTANCE;
            [ProtoMember(20)]
            public SCContractInstance instance
            {
                get => _instance;
                set
                {
                    _instance = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Instance")]
            #endif
            private SCContractInstance _instance;

            public override void ValidateCase() {}
        }
    }
    public static partial class SCValXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCVal value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCValXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static SCVal DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return SCValXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, SCVal value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SCVal.ScvBool case_SCV_BOOL:
                stream.WriteInt(case_SCV_BOOL.b ? 1 : 0);
                break;
                case SCVal.ScvVoid case_SCV_VOID:
                break;
                case SCVal.ScvError case_SCV_ERROR:
                SCErrorXdr.Encode(stream, case_SCV_ERROR.error);
                break;
                case SCVal.ScvU32 case_SCV_U32:
                uint32Xdr.Encode(stream, case_SCV_U32.u32);
                break;
                case SCVal.ScvI32 case_SCV_I32:
                int32Xdr.Encode(stream, case_SCV_I32.i32);
                break;
                case SCVal.ScvU64 case_SCV_U64:
                uint64Xdr.Encode(stream, case_SCV_U64.u64);
                break;
                case SCVal.ScvI64 case_SCV_I64:
                int64Xdr.Encode(stream, case_SCV_I64.i64);
                break;
                case SCVal.ScvTimepoint case_SCV_TIMEPOINT:
                TimePointXdr.Encode(stream, case_SCV_TIMEPOINT.timepoint);
                break;
                case SCVal.ScvDuration case_SCV_DURATION:
                DurationXdr.Encode(stream, case_SCV_DURATION.duration);
                break;
                case SCVal.ScvU128 case_SCV_U128:
                UInt128PartsXdr.Encode(stream, case_SCV_U128.u128);
                break;
                case SCVal.ScvI128 case_SCV_I128:
                Int128PartsXdr.Encode(stream, case_SCV_I128.i128);
                break;
                case SCVal.ScvU256 case_SCV_U256:
                UInt256PartsXdr.Encode(stream, case_SCV_U256.u256);
                break;
                case SCVal.ScvI256 case_SCV_I256:
                Int256PartsXdr.Encode(stream, case_SCV_I256.i256);
                break;
                case SCVal.ScvBytes case_SCV_BYTES:
                SCBytesXdr.Encode(stream, case_SCV_BYTES.bytes);
                break;
                case SCVal.ScvString case_SCV_STRING:
                SCStringXdr.Encode(stream, case_SCV_STRING.str);
                break;
                case SCVal.ScvSymbol case_SCV_SYMBOL:
                SCSymbolXdr.Encode(stream, case_SCV_SYMBOL.sym);
                break;
                case SCVal.ScvVec case_SCV_VEC:
                if (case_SCV_VEC.vec==null){
                	stream.WriteInt(0);
                }
                else
                {
                    stream.WriteInt(1);
                    SCVecXdr.Encode(stream, case_SCV_VEC.vec);
                }
                break;
                case SCVal.ScvMap case_SCV_MAP:
                if (case_SCV_MAP.map==null){
                	stream.WriteInt(0);
                }
                else
                {
                    stream.WriteInt(1);
                    SCMapXdr.Encode(stream, case_SCV_MAP.map);
                }
                break;
                case SCVal.ScvAddress case_SCV_ADDRESS:
                SCAddressXdr.Encode(stream, case_SCV_ADDRESS.address);
                break;
                case SCVal.ScvLedgerKeyContractInstance case_SCV_LEDGER_KEY_CONTRACT_INSTANCE:
                break;
                case SCVal.ScvLedgerKeyNonce case_SCV_LEDGER_KEY_NONCE:
                SCNonceKeyXdr.Encode(stream, case_SCV_LEDGER_KEY_NONCE.nonce_key);
                break;
                case SCVal.ScvContractInstance case_SCV_CONTRACT_INSTANCE:
                SCContractInstanceXdr.Encode(stream, case_SCV_CONTRACT_INSTANCE.instance);
                break;
            }
        }
        public static SCVal Decode(XdrReader stream)
        {
            var discriminator = (SCValType)stream.ReadInt();
            switch (discriminator)
            {
                case SCValType.SCV_BOOL:
                var result_SCV_BOOL = new SCVal.ScvBool();
                result_SCV_BOOL.b = stream.ReadInt() != 0;
                return result_SCV_BOOL;
                case SCValType.SCV_VOID:
                var result_SCV_VOID = new SCVal.ScvVoid();
                return result_SCV_VOID;
                case SCValType.SCV_ERROR:
                var result_SCV_ERROR = new SCVal.ScvError();
                result_SCV_ERROR.error = SCErrorXdr.Decode(stream);
                return result_SCV_ERROR;
                case SCValType.SCV_U32:
                var result_SCV_U32 = new SCVal.ScvU32();
                result_SCV_U32.u32 = uint32Xdr.Decode(stream);
                return result_SCV_U32;
                case SCValType.SCV_I32:
                var result_SCV_I32 = new SCVal.ScvI32();
                result_SCV_I32.i32 = int32Xdr.Decode(stream);
                return result_SCV_I32;
                case SCValType.SCV_U64:
                var result_SCV_U64 = new SCVal.ScvU64();
                result_SCV_U64.u64 = uint64Xdr.Decode(stream);
                return result_SCV_U64;
                case SCValType.SCV_I64:
                var result_SCV_I64 = new SCVal.ScvI64();
                result_SCV_I64.i64 = int64Xdr.Decode(stream);
                return result_SCV_I64;
                case SCValType.SCV_TIMEPOINT:
                var result_SCV_TIMEPOINT = new SCVal.ScvTimepoint();
                result_SCV_TIMEPOINT.timepoint = TimePointXdr.Decode(stream);
                return result_SCV_TIMEPOINT;
                case SCValType.SCV_DURATION:
                var result_SCV_DURATION = new SCVal.ScvDuration();
                result_SCV_DURATION.duration = DurationXdr.Decode(stream);
                return result_SCV_DURATION;
                case SCValType.SCV_U128:
                var result_SCV_U128 = new SCVal.ScvU128();
                result_SCV_U128.u128 = UInt128PartsXdr.Decode(stream);
                return result_SCV_U128;
                case SCValType.SCV_I128:
                var result_SCV_I128 = new SCVal.ScvI128();
                result_SCV_I128.i128 = Int128PartsXdr.Decode(stream);
                return result_SCV_I128;
                case SCValType.SCV_U256:
                var result_SCV_U256 = new SCVal.ScvU256();
                result_SCV_U256.u256 = UInt256PartsXdr.Decode(stream);
                return result_SCV_U256;
                case SCValType.SCV_I256:
                var result_SCV_I256 = new SCVal.ScvI256();
                result_SCV_I256.i256 = Int256PartsXdr.Decode(stream);
                return result_SCV_I256;
                case SCValType.SCV_BYTES:
                var result_SCV_BYTES = new SCVal.ScvBytes();
                result_SCV_BYTES.bytes = SCBytesXdr.Decode(stream);
                return result_SCV_BYTES;
                case SCValType.SCV_STRING:
                var result_SCV_STRING = new SCVal.ScvString();
                result_SCV_STRING.str = SCStringXdr.Decode(stream);
                return result_SCV_STRING;
                case SCValType.SCV_SYMBOL:
                var result_SCV_SYMBOL = new SCVal.ScvSymbol();
                result_SCV_SYMBOL.sym = SCSymbolXdr.Decode(stream);
                return result_SCV_SYMBOL;
                case SCValType.SCV_VEC:
                var result_SCV_VEC = new SCVal.ScvVec();
                if (stream.ReadInt()==1)
                {
                    result_SCV_VEC.vec = SCVecXdr.Decode(stream);
                }
                return result_SCV_VEC;
                case SCValType.SCV_MAP:
                var result_SCV_MAP = new SCVal.ScvMap();
                if (stream.ReadInt()==1)
                {
                    result_SCV_MAP.map = SCMapXdr.Decode(stream);
                }
                return result_SCV_MAP;
                case SCValType.SCV_ADDRESS:
                var result_SCV_ADDRESS = new SCVal.ScvAddress();
                result_SCV_ADDRESS.address = SCAddressXdr.Decode(stream);
                return result_SCV_ADDRESS;
                case SCValType.SCV_LEDGER_KEY_CONTRACT_INSTANCE:
                var result_SCV_LEDGER_KEY_CONTRACT_INSTANCE = new SCVal.ScvLedgerKeyContractInstance();
                return result_SCV_LEDGER_KEY_CONTRACT_INSTANCE;
                case SCValType.SCV_LEDGER_KEY_NONCE:
                var result_SCV_LEDGER_KEY_NONCE = new SCVal.ScvLedgerKeyNonce();
                result_SCV_LEDGER_KEY_NONCE.nonce_key = SCNonceKeyXdr.Decode(stream);
                return result_SCV_LEDGER_KEY_NONCE;
                case SCValType.SCV_CONTRACT_INSTANCE:
                var result_SCV_CONTRACT_INSTANCE = new SCVal.ScvContractInstance();
                result_SCV_CONTRACT_INSTANCE.instance = SCContractInstanceXdr.Decode(stream);
                return result_SCV_CONTRACT_INSTANCE;
                default:
                throw new Exception($"Unknown discriminator for SCVal: {discriminator}");
            }
        }
    }
}
