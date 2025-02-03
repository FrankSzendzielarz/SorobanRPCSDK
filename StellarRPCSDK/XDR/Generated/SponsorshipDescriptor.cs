// Generated code - do not modify
// Source:

// typedef AccountID* SponsorshipDescriptor;


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SponsorshipDescriptor
    {
        private AccountID _innerValue;
        public AccountID InnerValue
        {
            get => _innerValue;
            set
            {
                _innerValue = value;
            }
        }

        public SponsorshipDescriptor() { }

        public SponsorshipDescriptor(AccountID value)
        {
            InnerValue = value;
        }
    }
    public static partial class SponsorshipDescriptorXdr
    {
        public static void Encode(XdrWriter stream, SponsorshipDescriptor value)
        {
            if (value.InnerValue==null){
            	stream.WriteInt(0);
            }
            else
            {
                stream.WriteInt(1);
                AccountIDXdr.Encode(stream, value.InnerValue);
            }
        }
        public static SponsorshipDescriptor Decode(XdrReader stream)
        {
            var result = new SponsorshipDescriptor();
            if (stream.ReadInt()==1)
            {
                result.InnerValue = AccountIDXdr.Decode(stream);
            }
            return result;
        }
    }
}
