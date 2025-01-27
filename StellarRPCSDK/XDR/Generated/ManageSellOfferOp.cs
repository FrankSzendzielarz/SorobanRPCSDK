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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class ManageSellOfferOp
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

        private int64 _amount;
        public int64 amount
        {
            get => _amount;
            set
            {
                _amount = value;
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
