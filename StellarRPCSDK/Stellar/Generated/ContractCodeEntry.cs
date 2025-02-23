// Generated code - do not modify
// Source:

// struct ContractCodeEntry {
//     union switch (int v)
//     {
//         case 0:
//             void;
//         case 1:
//             struct
//             {
//                 ExtensionPoint ext;
//                 ContractCodeCostInputs costInputs;
//             } v1;
//     } ext;
// 
//     Hash hash;
//     opaque code<>;
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
    public partial class ContractCodeEntry
    {
        [ProtoMember(1)]
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

        [ProtoMember(2)]
        public Hash hash
        {
            get => _hash;
            set
            {
                _hash = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Hash")]
        #endif
        private Hash _hash;

        [ProtoMember(3, OverwriteList = true)]
        public byte[] code
        {
            get => _code;
            set
            {
                _code = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Code")]
        #endif
        private byte[] _code;

        public ContractCodeEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "ContractCodeEntry.extUnion")]
        [ProtoInclude(100, typeof(case_0), DataFormat = DataFormat.Default)]
        [ProtoInclude(101, typeof(case_1), DataFormat = DataFormat.Default)]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
            [System.Serializable]
            [ProtoContract(Name = "ContractCodeEntry.extUnion.v1Struct")]
            public partial class v1Struct
            {
                [ProtoMember(1)]
                public ExtensionPoint ext
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
                private ExtensionPoint _ext;

                [ProtoMember(2)]
                public ContractCodeCostInputs costInputs
                {
                    get => _costInputs;
                    set
                    {
                        _costInputs = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Cost Inputs")]
                #endif
                private ContractCodeCostInputs _costInputs;

                public v1Struct()
                {
                }
                /// <summary>Validates all fields have valid values</summary>
                public virtual void Validate()
                {
                }
            }
            public static partial class v1StructXdr
            {
                /// <summary>Encodes value to XDR base64 string</summary>
                public static string EncodeToBase64(v1Struct value)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        XdrWriter writer = new XdrWriter(memoryStream);
                        v1StructXdr.Encode(writer, value);
                        return Convert.ToBase64String(memoryStream.ToArray());
                    }
                }
                /// <summary>Decodes value from XDR base64 string</summary>
                public static v1Struct DecodeFromBase64(string base64)
                {
                    var bytes = Convert.FromBase64String(base64);
                    using (var memoryStream = new MemoryStream(bytes))
                    {
                        XdrReader reader = new XdrReader(memoryStream);
                        return v1StructXdr.Decode(reader);
                    }
                }
                /// <summary>Encodes struct to XDR stream</summary>
                public static void Encode(XdrWriter stream, v1Struct value)
                {
                    value.Validate();
                    ExtensionPointXdr.Encode(stream, value.ext);
                    ContractCodeCostInputsXdr.Encode(stream, value.costInputs);
                }
                /// <summary>Decodes struct from XDR stream</summary>
                public static v1Struct Decode(XdrReader stream)
                {
                    var result = new v1Struct();
                    result.ext = ExtensionPointXdr.Decode(stream);
                    result.costInputs = ContractCodeCostInputsXdr.Decode(stream);
                    return result;
                }
            }
            [System.Serializable]
            [ProtoContract(Name = "ContractCodeEntry.extUnion.case_0")]
            public sealed partial class case_0 : extUnion
            {
                public override int Discriminator => 0;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "ContractCodeEntry.extUnion.case_1")]
            public sealed partial class case_1 : extUnion
            {
                public override int Discriminator => 1;
                [ProtoMember(1)]
                public v1Struct v1
                {
                    get => _v1;
                    set
                    {
                        _v1 = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"V1")]
                #endif
                private v1Struct _v1;

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
                    case extUnion.case_1 case_1:
                    extUnion.v1StructXdr.Encode(stream, case_1.v1);
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
                    case 1:
                    var result_1 = new extUnion.case_1();
                    result_1.v1 = extUnion.v1StructXdr.Decode(stream);
                    return result_1;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class ContractCodeEntryXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ContractCodeEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ContractCodeEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ContractCodeEntry DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ContractCodeEntryXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ContractCodeEntry value)
        {
            value.Validate();
            ContractCodeEntry.extUnionXdr.Encode(stream, value.ext);
            HashXdr.Encode(stream, value.hash);
            stream.WriteOpaque(value.code);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ContractCodeEntry Decode(XdrReader stream)
        {
            var result = new ContractCodeEntry();
            result.ext = ContractCodeEntry.extUnionXdr.Decode(stream);
            result.hash = HashXdr.Decode(stream);
            result.code = stream.ReadOpaque();
            return result;
        }
    }
}
