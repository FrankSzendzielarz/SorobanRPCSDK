// Generated code - do not modify
// Source:

// struct StellarValue
// {
//     Hash txSetHash;      // transaction set to apply to previous ledger
//     TimePoint closeTime; // network close time
// 
//     // upgrades to apply to the previous ledger (usually empty)
//     // this is a vector of encoded 'LedgerUpgrade' so that nodes can drop
//     // unknown steps during consensus if needed.
//     // see notes below on 'LedgerUpgrade' for more detail
//     // max size is dictated by number of upgrade types (+ room for future)
//     UpgradeType upgrades<6>;
// 
//     // reserved for future use
//     union switch (StellarValueType v)
//     {
//     case STELLAR_VALUE_BASIC:
//         void;
//     case STELLAR_VALUE_SIGNED:
//         LedgerCloseValueSignature lcValueSignature;
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
    public partial class StellarValue
    {
        [ProtoMember(1)]
        public Hash txSetHash
        {
            get => _txSetHash;
            set
            {
                _txSetHash = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Tx Set Hash")]
        #endif
        private Hash _txSetHash;

        /// <summary>
        /// transaction set to apply to previous ledger
        /// </summary>
        [ProtoMember(2)]
        public TimePoint closeTime
        {
            get => _closeTime;
            set
            {
                _closeTime = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Close Time")]
        #endif
        private TimePoint _closeTime;

        /// <summary>
        /// max size is dictated by number of upgrade types (+ room for future)
        /// </summary>
        [ProtoMember(3, OverwriteList = true)]
        [MaxLength(6)]
        public UpgradeType[] upgrades
        {
            get => _upgrades;
            set
            {
                if (value.Length > 6)
                	throw new ArgumentException($"Cannot exceed 6 in length");
                _upgrades = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Upgrades")]
        #endif
        private UpgradeType[] _upgrades;

        /// <summary>
        /// reserved for future use
        /// </summary>
        [ProtoMember(4)]
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

        public StellarValue()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
            if (upgrades.Length > 6)
            	throw new InvalidOperationException($"upgrades cannot exceed 6 elements");
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "StellarValue.extUnion")]
        [ProtoInclude(100, typeof(StellarValueBasic), DataFormat = DataFormat.Default)]
        [ProtoInclude(101, typeof(StellarValueSigned), DataFormat = DataFormat.Default)]
        public abstract partial class extUnion
        {
            public abstract StellarValueType Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.Serializable]
            [ProtoContract(Name = "StellarValue.extUnion.StellarValueBasic")]
            public sealed partial class StellarValueBasic : extUnion
            {
                public override StellarValueType Discriminator => StellarValueType.STELLAR_VALUE_BASIC;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "StellarValue.extUnion.StellarValueSigned")]
            public sealed partial class StellarValueSigned : extUnion
            {
                public override StellarValueType Discriminator => StellarValueType.STELLAR_VALUE_SIGNED;
                [ProtoMember(1)]
                public LedgerCloseValueSignature lcValueSignature
                {
                    get => _lcValueSignature;
                    set
                    {
                        _lcValueSignature = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Lc Value Signature")]
                #endif
                private LedgerCloseValueSignature _lcValueSignature;

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
                    case extUnion.StellarValueBasic case_STELLAR_VALUE_BASIC:
                    break;
                    case extUnion.StellarValueSigned case_STELLAR_VALUE_SIGNED:
                    LedgerCloseValueSignatureXdr.Encode(stream, case_STELLAR_VALUE_SIGNED.lcValueSignature);
                    break;
                }
            }
            public static extUnion Decode(XdrReader stream)
            {
                var discriminator = (StellarValueType)stream.ReadInt();
                switch (discriminator)
                {
                    case StellarValueType.STELLAR_VALUE_BASIC:
                    var result_STELLAR_VALUE_BASIC = new extUnion.StellarValueBasic();
                    return result_STELLAR_VALUE_BASIC;
                    case StellarValueType.STELLAR_VALUE_SIGNED:
                    var result_STELLAR_VALUE_SIGNED = new extUnion.StellarValueSigned();
                    result_STELLAR_VALUE_SIGNED.lcValueSignature = LedgerCloseValueSignatureXdr.Decode(stream);
                    return result_STELLAR_VALUE_SIGNED;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class StellarValueXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(StellarValue value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                StellarValueXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static StellarValue DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return StellarValueXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, StellarValue value)
        {
            value.Validate();
            HashXdr.Encode(stream, value.txSetHash);
            TimePointXdr.Encode(stream, value.closeTime);
            stream.WriteInt(value.upgrades.Length);
            foreach (var item in value.upgrades)
            {
                    UpgradeTypeXdr.Encode(stream, item);
            }
            StellarValue.extUnionXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static StellarValue Decode(XdrReader stream)
        {
            var result = new StellarValue();
            result.txSetHash = HashXdr.Decode(stream);
            result.closeTime = TimePointXdr.Decode(stream);
            {
                var length = stream.ReadInt();
                result.upgrades = new UpgradeType[length];
                for (var i = 0; i < length; i++)
                {
                    result.upgrades[i] = UpgradeTypeXdr.Decode(stream);
                }
            }
            result.ext = StellarValue.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
