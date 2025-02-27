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
    /// <summary>Custom marshaller for Stellar.BucketMetadata+extUnion</summary>
    public static class BucketMetadataextUnionGrpcMarshaller
    {
        // Static constructor to configure type
        static BucketMetadataextUnionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.BucketMetadata.extUnion
            if (!model.IsDefined(typeof(Stellar.BucketMetadata.extUnion)))
            {
                var metaType = model.Add(typeof(Stellar.BucketMetadata.extUnion), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.BucketMetadata.extUnion.case_0));
                metaType.AddSubType(101, typeof(Stellar.BucketMetadata.extUnion.case_1));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.BucketMetadata+extUnion</summary>
        public static readonly Marshaller<Stellar.BucketMetadata.extUnion> BucketMetadata_extUnionMarshaller = Marshallers.Create<Stellar.BucketMetadata.extUnion>(
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
                        return Serializer.Deserialize<Stellar.BucketMetadata.extUnion>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
