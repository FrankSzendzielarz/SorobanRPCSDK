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
    /// <summary>Custom marshaller for Stellar.ConfigSettingContractComputeV0</summary>
    public static class ConfigSettingContractComputeV0GrpcMarshaller
    {
        // Static constructor to configure type
        static ConfigSettingContractComputeV0GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ConfigSettingContractComputeV0
            if (!model.IsDefined(typeof(Stellar.ConfigSettingContractComputeV0)))
            {
                var metaType = model.Add(typeof(Stellar.ConfigSettingContractComputeV0), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ledgerMaxInstructions");
                metaType.Add(2, "txMaxInstructions");
                metaType.Add(3, "feeRatePerInstructionsIncrement");
                metaType.Add(4, "txMemoryLimit");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ConfigSettingContractComputeV0</summary>
        public static readonly Marshaller<Stellar.ConfigSettingContractComputeV0> ConfigSettingContractComputeV0Marshaller = Marshallers.Create<Stellar.ConfigSettingContractComputeV0>(
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
                        return Serializer.Deserialize<Stellar.ConfigSettingContractComputeV0>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
