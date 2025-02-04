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

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ManageBuyOfferOp
    {
        private Asset _selling;
        public Asset selling
        {
            get => _selling;
            set
            {
                _selling = value;
            }
        }

        private Asset _buying;
        public Asset buying
        {
            get => _buying;
            set
            {
                _buying = value;
            }
        }

        private int64 _buyAmount;
        public int64 buyAmount
        {
            get => _buyAmount;
            set
            {
                _buyAmount = value;
            }
        }

        private Price _price;
        public Price price
        {
            get => _price;
            set
            {
                _price = value;
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
