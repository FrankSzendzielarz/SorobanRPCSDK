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
using System.IO;

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

        private string32 _homeDomain;
        public string32 homeDomain
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
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(SetOptionsOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                SetOptionsOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, SetOptionsOp value)
        {
            value.Validate();
            if (value.inflationDest==null){
            	stream.WriteInt(0);
            }
            else
            {
                stream.WriteInt(1);
                AccountIDXdr.Encode(stream, value.inflationDest);
            }
            if (value.clearFlags==null){
            	stream.WriteInt(0);
            }
            else
            {
                stream.WriteInt(1);
                uint32Xdr.Encode(stream, value.clearFlags);
            }
            if (value.setFlags==null){
            	stream.WriteInt(0);
            }
            else
            {
                stream.WriteInt(1);
                uint32Xdr.Encode(stream, value.setFlags);
            }
            if (value.masterWeight==null){
            	stream.WriteInt(0);
            }
            else
            {
                stream.WriteInt(1);
                uint32Xdr.Encode(stream, value.masterWeight);
            }
            if (value.lowThreshold==null){
            	stream.WriteInt(0);
            }
            else
            {
                stream.WriteInt(1);
                uint32Xdr.Encode(stream, value.lowThreshold);
            }
            if (value.medThreshold==null){
            	stream.WriteInt(0);
            }
            else
            {
                stream.WriteInt(1);
                uint32Xdr.Encode(stream, value.medThreshold);
            }
            if (value.highThreshold==null){
            	stream.WriteInt(0);
            }
            else
            {
                stream.WriteInt(1);
                uint32Xdr.Encode(stream, value.highThreshold);
            }
            if (value.homeDomain==null){
            	stream.WriteInt(0);
            }
            else
            {
                stream.WriteInt(1);
                string32Xdr.Encode(stream, value.homeDomain);
            }
            if (value.signer==null){
            	stream.WriteInt(0);
            }
            else
            {
                stream.WriteInt(1);
                SignerXdr.Encode(stream, value.signer);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static SetOptionsOp Decode(XdrReader stream)
        {
            var result = new SetOptionsOp();
            if (stream.ReadInt()==1)
            {
                result.inflationDest = AccountIDXdr.Decode(stream);
            }
            if (stream.ReadInt()==1)
            {
                result.clearFlags = uint32Xdr.Decode(stream);
            }
            if (stream.ReadInt()==1)
            {
                result.setFlags = uint32Xdr.Decode(stream);
            }
            if (stream.ReadInt()==1)
            {
                result.masterWeight = uint32Xdr.Decode(stream);
            }
            if (stream.ReadInt()==1)
            {
                result.lowThreshold = uint32Xdr.Decode(stream);
            }
            if (stream.ReadInt()==1)
            {
                result.medThreshold = uint32Xdr.Decode(stream);
            }
            if (stream.ReadInt()==1)
            {
                result.highThreshold = uint32Xdr.Decode(stream);
            }
            if (stream.ReadInt()==1)
            {
                result.homeDomain = string32Xdr.Decode(stream);
            }
            if (stream.ReadInt()==1)
            {
                result.signer = SignerXdr.Decode(stream);
            }
            return result;
        }
    }
}
