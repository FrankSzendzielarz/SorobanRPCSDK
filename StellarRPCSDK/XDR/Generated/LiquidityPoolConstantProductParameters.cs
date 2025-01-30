// Generated code - do not modify
// Source:

// struct LiquidityPoolConstantProductParameters
// {
//     Asset assetA; // assetA < assetB
//     Asset assetB;
//     int32 fee; // Fee is in basis points, so the actual rate is (fee/100)%
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class LiquidityPoolConstantProductParameters
    {
        private Asset _assetA;
        public Asset assetA
        {
            get => _assetA;
            set
            {
                _assetA = value;
            }
        }

        private Asset _assetB;
        public Asset assetB
        {
            get => _assetB;
            set
            {
                _assetB = value;
            }
        }

        private int32 _fee;
        public int32 fee
        {
            get => _fee;
            set
            {
                _fee = value;
            }
        }

        public LiquidityPoolConstantProductParameters()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class LiquidityPoolConstantProductParametersXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, LiquidityPoolConstantProductParameters value)
        {
            value.Validate();
            AssetXdr.Encode(stream, value.assetA);
            AssetXdr.Encode(stream, value.assetB);
            int32Xdr.Encode(stream, value.fee);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static LiquidityPoolConstantProductParameters Decode(XdrReader stream)
        {
            var result = new LiquidityPoolConstantProductParameters();
            result.assetA = AssetXdr.Decode(stream);
            result.assetB = AssetXdr.Decode(stream);
            result.fee = int32Xdr.Decode(stream);
            return result;
        }
    }
}
