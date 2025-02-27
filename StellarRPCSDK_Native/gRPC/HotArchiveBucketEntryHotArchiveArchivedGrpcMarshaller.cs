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
    /// <summary>Custom marshaller for Stellar.HotArchiveBucketEntry+HotArchiveArchived</summary>
    public static class HotArchiveBucketEntryHotArchiveArchivedGrpcMarshaller
    {
        // Static constructor to configure type
        static HotArchiveBucketEntryHotArchiveArchivedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.HotArchiveBucketEntry.HotArchiveArchived
            if (!model.IsDefined(typeof(Stellar.HotArchiveBucketEntry.HotArchiveArchived)))
            {
                var metaType = model.Add(typeof(Stellar.HotArchiveBucketEntry.HotArchiveArchived), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "archivedEntry");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.HotArchiveBucketEntry+HotArchiveArchived</summary>
        public static readonly Marshaller<Stellar.HotArchiveBucketEntry.HotArchiveArchived> HotArchiveBucketEntry_HotArchiveArchivedMarshaller = Marshallers.Create<Stellar.HotArchiveBucketEntry.HotArchiveArchived>(
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
                        return Serializer.Deserialize<Stellar.HotArchiveBucketEntry.HotArchiveArchived>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
