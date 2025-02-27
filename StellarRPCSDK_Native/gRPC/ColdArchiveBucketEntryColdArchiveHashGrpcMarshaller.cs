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
    /// <summary>Custom marshaller for Stellar.ColdArchiveBucketEntry+ColdArchiveHash</summary>
    public static class ColdArchiveBucketEntryColdArchiveHashGrpcMarshaller
    {
        // Static constructor to configure type
        static ColdArchiveBucketEntryColdArchiveHashGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ColdArchiveBucketEntry.ColdArchiveHash
            if (!model.IsDefined(typeof(Stellar.ColdArchiveBucketEntry.ColdArchiveHash)))
            {
                var metaType = model.Add(typeof(Stellar.ColdArchiveBucketEntry.ColdArchiveHash), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(5, "hashEntry");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ColdArchiveHash</summary>
        public static readonly Marshaller<Stellar.ColdArchiveBucketEntry.ColdArchiveHash> ColdArchiveHashMarshaller = Marshallers.Create<Stellar.ColdArchiveBucketEntry.ColdArchiveHash>(
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
                        return Serializer.Deserialize<Stellar.ColdArchiveBucketEntry.ColdArchiveHash>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
