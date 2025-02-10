// Generated code - do not modify
// Source:

// struct SimplePaymentResult
// {
//     AccountID destination;
//     Asset asset;
//     int64 amount;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SimplePaymentResult
    {
        public AccountID destination
        {
            get => _destination;
            set
            {
                _destination = value;
            }
        }
        private AccountID _destination;

        public Asset asset
        {
            get => _asset;
            set
            {
                _asset = value;
            }
        }
        private Asset _asset;

        public int64 amount
        {
            get => _amount;
            set
            {
                _amount = value;
            }
        }
        private int64 _amount;

        public SimplePaymentResult()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SimplePaymentResultXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SimplePaymentResult value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SimplePaymentResultXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SimplePaymentResult value)
        {
            value.Validate();
            AccountIDXdr.Encode(stream, value.destination);
            AssetXdr.Encode(stream, value.asset);
            int64Xdr.Encode(stream, value.amount);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SimplePaymentResult Decode(XdrReader stream)
        {
            var result = new SimplePaymentResult();
            result.destination = AccountIDXdr.Decode(stream);
            result.asset = AssetXdr.Decode(stream);
            result.amount = int64Xdr.Decode(stream);
            return result;
        }
    }
}
