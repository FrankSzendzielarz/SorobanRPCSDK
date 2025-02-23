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
using ProtoBuf;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    [ProtoContract]
    [ProtoInclude(100, typeof(LedgerUpgradeVersion), DataFormat = DataFormat.Default)]
    [ProtoInclude(101, typeof(LedgerUpgradeBaseFee), DataFormat = DataFormat.Default)]
    [ProtoInclude(102, typeof(LedgerUpgradeMaxTxSetSize), DataFormat = DataFormat.Default)]
    [ProtoInclude(103, typeof(LedgerUpgradeBaseReserve), DataFormat = DataFormat.Default)]
    [ProtoInclude(104, typeof(LedgerUpgradeFlags), DataFormat = DataFormat.Default)]
    [ProtoInclude(105, typeof(LedgerUpgradeConfig), DataFormat = DataFormat.Default)]
    [ProtoInclude(106, typeof(LedgerUpgradeMaxSorobanTxSetSize), DataFormat = DataFormat.Default)]
    public abstract partial class LedgerUpgrade
    {
        public abstract LedgerUpgradeType Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        [ProtoContract(Name = "LedgerUpgrade.LedgerUpgradeVersion")]
        public sealed partial class LedgerUpgradeVersion : LedgerUpgrade
        {
            public override LedgerUpgradeType Discriminator => LedgerUpgradeType.LEDGER_UPGRADE_VERSION;
            [ProtoMember(1)]
            public uint32 newLedgerVersion
            {
                get => _newLedgerVersion;
                set
                {
                    _newLedgerVersion = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"New Ledger Version")]
            #endif
            private uint32 _newLedgerVersion;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// update ledgerVersion
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "LedgerUpgrade.LedgerUpgradeBaseFee")]
        public sealed partial class LedgerUpgradeBaseFee : LedgerUpgrade
        {
            public override LedgerUpgradeType Discriminator => LedgerUpgradeType.LEDGER_UPGRADE_BASE_FEE;
            [ProtoMember(2)]
            public uint32 newBaseFee
            {
                get => _newBaseFee;
                set
                {
                    _newBaseFee = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"New Base Fee")]
            #endif
            private uint32 _newBaseFee;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// update baseFee
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "LedgerUpgrade.LedgerUpgradeMaxTxSetSize")]
        public sealed partial class LedgerUpgradeMaxTxSetSize : LedgerUpgrade
        {
            public override LedgerUpgradeType Discriminator => LedgerUpgradeType.LEDGER_UPGRADE_MAX_TX_SET_SIZE;
            [ProtoMember(3)]
            public uint32 newMaxTxSetSize
            {
                get => _newMaxTxSetSize;
                set
                {
                    _newMaxTxSetSize = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"New Max Tx Set Size")]
            #endif
            private uint32 _newMaxTxSetSize;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// update maxTxSetSize
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "LedgerUpgrade.LedgerUpgradeBaseReserve")]
        public sealed partial class LedgerUpgradeBaseReserve : LedgerUpgrade
        {
            public override LedgerUpgradeType Discriminator => LedgerUpgradeType.LEDGER_UPGRADE_BASE_RESERVE;
            [ProtoMember(4)]
            public uint32 newBaseReserve
            {
                get => _newBaseReserve;
                set
                {
                    _newBaseReserve = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"New Base Reserve")]
            #endif
            private uint32 _newBaseReserve;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// update baseReserve
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "LedgerUpgrade.LedgerUpgradeFlags")]
        public sealed partial class LedgerUpgradeFlags : LedgerUpgrade
        {
            public override LedgerUpgradeType Discriminator => LedgerUpgradeType.LEDGER_UPGRADE_FLAGS;
            [ProtoMember(5)]
            public uint32 newFlags
            {
                get => _newFlags;
                set
                {
                    _newFlags = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"New Flags")]
            #endif
            private uint32 _newFlags;

            public override void ValidateCase() {}
        }
        /// <summary>
        /// update flags
        /// </summary>
        [System.Serializable]
        [ProtoContract(Name = "LedgerUpgrade.LedgerUpgradeConfig")]
        public sealed partial class LedgerUpgradeConfig : LedgerUpgrade
        {
            public override LedgerUpgradeType Discriminator => LedgerUpgradeType.LEDGER_UPGRADE_CONFIG;
            [ProtoMember(6)]
            public ConfigUpgradeSetKey newConfig
            {
                get => _newConfig;
                set
                {
                    _newConfig = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"New Config")]
            #endif
            private ConfigUpgradeSetKey _newConfig;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        [ProtoContract(Name = "LedgerUpgrade.LedgerUpgradeMaxSorobanTxSetSize")]
        public sealed partial class LedgerUpgradeMaxSorobanTxSetSize : LedgerUpgrade
        {
            public override LedgerUpgradeType Discriminator => LedgerUpgradeType.LEDGER_UPGRADE_MAX_SOROBAN_TX_SET_SIZE;
            [ProtoMember(7)]
            public uint32 newMaxSorobanTxSetSize
            {
                get => _newMaxSorobanTxSetSize;
                set
                {
                    _newMaxSorobanTxSetSize = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"New Max Soroban Tx Set Size")]
            #endif
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
        /// <summary>Decodes value from XDR base64 string</summary>
        public static LedgerUpgrade DecodeFromBase64(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            using (var memoryStream = new MemoryStream(bytes))
            {
                XdrReader reader = new XdrReader(memoryStream);
                return LedgerUpgradeXdr.Decode(reader);
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
