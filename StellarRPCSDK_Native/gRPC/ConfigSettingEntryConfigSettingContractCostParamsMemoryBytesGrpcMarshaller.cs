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
    /// <summary>Custom marshaller for Stellar.ConfigSettingEntry+ConfigSettingContractCostParamsMemoryBytes</summary>
    public static class ConfigSettingEntryConfigSettingContractCostParamsMemoryBytesGrpcMarshaller
    {
        // Static constructor to configure type
        static ConfigSettingEntryConfigSettingContractCostParamsMemoryBytesGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ConfigSettingEntry.ConfigSettingContractCostParamsMemoryBytes
            if (!model.IsDefined(typeof(Stellar.ConfigSettingEntry.ConfigSettingContractCostParamsMemoryBytes)))
            {
                var metaType = model.Add(typeof(Stellar.ConfigSettingEntry.ConfigSettingContractCostParamsMemoryBytes), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(8, "contractCostParamsMemBytes");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ConfigSettingEntry+ConfigSettingContractCostParamsMemoryBytes</summary>
        public static readonly Marshaller<Stellar.ConfigSettingEntry.ConfigSettingContractCostParamsMemoryBytes> ConfigSettingEntry_ConfigSettingContractCostParamsMemoryBytesMarshaller = Marshallers.Create<Stellar.ConfigSettingEntry.ConfigSettingContractCostParamsMemoryBytes>(
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
                        return Serializer.Deserialize<Stellar.ConfigSettingEntry.ConfigSettingContractCostParamsMemoryBytes>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
