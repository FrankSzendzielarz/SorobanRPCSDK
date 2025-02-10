// Generated code - do not modify
// Source:

// struct LiquidityPoolConstantProductParameters
// {
//     Asset assetA; // assetA < assetB
//     Asset assetB;
//     int32 fee; // Fee is in basis points, so the actual rate is (fee/100)%
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class LiquidityPoolConstantProductParameters
    {
        public Asset assetA
        {
            get => _assetA;
            set
            {
                _assetA = value;
            }
        }
        private Asset _assetA;

        /// <summary>
        /// assetA < assetB
        /// </summary>
        public Asset assetB
        {
            get => _assetB;
            set
            {
                _assetB = value;
            }
        }
        private Asset _assetB;

        public int32 fee
        {
            get => _fee;
            set
            {
                _fee = value;
            }
        }
        private int32 _fee;

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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LiquidityPoolConstantProductParameters value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LiquidityPoolConstantProductParametersXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
