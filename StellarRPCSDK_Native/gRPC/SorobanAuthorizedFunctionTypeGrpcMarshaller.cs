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
    /// <summary>Custom marshaller for Stellar.SorobanAuthorizedFunctionType</summary>
    public static class SorobanAuthorizedFunctionTypeGrpcMarshaller
    {
        // Static constructor to configure type
        static SorobanAuthorizedFunctionTypeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SorobanAuthorizedFunctionType
            if (!model.IsDefined(typeof(Stellar.SorobanAuthorizedFunctionType)))
            {
                var metaType = model.Add(typeof(Stellar.SorobanAuthorizedFunctionType), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SorobanAuthorizedFunctionType</summary>
        public static readonly Marshaller<Stellar.SorobanAuthorizedFunctionType> SorobanAuthorizedFunctionTypeMarshaller = Marshallers.Create<Stellar.SorobanAuthorizedFunctionType>(
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
                        return Serializer.Deserialize<Stellar.SorobanAuthorizedFunctionType>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
