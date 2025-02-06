// Generated code - do not modify
// Source:

// struct CreateClaimableBalanceOp
// {
//     Asset asset;
//     int64 amount;
//     Claimant claimants<10>;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class CreateClaimableBalanceOp
    {
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

        [MaxLength(10)]
        public Claimant[] claimants
        {
            get => _claimants;
            set
            {
                if (value.Length > 10)
                	throw new ArgumentException($"Cannot exceed 10 in length");
                _claimants = value;
            }
        }
        private Claimant[] _claimants;

        public CreateClaimableBalanceOp()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (claimants.Length > 10)
            	throw new InvalidOperationException($"claimants cannot exceed 10 elements");
        }
    }
    public static partial class CreateClaimableBalanceOpXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(CreateClaimableBalanceOp value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                CreateClaimableBalanceOpXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, CreateClaimableBalanceOp value)
        {
            value.Validate();
            AssetXdr.Encode(stream, value.asset);
            int64Xdr.Encode(stream, value.amount);
            stream.WriteInt(value.claimants.Length);
            foreach (var item in value.claimants)
            {
                    ClaimantXdr.Encode(stream, item);
            }
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static CreateClaimableBalanceOp Decode(XdrReader stream)
        {
            var result = new CreateClaimableBalanceOp();
            result.asset = AssetXdr.Decode(stream);
            result.amount = int64Xdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.claimants = new Claimant[length];
                for (var i = 0; i < length; i++)
                {
                    result.claimants[i] = ClaimantXdr.Decode(stream);
                }
            }
            return result;
        }
    }
}
