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
    /// <summary>Custom marshaller for Stellar.ColdArchiveBucketEntry</summary>
    public static class ColdArchiveBucketEntryGrpcMarshaller
    {
        // Static constructor to configure type
        static ColdArchiveBucketEntryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ColdArchiveBucketEntry
            if (!model.IsDefined(typeof(Stellar.ColdArchiveBucketEntry)))
            {
                var metaType = model.Add(typeof(Stellar.ColdArchiveBucketEntry), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.ColdArchiveBucketEntry.ColdArchiveMetaentry));
                metaType.AddSubType(101, typeof(Stellar.ColdArchiveBucketEntry.ColdArchiveArchivedLeafCase));
                metaType.AddSubType(102, typeof(Stellar.ColdArchiveBucketEntry.ColdArchiveDeletedLeafCase));
                metaType.AddSubType(103, typeof(Stellar.ColdArchiveBucketEntry.ColdArchiveBoundaryLeafCase));
                metaType.AddSubType(104, typeof(Stellar.ColdArchiveBucketEntry.ColdArchiveHash));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ColdArchiveBucketEntry</summary>
        public static readonly Marshaller<Stellar.ColdArchiveBucketEntry> ColdArchiveBucketEntryMarshaller = Marshallers.Create<Stellar.ColdArchiveBucketEntry>(
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
                        return Serializer.Deserialize<Stellar.ColdArchiveBucketEntry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
