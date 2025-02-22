// Generated code - do not modify
// Source:

// union ClaimableBalanceID switch (ClaimableBalanceIDType type)
// {
// case CLAIMABLE_BALANCE_ID_TYPE_V0:
//     Hash v0;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    [ProtoInclude(100, typeof(ClaimableBalanceIdTypeV0), DataFormat = DataFormat.Default)]
    public abstract partial class ClaimableBalanceID
    {
        public abstract ClaimableBalanceIDType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "ClaimableBalanceID.ClaimableBalanceIdTypeV0")]
        public sealed partial class ClaimableBalanceIdTypeV0 : ClaimableBalanceID
        {
            public override ClaimableBalanceIDType Discriminator => ClaimableBalanceIDType.CLAIMABLE_BALANCE_ID_TYPE_V0;
            [ProtoMember(1)]
            public Hash v0
            {
                get => _v0;
                set
                {
                    _v0 = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"V0")]
            #endif
            private Hash _v0;

            public override void ValidateCase() {}
        }
    }
    public static partial class ClaimableBalanceIDXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ClaimableBalanceID value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ClaimableBalanceIDXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, ClaimableBalanceID value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ClaimableBalanceID.ClaimableBalanceIdTypeV0 case_CLAIMABLE_BALANCE_ID_TYPE_V0:
                HashXdr.Encode(stream, case_CLAIMABLE_BALANCE_ID_TYPE_V0.v0);
                break;
            }
        }
        public static ClaimableBalanceID Decode(XdrReader stream)
        {
            var discriminator = (ClaimableBalanceIDType)stream.ReadInt();
            switch (discriminator)
            {
                case ClaimableBalanceIDType.CLAIMABLE_BALANCE_ID_TYPE_V0:
                var result_CLAIMABLE_BALANCE_ID_TYPE_V0 = new ClaimableBalanceID.ClaimableBalanceIdTypeV0();
                result_CLAIMABLE_BALANCE_ID_TYPE_V0.v0 = HashXdr.Decode(stream);
                return result_CLAIMABLE_BALANCE_ID_TYPE_V0;
                default:
                throw new Exception($"Unknown discriminator for ClaimableBalanceID: {discriminator}");
            }
        }
    }
}
