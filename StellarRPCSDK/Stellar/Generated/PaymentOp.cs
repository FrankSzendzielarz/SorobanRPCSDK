// Generated code - do not modify
// Source:

// struct PaymentOp
// {
//     MuxedAccount destination; // recipient of the payment
//     Asset asset;              // what they end up with
//     int64 amount;             // amount they end up with
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
    public partial class PaymentOp
    {
        public MuxedAccount destination
        {
            get => _destination;
            set
            {
                _destination = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Destination")]
        #endif
        private MuxedAccount _destination;

        /// <summary>
        /// recipient of the payment
        /// </summary>
        public Asset asset
        {
            get => _asset;
            set
            {
                _asset = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Asset")]
        #endif
        private Asset _asset;

        /// <summary>
        /// what they end up with
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
        	[SerializeReference]
        	[InspectorName(@"Amount")]
        #endif
        private int64 _amount;

        public PaymentOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class PaymentOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(PaymentOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                PaymentOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, PaymentOp value)
        {
            value.Validate();
            MuxedAccountXdr.Encode(stream, value.destination);
            AssetXdr.Encode(stream, value.asset);
            int64Xdr.Encode(stream, value.amount);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static PaymentOp Decode(XdrReader stream)
        {
            var result = new PaymentOp();
            result.destination = MuxedAccountXdr.Decode(stream);
            result.asset = AssetXdr.Decode(stream);
            result.amount = int64Xdr.Decode(stream);
            return result;
        }
    }
}
