// Generated code - do not modify
// Source:

// struct TrustLineEntry
// {
//     AccountID accountID;  // account this trustline belongs to
//     TrustLineAsset asset; // type of asset (with issuer)
//     int64 balance;        // how much of this asset the user has.
//                           // Asset defines the unit for this;
// 
//     int64 limit;  // balance cannot be above this
//     uint32 flags; // see TrustLineFlags
// 
//     // reserved for future use
//     union switch (int v)
//     {
//     case 0:
//         void;
//     case 1:
//         struct
//         {
//             Liabilities liabilities;
// 
//             union switch (int v)
//             {
//             case 0:
//                 void;
//             case 2:
//                 TrustLineEntryExtensionV2 v2;
//             }
//             ext;
//         } v1;
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
    public partial class TrustLineEntry
    {
        [ProtoMember(1)]
        public AccountID accountID
        {
            get => _accountID;
            set
            {
                _accountID = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Account I D")]
        #endif
        private AccountID _accountID;

        /// <summary>
        /// account this trustline belongs to
        /// </summary>
        [ProtoMember(2)]
        public TrustLineAsset asset
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
        private TrustLineAsset _asset;

        /// <summary>
        /// type of asset (with issuer)
        /// </summary>
        [ProtoMember(3)]
        public int64 balance
        {
            get => _balance;
            set
            {
                _balance = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Balance")]
        #endif
        private int64 _balance;

        [ProtoMember(4)]
        public int64 limit
        {
            get => _limit;
            set
            {
                _limit = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Limit")]
        #endif
        private int64 _limit;

        /// <summary>
        /// balance cannot be above this
        /// </summary>
        [ProtoMember(5)]
        public uint32 flags
        {
            get => _flags;
            set
            {
                _flags = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Flags")]
        #endif
        private uint32 _flags;

        /// <summary>
        /// reserved for future use
        /// </summary>
        [ProtoMember(6)]
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

        public TrustLineEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract(Name = "TrustLineEntry.extUnion")]
        [ProtoInclude(100, typeof(case_0), DataFormat = DataFormat.Default)]
        [ProtoInclude(101, typeof(case_1), DataFormat = DataFormat.Default)]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
            [System.Serializable]
            [ProtoContract(Name = "TrustLineEntry.extUnion.v1Struct")]
            public partial class v1Struct
            {
                [ProtoMember(1)]
                public Liabilities liabilities
                {
                    get => _liabilities;
                    set
                    {
                        _liabilities = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Liabilities")]
                #endif
                private Liabilities _liabilities;

                [ProtoMember(2)]
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

                public v1Struct()
                {
                }
                /// <summary>Validates all fields have valid values</summary>
                public virtual void Validate()
                {
                }
                [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
                [System.Serializable]
                [ProtoContract(Name = "TrustLineEntry.extUnion.v1Struct.extUnion")]
                [ProtoInclude(100, typeof(case_0), DataFormat = DataFormat.Default)]
                [ProtoInclude(101, typeof(case_2), DataFormat = DataFormat.Default)]
                public abstract partial class extUnion
                {
                    public abstract int Discriminator { get; }

                    /// <summary>Validates the union case matches its discriminator</summary>
                    public abstract void ValidateCase();

                    [System.Serializable]
                    [ProtoContract(Name = "TrustLineEntry.extUnion.v1Struct.extUnion.case_0")]
                    public sealed partial class case_0 : extUnion
                    {
                        public override int Discriminator => 0;

                        public override void ValidateCase() {}
                    }
                    [System.Serializable]
                    [ProtoContract(Name = "TrustLineEntry.extUnion.v1Struct.extUnion.case_2")]
                    public sealed partial class case_2 : extUnion
                    {
                        public override int Discriminator => 2;
                        [ProtoMember(1)]
                        public TrustLineEntryExtensionV2 v2
                        {
                            get => _v2;
                            set
                            {
                                _v2 = value;
                            }
                        }
                        #if UNITY
                        	[SerializeField]
                        	[SerializeReference]
                        	[InspectorName(@"V2")]
                        #endif
                        private TrustLineEntryExtensionV2 _v2;

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
                            case extUnion.case_2 case_2:
                            TrustLineEntryExtensionV2Xdr.Encode(stream, case_2.v2);
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
                            case 2:
                            var result_2 = new extUnion.case_2();
                            result_2.v2 = TrustLineEntryExtensionV2Xdr.Decode(stream);
                            return result_2;
                            default:
                            throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                        }
                    }
                }
            }
            public static partial class v1StructXdr
            {
                /// <summary>Encodes value to XDR base64 string</summary>
                public static string EncodeToBase64(v1Struct value)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        XdrWriter writer = new XdrWriter(memoryStream);
                        v1StructXdr.Encode(writer, value);
                        return Convert.ToBase64String(memoryStream.ToArray());
                    }
                }
                /// <summary>Decodes value from XDR base64 string</summary>
                public static v1Struct DecodeFromBase64(string base64)
                {
                    var bytes = Convert.FromBase64String(base64);
                    using (var memoryStream = new MemoryStream(bytes))
                    {
                        XdrReader reader = new XdrReader(memoryStream);
                        return v1StructXdr.Decode(reader);
                    }
                }
                /// <summary>Encodes struct to XDR stream</summary>
                public static void Encode(XdrWriter stream, v1Struct value)
                {
                    value.Validate();
                    LiabilitiesXdr.Encode(stream, value.liabilities);
                    v1Struct.extUnionXdr.Encode(stream, value.ext);
                }
                /// <summary>Decodes struct from XDR stream</summary>
                public static v1Struct Decode(XdrReader stream)
                {
                    var result = new v1Struct();
                    result.liabilities = LiabilitiesXdr.Decode(stream);
                    result.ext = v1Struct.extUnionXdr.Decode(stream);
                    return result;
                }
            }
            [System.Serializable]
            [ProtoContract(Name = "TrustLineEntry.extUnion.case_0")]
            public sealed partial class case_0 : extUnion
            {
                public override int Discriminator => 0;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            [ProtoContract(Name = "TrustLineEntry.extUnion.case_1")]
            public sealed partial class case_1 : extUnion
            {
                public override int Discriminator => 1;
                [ProtoMember(1)]
                public v1Struct v1
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
                private v1Struct _v1;

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
                    extUnion.v1StructXdr.Encode(stream, case_1.v1);
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
                    result_1.v1 = extUnion.v1StructXdr.Decode(stream);
                    return result_1;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class TrustLineEntryXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(TrustLineEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                TrustLineEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Decodes value from XDR base64 string</summary>
        public static TrustLineEntry DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return TrustLineEntryXdr.Decode(reader);
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, TrustLineEntry value)
        {
            value.Validate();
            AccountIDXdr.Encode(stream, value.accountID);
            TrustLineAssetXdr.Encode(stream, value.asset);
            int64Xdr.Encode(stream, value.balance);
            int64Xdr.Encode(stream, value.limit);
            uint32Xdr.Encode(stream, value.flags);
            TrustLineEntry.extUnionXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static TrustLineEntry Decode(XdrReader stream)
        {
            var result = new TrustLineEntry();
            result.accountID = AccountIDXdr.Decode(stream);
            result.asset = TrustLineAssetXdr.Decode(stream);
            result.balance = int64Xdr.Decode(stream);
            result.limit = int64Xdr.Decode(stream);
            result.flags = uint32Xdr.Decode(stream);
            result.ext = TrustLineEntry.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
