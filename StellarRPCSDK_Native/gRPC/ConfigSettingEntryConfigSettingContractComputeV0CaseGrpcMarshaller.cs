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
    /// <summary>Custom marshaller for Stellar.ConfigSettingEntry+ConfigSettingContractComputeV0Case</summary>
    public static class ConfigSettingEntryConfigSettingContractComputeV0CaseGrpcMarshaller
    {
        // Static constructor to configure type
        static ConfigSettingEntryConfigSettingContractComputeV0CaseGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ConfigSettingEntry.ConfigSettingContractComputeV0Case
            if (!model.IsDefined(typeof(Stellar.ConfigSettingEntry.ConfigSettingContractComputeV0Case)))
            {
                var metaType = model.Add(typeof(Stellar.ConfigSettingEntry.ConfigSettingContractComputeV0Case), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(2, "contractCompute");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ConfigSettingContractComputeV0Case</summary>
        public static readonly Marshaller<Stellar.ConfigSettingEntry.ConfigSettingContractComputeV0Case> ConfigSettingContractComputeV0CaseMarshaller = Marshallers.Create<Stellar.ConfigSettingEntry.ConfigSettingContractComputeV0Case>(
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
                        return Serializer.Deserialize<Stellar.ConfigSettingEntry.ConfigSettingContractComputeV0Case>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
