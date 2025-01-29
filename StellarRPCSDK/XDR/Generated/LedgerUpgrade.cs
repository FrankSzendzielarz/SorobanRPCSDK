// Generated code - do not modify
// Source:

// union LedgerUpgrade switch (LedgerUpgradeType type)
// {
// case LEDGER_UPGRADE_VERSION:
//     uint32 newLedgerVersion; // update ledgerVersion
// case LEDGER_UPGRADE_BASE_FEE:
//     uint32 newBaseFee; // update baseFee
// case LEDGER_UPGRADE_MAX_TX_SET_SIZE:
//     uint32 newMaxTxSetSize; // update maxTxSetSize
// case LEDGER_UPGRADE_BASE_RESERVE:
//     uint32 newBaseReserve; // update baseReserve
// case LEDGER_UPGRADE_FLAGS:
//     uint32 newFlags; // update flags
// case LEDGER_UPGRADE_CONFIG:
//     // Update arbitrary `ConfigSetting` entries identified by the key.
//     ConfigUpgradeSetKey newConfig;
// case LEDGER_UPGRADE_MAX_SOROBAN_TX_SET_SIZE:
//     // Update ConfigSettingContractExecutionLanesV0.ledgerMaxTxCount without
//     // using `LEDGER_UPGRADE_CONFIG`.
//     uint32 newMaxSorobanTxSetSize;
// };


using System;

namespace stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class LedgerUpgrade
    {
        public abstract LedgerUpgradeType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class LedgerUpgrade_LEDGER_UPGRADE_VERSION : LedgerUpgrade
    {
        public override LedgerUpgradeType Discriminator => LedgerUpgradeType.LEDGER_UPGRADE_VERSION;
        private uint32 _newLedgerVersion;
        public uint32 newLedgerVersion
        {
            get => _newLedgerVersion;
            set
            {
                _newLedgerVersion = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class LedgerUpgrade_LEDGER_UPGRADE_BASE_FEE : LedgerUpgrade
    {
        public override LedgerUpgradeType Discriminator => LedgerUpgradeType.LEDGER_UPGRADE_BASE_FEE;
        private uint32 _newBaseFee;
        public uint32 newBaseFee
        {
            get => _newBaseFee;
            set
            {
                _newBaseFee = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class LedgerUpgrade_LEDGER_UPGRADE_MAX_TX_SET_SIZE : LedgerUpgrade
    {
        public override LedgerUpgradeType Discriminator => LedgerUpgradeType.LEDGER_UPGRADE_MAX_TX_SET_SIZE;
        private uint32 _newMaxTxSetSize;
        public uint32 newMaxTxSetSize
        {
            get => _newMaxTxSetSize;
            set
            {
                _newMaxTxSetSize = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class LedgerUpgrade_LEDGER_UPGRADE_BASE_RESERVE : LedgerUpgrade
    {
        public override LedgerUpgradeType Discriminator => LedgerUpgradeType.LEDGER_UPGRADE_BASE_RESERVE;
        private uint32 _newBaseReserve;
        public uint32 newBaseReserve
        {
            get => _newBaseReserve;
            set
            {
                _newBaseReserve = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class LedgerUpgrade_LEDGER_UPGRADE_FLAGS : LedgerUpgrade
    {
        public override LedgerUpgradeType Discriminator => LedgerUpgradeType.LEDGER_UPGRADE_FLAGS;
        private uint32 _newFlags;
        public uint32 newFlags
        {
            get => _newFlags;
            set
            {
                _newFlags = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class LedgerUpgrade_LEDGER_UPGRADE_CONFIG : LedgerUpgrade
    {
        public override LedgerUpgradeType Discriminator => LedgerUpgradeType.LEDGER_UPGRADE_CONFIG;
        private ConfigUpgradeSetKey _newConfig;
        public ConfigUpgradeSetKey newConfig
        {
            get => _newConfig;
            set
            {
                _newConfig = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class LedgerUpgrade_LEDGER_UPGRADE_MAX_SOROBAN_TX_SET_SIZE : LedgerUpgrade
    {
        public override LedgerUpgradeType Discriminator => LedgerUpgradeType.LEDGER_UPGRADE_MAX_SOROBAN_TX_SET_SIZE;
        private uint32 _newMaxSorobanTxSetSize;
        public uint32 newMaxSorobanTxSetSize
        {
            get => _newMaxSorobanTxSetSize;
            set
            {
                _newMaxSorobanTxSetSize = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class LedgerUpgradeXdr
    {
        public static void Encode(XdrWriter stream, LedgerUpgrade value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case LedgerUpgrade_LEDGER_UPGRADE_VERSION case_LEDGER_UPGRADE_VERSION:
                uint32Xdr.Encode(stream, case_LEDGER_UPGRADE_VERSION.newLedgerVersion);
                break;
                case LedgerUpgrade_LEDGER_UPGRADE_BASE_FEE case_LEDGER_UPGRADE_BASE_FEE:
                uint32Xdr.Encode(stream, case_LEDGER_UPGRADE_BASE_FEE.newBaseFee);
                break;
                case LedgerUpgrade_LEDGER_UPGRADE_MAX_TX_SET_SIZE case_LEDGER_UPGRADE_MAX_TX_SET_SIZE:
                uint32Xdr.Encode(stream, case_LEDGER_UPGRADE_MAX_TX_SET_SIZE.newMaxTxSetSize);
                break;
                case LedgerUpgrade_LEDGER_UPGRADE_BASE_RESERVE case_LEDGER_UPGRADE_BASE_RESERVE:
                uint32Xdr.Encode(stream, case_LEDGER_UPGRADE_BASE_RESERVE.newBaseReserve);
                break;
                case LedgerUpgrade_LEDGER_UPGRADE_FLAGS case_LEDGER_UPGRADE_FLAGS:
                uint32Xdr.Encode(stream, case_LEDGER_UPGRADE_FLAGS.newFlags);
                break;
                case LedgerUpgrade_LEDGER_UPGRADE_CONFIG case_LEDGER_UPGRADE_CONFIG:
                ConfigUpgradeSetKeyXdr.Encode(stream, case_LEDGER_UPGRADE_CONFIG.newConfig);
                break;
                case LedgerUpgrade_LEDGER_UPGRADE_MAX_SOROBAN_TX_SET_SIZE case_LEDGER_UPGRADE_MAX_SOROBAN_TX_SET_SIZE:
                uint32Xdr.Encode(stream, case_LEDGER_UPGRADE_MAX_SOROBAN_TX_SET_SIZE.newMaxSorobanTxSetSize);
                break;
            }
        }
        public static LedgerUpgrade Decode(XdrReader stream)
        {
            var discriminator = (LedgerUpgradeType)stream.ReadInt();
            switch (discriminator)
            {
                case LedgerUpgradeType.LEDGER_UPGRADE_VERSION:
                var result_LEDGER_UPGRADE_VERSION = new LedgerUpgrade_LEDGER_UPGRADE_VERSION();
                result_LEDGER_UPGRADE_VERSION.newLedgerVersion = uint32Xdr.Decode(stream);
                return result_LEDGER_UPGRADE_VERSION;
                case LedgerUpgradeType.LEDGER_UPGRADE_BASE_FEE:
                var result_LEDGER_UPGRADE_BASE_FEE = new LedgerUpgrade_LEDGER_UPGRADE_BASE_FEE();
                result_LEDGER_UPGRADE_BASE_FEE.newBaseFee = uint32Xdr.Decode(stream);
                return result_LEDGER_UPGRADE_BASE_FEE;
                case LedgerUpgradeType.LEDGER_UPGRADE_MAX_TX_SET_SIZE:
                var result_LEDGER_UPGRADE_MAX_TX_SET_SIZE = new LedgerUpgrade_LEDGER_UPGRADE_MAX_TX_SET_SIZE();
                result_LEDGER_UPGRADE_MAX_TX_SET_SIZE.newMaxTxSetSize = uint32Xdr.Decode(stream);
                return result_LEDGER_UPGRADE_MAX_TX_SET_SIZE;
                case LedgerUpgradeType.LEDGER_UPGRADE_BASE_RESERVE:
                var result_LEDGER_UPGRADE_BASE_RESERVE = new LedgerUpgrade_LEDGER_UPGRADE_BASE_RESERVE();
                result_LEDGER_UPGRADE_BASE_RESERVE.newBaseReserve = uint32Xdr.Decode(stream);
                return result_LEDGER_UPGRADE_BASE_RESERVE;
                case LedgerUpgradeType.LEDGER_UPGRADE_FLAGS:
                var result_LEDGER_UPGRADE_FLAGS = new LedgerUpgrade_LEDGER_UPGRADE_FLAGS();
                result_LEDGER_UPGRADE_FLAGS.newFlags = uint32Xdr.Decode(stream);
                return result_LEDGER_UPGRADE_FLAGS;
                case LedgerUpgradeType.LEDGER_UPGRADE_CONFIG:
                var result_LEDGER_UPGRADE_CONFIG = new LedgerUpgrade_LEDGER_UPGRADE_CONFIG();
                result_LEDGER_UPGRADE_CONFIG.newConfig = ConfigUpgradeSetKeyXdr.Decode(stream);
                return result_LEDGER_UPGRADE_CONFIG;
                case LedgerUpgradeType.LEDGER_UPGRADE_MAX_SOROBAN_TX_SET_SIZE:
                var result_LEDGER_UPGRADE_MAX_SOROBAN_TX_SET_SIZE = new LedgerUpgrade_LEDGER_UPGRADE_MAX_SOROBAN_TX_SET_SIZE();
                result_LEDGER_UPGRADE_MAX_SOROBAN_TX_SET_SIZE.newMaxSorobanTxSetSize = uint32Xdr.Decode(stream);
                return result_LEDGER_UPGRADE_MAX_SOROBAN_TX_SET_SIZE;
                default:
                throw new Exception($"Unknown discriminator for LedgerUpgrade: {discriminator}");
            }
        }
    }
}
