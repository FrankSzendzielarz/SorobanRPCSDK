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
    /// <summary>Custom marshaller for Stellar.BucketEntry+Metaentry</summary>
    public static class BucketEntryMetaentryGrpcMarshaller
    {
        // Static constructor to configure type
        static BucketEntryMetaentryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.BucketEntry.Metaentry
            if (!model.IsDefined(typeof(Stellar.BucketEntry.Metaentry)))
            {
                var metaType = model.Add(typeof(Stellar.BucketEntry.Metaentry), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(4, "metaEntry");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Metaentry</summary>
        public static readonly Marshaller<Stellar.BucketEntry.Metaentry> MetaentryMarshaller = Marshallers.Create<Stellar.BucketEntry.Metaentry>(
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
                        return Serializer.Deserialize<Stellar.BucketEntry.Metaentry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
