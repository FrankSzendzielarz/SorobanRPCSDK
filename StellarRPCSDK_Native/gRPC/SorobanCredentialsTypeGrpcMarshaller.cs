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
    /// <summary>Custom marshaller for Stellar.SorobanCredentialsType</summary>
    public static class SorobanCredentialsTypeGrpcMarshaller
    {
        // Static constructor to configure type
        static SorobanCredentialsTypeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SorobanCredentialsType
            if (!model.IsDefined(typeof(Stellar.SorobanCredentialsType)))
            {
                var metaType = model.Add(typeof(Stellar.SorobanCredentialsType), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SorobanCredentialsType</summary>
        public static readonly Marshaller<Stellar.SorobanCredentialsType> SorobanCredentialsTypeMarshaller = Marshallers.Create<Stellar.SorobanCredentialsType>(
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
                        return Serializer.Deserialize<Stellar.SorobanCredentialsType>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
