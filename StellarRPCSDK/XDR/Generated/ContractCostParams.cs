// Generated code - do not modify
// Source:

// typedef ContractCostParamEntry ContractCostParams<CONTRACT_COST_COUNT_LIMIT>;


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ContractCostParams
    {
        [MaxLength(1024)]
        public ContractCostParamEntry[] InnerValue
        {
            get => _innerValue;
            set
            {
                if (value.Length > Constants.CONTRACT_COST_COUNT_LIMIT)
                	throw new ArgumentException($"Cannot exceed Constants.CONTRACT_COST_COUNT_LIMIT in length");
                _innerValue = value;
            }
        }
        private ContractCostParamEntry[] _innerValue;

        public ContractCostParams() { }

        public ContractCostParams(ContractCostParamEntry[] value)
        {
            InnerValue = value;
        }
        public static implicit operator ContractCostParamEntry[](ContractCostParams _contractcostparams) => _contractcostparams.InnerValue;
        public static implicit operator ContractCostParams(ContractCostParamEntry[] value) => new ContractCostParams(value);
    }
    public static partial class ContractCostParamsXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ContractCostParams value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ContractCostParamsXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, ContractCostParams value)
        {
            stream.WriteInt(value.InnerValue.Length);
            foreach (var item in value.InnerValue)
            {
                    ContractCostParamEntryXdr.Encode(stream, item);
            }
        }
        public static ContractCostParams Decode(XdrReader stream)
        {
            var result = new ContractCostParams();
            {
                var length = stream.ReadInt();
                result.InnerValue = new ContractCostParamEntry[length];
                for (var i = 0; i < length; i++)
                {
                    result.InnerValue[i] = ContractCostParamEntryXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
