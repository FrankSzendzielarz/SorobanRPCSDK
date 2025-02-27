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
    /// <summary>Custom marshaller for Stellar.EnvelopeType</summary>
    public static class EnvelopeTypeGrpcMarshaller
    {
        // Static constructor to configure type
        static EnvelopeTypeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.EnvelopeType
            if (!model.IsDefined(typeof(Stellar.EnvelopeType)))
            {
                var metaType = model.Add(typeof(Stellar.EnvelopeType), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.EnvelopeType</summary>
        public static readonly Marshaller<Stellar.EnvelopeType> EnvelopeTypeMarshaller = Marshallers.Create<Stellar.EnvelopeType>(
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
                        return Serializer.Deserialize<Stellar.EnvelopeType>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
