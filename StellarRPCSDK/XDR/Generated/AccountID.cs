// Generated code - do not modify
// Source:

// typedef PublicKey AccountID;


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class AccountID
    {
        private PublicKey _innerValue;
        public PublicKey InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }

        public AccountID() { }

        public AccountID(PublicKey value)
        {
            InnerValue = value;
        }
    }
    public static partial class AccountIDXdr
    {
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
