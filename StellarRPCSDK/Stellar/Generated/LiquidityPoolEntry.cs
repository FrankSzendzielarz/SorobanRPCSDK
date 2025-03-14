// Generated code - do not modify
// Source:

// struct LiquidityPoolEntry
// {
//     PoolID liquidityPoolID;
// 
//     union switch (LiquidityPoolType type)
//     {
//     case LIQUIDITY_POOL_CONSTANT_PRODUCT:
//         struct
//         {
//             LiquidityPoolConstantProductParameters params;
// 
//             int64 reserveA;        // amount of A in the pool
//             int64 reserveB;        // amount of B in the pool
//             int64 totalPoolShares; // total number of pool shares issued
//             int64 poolSharesTrustLineCount; // number of trust lines for the
//                                             // associated pool shares
//         } constantProduct;
//     }
//     body;
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
    public partial class LiquidityPoolEntry
    {
        [ProtoMember(1)]
        public PoolID liquidityPoolID
        {
            get => _liquidityPoolID;
            set
            {
                _liquidityPoolID = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Liquidity Pool I D")]
        #endif
        private PoolID _liquidityPoolID;

        [ProtoMember(2)]
        public bodyUnion body
        {
            get => _body;
            set
            {
                _body = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Body")]
        #endif
        private bodyUnion _body;

        public LiquidityPoolEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "LiquidityPoolEntry_bodyUnion")]
        [ProtoInclude(100, typeof(LiquidityPoolConstantProduct), DataFormat = DataFormat.Default)]
        public abstract partial class bodyUnion
        {
            public abstract LiquidityPoolType Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
            [System.Serializable]
            [ProtoContract(Name = "LiquidityPoolEntry_bodyUnion_constantProductStruct")]
            public partial class constantProductStruct
            {
                [ProtoMember(1)]
                public LiquidityPoolConstantProductParameters _params
                {
                    get => __params;
                    set
                    {
                        __params = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"_params")]
                #endif
                private LiquidityPoolConstantProductParameters __params;

                [ProtoMember(2)]
                public int64 reserveA
                {
                    get => _reserveA;
                    set
                    {
                        _reserveA = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Reserve A")]
                #endif
                private int64 _reserveA;

                /// <summary>
                /// amount of A in the pool
                /// </summary>
                [ProtoMember(3)]
                public int64 reserveB
                {
                    get => _reserveB;
                    set
                    {
                        _reserveB = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Reserve B")]
                #endif
                private int64 _reserveB;

                /// <summary>
                /// amount of B in the pool
                /// </summary>
                [ProtoMember(4)]
                public int64 totalPoolShares
                {
                    get => _totalPoolShares;
                    set
                    {
                        _totalPoolShares = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Total Pool Shares")]
                #endif
                private int64 _totalPoolShares;

                /// <summary>
                /// total number of pool shares issued
                /// </summary>
                [ProtoMember(5)]
                public int64 poolSharesTrustLineCount
                {
                    get => _poolSharesTrustLineCount;
                    set
                    {
                        _poolSharesTrustLineCount = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Pool Shares Trust Line Count")]
                #endif
                private int64 _poolSharesTrustLineCount;

                public constantProductStruct()
                {
                }
                /// <summary>Validates all fields have valid values</summary>
                public virtual void Validate()
                {
                }
            }
            public static partial class constantProductStructXdr
            {
                /// <summary>Encodes value to XDR base64 string</summary>
                public static string EncodeToBase64(constantProductStruct value)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        XdrWriter writer = new XdrWriter(memoryStream);
                        constantProductStructXdr.Encode(writer, value);
                        return Convert.ToBase64String(memoryStream.ToArray());
                    }
                }
                /// <summary>Decodes value from XDR base64 string</summary>
                public static constantProductStruct DecodeFromBase64(string base64)
                {
                    var bytes = Convert.FromBase64String(base64);
                    using (var memoryStream = new MemoryStream(bytes))
                    {
                        XdrReader reader = new XdrReader(memoryStream);
                        return constantProductStructXdr.Decode(reader);
                    }
                }
                /// <summary>Encodes struct to XDR stream</summary>
                public static void Encode(XdrWriter stream, constantProductStruct value)
                {
                    value.Validate();
                    LiquidityPoolConstantProductParametersXdr.Encode(stream, value._params);
                    int64Xdr.Encode(stream, value.reserveA);
                    int64Xdr.Encode(stream, value.reserveB);
                    int64Xdr.Encode(stream, value.totalPoolShares);
                    int64Xdr.Encode(stream, value.poolSharesTrustLineCount);
                }
                /// <summary>Decodes struct from XDR stream</summary>
                public static constantProductStruct Decode(XdrReader stream)
                {
                    var result = new constantProductStruct();
                    result._params = LiquidityPoolConstantProductParametersXdr.Decode(stream);
                    result.reserveA = int64Xdr.Decode(stream);
                    result.reserveB = int64Xdr.Decode(stream);
                    result.totalPoolShares = int64Xdr.Decode(stream);
                    result.poolSharesTrustLineCount = int64Xdr.Decode(stream);
                    return result;
                }
            }
            [System.Serializable]
            [ProtoContract(Name = "LiquidityPoolEntry_bodyUnion_LiquidityPoolConstantProduct")]
            public sealed partial class LiquidityPoolConstantProduct : bodyUnion
            {
                public override LiquidityPoolType Discriminator => LiquidityPoolType.LIQUIDITY_POOL_CONSTANT_PRODUCT;
                [ProtoMember(1)]
                public constantProductStruct constantProduct
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
                private constantProductStruct _constantProduct;

                public override void ValidateCase() {}
            }
        }
        public static partial class bodyUnionXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(bodyUnion value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    bodyUnionXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Decodes value from XDR base64 string</summary>
            public static bodyUnion DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return bodyUnionXdr.Decode(reader);
                }
            }
            public static void Encode(XdrWriter stream, bodyUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case bodyUnion.LiquidityPoolConstantProduct case_LIQUIDITY_POOL_CONSTANT_PRODUCT:
                    bodyUnion.constantProductStructXdr.Encode(stream, case_LIQUIDITY_POOL_CONSTANT_PRODUCT.constantProduct);
                    break;
                }
            }
            public static bodyUnion Decode(XdrReader stream)
            {
                var discriminator = (LiquidityPoolType)stream.ReadInt();
                switch (discriminator)
                {
                    case LiquidityPoolType.LIQUIDITY_POOL_CONSTANT_PRODUCT:
                    var result_LIQUIDITY_POOL_CONSTANT_PRODUCT = new bodyUnion.LiquidityPoolConstantProduct();
                    result_LIQUIDITY_POOL_CONSTANT_PRODUCT.constantProduct = bodyUnion.constantProductStructXdr.Decode(stream);
                    return result_LIQUIDITY_POOL_CONSTANT_PRODUCT;
                    default:
                    throw new Exception($"Unknown discriminator for bodyUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class LiquidityPoolEntryXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LiquidityPoolEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LiquidityPoolEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static LiquidityPoolEntry DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return LiquidityPoolEntryXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, LiquidityPoolEntry value)
        {
            value.Validate();
            PoolIDXdr.Encode(stream, value.liquidityPoolID);
            LiquidityPoolEntry.bodyUnionXdr.Encode(stream, value.body);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static LiquidityPoolEntry Decode(XdrReader stream)
        {
            var result = new LiquidityPoolEntry();
            result.liquidityPoolID = PoolIDXdr.Decode(stream);
            result.body = LiquidityPoolEntry.bodyUnionXdr.Decode(stream);
            return result;
        }
    }
}
