// Generated code - do not modify
// Source:

// struct ClaimableBalanceEntry
// {
//     // Unique identifier for this ClaimableBalanceEntry
//     ClaimableBalanceID balanceID;
// 
//     // List of claimants with associated predicate
//     Claimant claimants<10>;
// 
//     // Any asset including native
//     Asset asset;
// 
//     // Amount of asset
//     int64 amount;
// 
//     // reserved for future use
//     union switch (int v)
//     {
//     case 0:
//         void;
//     case 1:
//         ClaimableBalanceEntryExtensionV1 v1;
//     }
//     ext;
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
    public partial class ClaimableBalanceEntry
    {
        /// <summary>
        /// Unique identifier for this ClaimableBalanceEntry
        /// </summary>
        [ProtoMember(1)]
        public ClaimableBalanceID balanceID
        {
            get => _balanceID;
            set
            {
                _balanceID = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Balance I D")]
        #endif
        private ClaimableBalanceID _balanceID;

        /// <summary>
        /// List of claimants with associated predicate
        /// </summary>
        [ProtoMember(2, OverwriteList = true)]
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
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Claimants")]
        #endif
        private Claimant[] _claimants;

        /// <summary>
        /// Any asset including native
        /// </summary>
        [ProtoMember(3)]
        public Asset asset
        {
            get => _asset;
            set
            {
                _asset = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Asset")]
        #endif
        private Asset _asset;

        /// <summary>
        /// Amount of asset
        /// </summary>
        [ProtoMember(4)]
        public int64 amount
        {
            get => _amount;
            set
            {
                _amount = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Amount")]
        #endif
        private int64 _amount;

        /// <summary>
        /// reserved for future use
        /// </summary>
        [ProtoMember(5)]
        public extUnion ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Ext")]
        #endif
        private extUnion _ext;

        public ClaimableBalanceEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (claimants.Length > 10)
            	throw new InvalidOperationException($"claimants cannot exceed 10 elements");
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "ClaimableBalanceEntry_extUnion")]
        [ProtoInclude(100, typeof(case_0), DataFormat = DataFormat.Default)]
        [ProtoInclude(101, typeof(case_1), DataFormat = DataFormat.Default)]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.Serializable]
            [ProtoContract(Name = "ClaimableBalanceEntry_extUnion_case_0")]
            public sealed partial class case_0 : extUnion
            {
                public override int Discriminator => 0;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "ClaimableBalanceEntry_extUnion_case_1")]
            public sealed partial class case_1 : extUnion
            {
                public override int Discriminator => 1;
                [ProtoMember(1)]
                public ClaimableBalanceEntryExtensionV1 v1
                {
                    get => _v1;
                    set
                    {
                        _v1 = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"V1")]
                #endif
                private ClaimableBalanceEntryExtensionV1 _v1;

                public override void ValidateCase() {}
            }
        }
        public static partial class extUnionXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(extUnion value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    extUnionXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Decodes value from XDR base64 string</summary>
            public static extUnion DecodeFromBase64(string base64)
            {
                var bytes = Convert.FromBase64String(base64);
                using (var memoryStream = new MemoryStream(bytes))
                {
                    XdrReader reader = new XdrReader(memoryStream);
                    return extUnionXdr.Decode(reader);
                }
            }
            public static void Encode(XdrWriter stream, extUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case extUnion.case_0 case_0:
                    break;
                    case extUnion.case_1 case_1:
                    ClaimableBalanceEntryExtensionV1Xdr.Encode(stream, case_1.v1);
                    break;
                }
            }
            public static extUnion Decode(XdrReader stream)
            {
                var discriminator = (int)stream.ReadInt();
                switch (discriminator)
                {
                    case 0:
                    var result_0 = new extUnion.case_0();
                    return result_0;
                    case 1:
                    var result_1 = new extUnion.case_1();
                    result_1.v1 = ClaimableBalanceEntryExtensionV1Xdr.Decode(stream);
                    return result_1;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class ClaimableBalanceEntryXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ClaimableBalanceEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ClaimableBalanceEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static ClaimableBalanceEntry DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return ClaimableBalanceEntryXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, ClaimableBalanceEntry value)
        {
            value.Validate();
            ClaimableBalanceIDXdr.Encode(stream, value.balanceID);
            stream.WriteInt(value.claimants.Length);
            foreach (var item in value.claimants)
            {
                    ClaimantXdr.Encode(stream, item);
            }
            AssetXdr.Encode(stream, value.asset);
            int64Xdr.Encode(stream, value.amount);
            ClaimableBalanceEntry.extUnionXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static ClaimableBalanceEntry Decode(XdrReader stream)
        {
            var result = new ClaimableBalanceEntry();
            result.balanceID = ClaimableBalanceIDXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.claimants = new Claimant[length];
                for (var i = 0; i < length; i++)
                {
                    result.claimants[i] = ClaimantXdr.Decode(stream);
                }
            }
            result.asset = AssetXdr.Decode(stream);
            result.amount = int64Xdr.Decode(stream);
            result.ext = ClaimableBalanceEntry.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
