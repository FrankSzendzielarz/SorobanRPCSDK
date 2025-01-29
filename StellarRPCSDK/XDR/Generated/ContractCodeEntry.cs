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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ContractCodeEntry
    {
        private extUnion _ext;
        public extUnion ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }

        private Hash _hash;
        public Hash hash
        {
            get => _hash;
            set
            {
                _hash = value;
            }
        }

        public ContractCodeEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
            public partial class v1Struct
            {
                private ExtensionPoint _ext;
                public ExtensionPoint ext
                {
                    get => _ext;
                    set
                    {
                        _ext = value;
                    }
                }

                private ContractCodeCostInputs _costInputs;
                public ContractCodeCostInputs costInputs
                {
                    get => _costInputs;
                    set
                    {
                        _costInputs = value;
                    }
                }

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
        }
        public sealed partial class extUnion_0 : extUnion
        {
            public override int Discriminator => 0;

            public override void ValidateCase() {}
        }
        public sealed partial class extUnion_1 : extUnion
        {
            public override int Discriminator => 1;
            private v1Struct _v1;
            public v1Struct v1
            {
                get => _v1;
                set
                {
                    _v1 = value;
                }
            }

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
                    case extUnion_1 case_1:
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
                    var result_0 = new extUnion_0();
                    return result_0;
                    case 1:
                    var result_1 = new extUnion_1();
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
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ContractCodeEntry value)
        {
            value.Validate();
            ContractCodeEntry.extUnionXdr.Encode(stream, value.ext);
            HashXdr.Encode(stream, value.hash);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ContractCodeEntry Decode(XdrReader stream)
        {
            var result = new ContractCodeEntry();
            result.ext = ContractCodeEntry.extUnionXdr.Decode(stream);
            result.hash = HashXdr.Decode(stream);
            return result;
        }
    }
}
