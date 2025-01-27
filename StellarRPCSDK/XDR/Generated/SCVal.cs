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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class SCVal
    {
        public abstract SCValType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class SCVal_SCV_BOOL : SCVal
    {
        public override SCValType Discriminator => SCV_BOOL;
        private bool _b;
        public bool b
        {
            get => _b;
            set
            {
                _b = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCVal_SCV_VOID : SCVal
    {
        public override SCValType Discriminator => SCV_VOID;

        public override void ValidateCase() {}
    }
    public sealed partial class SCVal_SCV_ERROR : SCVal
    {
        public override SCValType Discriminator => SCV_ERROR;
        private SCError _error;
        public SCError error
        {
            get => _error;
            set
            {
                _error = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCVal_SCV_U32 : SCVal
    {
        public override SCValType Discriminator => SCV_U32;
        private uint32 _u32;
        public uint32 u32
        {
            get => _u32;
            set
            {
                _u32 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCVal_SCV_I32 : SCVal
    {
        public override SCValType Discriminator => SCV_I32;
        private int32 _i32;
        public int32 i32
        {
            get => _i32;
            set
            {
                _i32 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCVal_SCV_U64 : SCVal
    {
        public override SCValType Discriminator => SCV_U64;
        private uint64 _u64;
        public uint64 u64
        {
            get => _u64;
            set
            {
                _u64 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCVal_SCV_I64 : SCVal
    {
        public override SCValType Discriminator => SCV_I64;
        private int64 _i64;
        public int64 i64
        {
            get => _i64;
            set
            {
                _i64 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCVal_SCV_TIMEPOINT : SCVal
    {
        public override SCValType Discriminator => SCV_TIMEPOINT;
        private TimePoint _timepoint;
        public TimePoint timepoint
        {
            get => _timepoint;
            set
            {
                _timepoint = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCVal_SCV_DURATION : SCVal
    {
        public override SCValType Discriminator => SCV_DURATION;
        private Duration _duration;
        public Duration duration
        {
            get => _duration;
            set
            {
                _duration = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCVal_SCV_U128 : SCVal
    {
        public override SCValType Discriminator => SCV_U128;
        private UInt128Parts _u128;
        public UInt128Parts u128
        {
            get => _u128;
            set
            {
                _u128 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCVal_SCV_I128 : SCVal
    {
        public override SCValType Discriminator => SCV_I128;
        private Int128Parts _i128;
        public Int128Parts i128
        {
            get => _i128;
            set
            {
                _i128 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCVal_SCV_U256 : SCVal
    {
        public override SCValType Discriminator => SCV_U256;
        private UInt256Parts _u256;
        public UInt256Parts u256
        {
            get => _u256;
            set
            {
                _u256 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCVal_SCV_I256 : SCVal
    {
        public override SCValType Discriminator => SCV_I256;
        private Int256Parts _i256;
        public Int256Parts i256
        {
            get => _i256;
            set
            {
                _i256 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCVal_SCV_BYTES : SCVal
    {
        public override SCValType Discriminator => SCV_BYTES;
        private SCBytes _bytes;
        public SCBytes bytes
        {
            get => _bytes;
            set
            {
                _bytes = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCVal_SCV_STRING : SCVal
    {
        public override SCValType Discriminator => SCV_STRING;
        private SCString _str;
        public SCString str
        {
            get => _str;
            set
            {
                _str = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCVal_SCV_SYMBOL : SCVal
    {
        public override SCValType Discriminator => SCV_SYMBOL;
        private SCSymbol _sym;
        public SCSymbol sym
        {
            get => _sym;
            set
            {
                _sym = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCVal_SCV_VEC : SCVal
    {
        public override SCValType Discriminator => SCV_VEC;
        private SCVec _vec;
        public SCVec vec
        {
            get => _vec;
            set
            {
                _vec = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCVal_SCV_MAP : SCVal
    {
        public override SCValType Discriminator => SCV_MAP;
        private SCMap _map;
        public SCMap map
        {
            get => _map;
            set
            {
                _map = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCVal_SCV_ADDRESS : SCVal
    {
        public override SCValType Discriminator => SCV_ADDRESS;
        private SCAddress _address;
        public SCAddress address
        {
            get => _address;
            set
            {
                _address = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCVal_SCV_LEDGER_KEY_CONTRACT_INSTANCE : SCVal
    {
        public override SCValType Discriminator => SCV_LEDGER_KEY_CONTRACT_INSTANCE;

        public override void ValidateCase() {}
    }
    public sealed partial class SCVal_SCV_LEDGER_KEY_NONCE : SCVal
    {
        public override SCValType Discriminator => SCV_LEDGER_KEY_NONCE;
        private SCNonceKey _nonce_key;
        public SCNonceKey nonce_key
        {
            get => _nonce_key;
            set
            {
                _nonce_key = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCVal_SCV_CONTRACT_INSTANCE : SCVal
    {
        public override SCValType Discriminator => SCV_CONTRACT_INSTANCE;
        private SCContractInstance _instance;
        public SCContractInstance instance
        {
            get => _instance;
            set
            {
                _instance = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class SCValXdr
    {
        public static void Encode(XdrWriter stream, SCVal value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SCVal_SCV_BOOL case_SCV_BOOL:
                stream.WriteInt(case_SCV_BOOL.b ? 1 : 0);
                break;
                case SCVal_SCV_VOID case_SCV_VOID:
                break;
                case SCVal_SCV_ERROR case_SCV_ERROR:
                SCErrorXdr.Encode(stream, case_SCV_ERROR.error);
                break;
                case SCVal_SCV_U32 case_SCV_U32:
                uint32Xdr.Encode(stream, case_SCV_U32.u32);
                break;
                case SCVal_SCV_I32 case_SCV_I32:
                int32Xdr.Encode(stream, case_SCV_I32.i32);
                break;
                case SCVal_SCV_U64 case_SCV_U64:
                uint64Xdr.Encode(stream, case_SCV_U64.u64);
                break;
                case SCVal_SCV_I64 case_SCV_I64:
                int64Xdr.Encode(stream, case_SCV_I64.i64);
                break;
                case SCVal_SCV_TIMEPOINT case_SCV_TIMEPOINT:
                TimePointXdr.Encode(stream, case_SCV_TIMEPOINT.timepoint);
                break;
                case SCVal_SCV_DURATION case_SCV_DURATION:
                DurationXdr.Encode(stream, case_SCV_DURATION.duration);
                break;
                case SCVal_SCV_U128 case_SCV_U128:
                UInt128PartsXdr.Encode(stream, case_SCV_U128.u128);
                break;
                case SCVal_SCV_I128 case_SCV_I128:
                Int128PartsXdr.Encode(stream, case_SCV_I128.i128);
                break;
                case SCVal_SCV_U256 case_SCV_U256:
                UInt256PartsXdr.Encode(stream, case_SCV_U256.u256);
                break;
                case SCVal_SCV_I256 case_SCV_I256:
                Int256PartsXdr.Encode(stream, case_SCV_I256.i256);
                break;
                case SCVal_SCV_BYTES case_SCV_BYTES:
                SCBytesXdr.Encode(stream, case_SCV_BYTES.bytes);
                break;
                case SCVal_SCV_STRING case_SCV_STRING:
                SCStringXdr.Encode(stream, case_SCV_STRING.str);
                break;
                case SCVal_SCV_SYMBOL case_SCV_SYMBOL:
                SCSymbolXdr.Encode(stream, case_SCV_SYMBOL.sym);
                break;
                case SCVal_SCV_VEC case_SCV_VEC:
                SCVecXdr.Encode(stream, case_SCV_VEC.vec);
                break;
                case SCVal_SCV_MAP case_SCV_MAP:
                SCMapXdr.Encode(stream, case_SCV_MAP.map);
                break;
                case SCVal_SCV_ADDRESS case_SCV_ADDRESS:
                SCAddressXdr.Encode(stream, case_SCV_ADDRESS.address);
                break;
                case SCVal_SCV_LEDGER_KEY_CONTRACT_INSTANCE case_SCV_LEDGER_KEY_CONTRACT_INSTANCE:
                break;
                case SCVal_SCV_LEDGER_KEY_NONCE case_SCV_LEDGER_KEY_NONCE:
                SCNonceKeyXdr.Encode(stream, case_SCV_LEDGER_KEY_NONCE.nonce_key);
                break;
                case SCVal_SCV_CONTRACT_INSTANCE case_SCV_CONTRACT_INSTANCE:
                SCContractInstanceXdr.Encode(stream, case_SCV_CONTRACT_INSTANCE.instance);
                break;
            }
        }
        public static SCVal Decode(XdrReader stream)
        {
            var discriminator = (SCValType)stream.ReadInt();
            switch (discriminator)
            {
                case SCV_BOOL:
                var result_SCV_BOOL = new SCVal_SCV_BOOL();
                result_SCV_BOOL.                 = stream.ReadInt() != 0;
                return result_SCV_BOOL;
                case SCV_VOID:
                var result_SCV_VOID = new SCVal_SCV_VOID();
                return result_SCV_VOID;
                case SCV_ERROR:
                var result_SCV_ERROR = new SCVal_SCV_ERROR();
                result_SCV_ERROR.                 = SCErrorXdr.Decode(stream);
                return result_SCV_ERROR;
                case SCV_U32:
                var result_SCV_U32 = new SCVal_SCV_U32();
                result_SCV_U32.                 = uint32Xdr.Decode(stream);
                return result_SCV_U32;
                case SCV_I32:
                var result_SCV_I32 = new SCVal_SCV_I32();
                result_SCV_I32.                 = int32Xdr.Decode(stream);
                return result_SCV_I32;
                case SCV_U64:
                var result_SCV_U64 = new SCVal_SCV_U64();
                result_SCV_U64.                 = uint64Xdr.Decode(stream);
                return result_SCV_U64;
                case SCV_I64:
                var result_SCV_I64 = new SCVal_SCV_I64();
                result_SCV_I64.                 = int64Xdr.Decode(stream);
                return result_SCV_I64;
                case SCV_TIMEPOINT:
                var result_SCV_TIMEPOINT = new SCVal_SCV_TIMEPOINT();
                result_SCV_TIMEPOINT.                 = TimePointXdr.Decode(stream);
                return result_SCV_TIMEPOINT;
                case SCV_DURATION:
                var result_SCV_DURATION = new SCVal_SCV_DURATION();
                result_SCV_DURATION.                 = DurationXdr.Decode(stream);
                return result_SCV_DURATION;
                case SCV_U128:
                var result_SCV_U128 = new SCVal_SCV_U128();
                result_SCV_U128.                 = UInt128PartsXdr.Decode(stream);
                return result_SCV_U128;
                case SCV_I128:
                var result_SCV_I128 = new SCVal_SCV_I128();
                result_SCV_I128.                 = Int128PartsXdr.Decode(stream);
                return result_SCV_I128;
                case SCV_U256:
                var result_SCV_U256 = new SCVal_SCV_U256();
                result_SCV_U256.                 = UInt256PartsXdr.Decode(stream);
                return result_SCV_U256;
                case SCV_I256:
                var result_SCV_I256 = new SCVal_SCV_I256();
                result_SCV_I256.                 = Int256PartsXdr.Decode(stream);
                return result_SCV_I256;
                case SCV_BYTES:
                var result_SCV_BYTES = new SCVal_SCV_BYTES();
                result_SCV_BYTES.                 = SCBytesXdr.Decode(stream);
                return result_SCV_BYTES;
                case SCV_STRING:
                var result_SCV_STRING = new SCVal_SCV_STRING();
                result_SCV_STRING.                 = SCStringXdr.Decode(stream);
                return result_SCV_STRING;
                case SCV_SYMBOL:
                var result_SCV_SYMBOL = new SCVal_SCV_SYMBOL();
                result_SCV_SYMBOL.                 = SCSymbolXdr.Decode(stream);
                return result_SCV_SYMBOL;
                case SCV_VEC:
                var result_SCV_VEC = new SCVal_SCV_VEC();
                result_SCV_VEC.                 = SCVecXdr.Decode(stream);
                return result_SCV_VEC;
                case SCV_MAP:
                var result_SCV_MAP = new SCVal_SCV_MAP();
                result_SCV_MAP.                 = SCMapXdr.Decode(stream);
                return result_SCV_MAP;
                case SCV_ADDRESS:
                var result_SCV_ADDRESS = new SCVal_SCV_ADDRESS();
                result_SCV_ADDRESS.                 = SCAddressXdr.Decode(stream);
                return result_SCV_ADDRESS;
                case SCV_LEDGER_KEY_CONTRACT_INSTANCE:
                var result_SCV_LEDGER_KEY_CONTRACT_INSTANCE = new SCVal_SCV_LEDGER_KEY_CONTRACT_INSTANCE();
                return result_SCV_LEDGER_KEY_CONTRACT_INSTANCE;
                case SCV_LEDGER_KEY_NONCE:
                var result_SCV_LEDGER_KEY_NONCE = new SCVal_SCV_LEDGER_KEY_NONCE();
                result_SCV_LEDGER_KEY_NONCE.                 = SCNonceKeyXdr.Decode(stream);
                return result_SCV_LEDGER_KEY_NONCE;
                case SCV_CONTRACT_INSTANCE:
                var result_SCV_CONTRACT_INSTANCE = new SCVal_SCV_CONTRACT_INSTANCE();
                result_SCV_CONTRACT_INSTANCE.                 = SCContractInstanceXdr.Decode(stream);
                return result_SCV_CONTRACT_INSTANCE;
                default:
                throw new Exception($"Unknown discriminator for SCVal: {discriminator}");
            }
        }
    }
}
