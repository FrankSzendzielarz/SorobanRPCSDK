// Generated code - do not modify
// Source:

// struct OfferEntry
// {
//     AccountID sellerID;
//     int64 offerID;
//     Asset selling; // A
//     Asset buying;  // B
//     int64 amount;  // amount of A
// 
//     /* price for this offer:
//         price of A in terms of B
//         price=AmountB/AmountA=priceNumerator/priceDenominator
//         price is after fees
//     */
//     Price price;
//     uint32 flags; // see OfferEntryFlags
// 
//     // reserved for future use
//     union switch (int v)
//     {
//     case 0:
//         void;
//     }
//     ext;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class OfferEntry
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

        private uint32 _flags;
        public uint32 flags
        {
            get => _flags;
            set
            {
                _flags = value;
            }
        }

        private object _ext;
        public object ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }

        public OfferEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class OfferEntryXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, OfferEntry value)
        {
            value.Validate();
            AccountIDXdr.Encode(stream, value.sellerID);
            int64Xdr.Encode(stream, value.offerID);
            AssetXdr.Encode(stream, value.selling);
            AssetXdr.Encode(stream, value.buying);
            int64Xdr.Encode(stream, value.amount);
            PriceXdr.Encode(stream, value.price);
            uint32Xdr.Encode(stream, value.flags);
            Xdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static OfferEntry Decode(XdrReader stream)
        {
            var result = new OfferEntry();
            result.sellerID = AccountIDXdr.Decode(stream);
            result.offerID = int64Xdr.Decode(stream);
            result.selling = AssetXdr.Decode(stream);
            result.buying = AssetXdr.Decode(stream);
            result.amount = int64Xdr.Decode(stream);
            result.price = PriceXdr.Decode(stream);
            result.flags = uint32Xdr.Decode(stream);
            result.ext = Xdr.Decode(stream);
            return result;
        }
    }
}
