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
    /// <summary>Custom marshaller for Stellar.Price</summary>
    public static class PriceGrpcMarshaller
    {
        // Static constructor to configure type
        static PriceGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Price
            if (!model.IsDefined(typeof(Stellar.Price)))
            {
                var metaType = model.Add(typeof(Stellar.Price), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "n");
                metaType.Add(2, "d");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.Price</summary>
        public static readonly Marshaller<Stellar.Price> PriceMarshaller = Marshallers.Create<Stellar.Price>(
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
                        return Serializer.Deserialize<Stellar.Price>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
