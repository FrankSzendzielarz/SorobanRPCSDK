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
    /// <summary>Custom marshaller for Stellar.ShortHashSeed</summary>
    public static class ShortHashSeedGrpcMarshaller
    {
        // Static constructor to configure type
        static ShortHashSeedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ShortHashSeed
            if (!model.IsDefined(typeof(Stellar.ShortHashSeed)))
            {
                var metaType = model.Add(typeof(Stellar.ShortHashSeed), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "seed");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ShortHashSeed</summary>
        public static readonly Marshaller<Stellar.ShortHashSeed> ShortHashSeedMarshaller = Marshallers.Create<Stellar.ShortHashSeed>(
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
                        return Serializer.Deserialize<Stellar.ShortHashSeed>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
