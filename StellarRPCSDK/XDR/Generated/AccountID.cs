// Generated code - do not modify
// Source:

// typedef PublicKey AccountID;


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class AccountID
    {
        public PublicKey InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }
        private PublicKey _innerValue;

        public AccountID() { }

        public AccountID(PublicKey value)
        {
            InnerValue = value;
        }
        public static implicit operator PublicKey(AccountID _accountid) => _accountid.InnerValue;
        public static implicit operator AccountID(PublicKey value) => new AccountID(value);
    }
    public static partial class AccountIDXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(AccountID value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                AccountIDXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, AccountID value)
        {
            PublicKeyXdr.Encode(stream, value.InnerValue);
        }
        public static AccountID Decode(XdrReader stream)
        {
            var result = new AccountID();
            result.InnerValue = PublicKeyXdr.Decode(stream);
            return result;
        }
    }
}
