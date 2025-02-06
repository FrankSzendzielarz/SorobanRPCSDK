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
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class LedgerUpgrade
    {
        public abstract LedgerUpgradeType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        public sealed partial class LedgerUpgradeVersion : LedgerUpgrade
        {
            public override LedgerUpgradeType Discriminator => LedgerUpgradeType.LEDGER_UPGRADE_VERSION;
            public uint32 newLedgerVersion
            {
                get => _newLedgerVersion;
                set
                {
                    _newLedgerVersion = value;
                }
            }
            private uint32 _newLedgerVersion;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// update ledgerVersion
        /// </summary>
        public sealed partial class LedgerUpgradeBaseFee : LedgerUpgrade
        {
            public override LedgerUpgradeType Discriminator => LedgerUpgradeType.LEDGER_UPGRADE_BASE_FEE;
            public uint32 newBaseFee
            {
                get => _newBaseFee;
                set
                {
                    _newBaseFee = value;
                }
            }
            private uint32 _newBaseFee;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// update baseFee
        /// </summary>
        public sealed partial class LedgerUpgradeMaxTxSetSize : LedgerUpgrade
        {
            public override LedgerUpgradeType Discriminator => LedgerUpgradeType.LEDGER_UPGRADE_MAX_TX_SET_SIZE;
            public uint32 newMaxTxSetSize
            {
                get => _newMaxTxSetSize;
                set
                {
                    _newMaxTxSetSize = value;
                }
            }
            private uint32 _newMaxTxSetSize;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// update maxTxSetSize
        /// </summary>
        public sealed partial class LedgerUpgradeBaseReserve : LedgerUpgrade
        {
            public override LedgerUpgradeType Discriminator => LedgerUpgradeType.LEDGER_UPGRADE_BASE_RESERVE;
            public uint32 newBaseReserve
            {
                get => _newBaseReserve;
                set
                {
                    _newBaseReserve = value;
                }
            }
            private uint32 _newBaseReserve;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// update baseReserve
        /// </summary>
        public sealed partial class LedgerUpgradeFlags : LedgerUpgrade
        {
            public override LedgerUpgradeType Discriminator => LedgerUpgradeType.LEDGER_UPGRADE_FLAGS;
            public uint32 newFlags
            {
                get => _newFlags;
                set
                {
                    _newFlags = value;
                }
            }
            private uint32 _newFlags;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// update flags
        /// </summary>
        public sealed partial class LedgerUpgradeConfig : LedgerUpgrade
        {
            public override LedgerUpgradeType Discriminator => LedgerUpgradeType.LEDGER_UPGRADE_CONFIG;
            public ConfigUpgradeSetKey newConfig
            {
                get => _newConfig;
                set
                {
                    _newConfig = value;
                }
            }
            private ConfigUpgradeSetKey _newConfig;

            public override void ValidateCase() {}
        }
        public sealed partial class LedgerUpgradeMaxSorobanTxSetSize : LedgerUpgrade
        {
            public override LedgerUpgradeType Discriminator => LedgerUpgradeType.LEDGER_UPGRADE_MAX_SOROBAN_TX_SET_SIZE;
            public uint32 newMaxSorobanTxSetSize
            {
                get => _newMaxSorobanTxSetSize;
                set
                {
                    _newMaxSorobanTxSetSize = value;
                }
            }
            private uint32 _newMaxSorobanTxSetSize;

            public override void ValidateCase() {}
        }
    }
    public static partial class LedgerUpgradeXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(LedgerUpgrade value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                LedgerUpgradeXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, LedgerUpgrade value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case LedgerUpgrade.LedgerUpgradeVersion case_LEDGER_UPGRADE_VERSION:
                uint32Xdr.Encode(stream, case_LEDGER_UPGRADE_VERSION.newLedgerVersion);
                break;
                case LedgerUpgrade.LedgerUpgradeBaseFee case_LEDGER_UPGRADE_BASE_FEE:
                uint32Xdr.Encode(stream, case_LEDGER_UPGRADE_BASE_FEE.newBaseFee);
                break;
                case LedgerUpgrade.LedgerUpgradeMaxTxSetSize case_LEDGER_UPGRADE_MAX_TX_SET_SIZE:
                uint32Xdr.Encode(stream, case_LEDGER_UPGRADE_MAX_TX_SET_SIZE.newMaxTxSetSize);
                break;
                case LedgerUpgrade.LedgerUpgradeBaseReserve case_LEDGER_UPGRADE_BASE_RESERVE:
                uint32Xdr.Encode(stream, case_LEDGER_UPGRADE_BASE_RESERVE.newBaseReserve);
                break;
                case LedgerUpgrade.LedgerUpgradeFlags case_LEDGER_UPGRADE_FLAGS:
                uint32Xdr.Encode(stream, case_LEDGER_UPGRADE_FLAGS.newFlags);
                break;
                case LedgerUpgrade.LedgerUpgradeConfig case_LEDGER_UPGRADE_CONFIG:
                ConfigUpgradeSetKeyXdr.Encode(stream, case_LEDGER_UPGRADE_CONFIG.newConfig);
                break;
                case LedgerUpgrade.LedgerUpgradeMaxSorobanTxSetSize case_LEDGER_UPGRADE_MAX_SOROBAN_TX_SET_SIZE:
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
                var result_LEDGER_UPGRADE_VERSION = new LedgerUpgrade.LedgerUpgradeVersion();
                result_LEDGER_UPGRADE_VERSION.newLedgerVersion = uint32Xdr.Decode(stream);
                return result_LEDGER_UPGRADE_VERSION;
                case LedgerUpgradeType.LEDGER_UPGRADE_BASE_FEE:
                var result_LEDGER_UPGRADE_BASE_FEE = new LedgerUpgrade.LedgerUpgradeBaseFee();
                result_LEDGER_UPGRADE_BASE_FEE.newBaseFee = uint32Xdr.Decode(stream);
                return result_LEDGER_UPGRADE_BASE_FEE;
                case LedgerUpgradeType.LEDGER_UPGRADE_MAX_TX_SET_SIZE:
                var result_LEDGER_UPGRADE_MAX_TX_SET_SIZE = new LedgerUpgrade.LedgerUpgradeMaxTxSetSize();
                result_LEDGER_UPGRADE_MAX_TX_SET_SIZE.newMaxTxSetSize = uint32Xdr.Decode(stream);
                return result_LEDGER_UPGRADE_MAX_TX_SET_SIZE;
                case LedgerUpgradeType.LEDGER_UPGRADE_BASE_RESERVE:
                var result_LEDGER_UPGRADE_BASE_RESERVE = new LedgerUpgrade.LedgerUpgradeBaseReserve();
                result_LEDGER_UPGRADE_BASE_RESERVE.newBaseReserve = uint32Xdr.Decode(stream);
                return result_LEDGER_UPGRADE_BASE_RESERVE;
                case LedgerUpgradeType.LEDGER_UPGRADE_FLAGS:
                var result_LEDGER_UPGRADE_FLAGS = new LedgerUpgrade.LedgerUpgradeFlags();
                result_LEDGER_UPGRADE_FLAGS.newFlags = uint32Xdr.Decode(stream);
                return result_LEDGER_UPGRADE_FLAGS;
                case LedgerUpgradeType.LEDGER_UPGRADE_CONFIG:
                var result_LEDGER_UPGRADE_CONFIG = new LedgerUpgrade.LedgerUpgradeConfig();
                result_LEDGER_UPGRADE_CONFIG.newConfig = ConfigUpgradeSetKeyXdr.Decode(stream);
                return result_LEDGER_UPGRADE_CONFIG;
                case LedgerUpgradeType.LEDGER_UPGRADE_MAX_SOROBAN_TX_SET_SIZE:
                var result_LEDGER_UPGRADE_MAX_SOROBAN_TX_SET_SIZE = new LedgerUpgrade.LedgerUpgradeMaxSorobanTxSetSize();
                result_LEDGER_UPGRADE_MAX_SOROBAN_TX_SET_SIZE.newMaxSorobanTxSetSize = uint32Xdr.Decode(stream);
                return result_LEDGER_UPGRADE_MAX_SOROBAN_TX_SET_SIZE;
                default:
                throw new Exception($"Unknown discriminator for LedgerUpgrade: {discriminator}");
            }
        }
    }
}
