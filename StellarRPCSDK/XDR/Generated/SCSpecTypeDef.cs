// Generated code - do not modify
// Source:

// union SCSpecTypeDef switch (SCSpecType type)
// {
// case SC_SPEC_TYPE_VAL:
// case SC_SPEC_TYPE_BOOL:
// case SC_SPEC_TYPE_VOID:
// case SC_SPEC_TYPE_ERROR:
// case SC_SPEC_TYPE_U32:
// case SC_SPEC_TYPE_I32:
// case SC_SPEC_TYPE_U64:
// case SC_SPEC_TYPE_I64:
// case SC_SPEC_TYPE_TIMEPOINT:
// case SC_SPEC_TYPE_DURATION:
// case SC_SPEC_TYPE_U128:
// case SC_SPEC_TYPE_I128:
// case SC_SPEC_TYPE_U256:
// case SC_SPEC_TYPE_I256:
// case SC_SPEC_TYPE_BYTES:
// case SC_SPEC_TYPE_STRING:
// case SC_SPEC_TYPE_SYMBOL:
// case SC_SPEC_TYPE_ADDRESS:
//     void;
// case SC_SPEC_TYPE_OPTION:
//     SCSpecTypeOption option;
// case SC_SPEC_TYPE_RESULT:
//     SCSpecTypeResult result;
// case SC_SPEC_TYPE_VEC:
//     SCSpecTypeVec vec;
// case SC_SPEC_TYPE_MAP:
//     SCSpecTypeMap map;
// case SC_SPEC_TYPE_TUPLE:
//     SCSpecTypeTuple tuple;
// case SC_SPEC_TYPE_BYTES_N:
//     SCSpecTypeBytesN bytesN;
// case SC_SPEC_TYPE_UDT:
//     SCSpecTypeUDT udt;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class SCSpecTypeDef
    {
        public abstract int Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_VAL : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_VAL;

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_BOOL : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_BOOL;

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_VOID : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_VOID;

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_ERROR : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_ERROR;

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_U32 : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_U32;

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_I32 : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_I32;

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_U64 : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_U64;

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_I64 : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_I64;

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_TIMEPOINT : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_TIMEPOINT;

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_DURATION : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_DURATION;

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_U128 : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_U128;

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_I128 : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_I128;

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_U256 : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_U256;

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_I256 : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_I256;

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_BYTES : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_BYTES;

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_STRING : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_STRING;

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_SYMBOL : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_SYMBOL;

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_ADDRESS : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_ADDRESS;

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_OPTION : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_OPTION;
        private SCSpecTypeOption _option;
        public SCSpecTypeOption option
        {
            get => _option;
            set
            {
                _option = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_RESULT : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_RESULT;
        private SCSpecTypeResult _result;
        public SCSpecTypeResult result
        {
            get => _result;
            set
            {
                _result = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_VEC : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_VEC;
        private SCSpecTypeVec _vec;
        public SCSpecTypeVec vec
        {
            get => _vec;
            set
            {
                _vec = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_MAP : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_MAP;
        private SCSpecTypeMap _map;
        public SCSpecTypeMap map
        {
            get => _map;
            set
            {
                _map = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_TUPLE : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_TUPLE;
        private SCSpecTypeTuple _tuple;
        public SCSpecTypeTuple tuple
        {
            get => _tuple;
            set
            {
                _tuple = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_BYTES_N : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_BYTES_N;
        private SCSpecTypeBytesN _bytesN;
        public SCSpecTypeBytesN bytesN
        {
            get => _bytesN;
            set
            {
                _bytesN = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class SCSpecTypeDef_SC_SPEC_TYPE_UDT : SCSpecTypeDef
    {
        public override int Discriminator => SC_SPEC_TYPE_UDT;
        private SCSpecTypeUDT _udt;
        public SCSpecTypeUDT udt
        {
            get => _udt;
            set
            {
                _udt = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class SCSpecTypeDefXdr
    {
        public static void Encode(XdrWriter stream, SCSpecTypeDef value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SCSpecTypeDef_SC_SPEC_TYPE_VAL case_SC_SPEC_TYPE_VAL:
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_BOOL case_SC_SPEC_TYPE_BOOL:
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_VOID case_SC_SPEC_TYPE_VOID:
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_ERROR case_SC_SPEC_TYPE_ERROR:
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_U32 case_SC_SPEC_TYPE_U32:
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_I32 case_SC_SPEC_TYPE_I32:
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_U64 case_SC_SPEC_TYPE_U64:
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_I64 case_SC_SPEC_TYPE_I64:
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_TIMEPOINT case_SC_SPEC_TYPE_TIMEPOINT:
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_DURATION case_SC_SPEC_TYPE_DURATION:
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_U128 case_SC_SPEC_TYPE_U128:
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_I128 case_SC_SPEC_TYPE_I128:
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_U256 case_SC_SPEC_TYPE_U256:
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_I256 case_SC_SPEC_TYPE_I256:
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_BYTES case_SC_SPEC_TYPE_BYTES:
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_STRING case_SC_SPEC_TYPE_STRING:
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_SYMBOL case_SC_SPEC_TYPE_SYMBOL:
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_ADDRESS case_SC_SPEC_TYPE_ADDRESS:
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_OPTION case_SC_SPEC_TYPE_OPTION:
                SCSpecTypeOptionXdr.Encode(stream, case_SC_SPEC_TYPE_OPTION.option);
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_RESULT case_SC_SPEC_TYPE_RESULT:
                SCSpecTypeResultXdr.Encode(stream, case_SC_SPEC_TYPE_RESULT.result);
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_VEC case_SC_SPEC_TYPE_VEC:
                SCSpecTypeVecXdr.Encode(stream, case_SC_SPEC_TYPE_VEC.vec);
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_MAP case_SC_SPEC_TYPE_MAP:
                SCSpecTypeMapXdr.Encode(stream, case_SC_SPEC_TYPE_MAP.map);
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_TUPLE case_SC_SPEC_TYPE_TUPLE:
                SCSpecTypeTupleXdr.Encode(stream, case_SC_SPEC_TYPE_TUPLE.tuple);
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_BYTES_N case_SC_SPEC_TYPE_BYTES_N:
                SCSpecTypeBytesNXdr.Encode(stream, case_SC_SPEC_TYPE_BYTES_N.bytesN);
                break;
                case SCSpecTypeDef_SC_SPEC_TYPE_UDT case_SC_SPEC_TYPE_UDT:
                SCSpecTypeUDTXdr.Encode(stream, case_SC_SPEC_TYPE_UDT.udt);
                break;
            }
        }
        public static SCSpecTypeDef Decode(XdrReader stream)
        {
            var discriminator = (int)stream.ReadInt();
            switch (discriminator)
            {
                case SC_SPEC_TYPE_VAL:
                var result_SC_SPEC_TYPE_VAL = new SCSpecTypeDef_SC_SPEC_TYPE_VAL();
                return result_SC_SPEC_TYPE_VAL;
                case SC_SPEC_TYPE_BOOL:
                var result_SC_SPEC_TYPE_BOOL = new SCSpecTypeDef_SC_SPEC_TYPE_BOOL();
                return result_SC_SPEC_TYPE_BOOL;
                case SC_SPEC_TYPE_VOID:
                var result_SC_SPEC_TYPE_VOID = new SCSpecTypeDef_SC_SPEC_TYPE_VOID();
                return result_SC_SPEC_TYPE_VOID;
                case SC_SPEC_TYPE_ERROR:
                var result_SC_SPEC_TYPE_ERROR = new SCSpecTypeDef_SC_SPEC_TYPE_ERROR();
                return result_SC_SPEC_TYPE_ERROR;
                case SC_SPEC_TYPE_U32:
                var result_SC_SPEC_TYPE_U32 = new SCSpecTypeDef_SC_SPEC_TYPE_U32();
                return result_SC_SPEC_TYPE_U32;
                case SC_SPEC_TYPE_I32:
                var result_SC_SPEC_TYPE_I32 = new SCSpecTypeDef_SC_SPEC_TYPE_I32();
                return result_SC_SPEC_TYPE_I32;
                case SC_SPEC_TYPE_U64:
                var result_SC_SPEC_TYPE_U64 = new SCSpecTypeDef_SC_SPEC_TYPE_U64();
                return result_SC_SPEC_TYPE_U64;
                case SC_SPEC_TYPE_I64:
                var result_SC_SPEC_TYPE_I64 = new SCSpecTypeDef_SC_SPEC_TYPE_I64();
                return result_SC_SPEC_TYPE_I64;
                case SC_SPEC_TYPE_TIMEPOINT:
                var result_SC_SPEC_TYPE_TIMEPOINT = new SCSpecTypeDef_SC_SPEC_TYPE_TIMEPOINT();
                return result_SC_SPEC_TYPE_TIMEPOINT;
                case SC_SPEC_TYPE_DURATION:
                var result_SC_SPEC_TYPE_DURATION = new SCSpecTypeDef_SC_SPEC_TYPE_DURATION();
                return result_SC_SPEC_TYPE_DURATION;
                case SC_SPEC_TYPE_U128:
                var result_SC_SPEC_TYPE_U128 = new SCSpecTypeDef_SC_SPEC_TYPE_U128();
                return result_SC_SPEC_TYPE_U128;
                case SC_SPEC_TYPE_I128:
                var result_SC_SPEC_TYPE_I128 = new SCSpecTypeDef_SC_SPEC_TYPE_I128();
                return result_SC_SPEC_TYPE_I128;
                case SC_SPEC_TYPE_U256:
                var result_SC_SPEC_TYPE_U256 = new SCSpecTypeDef_SC_SPEC_TYPE_U256();
                return result_SC_SPEC_TYPE_U256;
                case SC_SPEC_TYPE_I256:
                var result_SC_SPEC_TYPE_I256 = new SCSpecTypeDef_SC_SPEC_TYPE_I256();
                return result_SC_SPEC_TYPE_I256;
                case SC_SPEC_TYPE_BYTES:
                var result_SC_SPEC_TYPE_BYTES = new SCSpecTypeDef_SC_SPEC_TYPE_BYTES();
                return result_SC_SPEC_TYPE_BYTES;
                case SC_SPEC_TYPE_STRING:
                var result_SC_SPEC_TYPE_STRING = new SCSpecTypeDef_SC_SPEC_TYPE_STRING();
                return result_SC_SPEC_TYPE_STRING;
                case SC_SPEC_TYPE_SYMBOL:
                var result_SC_SPEC_TYPE_SYMBOL = new SCSpecTypeDef_SC_SPEC_TYPE_SYMBOL();
                return result_SC_SPEC_TYPE_SYMBOL;
                case SC_SPEC_TYPE_ADDRESS:
                var result_SC_SPEC_TYPE_ADDRESS = new SCSpecTypeDef_SC_SPEC_TYPE_ADDRESS();
                return result_SC_SPEC_TYPE_ADDRESS;
                case SC_SPEC_TYPE_OPTION:
                var result_SC_SPEC_TYPE_OPTION = new SCSpecTypeDef_SC_SPEC_TYPE_OPTION();
                result_SC_SPEC_TYPE_OPTION.                 = SCSpecTypeOptionXdr.Decode(stream);
                return result_SC_SPEC_TYPE_OPTION;
                case SC_SPEC_TYPE_RESULT:
                var result_SC_SPEC_TYPE_RESULT = new SCSpecTypeDef_SC_SPEC_TYPE_RESULT();
                result_SC_SPEC_TYPE_RESULT.                 = SCSpecTypeResultXdr.Decode(stream);
                return result_SC_SPEC_TYPE_RESULT;
                case SC_SPEC_TYPE_VEC:
                var result_SC_SPEC_TYPE_VEC = new SCSpecTypeDef_SC_SPEC_TYPE_VEC();
                result_SC_SPEC_TYPE_VEC.                 = SCSpecTypeVecXdr.Decode(stream);
                return result_SC_SPEC_TYPE_VEC;
                case SC_SPEC_TYPE_MAP:
                var result_SC_SPEC_TYPE_MAP = new SCSpecTypeDef_SC_SPEC_TYPE_MAP();
                result_SC_SPEC_TYPE_MAP.                 = SCSpecTypeMapXdr.Decode(stream);
                return result_SC_SPEC_TYPE_MAP;
                case SC_SPEC_TYPE_TUPLE:
                var result_SC_SPEC_TYPE_TUPLE = new SCSpecTypeDef_SC_SPEC_TYPE_TUPLE();
                result_SC_SPEC_TYPE_TUPLE.                 = SCSpecTypeTupleXdr.Decode(stream);
                return result_SC_SPEC_TYPE_TUPLE;
                case SC_SPEC_TYPE_BYTES_N:
                var result_SC_SPEC_TYPE_BYTES_N = new SCSpecTypeDef_SC_SPEC_TYPE_BYTES_N();
                result_SC_SPEC_TYPE_BYTES_N.                 = SCSpecTypeBytesNXdr.Decode(stream);
                return result_SC_SPEC_TYPE_BYTES_N;
                case SC_SPEC_TYPE_UDT:
                var result_SC_SPEC_TYPE_UDT = new SCSpecTypeDef_SC_SPEC_TYPE_UDT();
                result_SC_SPEC_TYPE_UDT.                 = SCSpecTypeUDTXdr.Decode(stream);
                return result_SC_SPEC_TYPE_UDT;
                default:
                throw new Exception($"Unknown discriminator for SCSpecTypeDef: {discriminator}");
            }
        }
    }
}
