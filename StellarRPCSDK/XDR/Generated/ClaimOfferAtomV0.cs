// Generated code - do not modify
// Source:

// struct ClaimOfferAtomV0
// {
//     // emitted to identify the offer
//     uint256 sellerEd25519; // Account that owns the offer
//     int64 offerID;
// 
//     // amount and asset taken from the owner
//     Asset assetSold;
//     int64 amountSold;
// 
//     // amount and asset sent to the owner
//     Asset assetBought;
//     int64 amountBought;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ClaimOfferAtomV0
    {
        private uint256 _sellerEd25519;
        public uint256 sellerEd25519
        {
            get => _sellerEd25519;
            set
            {
                _sellerEd25519 = value;
            }
        }

        private int64 _offerID;
        public int64 offerID
        {
            get => _offerID;
            set
            {
                _offerID = value;
            }
        }

        private Asset _assetSold;
        public Asset assetSold
        {
            get => _assetSold;
            set
            {
                _assetSold = value;
            }
        }

        private int64 _amountSold;
        public int64 amountSold
        {
            get => _amountSold;
            set
            {
                _amountSold = value;
            }
        }

        private Asset _assetBought;
        public Asset assetBought
        {
            get => _assetBought;
            set
            {
                _assetBought = value;
            }
        }

        private int64 _amountBought;
        public int64 amountBought
        {
            get => _amountBought;
            set
            {
                _amountBought = value;
            }
        }

        public ClaimOfferAtomV0()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ClaimOfferAtomV0Xdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ClaimOfferAtomV0 value)
        {
            value.Validate();
            uint256Xdr.Encode(stream, value.sellerEd25519);
            int64Xdr.Encode(stream, value.offerID);
            AssetXdr.Encode(stream, value.assetSold);
            int64Xdr.Encode(stream, value.amountSold);
            AssetXdr.Encode(stream, value.assetBought);
            int64Xdr.Encode(stream, value.amountBought);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ClaimOfferAtomV0 Decode(XdrReader stream)
        {
            var result = new ClaimOfferAtomV0();
            result.sellerEd25519 = uint256Xdr.Decode(stream);
            result.offerID = int64Xdr.Decode(stream);
            result.assetSold = AssetXdr.Decode(stream);
            result.amountSold = int64Xdr.Decode(stream);
            result.assetBought = AssetXdr.Decode(stream);
            result.amountBought = int64Xdr.Decode(stream);
            return result;
        }
    }
}
