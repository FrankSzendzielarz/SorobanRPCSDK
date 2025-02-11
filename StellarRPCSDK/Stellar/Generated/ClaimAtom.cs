// Generated code - do not modify
// Source:

// union ClaimAtom switch (ClaimAtomType type)
// {
// case CLAIM_ATOM_TYPE_V0:
//     ClaimOfferAtomV0 v0;
// case CLAIM_ATOM_TYPE_ORDER_BOOK:
//     ClaimOfferAtom orderBook;
// case CLAIM_ATOM_TYPE_LIQUIDITY_POOL:
//     ClaimLiquidityAtom liquidityPool;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public abstract partial class ClaimAtom
    {
        public abstract ClaimAtomType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        public sealed partial class ClaimAtomTypeV0 : ClaimAtom
        {
            public override ClaimAtomType Discriminator => ClaimAtomType.CLAIM_ATOM_TYPE_V0;
            public ClaimOfferAtomV0 v0
            {
                get => _v0;
                set
                {
                    _v0 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[InspectorName(@"V0")]
            #endif
            private ClaimOfferAtomV0 _v0;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ClaimAtomTypeOrderBook : ClaimAtom
        {
            public override ClaimAtomType Discriminator => ClaimAtomType.CLAIM_ATOM_TYPE_ORDER_BOOK;
            public ClaimOfferAtom orderBook
            {
                get => _orderBook;
                set
                {
                    _orderBook = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[InspectorName(@"Order Book")]
            #endif
            private ClaimOfferAtom _orderBook;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ClaimAtomTypeLiquidityPool : ClaimAtom
        {
            public override ClaimAtomType Discriminator => ClaimAtomType.CLAIM_ATOM_TYPE_LIQUIDITY_POOL;
            public ClaimLiquidityAtom liquidityPool
            {
                get => _liquidityPool;
                set
                {
                    _liquidityPool = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[InspectorName(@"Liquidity Pool")]
            #endif
            private ClaimLiquidityAtom _liquidityPool;

            public override void ValidateCase() {}
        }
    }
    public static partial class ClaimAtomXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ClaimAtom value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ClaimAtomXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, ClaimAtom value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ClaimAtom.ClaimAtomTypeV0 case_CLAIM_ATOM_TYPE_V0:
                ClaimOfferAtomV0Xdr.Encode(stream, case_CLAIM_ATOM_TYPE_V0.v0);
                break;
                case ClaimAtom.ClaimAtomTypeOrderBook case_CLAIM_ATOM_TYPE_ORDER_BOOK:
                ClaimOfferAtomXdr.Encode(stream, case_CLAIM_ATOM_TYPE_ORDER_BOOK.orderBook);
                break;
                case ClaimAtom.ClaimAtomTypeLiquidityPool case_CLAIM_ATOM_TYPE_LIQUIDITY_POOL:
                ClaimLiquidityAtomXdr.Encode(stream, case_CLAIM_ATOM_TYPE_LIQUIDITY_POOL.liquidityPool);
                break;
            }
        }
        public static ClaimAtom Decode(XdrReader stream)
        {
            var discriminator = (ClaimAtomType)stream.ReadInt();
            switch (discriminator)
            {
                case ClaimAtomType.CLAIM_ATOM_TYPE_V0:
                var result_CLAIM_ATOM_TYPE_V0 = new ClaimAtom.ClaimAtomTypeV0();
                result_CLAIM_ATOM_TYPE_V0.v0 = ClaimOfferAtomV0Xdr.Decode(stream);
                return result_CLAIM_ATOM_TYPE_V0;
                case ClaimAtomType.CLAIM_ATOM_TYPE_ORDER_BOOK:
                var result_CLAIM_ATOM_TYPE_ORDER_BOOK = new ClaimAtom.ClaimAtomTypeOrderBook();
                result_CLAIM_ATOM_TYPE_ORDER_BOOK.orderBook = ClaimOfferAtomXdr.Decode(stream);
                return result_CLAIM_ATOM_TYPE_ORDER_BOOK;
                case ClaimAtomType.CLAIM_ATOM_TYPE_LIQUIDITY_POOL:
                var result_CLAIM_ATOM_TYPE_LIQUIDITY_POOL = new ClaimAtom.ClaimAtomTypeLiquidityPool();
                result_CLAIM_ATOM_TYPE_LIQUIDITY_POOL.liquidityPool = ClaimLiquidityAtomXdr.Decode(stream);
                return result_CLAIM_ATOM_TYPE_LIQUIDITY_POOL;
                default:
                throw new Exception($"Unknown discriminator for ClaimAtom: {discriminator}");
            }
        }
    }
}
