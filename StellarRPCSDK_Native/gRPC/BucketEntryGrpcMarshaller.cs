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
    /// <summary>Custom marshaller for Stellar.BucketEntry</summary>
    public static class BucketEntryGrpcMarshaller
    {
        // Static constructor to configure type
        static BucketEntryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.BucketEntry
            if (!model.IsDefined(typeof(Stellar.BucketEntry)))
            {
                var metaType = model.Add(typeof(Stellar.BucketEntry), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.BucketEntry.Liveentry));
                metaType.AddSubType(101, typeof(Stellar.BucketEntry.Initentry));
                metaType.AddSubType(102, typeof(Stellar.BucketEntry.Deadentry));
                metaType.AddSubType(103, typeof(Stellar.BucketEntry.Metaentry));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for BucketEntry</summary>
        public static readonly Marshaller<Stellar.BucketEntry> BucketEntryMarshaller = Marshallers.Create<Stellar.BucketEntry>(
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
                        return Serializer.Deserialize<Stellar.BucketEntry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
