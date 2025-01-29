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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class LedgerKey
    {
        public abstract LedgerEntryType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public partial class accountStruct
        {
            private AccountID _accountID;
            public AccountID accountID
            {
                get => _accountID;
                set
                {
                    _accountID = value;
                }
            }

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
            private AccountID _accountID;
            public AccountID accountID
            {
                get => _accountID;
                set
                {
                    _accountID = value;
                }
            }

            private TrustLineAsset _asset;
            public TrustLineAsset asset
            {
                get => _asset;
                set
                {
                    _asset = value;
                }
            }

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
            private AccountID _sellerID;
            public AccountID sellerID
            {
                get => _sellerID;
                set
                {
                    _sellerID = value;
                }
            }

            private int64 _offerID;
            public int64 offerID
            {
                get => _offerID;
                set
                {
                    _offerID = value;
                }
            }

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
            private AccountID _accountID;
            public AccountID accountID
            {
                get => _accountID;
                set
                {
                    _accountID = value;
                }
            }

            private string _dataName;
            public string dataName
            {
                get => _dataName;
                set
                {
                    _dataName = value;
                }
            }

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
            /// <summary>Encodes struct to XDR stream</summary>
            public static void Encode(XdrWriter stream, dataStruct value)
            {
                value.Validate();
                AccountIDXdr.Encode(stream, value.accountID);
                stream.WriteString(value.dataName);
            }
            /// <summary>Decodes struct from XDR stream</summary>
            public static dataStruct Decode(XdrReader stream)
            {
                var result = new dataStruct();
                result.accountID = AccountIDXdr.Decode(stream);
                result.dataName = stream.ReadString();
                return result;
            }
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public partial class claimableBalanceStruct
        {
            private ClaimableBalanceID _balanceID;
            public ClaimableBalanceID balanceID
            {
                get => _balanceID;
                set
                {
                    _balanceID = value;
                }
            }

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
            private PoolID _liquidityPoolID;
            public PoolID liquidityPoolID
            {
                get => _liquidityPoolID;
                set
                {
                    _liquidityPoolID = value;
                }
            }

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
            private SCAddress _contract;
            public SCAddress contract
            {
                get => _contract;
                set
                {
                    _contract = value;
                }
            }

            private SCVal _key;
            public SCVal key
            {
                get => _key;
                set
                {
                    _key = value;
                }
            }

            private ContractDataDurability _durability;
            public ContractDataDurability durability
            {
                get => _durability;
                set
                {
                    _durability = value;
                }
            }

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
            private Hash _hash;
            public Hash hash
            {
                get => _hash;
                set
                {
                    _hash = value;
                }
            }

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
            private ConfigSettingID _configSettingID;
            public ConfigSettingID configSettingID
            {
                get => _configSettingID;
                set
                {
                    _configSettingID = value;
                }
            }

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
            private Hash _keyHash;
            public Hash keyHash
            {
                get => _keyHash;
                set
                {
                    _keyHash = value;
                }
            }

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
    }
    public sealed partial class LedgerKey_ACCOUNT : LedgerKey
    {
        public override LedgerEntryType Discriminator => LedgerEntryType.ACCOUNT;
        private accountStruct _account;
        public accountStruct account
        {
            get => _account;
            set
            {
                _account = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class LedgerKey_TRUSTLINE : LedgerKey
    {
        public override LedgerEntryType Discriminator => LedgerEntryType.TRUSTLINE;
        private trustLineStruct _trustLine;
        public trustLineStruct trustLine
        {
            get => _trustLine;
            set
            {
                _trustLine = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class LedgerKey_OFFER : LedgerKey
    {
        public override LedgerEntryType Discriminator => LedgerEntryType.OFFER;
        private offerStruct _offer;
        public offerStruct offer
        {
            get => _offer;
            set
            {
                _offer = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class LedgerKey_DATA : LedgerKey
    {
        public override LedgerEntryType Discriminator => LedgerEntryType.DATA;
        private dataStruct _data;
        public dataStruct data
        {
            get => _data;
            set
            {
                _data = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class LedgerKey_CLAIMABLE_BALANCE : LedgerKey
    {
        public override LedgerEntryType Discriminator => LedgerEntryType.CLAIMABLE_BALANCE;
        private claimableBalanceStruct _claimableBalance;
        public claimableBalanceStruct claimableBalance
        {
            get => _claimableBalance;
            set
            {
                _claimableBalance = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class LedgerKey_LIQUIDITY_POOL : LedgerKey
    {
        public override LedgerEntryType Discriminator => LedgerEntryType.LIQUIDITY_POOL;
        private liquidityPoolStruct _liquidityPool;
        public liquidityPoolStruct liquidityPool
        {
            get => _liquidityPool;
            set
            {
                _liquidityPool = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class LedgerKey_CONTRACT_DATA : LedgerKey
    {
        public override LedgerEntryType Discriminator => LedgerEntryType.CONTRACT_DATA;
        private contractDataStruct _contractData;
        public contractDataStruct contractData
        {
            get => _contractData;
            set
            {
                _contractData = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class LedgerKey_CONTRACT_CODE : LedgerKey
    {
        public override LedgerEntryType Discriminator => LedgerEntryType.CONTRACT_CODE;
        private contractCodeStruct _contractCode;
        public contractCodeStruct contractCode
        {
            get => _contractCode;
            set
            {
                _contractCode = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class LedgerKey_CONFIG_SETTING : LedgerKey
    {
        public override LedgerEntryType Discriminator => LedgerEntryType.CONFIG_SETTING;
        private configSettingStruct _configSetting;
        public configSettingStruct configSetting
        {
            get => _configSetting;
            set
            {
                _configSetting = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class LedgerKey_TTL : LedgerKey
    {
        public override LedgerEntryType Discriminator => LedgerEntryType.TTL;
        private ttlStruct _ttl;
        public ttlStruct ttl
        {
            get => _ttl;
            set
            {
                _ttl = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class LedgerKeyXdr
    {
        public static void Encode(XdrWriter stream, LedgerKey value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case LedgerKey_ACCOUNT case_ACCOUNT:
                LedgerKey.accountStructXdr.Encode(stream, case_ACCOUNT.account);
                break;
                case LedgerKey_TRUSTLINE case_TRUSTLINE:
                LedgerKey.trustLineStructXdr.Encode(stream, case_TRUSTLINE.trustLine);
                break;
                case LedgerKey_OFFER case_OFFER:
                LedgerKey.offerStructXdr.Encode(stream, case_OFFER.offer);
                break;
                case LedgerKey_DATA case_DATA:
                LedgerKey.dataStructXdr.Encode(stream, case_DATA.data);
                break;
                case LedgerKey_CLAIMABLE_BALANCE case_CLAIMABLE_BALANCE:
                LedgerKey.claimableBalanceStructXdr.Encode(stream, case_CLAIMABLE_BALANCE.claimableBalance);
                break;
                case LedgerKey_LIQUIDITY_POOL case_LIQUIDITY_POOL:
                LedgerKey.liquidityPoolStructXdr.Encode(stream, case_LIQUIDITY_POOL.liquidityPool);
                break;
                case LedgerKey_CONTRACT_DATA case_CONTRACT_DATA:
                LedgerKey.contractDataStructXdr.Encode(stream, case_CONTRACT_DATA.contractData);
                break;
                case LedgerKey_CONTRACT_CODE case_CONTRACT_CODE:
                LedgerKey.contractCodeStructXdr.Encode(stream, case_CONTRACT_CODE.contractCode);
                break;
                case LedgerKey_CONFIG_SETTING case_CONFIG_SETTING:
                LedgerKey.configSettingStructXdr.Encode(stream, case_CONFIG_SETTING.configSetting);
                break;
                case LedgerKey_TTL case_TTL:
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
                var result_ACCOUNT = new LedgerKey_ACCOUNT();
                result_ACCOUNT.account = LedgerKey.accountStructXdr.Decode(stream);
                return result_ACCOUNT;
                case LedgerEntryType.TRUSTLINE:
                var result_TRUSTLINE = new LedgerKey_TRUSTLINE();
                result_TRUSTLINE.trustLine = LedgerKey.trustLineStructXdr.Decode(stream);
                return result_TRUSTLINE;
                case LedgerEntryType.OFFER:
                var result_OFFER = new LedgerKey_OFFER();
                result_OFFER.offer = LedgerKey.offerStructXdr.Decode(stream);
                return result_OFFER;
                case LedgerEntryType.DATA:
                var result_DATA = new LedgerKey_DATA();
                result_DATA.data = LedgerKey.dataStructXdr.Decode(stream);
                return result_DATA;
                case LedgerEntryType.CLAIMABLE_BALANCE:
                var result_CLAIMABLE_BALANCE = new LedgerKey_CLAIMABLE_BALANCE();
                result_CLAIMABLE_BALANCE.claimableBalance = LedgerKey.claimableBalanceStructXdr.Decode(stream);
                return result_CLAIMABLE_BALANCE;
                case LedgerEntryType.LIQUIDITY_POOL:
                var result_LIQUIDITY_POOL = new LedgerKey_LIQUIDITY_POOL();
                result_LIQUIDITY_POOL.liquidityPool = LedgerKey.liquidityPoolStructXdr.Decode(stream);
                return result_LIQUIDITY_POOL;
                case LedgerEntryType.CONTRACT_DATA:
                var result_CONTRACT_DATA = new LedgerKey_CONTRACT_DATA();
                result_CONTRACT_DATA.contractData = LedgerKey.contractDataStructXdr.Decode(stream);
                return result_CONTRACT_DATA;
                case LedgerEntryType.CONTRACT_CODE:
                var result_CONTRACT_CODE = new LedgerKey_CONTRACT_CODE();
                result_CONTRACT_CODE.contractCode = LedgerKey.contractCodeStructXdr.Decode(stream);
                return result_CONTRACT_CODE;
                case LedgerEntryType.CONFIG_SETTING:
                var result_CONFIG_SETTING = new LedgerKey_CONFIG_SETTING();
                result_CONFIG_SETTING.configSetting = LedgerKey.configSettingStructXdr.Decode(stream);
                return result_CONFIG_SETTING;
                case LedgerEntryType.TTL:
                var result_TTL = new LedgerKey_TTL();
                result_TTL.ttl = LedgerKey.ttlStructXdr.Decode(stream);
                return result_TTL;
                default:
                throw new Exception($"Unknown discriminator for LedgerKey: {discriminator}");
            }
        }
    }
}
