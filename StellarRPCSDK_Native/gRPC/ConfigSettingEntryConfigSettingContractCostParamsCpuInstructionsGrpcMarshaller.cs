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
    /// <summary>Custom marshaller for Stellar.ConfigSettingEntry+ConfigSettingContractCostParamsCpuInstructions</summary>
    public static class ConfigSettingEntryConfigSettingContractCostParamsCpuInstructionsGrpcMarshaller
    {
        // Static constructor to configure type
        static ConfigSettingEntryConfigSettingContractCostParamsCpuInstructionsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ConfigSettingEntry.ConfigSettingContractCostParamsCpuInstructions
            if (!model.IsDefined(typeof(Stellar.ConfigSettingEntry.ConfigSettingContractCostParamsCpuInstructions)))
            {
                var metaType = model.Add(typeof(Stellar.ConfigSettingEntry.ConfigSettingContractCostParamsCpuInstructions), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(7, "contractCostParamsCpuInsns");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ConfigSettingEntry+ConfigSettingContractCostParamsCpuInstructions</summary>
        public static readonly Marshaller<Stellar.ConfigSettingEntry.ConfigSettingContractCostParamsCpuInstructions> ConfigSettingEntry_ConfigSettingContractCostParamsCpuInstructionsMarshaller = Marshallers.Create<Stellar.ConfigSettingEntry.ConfigSettingContractCostParamsCpuInstructions>(
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
                        return Serializer.Deserialize<Stellar.ConfigSettingEntry.ConfigSettingContractCostParamsCpuInstructions>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
