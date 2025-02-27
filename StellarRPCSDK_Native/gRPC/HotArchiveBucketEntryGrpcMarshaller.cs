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
    /// <summary>Custom marshaller for Stellar.HotArchiveBucketEntry</summary>
    public static class HotArchiveBucketEntryGrpcMarshaller
    {
        // Static constructor to configure type
        static HotArchiveBucketEntryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.HotArchiveBucketEntry
            if (!model.IsDefined(typeof(Stellar.HotArchiveBucketEntry)))
            {
                var metaType = model.Add(typeof(Stellar.HotArchiveBucketEntry), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.HotArchiveBucketEntry.HotArchiveArchived));
                metaType.AddSubType(101, typeof(Stellar.HotArchiveBucketEntry.HotArchiveLive));
                metaType.AddSubType(102, typeof(Stellar.HotArchiveBucketEntry.HotArchiveDeleted));
                metaType.AddSubType(103, typeof(Stellar.HotArchiveBucketEntry.HotArchiveMetaentry));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.HotArchiveBucketEntry</summary>
        public static readonly Marshaller<Stellar.HotArchiveBucketEntry> HotArchiveBucketEntryMarshaller = Marshallers.Create<Stellar.HotArchiveBucketEntry>(
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
                        return Serializer.Deserialize<Stellar.HotArchiveBucketEntry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
