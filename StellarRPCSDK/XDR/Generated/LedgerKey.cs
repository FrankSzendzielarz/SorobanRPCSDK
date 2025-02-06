// Generated code - do not modify
// Source:

// union LedgerKey switch (LedgerEntryType type)
// {
// case ACCOUNT:
//     struct
//     {
//         AccountID accountID;
//     } account;
// 
// case TRUSTLINE:
//     struct
//     {
//         AccountID accountID;
//         TrustLineAsset asset;
//     } trustLine;
// 
// case OFFER:
//     struct
//     {
//         AccountID sellerID;
//         int64 offerID;
//     } offer;
// 
// case DATA:
//     struct
//     {
//         AccountID accountID;
//         string64 dataName;
//     } data;
// 
// case CLAIMABLE_BALANCE:
//     struct
//     {
//         ClaimableBalanceID balanceID;
//     } claimableBalance;
// 
// case LIQUIDITY_POOL:
//     struct
//     {
//         PoolID liquidityPoolID;
//     } liquidityPool;
// case CONTRACT_DATA:
//     struct
//     {
//         SCAddress contract;
//         SCVal key;
//         ContractDataDurability durability;
//     } contractData;
// case CONTRACT_CODE:
//     struct
//     {
//         Hash hash;
//     } contractCode;
// case CONFIG_SETTING:
//     struct
//     {
//         ConfigSettingID configSettingID;
//     } configSetting;
// case TTL:
//     struct
//     {
//         // Hash of the LedgerKey that is associated with this TTLEntry
//         Hash keyHash;
//     } ttl;
// };


using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class LedgerKey
    {
        public abstract LedgerEntryType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public partial class accountStruct
        {
            public AccountID accountID
            {
                get => _accountID;
                set
                {
                    _accountID = value;
                }
            }
            private AccountID _accountID;

            public accountStruct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class accountStructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(accountStruct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    accountStructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, accountStruct value)
            {
                value.Validate();
                AccountIDXdr.Encode(stream, value.accountID);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static accountStruct Decode(XdrReader stream)
            {
                var result = new accountStruct();
                result.accountID = AccountIDXdr.Decode(stream);
                return result;
            }
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public partial class trustLineStruct
        {
            public AccountID accountID
            {
                get => _accountID;
                set
                {
                    _accountID = value;
                }
            }
            private AccountID _accountID;

            public TrustLineAsset asset
            {
                get => _asset;
                set
                {
                    _asset = value;
                }
            }
            private TrustLineAsset _asset;

            public trustLineStruct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class trustLineStructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(trustLineStruct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    trustLineStructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, trustLineStruct value)
            {
                value.Validate();
                AccountIDXdr.Encode(stream, value.accountID);
                TrustLineAssetXdr.Encode(stream, value.asset);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static trustLineStruct Decode(XdrReader stream)
            {
                var result = new trustLineStruct();
                result.accountID = AccountIDXdr.Decode(stream);
                result.asset = TrustLineAssetXdr.Decode(stream);
                return result;
            }
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public partial class offerStruct
        {
            public AccountID sellerID
            {
                get => _sellerID;
                set
                {
                    _sellerID = value;
                }
            }
            private AccountID _sellerID;

            public int64 offerID
            {
                get => _offerID;
                set
                {
                    _offerID = value;
                }
            }
            private int64 _offerID;

            public offerStruct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class offerStructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(offerStruct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    offerStructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, offerStruct value)
            {
                value.Validate();
                AccountIDXdr.Encode(stream, value.sellerID);
                int64Xdr.Encode(stream, value.offerID);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static offerStruct Decode(XdrReader stream)
            {
                var result = new offerStruct();
                result.sellerID = AccountIDXdr.Decode(stream);
                result.offerID = int64Xdr.Decode(stream);
                return result;
            }
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public partial class dataStruct
        {
            public AccountID accountID
            {
                get => _accountID;
                set
                {
                    _accountID = value;
                }
            }
            private AccountID _accountID;

            public string64 dataName
            {
                get => _dataName;
                set
                {
                    _dataName = value;
                }
            }
            private string64 _dataName;

            public dataStruct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class dataStructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(dataStruct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    dataStructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, dataStruct value)
            {
                value.Validate();
                AccountIDXdr.Encode(stream, value.accountID);
                string64Xdr.Encode(stream, value.dataName);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static dataStruct Decode(XdrReader stream)
            {
                var result = new dataStruct();
                result.accountID = AccountIDXdr.Decode(stream);
                result.dataName = string64Xdr.Decode(stream);
                return result;
            }
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public partial class claimableBalanceStruct
        {
            public ClaimableBalanceID balanceID
            {
                get => _balanceID;
                set
                {
                    _balanceID = value;
                }
            }
            private ClaimableBalanceID _balanceID;

            public claimableBalanceStruct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class claimableBalanceStructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(claimableBalanceStruct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    claimableBalanceStructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, claimableBalanceStruct value)
            {
                value.Validate();
                ClaimableBalanceIDXdr.Encode(stream, value.balanceID);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static claimableBalanceStruct Decode(XdrReader stream)
            {
                var result = new claimableBalanceStruct();
                result.balanceID = ClaimableBalanceIDXdr.Decode(stream);
                return result;
            }
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public partial class liquidityPoolStruct
        {
            public PoolID liquidityPoolID
            {
                get => _liquidityPoolID;
                set
                {
                    _liquidityPoolID = value;
                }
            }
            private PoolID _liquidityPoolID;

            public liquidityPoolStruct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class liquidityPoolStructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(liquidityPoolStruct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    liquidityPoolStructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, liquidityPoolStruct value)
            {
                value.Validate();
                PoolIDXdr.Encode(stream, value.liquidityPoolID);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static liquidityPoolStruct Decode(XdrReader stream)
            {
                var result = new liquidityPoolStruct();
                result.liquidityPoolID = PoolIDXdr.Decode(stream);
                return result;
            }
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public partial class contractDataStruct
        {
            public SCAddress contract
            {
                get => _contract;
                set
                {
                    _contract = value;
                }
            }
            private SCAddress _contract;

            public SCVal key
            {
                get => _key;
                set
                {
                    _key = value;
                }
            }
            private SCVal _key;

            public ContractDataDurability durability
            {
                get => _durability;
                set
                {
                    _durability = value;
                }
            }
            private ContractDataDurability _durability;

            public contractDataStruct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class contractDataStructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(contractDataStruct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    contractDataStructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, contractDataStruct value)
            {
                value.Validate();
                SCAddressXdr.Encode(stream, value.contract);
                SCValXdr.Encode(stream, value.key);
                ContractDataDurabilityXdr.Encode(stream, value.durability);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static contractDataStruct Decode(XdrReader stream)
            {
                var result = new contractDataStruct();
                result.contract = SCAddressXdr.Decode(stream);
                result.key = SCValXdr.Decode(stream);
                result.durability = ContractDataDurabilityXdr.Decode(stream);
                return result;
            }
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public partial class contractCodeStruct
        {
            public Hash hash
            {
                get => _hash;
                set
                {
                    _hash = value;
                }
            }
            private Hash _hash;

            public contractCodeStruct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class contractCodeStructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(contractCodeStruct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    contractCodeStructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, contractCodeStruct value)
            {
                value.Validate();
                HashXdr.Encode(stream, value.hash);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static contractCodeStruct Decode(XdrReader stream)
            {
                var result = new contractCodeStruct();
                result.hash = HashXdr.Decode(stream);
                return result;
            }
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public partial class configSettingStruct
        {
            public ConfigSettingID configSettingID
            {
                get => _configSettingID;
                set
                {
                    _configSettingID = value;
                }
            }
            private ConfigSettingID _configSettingID;

            public configSettingStruct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class configSettingStructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(configSettingStruct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    configSettingStructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, configSettingStruct value)
            {
                value.Validate();
                ConfigSettingIDXdr.Encode(stream, value.configSettingID);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static configSettingStruct Decode(XdrReader stream)
            {
                var result = new configSettingStruct();
                result.configSettingID = ConfigSettingIDXdr.Decode(stream);
                return result;
            }
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public partial class ttlStruct
        {
            /// <summary>
            /// Hash of the LedgerKey that is associated with this TTLEntry
            /// </summary>
            public Hash keyHash
            {
                get => _keyHash;
                set
                {
                    _keyHash = value;
                }
            }
            private Hash _keyHash;

            public ttlStruct()
            {
            }
            /// <summary>Validates all fields have valid values</summary>
            public virtual void Validate()
            {
            }
        }
        public static partial class ttlStructXdr
        {
            /// <summary>Encodes value to XDR base64 string</summary>
            public static string EncodeToBase64(ttlStruct value)
            {
                using (var memoryStream = new MemoryStream())
                {
                    XdrWriter writer = new XdrWriter(memoryStream);
                    ttlStructXdr.Encode(writer, value);
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, ttlStruct value)
            {
                value.Validate();
                HashXdr.Encode(stream, value.keyHash);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static ttlStruct Decode(XdrReader stream)
            {
                var result = new ttlStruct();
                result.keyHash = HashXdr.Decode(stream);
                return result;
            }
        }
        public sealed partial class Account : LedgerKey
        {
            public override LedgerEntryType Discriminator => LedgerEntryType.ACCOUNT;
            public accountStruct account
            {
                get => _account;
                set
                {
                    _account = value;
                }
            }
            private accountStruct _account;

            public override void ValidateCase() {}
        }
        public sealed partial class Trustline : LedgerKey
        {
            public override LedgerEntryType Discriminator => LedgerEntryType.TRUSTLINE;
            public trustLineStruct trustLine
            {
                get => _trustLine;
                set
                {
                    _trustLine = value;
                }
            }
            private trustLineStruct _trustLine;

            public override void ValidateCase() {}
        }
        public sealed partial class Offer : LedgerKey
        {
            public override LedgerEntryType Discriminator => LedgerEntryType.OFFER;
            public offerStruct offer
            {
                get => _offer;
                set
                {
                    _offer = value;
                }
            }
            private offerStruct _offer;

            public override void ValidateCase() {}
        }
        public sealed partial class Data : LedgerKey
        {
            public override LedgerEntryType Discriminator => LedgerEntryType.DATA;
            public dataStruct data
            {
                get => _data;
                set
                {
                    _data = value;
                }
            }
            private dataStruct _data;

            public override void ValidateCase() {}
        }
        public sealed partial class ClaimableBalance : LedgerKey
        {
            public override LedgerEntryType Discriminator => LedgerEntryType.CLAIMABLE_BALANCE;
            public claimableBalanceStruct claimableBalance
            {
                get => _claimableBalance;
                set
                {
                    _claimableBalance = value;
                }
            }
            private claimableBalanceStruct _claimableBalance;

            public override void ValidateCase() {}
        }
        public sealed partial class LiquidityPool : LedgerKey
        {
            public override LedgerEntryType Discriminator => LedgerEntryType.LIQUIDITY_POOL;
            public liquidityPoolStruct liquidityPool
            {
                get => _liquidityPool;
                set
                {
                    _liquidityPool = value;
                }
            }
            private liquidityPoolStruct _liquidityPool;

            public override void ValidateCase() {}
        }
        public sealed partial class ContractData : LedgerKey
        {
            public override LedgerEntryType Discriminator => LedgerEntryType.CONTRACT_DATA;
            public contractDataStruct contractData
            {
                get => _contractData;
                set
                {
                    _contractData = value;
                }
            }
            private contractDataStruct _contractData;

            public override void ValidateCase() {}
        }
        public sealed partial class ContractCode : LedgerKey
        {
            public override LedgerEntryType Discriminator => LedgerEntryType.CONTRACT_CODE;
            public contractCodeStruct contractCode
            {
                get => _contractCode;
                set
                {
                    _contractCode = value;
                }
            }
            private contractCodeStruct _contractCode;

            public override void ValidateCase() {}
        }
        public sealed partial class ConfigSetting : LedgerKey
        {
            public override LedgerEntryType Discriminator => LedgerEntryType.CONFIG_SETTING;
            public configSettingStruct configSetting
            {
                get => _configSetting;
                set
                {
                    _configSetting = value;
                }
            }
            private configSettingStruct _configSetting;

            public override void ValidateCase() {}
        }
        public sealed partial class Ttl : LedgerKey
        {
            public override LedgerEntryType Discriminator => LedgerEntryType.TTL;
            public ttlStruct ttl
            {
                get => _ttl;
                set
                {
                    _ttl = value;
                }
            }
            private ttlStruct _ttl;

            public override void ValidateCase() {}
        }
    }
    public static partial class LedgerKeyXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LedgerKey value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LedgerKeyXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, LedgerKey value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case LedgerKey.Account case_ACCOUNT:
                LedgerKey.accountStructXdr.Encode(stream, case_ACCOUNT.account);
                break;
                case LedgerKey.Trustline case_TRUSTLINE:
                LedgerKey.trustLineStructXdr.Encode(stream, case_TRUSTLINE.trustLine);
                break;
                case LedgerKey.Offer case_OFFER:
                LedgerKey.offerStructXdr.Encode(stream, case_OFFER.offer);
                break;
                case LedgerKey.Data case_DATA:
                LedgerKey.dataStructXdr.Encode(stream, case_DATA.data);
                break;
                case LedgerKey.ClaimableBalance case_CLAIMABLE_BALANCE:
                LedgerKey.claimableBalanceStructXdr.Encode(stream, case_CLAIMABLE_BALANCE.claimableBalance);
                break;
                case LedgerKey.LiquidityPool case_LIQUIDITY_POOL:
                LedgerKey.liquidityPoolStructXdr.Encode(stream, case_LIQUIDITY_POOL.liquidityPool);
                break;
                case LedgerKey.ContractData case_CONTRACT_DATA:
                LedgerKey.contractDataStructXdr.Encode(stream, case_CONTRACT_DATA.contractData);
                break;
                case LedgerKey.ContractCode case_CONTRACT_CODE:
                LedgerKey.contractCodeStructXdr.Encode(stream, case_CONTRACT_CODE.contractCode);
                break;
                case LedgerKey.ConfigSetting case_CONFIG_SETTING:
                LedgerKey.configSettingStructXdr.Encode(stream, case_CONFIG_SETTING.configSetting);
                break;
                case LedgerKey.Ttl case_TTL:
                LedgerKey.ttlStructXdr.Encode(stream, case_TTL.ttl);
                break;
            }
        }
        public static LedgerKey Decode(XdrReader stream)
        {
            var discriminator = (LedgerEntryType)stream.ReadInt();
            switch (discriminator)
            {
                case LedgerEntryType.ACCOUNT:
                var result_ACCOUNT = new LedgerKey.Account();
                result_ACCOUNT.account = LedgerKey.accountStructXdr.Decode(stream);
                return result_ACCOUNT;
                case LedgerEntryType.TRUSTLINE:
                var result_TRUSTLINE = new LedgerKey.Trustline();
                result_TRUSTLINE.trustLine = LedgerKey.trustLineStructXdr.Decode(stream);
                return result_TRUSTLINE;
                case LedgerEntryType.OFFER:
                var result_OFFER = new LedgerKey.Offer();
                result_OFFER.offer = LedgerKey.offerStructXdr.Decode(stream);
                return result_OFFER;
                case LedgerEntryType.DATA:
                var result_DATA = new LedgerKey.Data();
                result_DATA.data = LedgerKey.dataStructXdr.Decode(stream);
                return result_DATA;
                case LedgerEntryType.CLAIMABLE_BALANCE:
                var result_CLAIMABLE_BALANCE = new LedgerKey.ClaimableBalance();
                result_CLAIMABLE_BALANCE.claimableBalance = LedgerKey.claimableBalanceStructXdr.Decode(stream);
                return result_CLAIMABLE_BALANCE;
                case LedgerEntryType.LIQUIDITY_POOL:
                var result_LIQUIDITY_POOL = new LedgerKey.LiquidityPool();
                result_LIQUIDITY_POOL.liquidityPool = LedgerKey.liquidityPoolStructXdr.Decode(stream);
                return result_LIQUIDITY_POOL;
                case LedgerEntryType.CONTRACT_DATA:
                var result_CONTRACT_DATA = new LedgerKey.ContractData();
                result_CONTRACT_DATA.contractData = LedgerKey.contractDataStructXdr.Decode(stream);
                return result_CONTRACT_DATA;
                case LedgerEntryType.CONTRACT_CODE:
                var result_CONTRACT_CODE = new LedgerKey.ContractCode();
                result_CONTRACT_CODE.contractCode = LedgerKey.contractCodeStructXdr.Decode(stream);
                return result_CONTRACT_CODE;
                case LedgerEntryType.CONFIG_SETTING:
                var result_CONFIG_SETTING = new LedgerKey.ConfigSetting();
                result_CONFIG_SETTING.configSetting = LedgerKey.configSettingStructXdr.Decode(stream);
                return result_CONFIG_SETTING;
                case LedgerEntryType.TTL:
                var result_TTL = new LedgerKey.Ttl();
                result_TTL.ttl = LedgerKey.ttlStructXdr.Decode(stream);
                return result_TTL;
                default:
                throw new Exception($"Unknown discriminator for LedgerKey: {discriminator}");
            }
        }
    }
}
