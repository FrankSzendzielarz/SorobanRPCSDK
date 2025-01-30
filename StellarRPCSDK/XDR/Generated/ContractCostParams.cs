// Generated code - do not modify
// Source:

// typedef ContractCostParamEntry ContractCostParams<CONTRACT_COST_COUNT_LIMIT>;


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ContractCostParams
    {
        private ContractCostParamEntry[] _innerValue;
        public ContractCostParamEntry[] InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }

        public ContractCostParams() { }

        public ContractCostParams(ContractCostParamEntry[] value)
        {
            InnerValue = value;
        }
    }
    public static partial class ContractCostParamsXdr
    {
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
