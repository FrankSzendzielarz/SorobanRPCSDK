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
    /// <summary>Custom marshaller for Stellar.ConfigSettingContractExecutionLanesV0</summary>
    public static class ConfigSettingContractExecutionLanesV0GrpcMarshaller
    {
        // Static constructor to configure type
        static ConfigSettingContractExecutionLanesV0GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ConfigSettingContractExecutionLanesV0
            if (!model.IsDefined(typeof(Stellar.ConfigSettingContractExecutionLanesV0)))
            {
                var metaType = model.Add(typeof(Stellar.ConfigSettingContractExecutionLanesV0), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ledgerMaxTxCount");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ConfigSettingContractExecutionLanesV0</summary>
        public static readonly Marshaller<Stellar.ConfigSettingContractExecutionLanesV0> ConfigSettingContractExecutionLanesV0Marshaller = Marshallers.Create<Stellar.ConfigSettingContractExecutionLanesV0>(
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
                        return Serializer.Deserialize<Stellar.ConfigSettingContractExecutionLanesV0>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
