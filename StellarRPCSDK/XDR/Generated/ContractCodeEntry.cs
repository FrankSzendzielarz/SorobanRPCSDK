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
        private object _ext;
        public object ext
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
    }
    public static partial class ContractCodeEntryXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ContractCodeEntry value)
        {
            value.Validate();
            Xdr.Encode(stream, value.ext);
            HashXdr.Encode(stream, value.hash);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ContractCodeEntry Decode(XdrReader stream)
        {
            var result = new ContractCodeEntry();
            result.ext = Xdr.Decode(stream);
            result.hash = HashXdr.Decode(stream);
            return result;
        }
    }
}
