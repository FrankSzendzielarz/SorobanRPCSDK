// Generated code - do not modify
// Source:

// struct CreateAccountOp
// {
//     AccountID destination; // account to create
//     int64 startingBalance; // amount they end up with
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class CreateAccountOp
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

        /// <summary>
        /// account to create
        /// </summary>
        public int64 startingBalance
        {
            get => _startingBalance;
            set
            {
                _startingBalance = value;
            }
        }
        private int64 _startingBalance;

        public CreateAccountOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class CreateAccountOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(CreateAccountOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                CreateAccountOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, CreateAccountOp value)
        {
            value.Validate();
            AccountIDXdr.Encode(stream, value.destination);
            int64Xdr.Encode(stream, value.startingBalance);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static CreateAccountOp Decode(XdrReader stream)
        {
            var result = new CreateAccountOp();
            result.destination = AccountIDXdr.Decode(stream);
            result.startingBalance = int64Xdr.Decode(stream);
            return result;
        }
    }
}
