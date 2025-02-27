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
    /// <summary>Custom marshaller for Stellar.SorobanCredentials+SorobanCredentialsAddress</summary>
    public static class SorobanCredentialsSorobanCredentialsAddressGrpcMarshaller
    {
        // Static constructor to configure type
        static SorobanCredentialsSorobanCredentialsAddressGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SorobanCredentials.SorobanCredentialsAddress
            if (!model.IsDefined(typeof(Stellar.SorobanCredentials.SorobanCredentialsAddress)))
            {
                var metaType = model.Add(typeof(Stellar.SorobanCredentials.SorobanCredentialsAddress), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "address");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SorobanCredentials+SorobanCredentialsAddress</summary>
        public static readonly Marshaller<Stellar.SorobanCredentials.SorobanCredentialsAddress> SorobanCredentials_SorobanCredentialsAddressMarshaller = Marshallers.Create<Stellar.SorobanCredentials.SorobanCredentialsAddress>(
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
                        return Serializer.Deserialize<Stellar.SorobanCredentials.SorobanCredentialsAddress>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
