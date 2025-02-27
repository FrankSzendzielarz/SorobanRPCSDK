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
    /// <summary>Custom marshaller for Stellar.ColdArchiveBucketEntry+ColdArchiveDeletedLeafCase</summary>
    public static class ColdArchiveBucketEntryColdArchiveDeletedLeafCaseGrpcMarshaller
    {
        // Static constructor to configure type
        static ColdArchiveBucketEntryColdArchiveDeletedLeafCaseGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ColdArchiveBucketEntry.ColdArchiveDeletedLeafCase
            if (!model.IsDefined(typeof(Stellar.ColdArchiveBucketEntry.ColdArchiveDeletedLeafCase)))
            {
                var metaType = model.Add(typeof(Stellar.ColdArchiveBucketEntry.ColdArchiveDeletedLeafCase), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(3, "deletedLeaf");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ColdArchiveDeletedLeafCase</summary>
        public static readonly Marshaller<Stellar.ColdArchiveBucketEntry.ColdArchiveDeletedLeafCase> ColdArchiveDeletedLeafCaseMarshaller = Marshallers.Create<Stellar.ColdArchiveBucketEntry.ColdArchiveDeletedLeafCase>(
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
                        return Serializer.Deserialize<Stellar.ColdArchiveBucketEntry.ColdArchiveDeletedLeafCase>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
