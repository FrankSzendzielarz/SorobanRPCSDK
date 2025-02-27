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
    /// <summary>Custom marshaller for Stellar.ColdArchiveBucketEntryType</summary>
    public static class ColdArchiveBucketEntryTypeGrpcMarshaller
    {
        // Static constructor to configure type
        static ColdArchiveBucketEntryTypeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ColdArchiveBucketEntryType
            if (!model.IsDefined(typeof(Stellar.ColdArchiveBucketEntryType)))
            {
                var metaType = model.Add(typeof(Stellar.ColdArchiveBucketEntryType), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ColdArchiveBucketEntryType</summary>
        public static readonly Marshaller<Stellar.ColdArchiveBucketEntryType> ColdArchiveBucketEntryTypeMarshaller = Marshallers.Create<Stellar.ColdArchiveBucketEntryType>(
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
                        return Serializer.Deserialize<Stellar.ColdArchiveBucketEntryType>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
