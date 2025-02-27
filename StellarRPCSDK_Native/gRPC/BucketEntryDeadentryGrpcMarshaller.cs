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
    /// <summary>Custom marshaller for Stellar.BucketEntry+Deadentry</summary>
    public static class BucketEntryDeadentryGrpcMarshaller
    {
        // Static constructor to configure type
        static BucketEntryDeadentryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.BucketEntry.Deadentry
            if (!model.IsDefined(typeof(Stellar.BucketEntry.Deadentry)))
            {
                var metaType = model.Add(typeof(Stellar.BucketEntry.Deadentry), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(3, "deadEntry");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.BucketEntry+Deadentry</summary>
        public static readonly Marshaller<Stellar.BucketEntry.Deadentry> BucketEntry_DeadentryMarshaller = Marshallers.Create<Stellar.BucketEntry.Deadentry>(
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
                        return Serializer.Deserialize<Stellar.BucketEntry.Deadentry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
