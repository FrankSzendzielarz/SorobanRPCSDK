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
    /// <summary>Custom marshaller for Stellar.ColdArchiveBucketEntry+ColdArchiveArchivedLeafCase</summary>
    public static class ColdArchiveBucketEntryColdArchiveArchivedLeafCaseGrpcMarshaller
    {
        // Static constructor to configure type
        static ColdArchiveBucketEntryColdArchiveArchivedLeafCaseGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ColdArchiveBucketEntry.ColdArchiveArchivedLeafCase
            if (!model.IsDefined(typeof(Stellar.ColdArchiveBucketEntry.ColdArchiveArchivedLeafCase)))
            {
                var metaType = model.Add(typeof(Stellar.ColdArchiveBucketEntry.ColdArchiveArchivedLeafCase), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(2, "archivedLeaf");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ColdArchiveArchivedLeafCase</summary>
        public static readonly Marshaller<Stellar.ColdArchiveBucketEntry.ColdArchiveArchivedLeafCase> ColdArchiveArchivedLeafCaseMarshaller = Marshallers.Create<Stellar.ColdArchiveBucketEntry.ColdArchiveArchivedLeafCase>(
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
                        return Serializer.Deserialize<Stellar.ColdArchiveBucketEntry.ColdArchiveArchivedLeafCase>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
