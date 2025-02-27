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
    /// <summary>Custom marshaller for Stellar.FloodAdvert</summary>
    public static class FloodAdvertGrpcMarshaller
    {
        // Static constructor to configure type
        static FloodAdvertGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.FloodAdvert
            if (!model.IsDefined(typeof(Stellar.FloodAdvert)))
            {
                var metaType = model.Add(typeof(Stellar.FloodAdvert), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "txHashes");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.FloodAdvert</summary>
        public static readonly Marshaller<Stellar.FloodAdvert> FloodAdvertMarshaller = Marshallers.Create<Stellar.FloodAdvert>(
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
                        return Serializer.Deserialize<Stellar.FloodAdvert>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
