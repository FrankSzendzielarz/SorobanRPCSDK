// Generated code - do not modify
// Source:

// struct CreatePassiveSellOfferOp
// {
//     Asset selling; // A
//     Asset buying;  // B
//     int64 amount;  // amount taker gets
//     Price price;   // cost of A in terms of B
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class CreatePassiveSellOfferOp
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

        public CreatePassiveSellOfferOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class CreatePassiveSellOfferOpXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, CreatePassiveSellOfferOp value)
        {
            value.Validate();
            AssetXdr.Encode(stream, value.selling);
            AssetXdr.Encode(stream, value.buying);
            int64Xdr.Encode(stream, value.amount);
            PriceXdr.Encode(stream, value.price);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static CreatePassiveSellOfferOp Decode(XdrReader stream)
        {
            var result = new CreatePassiveSellOfferOp();
            result.selling = AssetXdr.Decode(stream);
            result.buying = AssetXdr.Decode(stream);
            result.amount = int64Xdr.Decode(stream);
            result.price = PriceXdr.Decode(stream);
            return result;
        }
    }
}
