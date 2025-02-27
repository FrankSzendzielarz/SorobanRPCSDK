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
    /// <summary>Custom marshaller for Stellar.ConfigSettingEntry+ConfigSettingContractMaxSizeBytes</summary>
    public static class ConfigSettingEntryConfigSettingContractMaxSizeBytesGrpcMarshaller
    {
        // Static constructor to configure type
        static ConfigSettingEntryConfigSettingContractMaxSizeBytesGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ConfigSettingEntry.ConfigSettingContractMaxSizeBytes
            if (!model.IsDefined(typeof(Stellar.ConfigSettingEntry.ConfigSettingContractMaxSizeBytes)))
            {
                var metaType = model.Add(typeof(Stellar.ConfigSettingEntry.ConfigSettingContractMaxSizeBytes), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "contractMaxSizeBytes");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ConfigSettingEntry+ConfigSettingContractMaxSizeBytes</summary>
        public static readonly Marshaller<Stellar.ConfigSettingEntry.ConfigSettingContractMaxSizeBytes> ConfigSettingEntry_ConfigSettingContractMaxSizeBytesMarshaller = Marshallers.Create<Stellar.ConfigSettingEntry.ConfigSettingContractMaxSizeBytes>(
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
                        return Serializer.Deserialize<Stellar.ConfigSettingEntry.ConfigSettingContractMaxSizeBytes>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
