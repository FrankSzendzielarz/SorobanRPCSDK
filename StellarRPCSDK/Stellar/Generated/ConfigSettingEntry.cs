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
using System.IO;
using System.ComponentModel.DataAnnotations;
#if UNITY
	using UnityEngine;
#endif

namespace Stellar {

    [System.CodeDom.Compiler.GeneratedCode("XdrGenerator", "1.0")]
    [System.Serializable]
    public abstract partial class ConfigSettingEntry
    {
        public abstract ConfigSettingID Discriminator { get; }

        /// <summary>Validates the union case matches its discriminator</summary>
        public abstract void ValidateCase();

        [System.Serializable]
        public sealed partial class ConfigSettingContractMaxSizeBytes : ConfigSettingEntry
        {
            public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_MAX_SIZE_BYTES;
            public uint32 contractMaxSizeBytes
            {
                get => _contractMaxSizeBytes;
                set
                {
                    _contractMaxSizeBytes = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Contract Max Size Bytes")]
            #endif
            private uint32 _contractMaxSizeBytes;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ConfigSettingContractComputeV0Case : ConfigSettingEntry
        {
            public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_COMPUTE_V0;
            public ConfigSettingContractComputeV0 contractCompute
            {
                get => _contractCompute;
                set
                {
                    _contractCompute = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Contract Compute")]
            #endif
            private ConfigSettingContractComputeV0 _contractCompute;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ConfigSettingContractLedgerCostV0Case : ConfigSettingEntry
        {
            public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_LEDGER_COST_V0;
            public ConfigSettingContractLedgerCostV0 contractLedgerCost
            {
                get => _contractLedgerCost;
                set
                {
                    _contractLedgerCost = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Contract Ledger Cost")]
            #endif
            private ConfigSettingContractLedgerCostV0 _contractLedgerCost;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ConfigSettingContractHistoricalDataV0Case : ConfigSettingEntry
        {
            public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_HISTORICAL_DATA_V0;
            public ConfigSettingContractHistoricalDataV0 contractHistoricalData
            {
                get => _contractHistoricalData;
                set
                {
                    _contractHistoricalData = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Contract Historical Data")]
            #endif
            private ConfigSettingContractHistoricalDataV0 _contractHistoricalData;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ConfigSettingContractEventsV0Case : ConfigSettingEntry
        {
            public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_EVENTS_V0;
            public ConfigSettingContractEventsV0 contractEvents
            {
                get => _contractEvents;
                set
                {
                    _contractEvents = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Contract Events")]
            #endif
            private ConfigSettingContractEventsV0 _contractEvents;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ConfigSettingContractBandwidthV0Case : ConfigSettingEntry
        {
            public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_BANDWIDTH_V0;
            public ConfigSettingContractBandwidthV0 contractBandwidth
            {
                get => _contractBandwidth;
                set
                {
                    _contractBandwidth = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Contract Bandwidth")]
            #endif
            private ConfigSettingContractBandwidthV0 _contractBandwidth;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ConfigSettingContractCostParamsCpuInstructions : ConfigSettingEntry
        {
            public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_COST_PARAMS_CPU_INSTRUCTIONS;
            public ContractCostParams contractCostParamsCpuInsns
            {
                get => _contractCostParamsCpuInsns;
                set
                {
                    _contractCostParamsCpuInsns = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Contract Cost Params Cpu Insns")]
            #endif
            private ContractCostParams _contractCostParamsCpuInsns;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ConfigSettingContractCostParamsMemoryBytes : ConfigSettingEntry
        {
            public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_COST_PARAMS_MEMORY_BYTES;
            public ContractCostParams contractCostParamsMemBytes
            {
                get => _contractCostParamsMemBytes;
                set
                {
                    _contractCostParamsMemBytes = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Contract Cost Params Mem Bytes")]
            #endif
            private ContractCostParams _contractCostParamsMemBytes;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ConfigSettingContractDataKeySizeBytes : ConfigSettingEntry
        {
            public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_DATA_KEY_SIZE_BYTES;
            public uint32 contractDataKeySizeBytes
            {
                get => _contractDataKeySizeBytes;
                set
                {
                    _contractDataKeySizeBytes = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Contract Data Key Size Bytes")]
            #endif
            private uint32 _contractDataKeySizeBytes;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ConfigSettingContractDataEntrySizeBytes : ConfigSettingEntry
        {
            public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_DATA_ENTRY_SIZE_BYTES;
            public uint32 contractDataEntrySizeBytes
            {
                get => _contractDataEntrySizeBytes;
                set
                {
                    _contractDataEntrySizeBytes = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Contract Data Entry Size Bytes")]
            #endif
            private uint32 _contractDataEntrySizeBytes;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ConfigSettingStateArchival : ConfigSettingEntry
        {
            public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_STATE_ARCHIVAL;
            public StateArchivalSettings stateArchivalSettings
            {
                get => _stateArchivalSettings;
                set
                {
                    _stateArchivalSettings = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"State Archival Settings")]
            #endif
            private StateArchivalSettings _stateArchivalSettings;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ConfigSettingContractExecutionLanes : ConfigSettingEntry
        {
            public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_CONTRACT_EXECUTION_LANES;
            public ConfigSettingContractExecutionLanesV0 contractExecutionLanes
            {
                get => _contractExecutionLanes;
                set
                {
                    _contractExecutionLanes = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Contract Execution Lanes")]
            #endif
            private ConfigSettingContractExecutionLanesV0 _contractExecutionLanes;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ConfigSettingBucketlistSizeWindow : ConfigSettingEntry
        {
            public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_BUCKETLIST_SIZE_WINDOW;
            public uint64[] bucketListSizeWindow
            {
                get => _bucketListSizeWindow;
                set
                {
                    _bucketListSizeWindow = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Bucket List Size Window")]
            #endif
            private uint64[] _bucketListSizeWindow;

            public override void ValidateCase() {}
        }
        [System.Serializable]
        public sealed partial class ConfigSettingEvictionIterator : ConfigSettingEntry
        {
            public override ConfigSettingID Discriminator => ConfigSettingID.CONFIG_SETTING_EVICTION_ITERATOR;
            public EvictionIterator evictionIterator
            {
                get => _evictionIterator;
                set
                {
                    _evictionIterator = value;
                }
            }
            #if UNITY
            	[SerializeField]
            	[SerializeReference]
            	[InspectorName(@"Eviction Iterator")]
            #endif
            private EvictionIterator _evictionIterator;

            public override void ValidateCase() {}
        }
    }
    public static partial class ConfigSettingEntryXdr
    {
        /// <summary>Encodes value to XDR base64 string</summary>
        public static string EncodeToBase64(ConfigSettingEntry value)
        {
            using (var memoryStream = new MemoryStream())
            {
                XdrWriter writer = new XdrWriter(memoryStream);
                ConfigSettingEntryXdr.Encode(writer, value);
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static void Encode(XdrWriter stream, ConfigSettingEntry value)
        {
            value.ValidateCase();
            stream.WriteInt((int)value.Discriminator);
            switch (value)
            {
                case ConfigSettingEntry.ConfigSettingContractMaxSizeBytes case_CONFIG_SETTING_CONTRACT_MAX_SIZE_BYTES:
                uint32Xdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_MAX_SIZE_BYTES.contractMaxSizeBytes);
                break;
                case ConfigSettingEntry.ConfigSettingContractComputeV0Case case_CONFIG_SETTING_CONTRACT_COMPUTE_V0:
                ConfigSettingContractComputeV0Xdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_COMPUTE_V0.contractCompute);
                break;
                case ConfigSettingEntry.ConfigSettingContractLedgerCostV0Case case_CONFIG_SETTING_CONTRACT_LEDGER_COST_V0:
                ConfigSettingContractLedgerCostV0Xdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_LEDGER_COST_V0.contractLedgerCost);
                break;
                case ConfigSettingEntry.ConfigSettingContractHistoricalDataV0Case case_CONFIG_SETTING_CONTRACT_HISTORICAL_DATA_V0:
                ConfigSettingContractHistoricalDataV0Xdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_HISTORICAL_DATA_V0.contractHistoricalData);
                break;
                case ConfigSettingEntry.ConfigSettingContractEventsV0Case case_CONFIG_SETTING_CONTRACT_EVENTS_V0:
                ConfigSettingContractEventsV0Xdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_EVENTS_V0.contractEvents);
                break;
                case ConfigSettingEntry.ConfigSettingContractBandwidthV0Case case_CONFIG_SETTING_CONTRACT_BANDWIDTH_V0:
                ConfigSettingContractBandwidthV0Xdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_BANDWIDTH_V0.contractBandwidth);
                break;
                case ConfigSettingEntry.ConfigSettingContractCostParamsCpuInstructions case_CONFIG_SETTING_CONTRACT_COST_PARAMS_CPU_INSTRUCTIONS:
                ContractCostParamsXdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_COST_PARAMS_CPU_INSTRUCTIONS.contractCostParamsCpuInsns);
                break;
                case ConfigSettingEntry.ConfigSettingContractCostParamsMemoryBytes case_CONFIG_SETTING_CONTRACT_COST_PARAMS_MEMORY_BYTES:
                ContractCostParamsXdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_COST_PARAMS_MEMORY_BYTES.contractCostParamsMemBytes);
                break;
                case ConfigSettingEntry.ConfigSettingContractDataKeySizeBytes case_CONFIG_SETTING_CONTRACT_DATA_KEY_SIZE_BYTES:
                uint32Xdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_DATA_KEY_SIZE_BYTES.contractDataKeySizeBytes);
                break;
                case ConfigSettingEntry.ConfigSettingContractDataEntrySizeBytes case_CONFIG_SETTING_CONTRACT_DATA_ENTRY_SIZE_BYTES:
                uint32Xdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_DATA_ENTRY_SIZE_BYTES.contractDataEntrySizeBytes);
                break;
                case ConfigSettingEntry.ConfigSettingStateArchival case_CONFIG_SETTING_STATE_ARCHIVAL:
                StateArchivalSettingsXdr.Encode(stream, case_CONFIG_SETTING_STATE_ARCHIVAL.stateArchivalSettings);
                break;
                case ConfigSettingEntry.ConfigSettingContractExecutionLanes case_CONFIG_SETTING_CONTRACT_EXECUTION_LANES:
                ConfigSettingContractExecutionLanesV0Xdr.Encode(stream, case_CONFIG_SETTING_CONTRACT_EXECUTION_LANES.contractExecutionLanes);
                break;
                case ConfigSettingEntry.ConfigSettingBucketlistSizeWindow case_CONFIG_SETTING_BUCKETLIST_SIZE_WINDOW:
                stream.WriteInt(case_CONFIG_SETTING_BUCKETLIST_SIZE_WINDOW.bucketListSizeWindow.Length);
                foreach (var item in case_CONFIG_SETTING_BUCKETLIST_SIZE_WINDOW.bucketListSizeWindow)
                {
                        uint64Xdr.Encode(stream, item);
                }
                break;
                case ConfigSettingEntry.ConfigSettingEvictionIterator case_CONFIG_SETTING_EVICTION_ITERATOR:
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
                var result_CONFIG_SETTING_CONTRACT_MAX_SIZE_BYTES = new ConfigSettingEntry.ConfigSettingContractMaxSizeBytes();
                result_CONFIG_SETTING_CONTRACT_MAX_SIZE_BYTES.contractMaxSizeBytes = uint32Xdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_MAX_SIZE_BYTES;
                case ConfigSettingID.CONFIG_SETTING_CONTRACT_COMPUTE_V0:
                var result_CONFIG_SETTING_CONTRACT_COMPUTE_V0 = new ConfigSettingEntry.ConfigSettingContractComputeV0Case();
                result_CONFIG_SETTING_CONTRACT_COMPUTE_V0.contractCompute = ConfigSettingContractComputeV0Xdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_COMPUTE_V0;
                case ConfigSettingID.CONFIG_SETTING_CONTRACT_LEDGER_COST_V0:
                var result_CONFIG_SETTING_CONTRACT_LEDGER_COST_V0 = new ConfigSettingEntry.ConfigSettingContractLedgerCostV0Case();
                result_CONFIG_SETTING_CONTRACT_LEDGER_COST_V0.contractLedgerCost = ConfigSettingContractLedgerCostV0Xdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_LEDGER_COST_V0;
                case ConfigSettingID.CONFIG_SETTING_CONTRACT_HISTORICAL_DATA_V0:
                var result_CONFIG_SETTING_CONTRACT_HISTORICAL_DATA_V0 = new ConfigSettingEntry.ConfigSettingContractHistoricalDataV0Case();
                result_CONFIG_SETTING_CONTRACT_HISTORICAL_DATA_V0.contractHistoricalData = ConfigSettingContractHistoricalDataV0Xdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_HISTORICAL_DATA_V0;
                case ConfigSettingID.CONFIG_SETTING_CONTRACT_EVENTS_V0:
                var result_CONFIG_SETTING_CONTRACT_EVENTS_V0 = new ConfigSettingEntry.ConfigSettingContractEventsV0Case();
                result_CONFIG_SETTING_CONTRACT_EVENTS_V0.contractEvents = ConfigSettingContractEventsV0Xdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_EVENTS_V0;
                case ConfigSettingID.CONFIG_SETTING_CONTRACT_BANDWIDTH_V0:
                var result_CONFIG_SETTING_CONTRACT_BANDWIDTH_V0 = new ConfigSettingEntry.ConfigSettingContractBandwidthV0Case();
                result_CONFIG_SETTING_CONTRACT_BANDWIDTH_V0.contractBandwidth = ConfigSettingContractBandwidthV0Xdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_BANDWIDTH_V0;
                case ConfigSettingID.CONFIG_SETTING_CONTRACT_COST_PARAMS_CPU_INSTRUCTIONS:
                var result_CONFIG_SETTING_CONTRACT_COST_PARAMS_CPU_INSTRUCTIONS = new ConfigSettingEntry.ConfigSettingContractCostParamsCpuInstructions();
                result_CONFIG_SETTING_CONTRACT_COST_PARAMS_CPU_INSTRUCTIONS.contractCostParamsCpuInsns = ContractCostParamsXdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_COST_PARAMS_CPU_INSTRUCTIONS;
                case ConfigSettingID.CONFIG_SETTING_CONTRACT_COST_PARAMS_MEMORY_BYTES:
                var result_CONFIG_SETTING_CONTRACT_COST_PARAMS_MEMORY_BYTES = new ConfigSettingEntry.ConfigSettingContractCostParamsMemoryBytes();
                result_CONFIG_SETTING_CONTRACT_COST_PARAMS_MEMORY_BYTES.contractCostParamsMemBytes = ContractCostParamsXdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_COST_PARAMS_MEMORY_BYTES;
                case ConfigSettingID.CONFIG_SETTING_CONTRACT_DATA_KEY_SIZE_BYTES:
                var result_CONFIG_SETTING_CONTRACT_DATA_KEY_SIZE_BYTES = new ConfigSettingEntry.ConfigSettingContractDataKeySizeBytes();
                result_CONFIG_SETTING_CONTRACT_DATA_KEY_SIZE_BYTES.contractDataKeySizeBytes = uint32Xdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_DATA_KEY_SIZE_BYTES;
                case ConfigSettingID.CONFIG_SETTING_CONTRACT_DATA_ENTRY_SIZE_BYTES:
                var result_CONFIG_SETTING_CONTRACT_DATA_ENTRY_SIZE_BYTES = new ConfigSettingEntry.ConfigSettingContractDataEntrySizeBytes();
                result_CONFIG_SETTING_CONTRACT_DATA_ENTRY_SIZE_BYTES.contractDataEntrySizeBytes = uint32Xdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_DATA_ENTRY_SIZE_BYTES;
                case ConfigSettingID.CONFIG_SETTING_STATE_ARCHIVAL:
                var result_CONFIG_SETTING_STATE_ARCHIVAL = new ConfigSettingEntry.ConfigSettingStateArchival();
                result_CONFIG_SETTING_STATE_ARCHIVAL.stateArchivalSettings = StateArchivalSettingsXdr.Decode(stream);
                return result_CONFIG_SETTING_STATE_ARCHIVAL;
                case ConfigSettingID.CONFIG_SETTING_CONTRACT_EXECUTION_LANES:
                var result_CONFIG_SETTING_CONTRACT_EXECUTION_LANES = new ConfigSettingEntry.ConfigSettingContractExecutionLanes();
                result_CONFIG_SETTING_CONTRACT_EXECUTION_LANES.contractExecutionLanes = ConfigSettingContractExecutionLanesV0Xdr.Decode(stream);
                return result_CONFIG_SETTING_CONTRACT_EXECUTION_LANES;
                case ConfigSettingID.CONFIG_SETTING_BUCKETLIST_SIZE_WINDOW:
                var result_CONFIG_SETTING_BUCKETLIST_SIZE_WINDOW = new ConfigSettingEntry.ConfigSettingBucketlistSizeWindow();
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
                var result_CONFIG_SETTING_EVICTION_ITERATOR = new ConfigSettingEntry.ConfigSettingEvictionIterator();
                result_CONFIG_SETTING_EVICTION_ITERATOR.evictionIterator = EvictionIteratorXdr.Decode(stream);
                return result_CONFIG_SETTING_EVICTION_ITERATOR;
                default:
                throw new Exception($"Unknown discriminator for ConfigSettingEntry: {discriminator}");
            }
        }
    }
}
