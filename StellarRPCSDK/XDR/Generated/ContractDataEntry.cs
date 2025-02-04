// Generated code - do not modify
// Source:

// struct ContractDataEntry {
//     ExtensionPoint ext;
// 
//     SCAddress contract;
//     SCVal key;
//     ContractDataDurability durability;
//     SCVal val;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ContractDataEntry
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

        private SCAddress _contract;
        public SCAddress contract
        {
            get => _contract;
            set
            {
                _contract = value;
            }
        }

        private SCVal _key;
        public SCVal key
        {
            get => _key;
            set
            {
                _key = value;
            }
        }

        private ContractDataDurability _durability;
        public ContractDataDurability durability
        {
            get => _durability;
            set
            {
                _durability = value;
            }
        }

        private SCVal _val;
        public SCVal val
        {
            get => _val;
            set
            {
                _val = value;
            }
        }

        public ContractDataEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ContractDataEntryXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ContractDataEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ContractDataEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ContractDataEntry value)
        {
            value.Validate();
            ExtensionPointXdr.Encode(stream, value.ext);
            SCAddressXdr.Encode(stream, value.contract);
            SCValXdr.Encode(stream, value.key);
            ContractDataDurabilityXdr.Encode(stream, value.durability);
            SCValXdr.Encode(stream, value.val);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ContractDataEntry Decode(XdrReader stream)
        {
            var result = new ContractDataEntry();
            result.ext = ExtensionPointXdr.Decode(stream);
            result.contract = SCAddressXdr.Decode(stream);
            result.key = SCValXdr.Decode(stream);
            result.durability = ContractDataDurabilityXdr.Decode(stream);
            result.val = SCValXdr.Decode(stream);
            return result;
        }
    }
}
