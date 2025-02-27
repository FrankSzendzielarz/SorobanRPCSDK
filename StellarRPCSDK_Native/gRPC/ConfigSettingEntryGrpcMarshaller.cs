// Generated code - do not modify directly
using System;
using System.IO;
using System.Buffers;
using Grpc.Core;
using ProtoBuf;
using ProtoBuf.Meta;
using Stellar;

namespace Stellar.RPC.AOT
{
    /// <summary>Custom marshaller for Stellar.ConfigSettingEntry</summary>
    public static class ConfigSettingEntryGrpcMarshaller
    {
        // Static constructor to configure type
        static ConfigSettingEntryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ConfigSettingEntry
            if (!model.IsDefined(typeof(Stellar.ConfigSettingEntry)))
            {
                var metaType = model.Add(typeof(Stellar.ConfigSettingEntry), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.ConfigSettingEntry.ConfigSettingContractMaxSizeBytes));
                metaType.AddSubType(101, typeof(Stellar.ConfigSettingEntry.ConfigSettingContractComputeV0Case));
                metaType.AddSubType(102, typeof(Stellar.ConfigSettingEntry.ConfigSettingContractLedgerCostV0Case));
                metaType.AddSubType(103, typeof(Stellar.ConfigSettingEntry.ConfigSettingContractHistoricalDataV0Case));
                metaType.AddSubType(104, typeof(Stellar.ConfigSettingEntry.ConfigSettingContractEventsV0Case));
                metaType.AddSubType(105, typeof(Stellar.ConfigSettingEntry.ConfigSettingContractBandwidthV0Case));
                metaType.AddSubType(106, typeof(Stellar.ConfigSettingEntry.ConfigSettingContractCostParamsCpuInstructions));
                metaType.AddSubType(107, typeof(Stellar.ConfigSettingEntry.ConfigSettingContractCostParamsMemoryBytes));
                metaType.AddSubType(108, typeof(Stellar.ConfigSettingEntry.ConfigSettingContractDataKeySizeBytes));
                metaType.AddSubType(109, typeof(Stellar.ConfigSettingEntry.ConfigSettingContractDataEntrySizeBytes));
                metaType.AddSubType(110, typeof(Stellar.ConfigSettingEntry.ConfigSettingStateArchival));
                metaType.AddSubType(111, typeof(Stellar.ConfigSettingEntry.ConfigSettingContractExecutionLanes));
                metaType.AddSubType(112, typeof(Stellar.ConfigSettingEntry.ConfigSettingBucketlistSizeWindow));
                metaType.AddSubType(113, typeof(Stellar.ConfigSettingEntry.ConfigSettingEvictionIterator));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ConfigSettingEntry</summary>
        public static readonly Marshaller<Stellar.ConfigSettingEntry> ConfigSettingEntryMarshaller = Marshallers.Create<Stellar.ConfigSettingEntry>(
            (message, serializationContext) =>
            {
                try
                {
                    var ms = new MemoryStream();
                    Serializer.Serialize(ms, message);
                    var buffer = ms.ToArray();
                    serializationContext.Complete(buffer);
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Serialization error: {ex.Message}"));
                }
            },
            (deserializationContext) =>
            {
                try
                {
                    var buffer = deserializationContext.PayloadAsReadOnlySequence().ToArray();
                    using (var ms = new MemoryStream(buffer))
                    {
                        return Serializer.Deserialize<Stellar.ConfigSettingEntry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
