// Generated code - do not modify
// Source:

// struct ManageSellOfferOp
// {
//     Asset selling;
//     Asset buying;
//     int64 amount; // amount being sold. if set to 0, delete the offer
//     Price price;  // price of thing being sold in terms of what you are buying
// 
//     // 0=create a new offer, otherwise edit an existing offer
//     int64 offerID;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ManageSellOfferOp
    {
        public Asset selling
        {
            get => _selling;
            set
            {
                _selling = value;
            }
        }
        private Asset _selling;

        public Asset buying
        {
            get => _buying;
            set
            {
                _buying = value;
            }
        }
        private Asset _buying;

        public int64 amount
        {
            get => _amount;
            set
            {
                _amount = value;
            }
        }
        private int64 _amount;

        /// <summary>
        /// amount being sold. if set to 0, delete the offer
        /// </summary>
        public Price price
        {
            get => _price;
            set
            {
                _price = value;
            }
        }
        private Price _price;

        /// <summary>
        /// 0=create a new offer, otherwise edit an existing offer
        /// </summary>
        public int64 offerID
        {
            get => _offerID;
            set
            {
                _offerID = value;
            }
        }
        private int64 _offerID;

        public ManageSellOfferOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class ManageSellOfferOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ManageSellOfferOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ManageSellOfferOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ManageSellOfferOp value)
        {
            value.Validate();
            AssetXdr.Encode(stream, value.selling);
            AssetXdr.Encode(stream, value.buying);
            int64Xdr.Encode(stream, value.amount);
            PriceXdr.Encode(stream, value.price);
            int64Xdr.Encode(stream, value.offerID);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ManageSellOfferOp Decode(XdrReader stream)
        {
            var result = new ManageSellOfferOp();
            result.selling = AssetXdr.Decode(stream);
            result.buying = AssetXdr.Decode(stream);
            result.amount = int64Xdr.Decode(stream);
            result.price = PriceXdr.Decode(stream);
            result.offerID = int64Xdr.Decode(stream);
            return result;
        }
    }
}
