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
    }
    public sealed partial class LedgerKey_ACCOUNT : LedgerKey
    {
        public override LedgerEntryType Discriminator => ACCOUNT;
        private object _account;
        public object account
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
        public override LedgerEntryType Discriminator => TRUSTLINE;
        private object _trustLine;
        public object trustLine
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
        public override LedgerEntryType Discriminator => OFFER;
        private object _offer;
        public object offer
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
        public override LedgerEntryType Discriminator => DATA;
        private object _data;
        public object data
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
        public override LedgerEntryType Discriminator => CLAIMABLE_BALANCE;
        private object _claimableBalance;
        public object claimableBalance
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
        public override LedgerEntryType Discriminator => LIQUIDITY_POOL;
        private object _liquidityPool;
        public object liquidityPool
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
        public override LedgerEntryType Discriminator => CONTRACT_DATA;
        private object _contractData;
        public object contractData
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
        public override LedgerEntryType Discriminator => CONTRACT_CODE;
        private object _contractCode;
        public object contractCode
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
        public override LedgerEntryType Discriminator => CONFIG_SETTING;
        private object _configSetting;
        public object configSetting
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
        public override LedgerEntryType Discriminator => TTL;
        private object _ttl;
        public object ttl
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
                Xdr.Encode(stream, case_ACCOUNT.account);
                break;
                case LedgerKey_TRUSTLINE case_TRUSTLINE:
                Xdr.Encode(stream, case_TRUSTLINE.trustLine);
                break;
                case LedgerKey_OFFER case_OFFER:
                Xdr.Encode(stream, case_OFFER.offer);
                break;
                case LedgerKey_DATA case_DATA:
                Xdr.Encode(stream, case_DATA.data);
                break;
                case LedgerKey_CLAIMABLE_BALANCE case_CLAIMABLE_BALANCE:
                Xdr.Encode(stream, case_CLAIMABLE_BALANCE.claimableBalance);
                break;
                case LedgerKey_LIQUIDITY_POOL case_LIQUIDITY_POOL:
                Xdr.Encode(stream, case_LIQUIDITY_POOL.liquidityPool);
                break;
                case LedgerKey_CONTRACT_DATA case_CONTRACT_DATA:
                Xdr.Encode(stream, case_CONTRACT_DATA.contractData);
                break;
                case LedgerKey_CONTRACT_CODE case_CONTRACT_CODE:
                Xdr.Encode(stream, case_CONTRACT_CODE.contractCode);
                break;
                case LedgerKey_CONFIG_SETTING case_CONFIG_SETTING:
                Xdr.Encode(stream, case_CONFIG_SETTING.configSetting);
                break;
                case LedgerKey_TTL case_TTL:
                Xdr.Encode(stream, case_TTL.ttl);
                break;
            }
        }
        public static LedgerKey Decode(XdrReader stream)
        {
            var discriminator = (LedgerEntryType)stream.ReadInt();
            switch (discriminator)
            {
                case ACCOUNT:
                var result_ACCOUNT = new LedgerKey_ACCOUNT();
                result_ACCOUNT.                 = Xdr.Decode(stream);
                return result_ACCOUNT;
                case TRUSTLINE:
                var result_TRUSTLINE = new LedgerKey_TRUSTLINE();
                result_TRUSTLINE.                 = Xdr.Decode(stream);
                return result_TRUSTLINE;
                case OFFER:
                var result_OFFER = new LedgerKey_OFFER();
                result_OFFER.                 = Xdr.Decode(stream);
                return result_OFFER;
                case DATA:
                var result_DATA = new LedgerKey_DATA();
                result_DATA.                 = Xdr.Decode(stream);
                return result_DATA;
                case CLAIMABLE_BALANCE:
                var result_CLAIMABLE_BALANCE = new LedgerKey_CLAIMABLE_BALANCE();
                result_CLAIMABLE_BALANCE.                 = Xdr.Decode(stream);
                return result_CLAIMABLE_BALANCE;
                case LIQUIDITY_POOL:
                var result_LIQUIDITY_POOL = new LedgerKey_LIQUIDITY_POOL();
                result_LIQUIDITY_POOL.                 = Xdr.Decode(stream);
                return result_LIQUIDITY_POOL;
                case CONTRACT_DATA:
                var result_CONTRACT_DATA = new LedgerKey_CONTRACT_DATA();
                result_CONTRACT_DATA.                 = Xdr.Decode(stream);
                return result_CONTRACT_DATA;
                case CONTRACT_CODE:
                var result_CONTRACT_CODE = new LedgerKey_CONTRACT_CODE();
                result_CONTRACT_CODE.                 = Xdr.Decode(stream);
                return result_CONTRACT_CODE;
                case CONFIG_SETTING:
                var result_CONFIG_SETTING = new LedgerKey_CONFIG_SETTING();
                result_CONFIG_SETTING.                 = Xdr.Decode(stream);
                return result_CONFIG_SETTING;
                case TTL:
                var result_TTL = new LedgerKey_TTL();
                result_TTL.                 = Xdr.Decode(stream);
                return result_TTL;
                default:
                throw new Exception($"Unknown discriminator for LedgerKey: {discriminator}");
            }
        }
    }
}
