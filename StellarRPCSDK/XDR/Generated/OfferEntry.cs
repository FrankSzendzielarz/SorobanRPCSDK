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
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class OfferEntry
    {
        public AccountID sellerID
        {
            get => _sellerID;
            set
            {
                _sellerID = value;
            }
        }
        private AccountID _sellerID;

        public int64 offerID
        {
            get => _offerID;
            set
            {
                _offerID = value;
            }
        }
        private int64 _offerID;

        public Asset selling
        {
            get => _selling;
            set
            {
                _selling = value;
            }
        }
        private Asset _selling;

        /// <summary>
        /// A
        /// </summary>
        public Asset buying
        {
            get => _buying;
            set
            {
                _buying = value;
            }
        }
        private Asset _buying;

        /// <summary>
        /// B
        /// </summary>
        public int64 amount
        {
            get => _amount;
            set
            {
                _amount = value;
            }
        }
        private int64 _amount;

        public Price price
        {
            get => _price;
            set
            {
                _price = value;
            }
        }
        private Price _price;

        public uint32 flags
        {
            get => _flags;
            set
            {
                _flags = value;
            }
        }
        private uint32 _flags;

        /// <summary>
        /// reserved for future use
        /// </summary>
        public extUnion ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }
        private extUnion _ext;

        public OfferEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            public sealed partial class case_0 : extUnion
            {
                public override int Discriminator => 0;

                public override void ValidateCase() {}
            }
        }
        public static partial class extUnionXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(extUnion value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    extUnionXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            public static void Encode(XdrWriter stream, extUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case extUnion.case_0 case_0:
                    break;
                }
            }
            public static extUnion Decode(XdrReader stream)
            {
                var discriminator = (int)stream.ReadInt();
                switch (discriminator)
                {
                    case 0:
                    var result_0 = new extUnion.case_0();
                    return result_0;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class OfferEntryXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(OfferEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                OfferEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
            OfferEntry.extUnionXdr.Encode(stream, value.ext);
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
            result.ext = OfferEntry.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
