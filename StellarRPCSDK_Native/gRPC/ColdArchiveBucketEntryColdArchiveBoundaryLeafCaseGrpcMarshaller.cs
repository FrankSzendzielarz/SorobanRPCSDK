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
    /// <summary>Custom marshaller for Stellar.ColdArchiveBucketEntry+ColdArchiveBoundaryLeafCase</summary>
    public static class ColdArchiveBucketEntryColdArchiveBoundaryLeafCaseGrpcMarshaller
    {
        // Static constructor to configure type
        static ColdArchiveBucketEntryColdArchiveBoundaryLeafCaseGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ColdArchiveBucketEntry.ColdArchiveBoundaryLeafCase
            if (!model.IsDefined(typeof(Stellar.ColdArchiveBucketEntry.ColdArchiveBoundaryLeafCase)))
            {
                var metaType = model.Add(typeof(Stellar.ColdArchiveBucketEntry.ColdArchiveBoundaryLeafCase), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(4, "boundaryLeaf");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ColdArchiveBoundaryLeafCase</summary>
        public static readonly Marshaller<Stellar.ColdArchiveBucketEntry.ColdArchiveBoundaryLeafCase> ColdArchiveBoundaryLeafCaseMarshaller = Marshallers.Create<Stellar.ColdArchiveBucketEntry.ColdArchiveBoundaryLeafCase>(
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
                        return Serializer.Deserialize<Stellar.ColdArchiveBucketEntry.ColdArchiveBoundaryLeafCase>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
