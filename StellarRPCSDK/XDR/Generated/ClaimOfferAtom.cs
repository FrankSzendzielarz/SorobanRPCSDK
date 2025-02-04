// Generated code - do not modify
// Source:

// struct ClaimOfferAtom
// {
//     // emitted to identify the offer
//     AccountID sellerID; // Account that owns the offer
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
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ClaimOfferAtom
    {
        private AccountID _sellerID;
        public AccountID sellerID
        {
            get => _sellerID;
            set
            {
                _sellerID = value;
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

        public ClaimOfferAtom()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ClaimOfferAtomXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ClaimOfferAtom value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ClaimOfferAtomXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ClaimOfferAtom value)
        {
            value.Validate();
            AccountIDXdr.Encode(stream, value.sellerID);
            int64Xdr.Encode(stream, value.offerID);
            AssetXdr.Encode(stream, value.assetSold);
            int64Xdr.Encode(stream, value.amountSold);
            AssetXdr.Encode(stream, value.assetBought);
            int64Xdr.Encode(stream, value.amountBought);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ClaimOfferAtom Decode(XdrReader stream)
        {
            var result = new ClaimOfferAtom();
            result.sellerID = AccountIDXdr.Decode(stream);
            result.offerID = int64Xdr.Decode(stream);
            result.assetSold = AssetXdr.Decode(stream);
            result.amountSold = int64Xdr.Decode(stream);
            result.assetBought = AssetXdr.Decode(stream);
            result.amountBought = int64Xdr.Decode(stream);
            return result;
        }
    }
}
