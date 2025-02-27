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
    /// <summary>Custom marshaller for Stellar.ColdArchiveBucketEntryDecodeResponse</summary>
    public static class ColdArchiveBucketEntryDecodeResponseGrpcMarshaller
    {
        // Static constructor to configure type
        static ColdArchiveBucketEntryDecodeResponseGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ColdArchiveBucketEntryDecodeResponse
            if (!model.IsDefined(typeof(Stellar.ColdArchiveBucketEntryDecodeResponse)))
            {
                var metaType = model.Add(typeof(Stellar.ColdArchiveBucketEntryDecodeResponse), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Value");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ColdArchiveBucketEntryDecodeResponse</summary>
        public static readonly Marshaller<Stellar.ColdArchiveBucketEntryDecodeResponse> ColdArchiveBucketEntryDecodeResponseMarshaller = Marshallers.Create<Stellar.ColdArchiveBucketEntryDecodeResponse>(
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
                        return Serializer.Deserialize<Stellar.ColdArchiveBucketEntryDecodeResponse>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
