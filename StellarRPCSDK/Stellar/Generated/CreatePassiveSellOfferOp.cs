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
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public partial class CreatePassiveSellOfferOp
    {
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
        	[InspectorName(@"Selling")]
        #endif
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
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Buying")]
        #endif
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
        #if UNITY
        	[SerializeField]
        	[InspectorName(@"Amount")]
        #endif
        private int64 _amount;

        /// <summary>
        /// amount taker gets
        /// </summary>
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
        	[InspectorName(@"Price")]
        #endif
        private Price _price;

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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(CreatePassiveSellOfferOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                CreatePassiveSellOfferOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
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
