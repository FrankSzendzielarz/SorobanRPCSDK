// Generated code - do not modify
// Source:

// struct ManageBuyOfferOp
// {
//     Asset selling;
//     Asset buying;
//     int64 buyAmount; // amount being bought. if set to 0, delete the offer
//     Price price;     // price of thing being bought in terms of what you are
//                      // selling
// 
//     // 0=create a new offer, otherwise edit an existing offer
//     int64 offerID;
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
    public partial class ManageBuyOfferOp
    {
        [ProtoMember(1)]
        public Asset selling
        {
            get => _selling;
            set
            {
                _selling = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Selling")]
        #endif
        private Asset _selling;

        [ProtoMember(2)]
        public Asset buying
        {
            get => _buying;
            set
            {
                _buying = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Buying")]
        #endif
        private Asset _buying;

        [ProtoMember(3)]
        public int64 buyAmount
        {
            get => _buyAmount;
            set
            {
                _buyAmount = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Buy Amount")]
        #endif
        private int64 _buyAmount;

        /// <summary>
        /// amount being bought. if set to 0, delete the offer
        /// </summary>
        [ProtoMember(4)]
        public Price price
        {
            get => _price;
            set
            {
                _price = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Price")]
        #endif
        private Price _price;

        /// <summary>
        /// 0=create a new offer, otherwise edit an existing offer
        /// </summary>
        [ProtoMember(5)]
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
        	[SerializeReference]
        	[InspectorName(@"Offer I D")]
        #endif
        private int64 _offerID;

        public ManageBuyOfferOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ManageBuyOfferOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ManageBuyOfferOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ManageBuyOfferOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ManageBuyOfferOp DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ManageBuyOfferOpXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ManageBuyOfferOp value)
        {
            value.Validate();
            AssetXdr.Encode(stream, value.selling);
            AssetXdr.Encode(stream, value.buying);
            int64Xdr.Encode(stream, value.buyAmount);
            PriceXdr.Encode(stream, value.price);
            int64Xdr.Encode(stream, value.offerID);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ManageBuyOfferOp Decode(XdrReader stream)
        {
            var result = new ManageBuyOfferOp();
            result.selling = AssetXdr.Decode(stream);
            result.buying = AssetXdr.Decode(stream);
            result.buyAmount = int64Xdr.Decode(stream);
            result.price = PriceXdr.Decode(stream);
            result.offerID = int64Xdr.Decode(stream);
            return result;
        }
    }
}
