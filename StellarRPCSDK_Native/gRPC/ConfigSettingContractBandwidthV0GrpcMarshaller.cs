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
    /// <summary>Custom marshaller for Stellar.ConfigSettingContractBandwidthV0</summary>
    public static class ConfigSettingContractBandwidthV0GrpcMarshaller
    {
        // Static constructor to configure type
        static ConfigSettingContractBandwidthV0GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ConfigSettingContractBandwidthV0
            if (!model.IsDefined(typeof(Stellar.ConfigSettingContractBandwidthV0)))
            {
                var metaType = model.Add(typeof(Stellar.ConfigSettingContractBandwidthV0), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ledgerMaxTxsSizeBytes");
                metaType.Add(2, "txMaxSizeBytes");
                metaType.Add(3, "feeTxSize1KB");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ConfigSettingContractBandwidthV0</summary>
        public static readonly Marshaller<Stellar.ConfigSettingContractBandwidthV0> ConfigSettingContractBandwidthV0Marshaller = Marshallers.Create<Stellar.ConfigSettingContractBandwidthV0>(
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
                        return Serializer.Deserialize<Stellar.ConfigSettingContractBandwidthV0>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
