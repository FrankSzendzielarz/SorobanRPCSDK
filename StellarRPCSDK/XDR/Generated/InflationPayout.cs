// Generated code - do not modify
// Source:

// struct InflationPayout // or use PaymentResultAtom to limit types?
// {
//     AccountID destination;
//     int64 amount;
// };


using System;
using System.IO;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class InflationPayout
    {
        private AccountID _destination;
        public AccountID destination
        {
            get => _destination;
            set
            {
                _destination = value;
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

        public InflationPayout()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class InflationPayoutXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(InflationPayout value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                InflationPayoutXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, InflationPayout value)
        {
            value.Validate();
            AccountIDXdr.Encode(stream, value.destination);
            int64Xdr.Encode(stream, value.amount);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static InflationPayout Decode(XdrReader stream)
        {
            var result = new InflationPayout();
            result.destination = AccountIDXdr.Decode(stream);
            result.amount = int64Xdr.Decode(stream);
            return result;
        }
    }
}
