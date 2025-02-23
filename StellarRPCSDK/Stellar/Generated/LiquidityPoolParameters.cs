// Generated code - do not modify
// Source:

// union LiquidityPoolParameters switch (LiquidityPoolType type)
// {
// case LIQUIDITY_POOL_CONSTANT_PRODUCT:
//     LiquidityPoolConstantProductParameters constantProduct;
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
    [ProtoInclude(100, typeof(LiquidityPoolConstantProduct), DataFormat = DataFormat.Default)]
    public abstract partial class LiquidityPoolParameters
    {
        public abstract LiquidityPoolType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "LiquidityPoolParameters_LiquidityPoolConstantProduct")]
        public sealed partial class LiquidityPoolConstantProduct : LiquidityPoolParameters
        {
            public override LiquidityPoolType Discriminator => LiquidityPoolType.LIQUIDITY_POOL_CONSTANT_PRODUCT;
            [ProtoMember(1)]
            public LiquidityPoolConstantProductParameters constantProduct
            {
                get => _constantProduct;
                set
                {
                    _constantProduct = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Constant Product")]
            #endif
            private LiquidityPoolConstantProductParameters _constantProduct;

            public override void ValidateCase() {}
        }
    }
    public static partial class LiquidityPoolParametersXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LiquidityPoolParameters value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LiquidityPoolParametersXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static LiquidityPoolParameters DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return LiquidityPoolParametersXdr.Decode(reader);
            }
        }
        public static void Encode(XdrWriter stream, LiquidityPoolParameters value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case LiquidityPoolParameters.LiquidityPoolConstantProduct case_LIQUIDITY_POOL_CONSTANT_PRODUCT:
                LiquidityPoolConstantProductParametersXdr.Encode(stream, case_LIQUIDITY_POOL_CONSTANT_PRODUCT.constantProduct);
                break;
            }
        }
        public static LiquidityPoolParameters Decode(XdrReader stream)
        {
            var discriminator = (LiquidityPoolType)stream.ReadInt();
            switch (discriminator)
            {
                case LiquidityPoolType.LIQUIDITY_POOL_CONSTANT_PRODUCT:
                var result_LIQUIDITY_POOL_CONSTANT_PRODUCT = new LiquidityPoolParameters.LiquidityPoolConstantProduct();
                result_LIQUIDITY_POOL_CONSTANT_PRODUCT.constantProduct = LiquidityPoolConstantProductParametersXdr.Decode(stream);
                return result_LIQUIDITY_POOL_CONSTANT_PRODUCT;
                default:
                throw new Exception($"Unknown discriminator for LiquidityPoolParameters: {discriminator}");
            }
        }
    }
}
