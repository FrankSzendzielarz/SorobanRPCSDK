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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class ClaimAtom
    {
        public abstract ClaimAtomType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class ClaimAtom_CLAIM_ATOM_TYPE_V0 : ClaimAtom
    {
        public override ClaimAtomType Discriminator => ClaimAtomType.CLAIM_ATOM_TYPE_V0;
        private ClaimOfferAtomV0 _v0;
        public ClaimOfferAtomV0 v0
        {
            get => _v0;
            set
            {
                _v0 = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class ClaimAtom_CLAIM_ATOM_TYPE_ORDER_BOOK : ClaimAtom
    {
        public override ClaimAtomType Discriminator => ClaimAtomType.CLAIM_ATOM_TYPE_ORDER_BOOK;
        private ClaimOfferAtom _orderBook;
        public ClaimOfferAtom orderBook
        {
            get => _orderBook;
            set
            {
                _orderBook = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class ClaimAtom_CLAIM_ATOM_TYPE_LIQUIDITY_POOL : ClaimAtom
    {
        public override ClaimAtomType Discriminator => ClaimAtomType.CLAIM_ATOM_TYPE_LIQUIDITY_POOL;
        private ClaimLiquidityAtom _liquidityPool;
        public ClaimLiquidityAtom liquidityPool
        {
            get => _liquidityPool;
            set
            {
                _liquidityPool = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class ClaimAtomXdr
    {
        public static void Encode(XdrWriter stream, ClaimAtom value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ClaimAtom_CLAIM_ATOM_TYPE_V0 case_CLAIM_ATOM_TYPE_V0:
                ClaimOfferAtomV0Xdr.Encode(stream, case_CLAIM_ATOM_TYPE_V0.v0);
                break;
                case ClaimAtom_CLAIM_ATOM_TYPE_ORDER_BOOK case_CLAIM_ATOM_TYPE_ORDER_BOOK:
                ClaimOfferAtomXdr.Encode(stream, case_CLAIM_ATOM_TYPE_ORDER_BOOK.orderBook);
                break;
                case ClaimAtom_CLAIM_ATOM_TYPE_LIQUIDITY_POOL case_CLAIM_ATOM_TYPE_LIQUIDITY_POOL:
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
                var result_CLAIM_ATOM_TYPE_V0 = new ClaimAtom_CLAIM_ATOM_TYPE_V0();
                result_CLAIM_ATOM_TYPE_V0.v0 = ClaimOfferAtomV0Xdr.Decode(stream);
                return result_CLAIM_ATOM_TYPE_V0;
                case ClaimAtomType.CLAIM_ATOM_TYPE_ORDER_BOOK:
                var result_CLAIM_ATOM_TYPE_ORDER_BOOK = new ClaimAtom_CLAIM_ATOM_TYPE_ORDER_BOOK();
                result_CLAIM_ATOM_TYPE_ORDER_BOOK.orderBook = ClaimOfferAtomXdr.Decode(stream);
                return result_CLAIM_ATOM_TYPE_ORDER_BOOK;
                case ClaimAtomType.CLAIM_ATOM_TYPE_LIQUIDITY_POOL:
                var result_CLAIM_ATOM_TYPE_LIQUIDITY_POOL = new ClaimAtom_CLAIM_ATOM_TYPE_LIQUIDITY_POOL();
                result_CLAIM_ATOM_TYPE_LIQUIDITY_POOL.liquidityPool = ClaimLiquidityAtomXdr.Decode(stream);
                return result_CLAIM_ATOM_TYPE_LIQUIDITY_POOL;
                default:
                throw new Exception($"Unknown discriminator for ClaimAtom: {discriminator}");
            }
        }
    }
}
