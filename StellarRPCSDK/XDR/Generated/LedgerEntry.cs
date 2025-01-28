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

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public partial class LedgerEntry
    {
        private uint32 _lastModifiedLedgerSeq;
        public uint32 lastModifiedLedgerSeq
        {
            get => _lastModifiedLedgerSeq;
            set
            {
                _lastModifiedLedgerSeq = value;
            }
        }

        private object _data;
        public object data
        {
            get => _data;
            set
            {
                _data = value;
            }
        }

        private object _ext;
        public object ext
        {
            get => _ext;
            set
            {
                _ext = value;
            }
        }

        public LedgerEntry()
        {
        }
        /// <summary>Validates all fields have valid values</summary>
        public virtual void Validate()
        {
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class dataUnion
        {
            public abstract LedgerEntryType Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();
        }
        public sealed partial class dataUnion_ACCOUNT : dataUnion
        {
            public override LedgerEntryType Discriminator => LedgerEntryType.ACCOUNT;
            private AccountEntry _account;
            public AccountEntry account
            {
                get => _account;
                set
                {
                    _account = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class dataUnion_TRUSTLINE : dataUnion
        {
            public override LedgerEntryType Discriminator => LedgerEntryType.TRUSTLINE;
            private TrustLineEntry _trustLine;
            public TrustLineEntry trustLine
            {
                get => _trustLine;
                set
                {
                    _trustLine = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class dataUnion_OFFER : dataUnion
        {
            public override LedgerEntryType Discriminator => LedgerEntryType.OFFER;
            private OfferEntry _offer;
            public OfferEntry offer
            {
                get => _offer;
                set
                {
                    _offer = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class dataUnion_DATA : dataUnion
        {
            public override LedgerEntryType Discriminator => LedgerEntryType.DATA;
            private DataEntry _data;
            public DataEntry data
            {
                get => _data;
                set
                {
                    _data = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class dataUnion_CLAIMABLE_BALANCE : dataUnion
        {
            public override LedgerEntryType Discriminator => LedgerEntryType.CLAIMABLE_BALANCE;
            private ClaimableBalanceEntry _claimableBalance;
            public ClaimableBalanceEntry claimableBalance
            {
                get => _claimableBalance;
                set
                {
                    _claimableBalance = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class dataUnion_LIQUIDITY_POOL : dataUnion
        {
            public override LedgerEntryType Discriminator => LedgerEntryType.LIQUIDITY_POOL;
            private LiquidityPoolEntry _liquidityPool;
            public LiquidityPoolEntry liquidityPool
            {
                get => _liquidityPool;
                set
                {
                    _liquidityPool = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class dataUnion_CONTRACT_DATA : dataUnion
        {
            public override LedgerEntryType Discriminator => LedgerEntryType.CONTRACT_DATA;
            private ContractDataEntry _contractData;
            public ContractDataEntry contractData
            {
                get => _contractData;
                set
                {
                    _contractData = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class dataUnion_CONTRACT_CODE : dataUnion
        {
            public override LedgerEntryType Discriminator => LedgerEntryType.CONTRACT_CODE;
            private ContractCodeEntry _contractCode;
            public ContractCodeEntry contractCode
            {
                get => _contractCode;
                set
                {
                    _contractCode = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class dataUnion_CONFIG_SETTING : dataUnion
        {
            public override LedgerEntryType Discriminator => LedgerEntryType.CONFIG_SETTING;
            private ConfigSettingEntry _configSetting;
            public ConfigSettingEntry configSetting
            {
                get => _configSetting;
                set
                {
                    _configSetting = value;
                }
            }

            public override void ValidateCase() {}
        }
        public sealed partial class dataUnion_TTL : dataUnion
        {
            public override LedgerEntryType Discriminator => LedgerEntryType.TTL;
            private TTLEntry _ttl;
            public TTLEntry ttl
            {
                get => _ttl;
                set
                {
                    _ttl = value;
                }
            }

            public override void ValidateCase() {}
        }
        public static partial class dataUnionXdr
        {
            public static void Encode(XdrWriter stream, dataUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case dataUnion_ACCOUNT case_ACCOUNT:
                    AccountEntryXdr.Encode(stream, case_ACCOUNT.account);
                    break;
                    case dataUnion_TRUSTLINE case_TRUSTLINE:
                    TrustLineEntryXdr.Encode(stream, case_TRUSTLINE.trustLine);
                    break;
                    case dataUnion_OFFER case_OFFER:
                    OfferEntryXdr.Encode(stream, case_OFFER.offer);
                    break;
                    case dataUnion_DATA case_DATA:
                    DataEntryXdr.Encode(stream, case_DATA.data);
                    break;
                    case dataUnion_CLAIMABLE_BALANCE case_CLAIMABLE_BALANCE:
                    ClaimableBalanceEntryXdr.Encode(stream, case_CLAIMABLE_BALANCE.claimableBalance);
                    break;
                    case dataUnion_LIQUIDITY_POOL case_LIQUIDITY_POOL:
                    LiquidityPoolEntryXdr.Encode(stream, case_LIQUIDITY_POOL.liquidityPool);
                    break;
                    case dataUnion_CONTRACT_DATA case_CONTRACT_DATA:
                    ContractDataEntryXdr.Encode(stream, case_CONTRACT_DATA.contractData);
                    break;
                    case dataUnion_CONTRACT_CODE case_CONTRACT_CODE:
                    ContractCodeEntryXdr.Encode(stream, case_CONTRACT_CODE.contractCode);
                    break;
                    case dataUnion_CONFIG_SETTING case_CONFIG_SETTING:
                    ConfigSettingEntryXdr.Encode(stream, case_CONFIG_SETTING.configSetting);
                    break;
                    case dataUnion_TTL case_TTL:
                    TTLEntryXdr.Encode(stream, case_TTL.ttl);
                    break;
                }
            }
            public static dataUnion Decode(XdrReader stream)
            {
                var discriminator = (LedgerEntryType)stream.ReadInt();
                switch (discriminator)
                {
                    case ACCOUNT:
                    var result_ACCOUNT = new dataUnion_ACCOUNT();
                    result_ACCOUNT.                 = AccountEntryXdr.Decode(stream);
                    return result_ACCOUNT;
                    case TRUSTLINE:
                    var result_TRUSTLINE = new dataUnion_TRUSTLINE();
                    result_TRUSTLINE.                 = TrustLineEntryXdr.Decode(stream);
                    return result_TRUSTLINE;
                    case OFFER:
                    var result_OFFER = new dataUnion_OFFER();
                    result_OFFER.                 = OfferEntryXdr.Decode(stream);
                    return result_OFFER;
                    case DATA:
                    var result_DATA = new dataUnion_DATA();
                    result_DATA.                 = DataEntryXdr.Decode(stream);
                    return result_DATA;
                    case CLAIMABLE_BALANCE:
                    var result_CLAIMABLE_BALANCE = new dataUnion_CLAIMABLE_BALANCE();
                    result_CLAIMABLE_BALANCE.                 = ClaimableBalanceEntryXdr.Decode(stream);
                    return result_CLAIMABLE_BALANCE;
                    case LIQUIDITY_POOL:
                    var result_LIQUIDITY_POOL = new dataUnion_LIQUIDITY_POOL();
                    result_LIQUIDITY_POOL.                 = LiquidityPoolEntryXdr.Decode(stream);
                    return result_LIQUIDITY_POOL;
                    case CONTRACT_DATA:
                    var result_CONTRACT_DATA = new dataUnion_CONTRACT_DATA();
                    result_CONTRACT_DATA.                 = ContractDataEntryXdr.Decode(stream);
                    return result_CONTRACT_DATA;
                    case CONTRACT_CODE:
                    var result_CONTRACT_CODE = new dataUnion_CONTRACT_CODE();
                    result_CONTRACT_CODE.                 = ContractCodeEntryXdr.Decode(stream);
                    return result_CONTRACT_CODE;
                    case CONFIG_SETTING:
                    var result_CONFIG_SETTING = new dataUnion_CONFIG_SETTING();
                    result_CONFIG_SETTING.                 = ConfigSettingEntryXdr.Decode(stream);
                    return result_CONFIG_SETTING;
                    case TTL:
                    var result_TTL = new dataUnion_TTL();
                    result_TTL.                 = TTLEntryXdr.Decode(stream);
                    return result_TTL;
                    default:
                    throw new Exception($"Unknown discriminator for dataUnion: {discriminator}");
                }
            }
        }
        [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
        public abstract partial class extUnion
        {
            public abstract int Discriminator { get; }

            /// <summary>Validates the union case matches its discriminator</summary>
            public abstract void ValidateCase();
        }
        public sealed partial class extUnion_0 : extUnion
        {
            public override int Discriminator => int.0;

            public override void ValidateCase() {}
        }
        public sealed partial class extUnion_1 : extUnion
        {
            public override int Discriminator => int.1;
            private LedgerEntryExtensionV1 _v1;
            public LedgerEntryExtensionV1 v1
            {
                get => _v1;
                set
                {
                    _v1 = value;
                }
            }

            public override void ValidateCase() {}
        }
        public static partial class extUnionXdr
        {
            public static void Encode(XdrWriter stream, extUnion value)
            {
                value.ValidateCase();
                stream.WriteInt((int)value.Discriminator);
                switch (value)
                {
                    case extUnion_0 case_0:
                    break;
                    case extUnion_1 case_1:
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
                    var result_0 = new extUnion_0();
                    return result_0;
                    case 1:
                    var result_1 = new extUnion_1();
                    result_1.                 = LedgerEntryExtensionV1Xdr.Decode(stream);
                    return result_1;
                    default:
                    throw new Exception($"Unknown discriminator for extUnion: {discriminator}");
                }
            }
        }
    }
    public static partial class LedgerEntryXdr
    {
        /// <summary>Encodes struct to XDR stream</summary>
        public static void Encode(XdrWriter stream, LedgerEntry value)
        {
            value.Validate();
            uint32Xdr.Encode(stream, value.lastModifiedLedgerSeq);
            Xdr.Encode(stream, value.data);
            Xdr.Encode(stream, value.ext);
        }
        /// <summary>Decodes struct from XDR stream</summary>
        public static LedgerEntry Decode(XdrReader stream)
        {
            var result = new LedgerEntry();
            result.lastModifiedLedgerSeq = uint32Xdr.Decode(stream);
            result.data = Xdr.Decode(stream);
            result.ext = Xdr.Decode(stream);
            return result;
        }
    }
}
