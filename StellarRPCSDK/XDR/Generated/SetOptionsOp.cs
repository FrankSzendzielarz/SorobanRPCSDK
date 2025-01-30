// Generated code - do not modify
// Source:

// struct SetOptionsOp
// {
//     AccountID* inflationDest; // sets the inflation destination
// 
//     uint32* clearFlags; // which flags to clear
//     uint32* setFlags;   // which flags to set
// 
//     // account threshold manipulation
//     uint32* masterWeight; // weight of the master account
//     uint32* lowThreshold;
//     uint32* medThreshold;
//     uint32* highThreshold;
// 
//     string32* homeDomain; // sets the home domain
// 
//     // Add, update or remove a signer for the account
//     // signer is deleted if the weight is 0
//     Signer* signer;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class SetOptionsOp
    {
        private AccountID _inflationDest;
        public AccountID inflationDest
        {
            get => _inflationDest;
            set
            {
                _inflationDest = value;
            }
        }

        private uint32 _clearFlags;
        public uint32 clearFlags
        {
            get => _clearFlags;
            set
            {
                _clearFlags = value;
            }
        }

        private uint32 _setFlags;
        public uint32 setFlags
        {
            get => _setFlags;
            set
            {
                _setFlags = value;
            }
        }

        private uint32 _masterWeight;
        public uint32 masterWeight
        {
            get => _masterWeight;
            set
            {
                _masterWeight = value;
            }
        }

        private uint32 _lowThreshold;
        public uint32 lowThreshold
        {
            get => _lowThreshold;
            set
            {
                _lowThreshold = value;
            }
        }

        private uint32 _medThreshold;
        public uint32 medThreshold
        {
            get => _medThreshold;
            set
            {
                _medThreshold = value;
            }
        }

        private uint32 _highThreshold;
        public uint32 highThreshold
        {
            get => _highThreshold;
            set
            {
                _highThreshold = value;
            }
        }

        private string _homeDomain;
        public string homeDomain
        {
            get => _homeDomain;
            set
            {
                _homeDomain = value;
            }
        }

        private Signer _signer;
        public Signer signer
        {
            get => _signer;
            set
            {
                _signer = value;
            }
        }

        public SetOptionsOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
    }
    public static partial class SetOptionsOpXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SetOptionsOp value)
        {
            value.Validate();
            AccountIDXdr.Encode(stream, value.inflationDest);
            uint32Xdr.Encode(stream, value.clearFlags);
            uint32Xdr.Encode(stream, value.setFlags);
            uint32Xdr.Encode(stream, value.masterWeight);
            uint32Xdr.Encode(stream, value.lowThreshold);
            uint32Xdr.Encode(stream, value.medThreshold);
            uint32Xdr.Encode(stream, value.highThreshold);
            stream.WriteString(value.homeDomain);
            SignerXdr.Encode(stream, value.signer);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SetOptionsOp Decode(XdrReader stream)
        {
            var result = new SetOptionsOp();
            result.inflationDest = AccountIDXdr.Decode(stream);
            result.clearFlags = uint32Xdr.Decode(stream);
            result.setFlags = uint32Xdr.Decode(stream);
            result.masterWeight = uint32Xdr.Decode(stream);
            result.lowThreshold = uint32Xdr.Decode(stream);
            result.medThreshold = uint32Xdr.Decode(stream);
            result.highThreshold = uint32Xdr.Decode(stream);
            result.homeDomain = stream.ReadString();
            result.signer = SignerXdr.Decode(stream);
            return result;
        }
    }
}
