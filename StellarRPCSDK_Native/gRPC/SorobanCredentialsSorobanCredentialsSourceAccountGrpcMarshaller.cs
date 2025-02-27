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
    /// <summary>Custom marshaller for Stellar.SorobanCredentials+SorobanCredentialsSourceAccount</summary>
    public static class SorobanCredentialsSorobanCredentialsSourceAccountGrpcMarshaller
    {
        // Static constructor to configure type
        static SorobanCredentialsSorobanCredentialsSourceAccountGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SorobanCredentials.SorobanCredentialsSourceAccount
            if (!model.IsDefined(typeof(Stellar.SorobanCredentials.SorobanCredentialsSourceAccount)))
            {
                var metaType = model.Add(typeof(Stellar.SorobanCredentials.SorobanCredentialsSourceAccount), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SorobanCredentials+SorobanCredentialsSourceAccount</summary>
        public static readonly Marshaller<Stellar.SorobanCredentials.SorobanCredentialsSourceAccount> SorobanCredentials_SorobanCredentialsSourceAccountMarshaller = Marshallers.Create<Stellar.SorobanCredentials.SorobanCredentialsSourceAccount>(
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
                        return Serializer.Deserialize<Stellar.SorobanCredentials.SorobanCredentialsSourceAccount>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
