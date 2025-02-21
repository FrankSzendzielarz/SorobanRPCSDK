// Generated code - do not modify
// Source:

// struct LedgerEntry
// {
//     uint32 lastModifiedLedgerSeq; // ledger the LedgerEntry was last changed
// 
//     union switch (LedgerEntryType type)
//     {
//     case ACCOUNT:
//         AccountEntry account;
//     case TRUSTLINE:
//         TrustLineEntry trustLine;
//     case OFFER:
//         OfferEntry offer;
//     case DATA:
//         DataEntry data;
//     case CLAIMABLE_BALANCE:
//         ClaimableBalanceEntry claimableBalance;
//     case LIQUIDITY_POOL:
//         LiquidityPoolEntry liquidityPool;
//     case CONTRACT_DATA:
//         ContractDataEntry contractData;
//     case CONTRACT_CODE:
//         ContractCodeEntry contractCode;
//     case CONFIG_SETTING:
//         ConfigSettingEntry configSetting;
//     case TTL:
//         TTLEntry ttl;
//     }
//     data;
// 
//     // reserved for future use
//     union switch (int v)
//     {
//     case 0:
//         void;
//     case 1:
//         LedgerEntryExtensionV1 v1;
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
    public partial class LedgerEntry
    {
        public uint32 lastModifiedLedgerSeq
        {
            get => _lastModifiedLedgerSeq;
            set
            {
                _lastModifiedLedgerSeq = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Last Modified Ledger Seq")]
        #endif
        private uint32 _lastModifiedLedgerSeq;

        public dataUnion data
        {
            get => _data;
            set
            {
                _data = value;
            }
        }
        #if UNITY
        	[SerializeField]
        	[SerializeReference]
        	[InspectorName(@"Data")]
        #endif
        private dataUnion _data;

        /// <summary>
        /// reserved for future use
        /// </summary>
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

        public LedgerEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        [ProtoContract]
        public abstract partial class dataUnion
        {
            public abstract LedgerEntryType Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.Serializable]
            public sealed partial class Account : dataUnion
            {
                public override LedgerEntryType Discriminator => LedgerEntryType.ACCOUNT;
                public AccountEntry account
                {
                    get => _account;
                    set
                    {
                        _account = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Account")]
                #endif
                private AccountEntry _account;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class Trustline : dataUnion
            {
                public override LedgerEntryType Discriminator => LedgerEntryType.TRUSTLINE;
                public TrustLineEntry trustLine
                {
                    get => _trustLine;
                    set
                    {
                        _trustLine = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Trust Line")]
                #endif
                private TrustLineEntry _trustLine;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class Offer : dataUnion
            {
                public override LedgerEntryType Discriminator => LedgerEntryType.OFFER;
                public OfferEntry offer
                {
                    get => _offer;
                    set
                    {
                        _offer = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Offer")]
                #endif
                private OfferEntry _offer;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class Data : dataUnion
            {
                public override LedgerEntryType Discriminator => LedgerEntryType.DATA;
                public DataEntry data
                {
                    get => _data;
                    set
                    {
                        _data = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Data")]
                #endif
                private DataEntry _data;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class ClaimableBalance : dataUnion
            {
                public override LedgerEntryType Discriminator => LedgerEntryType.CLAIMABLE_BALANCE;
                public ClaimableBalanceEntry claimableBalance
                {
                    get => _claimableBalance;
                    set
                    {
                        _claimableBalance = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Claimable Balance")]
                #endif
                private ClaimableBalanceEntry _claimableBalance;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class LiquidityPool : dataUnion
            {
                public override LedgerEntryType Discriminator => LedgerEntryType.LIQUIDITY_POOL;
                public LiquidityPoolEntry liquidityPool
                {
                    get => _liquidityPool;
                    set
                    {
                        _liquidityPool = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Liquidity Pool")]
                #endif
                private LiquidityPoolEntry _liquidityPool;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class ContractData : dataUnion
            {
                public override LedgerEntryType Discriminator => LedgerEntryType.CONTRACT_DATA;
                public ContractDataEntry contractData
                {
                    get => _contractData;
                    set
                    {
                        _contractData = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Contract Data")]
                #endif
                private ContractDataEntry _contractData;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class ContractCode : dataUnion
            {
                public override LedgerEntryType Discriminator => LedgerEntryType.CONTRACT_CODE;
                public ContractCodeEntry contractCode
                {
                    get => _contractCode;
                    set
                    {
                        _contractCode = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Contract Code")]
                #endif
                private ContractCodeEntry _contractCode;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class ConfigSetting : dataUnion
            {
                public override LedgerEntryType Discriminator => LedgerEntryType.CONFIG_SETTING;
                public ConfigSettingEntry configSetting
                {
                    get => _configSetting;
                    set
                    {
                        _configSetting = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Config Setting")]
                #endif
                private ConfigSettingEntry _configSetting;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class Ttl : dataUnion
            {
                public override LedgerEntryType Discriminator => LedgerEntryType.TTL;
                public TTLEntry ttl
                {
                    get => _ttl;
                    set
                    {
                        _ttl = value;
                    }
                }
                #if UNITY
                	[SerializeField]
                	[SerializeReference]
                	[InspectorName(@"Ttl")]
                #endif
                private TTLEntry _ttl;

                public override void ValidateCase() {}
            }
        }
        public static partial class dataUnionXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(dataUnion value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    dataUnionXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            public static void Encode(XdrWriter stream, dataUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case dataUnion.Account case_ACCOUNT:
                    AccountEntryXdr.Encode(stream, case_ACCOUNT.account);
                    break;
                    case dataUnion.Trustline case_TRUSTLINE:
                    TrustLineEntryXdr.Encode(stream, case_TRUSTLINE.trustLine);
                    break;
                    case dataUnion.Offer case_OFFER:
                    OfferEntryXdr.Encode(stream, case_OFFER.offer);
                    break;
                    case dataUnion.Data case_DATA:
                    DataEntryXdr.Encode(stream, case_DATA.data);
                    break;
                    case dataUnion.ClaimableBalance case_CLAIMABLE_BALANCE:
                    ClaimableBalanceEntryXdr.Encode(stream, case_CLAIMABLE_BALANCE.claimableBalance);
                    break;
                    case dataUnion.LiquidityPool case_LIQUIDITY_POOL:
                    LiquidityPoolEntryXdr.Encode(stream, case_LIQUIDITY_POOL.liquidityPool);
                    break;
                    case dataUnion.ContractData case_CONTRACT_DATA:
                    ContractDataEntryXdr.Encode(stream, case_CONTRACT_DATA.contractData);
                    break;
                    case dataUnion.ContractCode case_CONTRACT_CODE:
                    ContractCodeEntryXdr.Encode(stream, case_CONTRACT_CODE.contractCode);
                    break;
                    case dataUnion.ConfigSetting case_CONFIG_SETTING:
                    ConfigSettingEntryXdr.Encode(stream, case_CONFIG_SETTING.configSetting);
                    break;
                    case dataUnion.Ttl case_TTL:
                    TTLEntryXdr.Encode(stream, case_TTL.ttl);
                    break;
                }
            }
            public static dataUnion Decode(XdrReader stream)
            {
                var discriminator = (LedgerEntryType)stream.ReadInt();
                switch (discriminator)
                {
                    case LedgerEntryType.ACCOUNT:
                    var result_ACCOUNT = new dataUnion.Account();
                    result_ACCOUNT.account = AccountEntryXdr.Decode(stream);
                    return result_ACCOUNT;
                    case LedgerEntryType.TRUSTLINE:
                    var result_TRUSTLINE = new dataUnion.Trustline();
                    result_TRUSTLINE.trustLine = TrustLineEntryXdr.Decode(stream);
                    return result_TRUSTLINE;
                    case LedgerEntryType.OFFER:
                    var result_OFFER = new dataUnion.Offer();
                    result_OFFER.offer = OfferEntryXdr.Decode(stream);
                    return result_OFFER;
                    case LedgerEntryType.DATA:
                    var result_DATA = new dataUnion.Data();
                    result_DATA.data = DataEntryXdr.Decode(stream);
                    return result_DATA;
                    case LedgerEntryType.CLAIMABLE_BALANCE:
                    var result_CLAIMABLE_BALANCE = new dataUnion.ClaimableBalance();
                    result_CLAIMABLE_BALANCE.claimableBalance = ClaimableBalanceEntryXdr.Decode(stream);
                    return result_CLAIMABLE_BALANCE;
                    case LedgerEntryType.LIQUIDITY_POOL:
                    var result_LIQUIDITY_POOL = new dataUnion.LiquidityPool();
                    result_LIQUIDITY_POOL.liquidityPool = LiquidityPoolEntryXdr.Decode(stream);
                    return result_LIQUIDITY_POOL;
                    case LedgerEntryType.CONTRACT_DATA:
                    var result_CONTRACT_DATA = new dataUnion.ContractData();
                    result_CONTRACT_DATA.contractData = ContractDataEntryXdr.Decode(stream);
                    return result_CONTRACT_DATA;
                    case LedgerEntryType.CONTRACT_CODE:
                    var result_CONTRACT_CODE = new dataUnion.ContractCode();
                    result_CONTRACT_CODE.contractCode = ContractCodeEntryXdr.Decode(stream);
                    return result_CONTRACT_CODE;
                    case LedgerEntryType.CONFIG_SETTING:
                    var result_CONFIG_SETTING = new dataUnion.ConfigSetting();
                    result_CONFIG_SETTING.configSetting = ConfigSettingEntryXdr.Decode(stream);
                    return result_CONFIG_SETTING;
                    case LedgerEntryType.TTL:
                    var result_TTL = new dataUnion.Ttl();
                    result_TTL.ttl = TTLEntryXdr.Decode(stream);
                    return result_TTL;
                    default:
                    throw new Exception($"Unknown discriminator for dataUnion: {discriminator}");
                }
            }
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        [System.Serializable]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();

            [System.Serializable]
            public sealed partial class case_0 : extUnion
            {
                public override int Discriminator => 0;

                public override void ValidateCase() {}
            }
            [System.Serializable]
            public sealed partial class case_1 : extUnion
            {
                public override int Discriminator => 1;
                public LedgerEntryExtensionV1 v1
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
                private LedgerEntryExtensionV1 _v1;

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
            public static void Encode(XdrWriter stream, extUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case extUnion.case_0 case_0:
                    break;
                    case extUnion.case_1 case_1:
                    LedgerEntryExtensionV1Xdr.Encode(stream, case_1.v1);
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
                    result_1.v1 = LedgerEntryExtensionV1Xdr.Decode(stream);
                    return result_1;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class LedgerEntryXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LedgerEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LedgerEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, LedgerEntry value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.lastModifiedLedgerSeq);
            LedgerEntry.dataUnionXdr.Encode(stream, value.data);
            LedgerEntry.extUnionXdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static LedgerEntry Decode(XdrReader stream)
        {
            var result = new LedgerEntry();
            result.lastModifiedLedgerSeq = uint32Xdr.Decode(stream);
            result.data = LedgerEntry.dataUnionXdr.Decode(stream);
            result.ext = LedgerEntry.extUnionXdr.Decode(stream);
            return result;
        }
    }
}
