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
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public abstract partial class SCSpecTypeDef
    {
        public abstract SCSpecType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        public sealed partial class ScSpecTypeVal : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_VAL;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeBool : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_BOOL;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeVoid : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_VOID;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeError : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_ERROR;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeU32 : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_U32;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeI32 : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_I32;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeU64 : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_U64;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeI64 : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_I64;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeTimepoint : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_TIMEPOINT;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeDuration : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_DURATION;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeU128 : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_U128;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeI128 : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_I128;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeU256 : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_U256;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeI256 : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_I256;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeBytes : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_BYTES;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeString : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_STRING;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeSymbol : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_SYMBOL;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeAddress : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_ADDRESS;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeOption : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_OPTION;
            public SCSpecTypeOption option
            {
                get => _option;
                set
                {
                    _option = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Option")]
            #endif
            private SCSpecTypeOption _option;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeResult : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_RESULT;
            public SCSpecTypeResult result
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
            private SCSpecTypeResult _result;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeVec : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_VEC;
            public SCSpecTypeVec vec
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
            private SCSpecTypeVec _vec;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeMap : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_MAP;
            public SCSpecTypeMap map
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
            private SCSpecTypeMap _map;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeTuple : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_TUPLE;
            public SCSpecTypeTuple tuple
            {
                get => _tuple;
                set
                {
                    _tuple = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Tuple")]
            #endif
            private SCSpecTypeTuple _tuple;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeBytesN : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_BYTES_N;
            public SCSpecTypeBytesN bytesN
            {
                get => _bytesN;
                set
                {
                    _bytesN = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Bytes N")]
            #endif
            private SCSpecTypeBytesN _bytesN;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ScSpecTypeUdt : SCSpecTypeDef
        {
            public override SCSpecType Discriminator => SCSpecType.SC_SPEC_TYPE_UDT;
            public SCSpecTypeUDT udt
            {
                get => _udt;
                set
                {
                    _udt = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Udt")]
            #endif
            private SCSpecTypeUDT _udt;

            public override void ValidateCase() {}
        }
    }
    public static partial class SCSpecTypeDefXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SCSpecTypeDef value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SCSpecTypeDefXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, SCSpecTypeDef value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case SCSpecTypeDef.ScSpecTypeVal case_SC_SPEC_TYPE_VAL:
                break;
                case SCSpecTypeDef.ScSpecTypeBool case_SC_SPEC_TYPE_BOOL:
                break;
                case SCSpecTypeDef.ScSpecTypeVoid case_SC_SPEC_TYPE_VOID:
                break;
                case SCSpecTypeDef.ScSpecTypeError case_SC_SPEC_TYPE_ERROR:
                break;
                case SCSpecTypeDef.ScSpecTypeU32 case_SC_SPEC_TYPE_U32:
                break;
                case SCSpecTypeDef.ScSpecTypeI32 case_SC_SPEC_TYPE_I32:
                break;
                case SCSpecTypeDef.ScSpecTypeU64 case_SC_SPEC_TYPE_U64:
                break;
                case SCSpecTypeDef.ScSpecTypeI64 case_SC_SPEC_TYPE_I64:
                break;
                case SCSpecTypeDef.ScSpecTypeTimepoint case_SC_SPEC_TYPE_TIMEPOINT:
                break;
                case SCSpecTypeDef.ScSpecTypeDuration case_SC_SPEC_TYPE_DURATION:
                break;
                case SCSpecTypeDef.ScSpecTypeU128 case_SC_SPEC_TYPE_U128:
                break;
                case SCSpecTypeDef.ScSpecTypeI128 case_SC_SPEC_TYPE_I128:
                break;
                case SCSpecTypeDef.ScSpecTypeU256 case_SC_SPEC_TYPE_U256:
                break;
                case SCSpecTypeDef.ScSpecTypeI256 case_SC_SPEC_TYPE_I256:
                break;
                case SCSpecTypeDef.ScSpecTypeBytes case_SC_SPEC_TYPE_BYTES:
                break;
                case SCSpecTypeDef.ScSpecTypeString case_SC_SPEC_TYPE_STRING:
                break;
                case SCSpecTypeDef.ScSpecTypeSymbol case_SC_SPEC_TYPE_SYMBOL:
                break;
                case SCSpecTypeDef.ScSpecTypeAddress case_SC_SPEC_TYPE_ADDRESS:
                break;
                case SCSpecTypeDef.ScSpecTypeOption case_SC_SPEC_TYPE_OPTION:
                SCSpecTypeOptionXdr.Encode(stream, case_SC_SPEC_TYPE_OPTION.option);
                break;
                case SCSpecTypeDef.ScSpecTypeResult case_SC_SPEC_TYPE_RESULT:
                SCSpecTypeResultXdr.Encode(stream, case_SC_SPEC_TYPE_RESULT.result);
                break;
                case SCSpecTypeDef.ScSpecTypeVec case_SC_SPEC_TYPE_VEC:
                SCSpecTypeVecXdr.Encode(stream, case_SC_SPEC_TYPE_VEC.vec);
                break;
                case SCSpecTypeDef.ScSpecTypeMap case_SC_SPEC_TYPE_MAP:
                SCSpecTypeMapXdr.Encode(stream, case_SC_SPEC_TYPE_MAP.map);
                break;
                case SCSpecTypeDef.ScSpecTypeTuple case_SC_SPEC_TYPE_TUPLE:
                SCSpecTypeTupleXdr.Encode(stream, case_SC_SPEC_TYPE_TUPLE.tuple);
                break;
                case SCSpecTypeDef.ScSpecTypeBytesN case_SC_SPEC_TYPE_BYTES_N:
                SCSpecTypeBytesNXdr.Encode(stream, case_SC_SPEC_TYPE_BYTES_N.bytesN);
                break;
                case SCSpecTypeDef.ScSpecTypeUdt case_SC_SPEC_TYPE_UDT:
                SCSpecTypeUDTXdr.Encode(stream, case_SC_SPEC_TYPE_UDT.udt);
                break;
            }
        }
        public static SCSpecTypeDef Decode(XdrReader stream)
        {
            var discriminator = (SCSpecType)stream.ReadInt();
            switch (discriminator)
            {
                case SCSpecType.SC_SPEC_TYPE_VAL:
                var result_SC_SPEC_TYPE_VAL = new SCSpecTypeDef.ScSpecTypeVal();
                return result_SC_SPEC_TYPE_VAL;
                case SCSpecType.SC_SPEC_TYPE_BOOL:
                var result_SC_SPEC_TYPE_BOOL = new SCSpecTypeDef.ScSpecTypeBool();
                return result_SC_SPEC_TYPE_BOOL;
                case SCSpecType.SC_SPEC_TYPE_VOID:
                var result_SC_SPEC_TYPE_VOID = new SCSpecTypeDef.ScSpecTypeVoid();
                return result_SC_SPEC_TYPE_VOID;
                case SCSpecType.SC_SPEC_TYPE_ERROR:
                var result_SC_SPEC_TYPE_ERROR = new SCSpecTypeDef.ScSpecTypeError();
                return result_SC_SPEC_TYPE_ERROR;
                case SCSpecType.SC_SPEC_TYPE_U32:
                var result_SC_SPEC_TYPE_U32 = new SCSpecTypeDef.ScSpecTypeU32();
                return result_SC_SPEC_TYPE_U32;
                case SCSpecType.SC_SPEC_TYPE_I32:
                var result_SC_SPEC_TYPE_I32 = new SCSpecTypeDef.ScSpecTypeI32();
                return result_SC_SPEC_TYPE_I32;
                case SCSpecType.SC_SPEC_TYPE_U64:
                var result_SC_SPEC_TYPE_U64 = new SCSpecTypeDef.ScSpecTypeU64();
                return result_SC_SPEC_TYPE_U64;
                case SCSpecType.SC_SPEC_TYPE_I64:
                var result_SC_SPEC_TYPE_I64 = new SCSpecTypeDef.ScSpecTypeI64();
                return result_SC_SPEC_TYPE_I64;
                case SCSpecType.SC_SPEC_TYPE_TIMEPOINT:
                var result_SC_SPEC_TYPE_TIMEPOINT = new SCSpecTypeDef.ScSpecTypeTimepoint();
                return result_SC_SPEC_TYPE_TIMEPOINT;
                case SCSpecType.SC_SPEC_TYPE_DURATION:
                var result_SC_SPEC_TYPE_DURATION = new SCSpecTypeDef.ScSpecTypeDuration();
                return result_SC_SPEC_TYPE_DURATION;
                case SCSpecType.SC_SPEC_TYPE_U128:
                var result_SC_SPEC_TYPE_U128 = new SCSpecTypeDef.ScSpecTypeU128();
                return result_SC_SPEC_TYPE_U128;
                case SCSpecType.SC_SPEC_TYPE_I128:
                var result_SC_SPEC_TYPE_I128 = new SCSpecTypeDef.ScSpecTypeI128();
                return result_SC_SPEC_TYPE_I128;
                case SCSpecType.SC_SPEC_TYPE_U256:
                var result_SC_SPEC_TYPE_U256 = new SCSpecTypeDef.ScSpecTypeU256();
                return result_SC_SPEC_TYPE_U256;
                case SCSpecType.SC_SPEC_TYPE_I256:
                var result_SC_SPEC_TYPE_I256 = new SCSpecTypeDef.ScSpecTypeI256();
                return result_SC_SPEC_TYPE_I256;
                case SCSpecType.SC_SPEC_TYPE_BYTES:
                var result_SC_SPEC_TYPE_BYTES = new SCSpecTypeDef.ScSpecTypeBytes();
                return result_SC_SPEC_TYPE_BYTES;
                case SCSpecType.SC_SPEC_TYPE_STRING:
                var result_SC_SPEC_TYPE_STRING = new SCSpecTypeDef.ScSpecTypeString();
                return result_SC_SPEC_TYPE_STRING;
                case SCSpecType.SC_SPEC_TYPE_SYMBOL:
                var result_SC_SPEC_TYPE_SYMBOL = new SCSpecTypeDef.ScSpecTypeSymbol();
                return result_SC_SPEC_TYPE_SYMBOL;
                case SCSpecType.SC_SPEC_TYPE_ADDRESS:
                var result_SC_SPEC_TYPE_ADDRESS = new SCSpecTypeDef.ScSpecTypeAddress();
                return result_SC_SPEC_TYPE_ADDRESS;
                case SCSpecType.SC_SPEC_TYPE_OPTION:
                var result_SC_SPEC_TYPE_OPTION = new SCSpecTypeDef.ScSpecTypeOption();
                result_SC_SPEC_TYPE_OPTION.option = SCSpecTypeOptionXdr.Decode(stream);
                return result_SC_SPEC_TYPE_OPTION;
                case SCSpecType.SC_SPEC_TYPE_RESULT:
                var result_SC_SPEC_TYPE_RESULT = new SCSpecTypeDef.ScSpecTypeResult();
                result_SC_SPEC_TYPE_RESULT.result = SCSpecTypeResultXdr.Decode(stream);
                return result_SC_SPEC_TYPE_RESULT;
                case SCSpecType.SC_SPEC_TYPE_VEC:
                var result_SC_SPEC_TYPE_VEC = new SCSpecTypeDef.ScSpecTypeVec();
                result_SC_SPEC_TYPE_VEC.vec = SCSpecTypeVecXdr.Decode(stream);
                return result_SC_SPEC_TYPE_VEC;
                case SCSpecType.SC_SPEC_TYPE_MAP:
                var result_SC_SPEC_TYPE_MAP = new SCSpecTypeDef.ScSpecTypeMap();
                result_SC_SPEC_TYPE_MAP.map = SCSpecTypeMapXdr.Decode(stream);
                return result_SC_SPEC_TYPE_MAP;
                case SCSpecType.SC_SPEC_TYPE_TUPLE:
                var result_SC_SPEC_TYPE_TUPLE = new SCSpecTypeDef.ScSpecTypeTuple();
                result_SC_SPEC_TYPE_TUPLE.tuple = SCSpecTypeTupleXdr.Decode(stream);
                return result_SC_SPEC_TYPE_TUPLE;
                case SCSpecType.SC_SPEC_TYPE_BYTES_N:
                var result_SC_SPEC_TYPE_BYTES_N = new SCSpecTypeDef.ScSpecTypeBytesN();
                result_SC_SPEC_TYPE_BYTES_N.bytesN = SCSpecTypeBytesNXdr.Decode(stream);
                return result_SC_SPEC_TYPE_BYTES_N;
                case SCSpecType.SC_SPEC_TYPE_UDT:
                var result_SC_SPEC_TYPE_UDT = new SCSpecTypeDef.ScSpecTypeUdt();
                result_SC_SPEC_TYPE_UDT.udt = SCSpecTypeUDTXdr.Decode(stream);
                return result_SC_SPEC_TYPE_UDT;
                default:
                throw new Exception($"Unknown discriminator for SCSpecTypeDef: {discriminator}");
            }
        }
    }
}
