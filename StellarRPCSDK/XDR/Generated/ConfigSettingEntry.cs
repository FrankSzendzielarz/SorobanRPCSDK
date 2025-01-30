// Generated code - do not modify
// Source:

// union ConfigSettingEntry switch (ConfigSettingID configSettingID)
// {
// case CONFIG_SETTING_CONTRACT_MAX_SIZE_BYTES:
//     uint32 contractMaxSizeBytes;
// case CONFIG_SETTING_CONTRACT_COMPUTE_V0:
//     ConfigSettingContractComputeV0 contractCompute;
// case CONFIG_SETTING_CONTRACT_LEDGER_COST_V0:
//     ConfigSettingContractLedgerCostV0 contractLedgerCost;
// case CONFIG_SETTING_CONTRACT_HISTORICAL_DATA_V0:
//     ConfigSettingContractHistoricalDataV0 contractHistoricalData;
// case CONFIG_SETTING_CONTRACT_EVENTS_V0:
//     ConfigSettingContractEventsV0 contractEvents;
// case CONFIG_SETTING_CONTRACT_BANDWIDTH_V0:
//     ConfigSettingContractBandwidthV0 contractBandwidth;
// case CONFIG_SETTING_CONTRACT_COST_PARAMS_CPU_INSTRUCTIONS:
//     ContractCostParams contractCostParamsCpuInsns;
// case CONFIG_SETTING_CONTRACT_COST_PARAMS_MEMORY_BYTES:
//     ContractCostParams contractCostParamsMemBytes;
// case CONFIG_SETTING_CONTRACT_DATA_KEY_SIZE_BYTES:
//     uint32 contractDataKeySizeBytes;
// case CONFIG_SETTING_CONTRACT_DATA_ENTRY_SIZE_BYTES:
//     uint32 contractDataEntrySizeBytes;
// case CONFIG_SETTING_STATE_ARCHIVAL:
//     StateArchivalSettings stateArchivalSettings;
// case CONFIG_SETTING_CONTRACT_EXECUTION_LANES:
//     ConfigSettingContractExecutionLanesV0 contractExecutionLanes;
// case CONFIG_SETTING_BUCKETLIST_SIZE_WINDOW:
//     uint64 bucketListSizeWindow<>;
// case CONFIG_SETTING_EVICTION_ITERATOR:
//     EvictionIterator evictionIterator;
// };


using System;

namespace Stellar.XDR {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    public abstract partial class ConfigSettingEntry
    {
        public abstract ConfigSettingID Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

    }
    public sealed partial class ConfigSettingEntry_CONFIG_SETTING_CONTRACT_MAX_SIZE_BYTES : ConfigSettingEntry
    {
        public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_MAX_SIZE_BYTES;
        private uint32 _contractMaxSizeBytes;
        public uint32 contractMaxSizeBytes
        {
            get => _contractMaxSizeBytes;
            set
            {
                _contractMaxSizeBytes = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class ConfigSettingEntry_CONFIG_SETTING_CONTRACT_COMPUTE_V0 : ConfigSettingEntry
    {
        public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_COMPUTE_V0;
        private ConfigSettingContractComputeV0 _contractCompute;
        public ConfigSettingContractComputeV0 contractCompute
        {
            get => _contractCompute;
            set
            {
                _contractCompute = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class ConfigSettingEntry_CONFIG_SETTING_CONTRACT_LEDGER_COST_V0 : ConfigSettingEntry
    {
        public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_LEDGER_COST_V0;
        private ConfigSettingContractLedgerCostV0 _contractLedgerCost;
        public ConfigSettingContractLedgerCostV0 contractLedgerCost
        {
            get => _contractLedgerCost;
            set
            {
                _contractLedgerCost = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class ConfigSettingEntry_CONFIG_SETTING_CONTRACT_HISTORICAL_DATA_V0 : ConfigSettingEntry
    {
        public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_HISTORICAL_DATA_V0;
        private ConfigSettingContractHistoricalDataV0 _contractHistoricalData;
        public ConfigSettingContractHistoricalDataV0 contractHistoricalData
        {
            get => _contractHistoricalData;
            set
            {
                _contractHistoricalData = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class ConfigSettingEntry_CONFIG_SETTING_CONTRACT_EVENTS_V0 : ConfigSettingEntry
    {
        public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_EVENTS_V0;
        private ConfigSettingContractEventsV0 _contractEvents;
        public ConfigSettingContractEventsV0 contractEvents
        {
            get => _contractEvents;
            set
            {
                _contractEvents = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class ConfigSettingEntry_CONFIG_SETTING_CONTRACT_BANDWIDTH_V0 : ConfigSettingEntry
    {
        public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_BANDWIDTH_V0;
        private ConfigSettingContractBandwidthV0 _contractBandwidth;
        public ConfigSettingContractBandwidthV0 contractBandwidth
        {
            get => _contractBandwidth;
            set
            {
                _contractBandwidth = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class ConfigSettingEntry_CONFIG_SETTING_CONTRACT_COST_PARAMS_CPU_INSTRUCTIONS : ConfigSettingEntry
    {
        public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_COST_PARAMS_CPU_INSTRUCTIONS;
        private ContractCostParams _contractCostParamsCpuInsns;
        public ContractCostParams contractCostParamsCpuInsns
        {
            get => _contractCostParamsCpuInsns;
            set
            {
                _contractCostParamsCpuInsns = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class ConfigSettingEntry_CONFIG_SETTING_CONTRACT_COST_PARAMS_MEMORY_BYTES : ConfigSettingEntry
    {
        public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_COST_PARAMS_MEMORY_BYTES;
        private ContractCostParams _contractCostParamsMemBytes;
        public ContractCostParams contractCostParamsMemBytes
        {
            get => _contractCostParamsMemBytes;
            set
            {
                _contractCostParamsMemBytes = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class ConfigSettingEntry_CONFIG_SETTING_CONTRACT_DATA_KEY_SIZE_BYTES : ConfigSettingEntry
    {
        public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_DATA_KEY_SIZE_BYTES;
        private uint32 _contractDataKeySizeBytes;
        public uint32 contractDataKeySizeBytes
        {
            get => _contractDataKeySizeBytes;
            set
            {
                _contractDataKeySizeBytes = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class ConfigSettingEntry_CONFIG_SETTING_CONTRACT_DATA_ENTRY_SIZE_BYTES : ConfigSettingEntry
    {
        public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_DATA_ENTRY_SIZE_BYTES;
        private uint32 _contractDataEntrySizeBytes;
        public uint32 contractDataEntrySizeBytes
        {
            get => _contractDataEntrySizeBytes;
            set
            {
                _contractDataEntrySizeBytes = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class ConfigSettingEntry_CONFIG_SETTING_STATE_ARCHIVAL : ConfigSettingEntry
    {
        public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_STATE_ARCHIVAL;
        private StateArchivalSettings _stateArchivalSettings;
        public StateArchivalSettings stateArchivalSettings
        {
            get => _stateArchivalSettings;
            set
            {
                _stateArchivalSettings = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class ConfigSettingEntry_CONFIG_SETTING_CONTRACT_EXECUTION_LANES : ConfigSettingEntry
    {
        public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_EXECUTION_LANES;
        private ConfigSettingContractExecutionLanesV0 _contractExecutionLanes;
        public ConfigSettingContractExecutionLanesV0 contractExecutionLanes
        {
            get => _contractExecutionLanes;
            set
            {
                _contractExecutionLanes = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class ConfigSettingEntry_CONFIG_SETTING_BUCKETLIST_SIZE_WINDOW : ConfigSettingEntry
    {
        public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_BUCKETLIST_SIZE_WINDOW;
        private uint64[] _bucketListSizeWindow;
        public uint64[] bucketListSizeWindow
        {
            get => _bucketListSizeWindow;
            set
            {
                _bucketListSizeWindow = value;
            }
        }

        public override void ValidateCase() {}
    }
    public sealed partial class ConfigSettingEntry_CONFIG_SETTING_EVICTION_ITERATOR : ConfigSettingEntry
    {
        public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_EVICTION_ITERATOR;
        private EvictionIterator _evictionIterator;
        public EvictionIterator evictionIterator
        {
            get => _evictionIterator;
            set
            {
                _evictionIterator = value;
            }
        }

        public override void ValidateCase() {}
    }
    public static partial class ConfigSettingEntryXdr
    {
        public static void Encode(XdrWriter stream, ConfigSettingEntry value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ConfigSettingEntry_CONFIG_SETTING_CONTRACT_MAX_SIZE_BYTES case_CONFIG_SETTING_CONTRACT_MAX_SIZE_BYTES:
                uint32Xdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_MAX_SIZE_BYTES.contractMaxSizeBytes);
                break;
                case ConfigSettingEntry_CONFIG_SETTING_CONTRACT_COMPUTE_V0 case_CONFIG_SETTING_CONTRACT_COMPUTE_V0:
                ConfigSettingContractComputeV0Xdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_COMPUTE_V0.contractCompute);
                break;
                case ConfigSettingEntry_CONFIG_SETTING_CONTRACT_LEDGER_COST_V0 case_CONFIG_SETTING_CONTRACT_LEDGER_COST_V0:
                ConfigSettingContractLedgerCostV0Xdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_LEDGER_COST_V0.contractLedgerCost);
                break;
                case ConfigSettingEntry_CONFIG_SETTING_CONTRACT_HISTORICAL_DATA_V0 case_CONFIG_SETTING_CONTRACT_HISTORICAL_DATA_V0:
                ConfigSettingContractHistoricalDataV0Xdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_HISTORICAL_DATA_V0.contractHistoricalData);
                break;
                case ConfigSettingEntry_CONFIG_SETTING_CONTRACT_EVENTS_V0 case_CONFIG_SETTING_CONTRACT_EVENTS_V0:
                ConfigSettingContractEventsV0Xdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_EVENTS_V0.contractEvents);
                break;
                case ConfigSettingEntry_CONFIG_SETTING_CONTRACT_BANDWIDTH_V0 case_CONFIG_SETTING_CONTRACT_BANDWIDTH_V0:
                ConfigSettingContractBandwidthV0Xdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_BANDWIDTH_V0.contractBandwidth);
                break;
                case ConfigSettingEntry_CONFIG_SETTING_CONTRACT_COST_PARAMS_CPU_INSTRUCTIONS case_CONFIG_SETTING_CONTRACT_COST_PARAMS_CPU_INSTRUCTIONS:
                ContractCostParamsXdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_COST_PARAMS_CPU_INSTRUCTIONS.contractCostParamsCpuInsns);
                break;
                case ConfigSettingEntry_CONFIG_SETTING_CONTRACT_COST_PARAMS_MEMORY_BYTES case_CONFIG_SETTING_CONTRACT_COST_PARAMS_MEMORY_BYTES:
                ContractCostParamsXdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_COST_PARAMS_MEMORY_BYTES.contractCostParamsMemBytes);
                break;
                case ConfigSettingEntry_CONFIG_SETTING_CONTRACT_DATA_KEY_SIZE_BYTES case_CONFIG_SETTING_CONTRACT_DATA_KEY_SIZE_BYTES:
                uint32Xdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_DATA_KEY_SIZE_BYTES.contractDataKeySizeBytes);
                break;
                case ConfigSettingEntry_CONFIG_SETTING_CONTRACT_DATA_ENTRY_SIZE_BYTES case_CONFIG_SETTING_CONTRACT_DATA_ENTRY_SIZE_BYTES:
                uint32Xdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_DATA_ENTRY_SIZE_BYTES.contractDataEntrySizeBytes);
                break;
                case ConfigSettingEntry_CONFIG_SETTING_STATE_ARCHIVAL case_CONFIG_SETTING_STATE_ARCHIVAL:
                StateArchivalSettingsXdr.Encode(stream, case_CONFIG_SETTING_STATE_ARCHIVAL.stateArchivalSettings);
                break;
                case ConfigSettingEntry_CONFIG_SETTING_CONTRACT_EXECUTION_LANES case_CONFIG_SETTING_CONTRACT_EXECUTION_LANES:
                ConfigSettingContractExecutionLanesV0Xdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_EXECUTION_LANES.contractExecutionLanes);
                break;
                case ConfigSettingEntry_CONFIG_SETTING_BUCKETLIST_SIZE_WINDOW case_CONFIG_SETTING_BUCKETLIST_SIZE_WINDOW:
                stream.WriteInt(case_CONFIG_SETTING_BUCKETLIST_SIZE_WINDOW.bucketListSizeWindow.Length);
                foreach (var item in case_CONFIG_SETTING_BUCKETLIST_SIZE_WINDOW.bucketListSizeWindow)
                {
                        uint64Xdr.Encode(stream, item);
                }
                break;
                case ConfigSettingEntry_CONFIG_SETTING_EVICTION_ITERATOR case_CONFIG_SETTING_EVICTION_ITERATOR:
                EvictionIteratorXdr.Encode(stream, case_CONFIG_SETTING_EVICTION_ITERATOR.evictionIterator);
                break;
            }
        }
        public static ConfigSettingEntry Decode(XdrReader stream)
        {
            var discriminator = (ConfigSettingID)stream.ReadInt();
            switch (discriminator)
            {
                case ConfigSettingID.CONFIG_SETTING_CONTRACT_MAX_SIZE_BYTES:
                var result_CONFIG_SETTING_CONTRACT_MAX_SIZE_BYTES = new ConfigSettingEntry_CONFIG_SETTING_CONTRACT_MAX_SIZE_BYTES();
                result_CONFIG_SETTING_CONTRACT_MAX_SIZE_BYTES.contractMaxSizeBytes = uint32Xdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_MAX_SIZE_BYTES;
                case ConfigSettingID.CONFIG_SETTING_CONTRACT_COMPUTE_V0:
                var result_CONFIG_SETTING_CONTRACT_COMPUTE_V0 = new ConfigSettingEntry_CONFIG_SETTING_CONTRACT_COMPUTE_V0();
                result_CONFIG_SETTING_CONTRACT_COMPUTE_V0.contractCompute = ConfigSettingContractComputeV0Xdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_COMPUTE_V0;
                case ConfigSettingID.CONFIG_SETTING_CONTRACT_LEDGER_COST_V0:
                var result_CONFIG_SETTING_CONTRACT_LEDGER_COST_V0 = new ConfigSettingEntry_CONFIG_SETTING_CONTRACT_LEDGER_COST_V0();
                result_CONFIG_SETTING_CONTRACT_LEDGER_COST_V0.contractLedgerCost = ConfigSettingContractLedgerCostV0Xdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_LEDGER_COST_V0;
                case ConfigSettingID.CONFIG_SETTING_CONTRACT_HISTORICAL_DATA_V0:
                var result_CONFIG_SETTING_CONTRACT_HISTORICAL_DATA_V0 = new ConfigSettingEntry_CONFIG_SETTING_CONTRACT_HISTORICAL_DATA_V0();
                result_CONFIG_SETTING_CONTRACT_HISTORICAL_DATA_V0.contractHistoricalData = ConfigSettingContractHistoricalDataV0Xdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_HISTORICAL_DATA_V0;
                case ConfigSettingID.CONFIG_SETTING_CONTRACT_EVENTS_V0:
                var result_CONFIG_SETTING_CONTRACT_EVENTS_V0 = new ConfigSettingEntry_CONFIG_SETTING_CONTRACT_EVENTS_V0();
                result_CONFIG_SETTING_CONTRACT_EVENTS_V0.contractEvents = ConfigSettingContractEventsV0Xdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_EVENTS_V0;
                case ConfigSettingID.CONFIG_SETTING_CONTRACT_BANDWIDTH_V0:
                var result_CONFIG_SETTING_CONTRACT_BANDWIDTH_V0 = new ConfigSettingEntry_CONFIG_SETTING_CONTRACT_BANDWIDTH_V0();
                result_CONFIG_SETTING_CONTRACT_BANDWIDTH_V0.contractBandwidth = ConfigSettingContractBandwidthV0Xdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_BANDWIDTH_V0;
                case ConfigSettingID.CONFIG_SETTING_CONTRACT_COST_PARAMS_CPU_INSTRUCTIONS:
                var result_CONFIG_SETTING_CONTRACT_COST_PARAMS_CPU_INSTRUCTIONS = new ConfigSettingEntry_CONFIG_SETTING_CONTRACT_COST_PARAMS_CPU_INSTRUCTIONS();
                result_CONFIG_SETTING_CONTRACT_COST_PARAMS_CPU_INSTRUCTIONS.contractCostParamsCpuInsns = ContractCostParamsXdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_COST_PARAMS_CPU_INSTRUCTIONS;
                case ConfigSettingID.CONFIG_SETTING_CONTRACT_COST_PARAMS_MEMORY_BYTES:
                var result_CONFIG_SETTING_CONTRACT_COST_PARAMS_MEMORY_BYTES = new ConfigSettingEntry_CONFIG_SETTING_CONTRACT_COST_PARAMS_MEMORY_BYTES();
                result_CONFIG_SETTING_CONTRACT_COST_PARAMS_MEMORY_BYTES.contractCostParamsMemBytes = ContractCostParamsXdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_COST_PARAMS_MEMORY_BYTES;
                case ConfigSettingID.CONFIG_SETTING_CONTRACT_DATA_KEY_SIZE_BYTES:
                var result_CONFIG_SETTING_CONTRACT_DATA_KEY_SIZE_BYTES = new ConfigSettingEntry_CONFIG_SETTING_CONTRACT_DATA_KEY_SIZE_BYTES();
                result_CONFIG_SETTING_CONTRACT_DATA_KEY_SIZE_BYTES.contractDataKeySizeBytes = uint32Xdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_DATA_KEY_SIZE_BYTES;
                case ConfigSettingID.CONFIG_SETTING_CONTRACT_DATA_ENTRY_SIZE_BYTES:
                var result_CONFIG_SETTING_CONTRACT_DATA_ENTRY_SIZE_BYTES = new ConfigSettingEntry_CONFIG_SETTING_CONTRACT_DATA_ENTRY_SIZE_BYTES();
                result_CONFIG_SETTING_CONTRACT_DATA_ENTRY_SIZE_BYTES.contractDataEntrySizeBytes = uint32Xdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_DATA_ENTRY_SIZE_BYTES;
                case ConfigSettingID.CONFIG_SETTING_STATE_ARCHIVAL:
                var result_CONFIG_SETTING_STATE_ARCHIVAL = new ConfigSettingEntry_CONFIG_SETTING_STATE_ARCHIVAL();
                result_CONFIG_SETTING_STATE_ARCHIVAL.stateArchivalSettings = StateArchivalSettingsXdr.Decode(stream);
                return result_CONFIG_SETTING_STATE_ARCHIVAL;
                case ConfigSettingID.CONFIG_SETTING_CONTRACT_EXECUTION_LANES:
                var result_CONFIG_SETTING_CONTRACT_EXECUTION_LANES = new ConfigSettingEntry_CONFIG_SETTING_CONTRACT_EXECUTION_LANES();
                result_CONFIG_SETTING_CONTRACT_EXECUTION_LANES.contractExecutionLanes = ConfigSettingContractExecutionLanesV0Xdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_EXECUTION_LANES;
                case ConfigSettingID.CONFIG_SETTING_BUCKETLIST_SIZE_WINDOW:
                var result_CONFIG_SETTING_BUCKETLIST_SIZE_WINDOW = new ConfigSettingEntry_CONFIG_SETTING_BUCKETLIST_SIZE_WINDOW();
                {
                    var length = stream.ReadInt();
                    result_CONFIG_SETTING_BUCKETLIST_SIZE_WINDOW.bucketListSizeWindow = new uint64[length];
                    for (var i = 0; i < length; i++)
                    {
                        result_CONFIG_SETTING_BUCKETLIST_SIZE_WINDOW.bucketListSizeWindow[i] = uint64Xdr.Decode(stream);
                    }
                }
                return result_CONFIG_SETTING_BUCKETLIST_SIZE_WINDOW;
                case ConfigSettingID.CONFIG_SETTING_EVICTION_ITERATOR:
                var result_CONFIG_SETTING_EVICTION_ITERATOR = new ConfigSettingEntry_CONFIG_SETTING_EVICTION_ITERATOR();
                result_CONFIG_SETTING_EVICTION_ITERATOR.evictionIterator = EvictionIteratorXdr.Decode(stream);
                return result_CONFIG_SETTING_EVICTION_ITERATOR;
                default:
                throw new Exception($"Unknown discriminator for ConfigSettingEntry: {discriminator}");
            }
        }
    }
}
