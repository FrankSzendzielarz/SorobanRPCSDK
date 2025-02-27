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
    /// <summary>Custom marshaller for Stellar.ConfigSettingContractLedgerCostV0</summary>
    public static class ConfigSettingContractLedgerCostV0GrpcMarshaller
    {
        // Static constructor to configure type
        static ConfigSettingContractLedgerCostV0GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ConfigSettingContractLedgerCostV0
            if (!model.IsDefined(typeof(Stellar.ConfigSettingContractLedgerCostV0)))
            {
                var metaType = model.Add(typeof(Stellar.ConfigSettingContractLedgerCostV0), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ledgerMaxReadLedgerEntries");
                metaType.Add(2, "ledgerMaxReadBytes");
                metaType.Add(3, "ledgerMaxWriteLedgerEntries");
                metaType.Add(4, "ledgerMaxWriteBytes");
                metaType.Add(5, "txMaxReadLedgerEntries");
                metaType.Add(6, "txMaxReadBytes");
                metaType.Add(7, "txMaxWriteLedgerEntries");
                metaType.Add(8, "txMaxWriteBytes");
                metaType.Add(9, "feeReadLedgerEntry");
                metaType.Add(10, "feeWriteLedgerEntry");
                metaType.Add(11, "feeRead1KB");
                metaType.Add(12, "bucketListTargetSizeBytes");
                metaType.Add(13, "writeFee1KBBucketListLow");
                metaType.Add(14, "writeFee1KBBucketListHigh");
                metaType.Add(15, "bucketListWriteFeeGrowthFactor");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ConfigSettingContractLedgerCostV0</summary>
        public static readonly Marshaller<Stellar.ConfigSettingContractLedgerCostV0> ConfigSettingContractLedgerCostV0Marshaller = Marshallers.Create<Stellar.ConfigSettingContractLedgerCostV0>(
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
                        return Serializer.Deserialize<Stellar.ConfigSettingContractLedgerCostV0>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
