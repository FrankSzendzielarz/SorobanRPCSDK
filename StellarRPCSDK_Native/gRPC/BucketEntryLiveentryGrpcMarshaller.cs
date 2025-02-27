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
    /// <summary>Custom marshaller for Stellar.BucketEntry+Liveentry</summary>
    public static class BucketEntryLiveentryGrpcMarshaller
    {
        // Static constructor to configure type
        static BucketEntryLiveentryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.BucketEntry.Liveentry
            if (!model.IsDefined(typeof(Stellar.BucketEntry.Liveentry)))
            {
                var metaType = model.Add(typeof(Stellar.BucketEntry.Liveentry), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "liveEntry");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.BucketEntry+Liveentry</summary>
        public static readonly Marshaller<Stellar.BucketEntry.Liveentry> BucketEntry_LiveentryMarshaller = Marshallers.Create<Stellar.BucketEntry.Liveentry>(
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
                        return Serializer.Deserialize<Stellar.BucketEntry.Liveentry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
