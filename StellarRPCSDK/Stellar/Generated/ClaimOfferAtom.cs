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
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class ClaimOfferAtom
    {
        /// <summary>
        /// emitted to identify the offer
        /// </summary>
        public AccountID sellerID
        {
            get => _sellerID;
            set
            {
                _sellerID = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Seller I D")]
        #endif
        private AccountID _sellerID;

        /// <summary>
        /// Account that owns the offer
        /// </summary>
        public int64 offerID
        {
            get => _offerID;
            set
            {
                _offerID = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Offer I D")]
        #endif
        private int64 _offerID;

        /// <summary>
        /// amount and asset taken from the owner
        /// </summary>
        public Asset assetSold
        {
            get => _assetSold;
            set
            {
                _assetSold = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Asset Sold")]
        #endif
        private Asset _assetSold;

        public int64 amountSold
        {
            get => _amountSold;
            set
            {
                _amountSold = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Amount Sold")]
        #endif
        private int64 _amountSold;

        /// <summary>
        /// amount and asset sent to the owner
        /// </summary>
        public Asset assetBought
        {
            get => _assetBought;
            set
            {
                _assetBought = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Asset Bought")]
        #endif
        private Asset _assetBought;

        public int64 amountBought
        {
            get => _amountBought;
            set
            {
                _amountBought = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Amount Bought")]
        #endif
        private int64 _amountBought;

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
