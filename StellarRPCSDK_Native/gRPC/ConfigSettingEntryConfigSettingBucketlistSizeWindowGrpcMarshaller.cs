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
    /// <summary>Custom marshaller for Stellar.ConfigSettingEntry+ConfigSettingBucketlistSizeWindow</summary>
    public static class ConfigSettingEntryConfigSettingBucketlistSizeWindowGrpcMarshaller
    {
        // Static constructor to configure type
        static ConfigSettingEntryConfigSettingBucketlistSizeWindowGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ConfigSettingEntry.ConfigSettingBucketlistSizeWindow
            if (!model.IsDefined(typeof(Stellar.ConfigSettingEntry.ConfigSettingBucketlistSizeWindow)))
            {
                var metaType = model.Add(typeof(Stellar.ConfigSettingEntry.ConfigSettingBucketlistSizeWindow), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(13, "bucketListSizeWindow");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ConfigSettingEntry+ConfigSettingBucketlistSizeWindow</summary>
        public static readonly Marshaller<Stellar.ConfigSettingEntry.ConfigSettingBucketlistSizeWindow> ConfigSettingEntry_ConfigSettingBucketlistSizeWindowMarshaller = Marshallers.Create<Stellar.ConfigSettingEntry.ConfigSettingBucketlistSizeWindow>(
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
                        return Serializer.Deserialize<Stellar.ConfigSettingEntry.ConfigSettingBucketlistSizeWindow>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
