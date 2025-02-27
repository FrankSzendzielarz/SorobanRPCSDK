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
    /// <summary>Custom marshaller for Stellar.SetOptionsResult+SetOptionsAuthRevocableRequired</summary>
    public static class SetOptionsResultSetOptionsAuthRevocableRequiredGrpcMarshaller
    {
        // Static constructor to configure type
        static SetOptionsResultSetOptionsAuthRevocableRequiredGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SetOptionsResult.SetOptionsAuthRevocableRequired
            if (!model.IsDefined(typeof(Stellar.SetOptionsResult.SetOptionsAuthRevocableRequired)))
            {
                var metaType = model.Add(typeof(Stellar.SetOptionsResult.SetOptionsAuthRevocableRequired), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SetOptionsResult+SetOptionsAuthRevocableRequired</summary>
        public static readonly Marshaller<Stellar.SetOptionsResult.SetOptionsAuthRevocableRequired> SetOptionsResult_SetOptionsAuthRevocableRequiredMarshaller = Marshallers.Create<Stellar.SetOptionsResult.SetOptionsAuthRevocableRequired>(
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
                        return Serializer.Deserialize<Stellar.SetOptionsResult.SetOptionsAuthRevocableRequired>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
