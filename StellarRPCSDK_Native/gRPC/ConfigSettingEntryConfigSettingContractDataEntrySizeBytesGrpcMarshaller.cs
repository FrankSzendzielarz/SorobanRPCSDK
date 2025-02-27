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
    /// <summary>Custom marshaller for Stellar.ConfigSettingEntry+ConfigSettingContractDataEntrySizeBytes</summary>
    public static class ConfigSettingEntryConfigSettingContractDataEntrySizeBytesGrpcMarshaller
    {
        // Static constructor to configure type
        static ConfigSettingEntryConfigSettingContractDataEntrySizeBytesGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ConfigSettingEntry.ConfigSettingContractDataEntrySizeBytes
            if (!model.IsDefined(typeof(Stellar.ConfigSettingEntry.ConfigSettingContractDataEntrySizeBytes)))
            {
                var metaType = model.Add(typeof(Stellar.ConfigSettingEntry.ConfigSettingContractDataEntrySizeBytes), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(10, "contractDataEntrySizeBytes");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ConfigSettingContractDataEntrySizeBytes</summary>
        public static readonly Marshaller<Stellar.ConfigSettingEntry.ConfigSettingContractDataEntrySizeBytes> ConfigSettingContractDataEntrySizeBytesMarshaller = Marshallers.Create<Stellar.ConfigSettingEntry.ConfigSettingContractDataEntrySizeBytes>(
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
                        return Serializer.Deserialize<Stellar.ConfigSettingEntry.ConfigSettingContractDataEntrySizeBytes>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
