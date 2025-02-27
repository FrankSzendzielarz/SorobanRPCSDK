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
    /// <summary>Custom marshaller for Stellar.SorobanAddressCredentials</summary>
    public static class SorobanAddressCredentialsGrpcMarshaller
    {
        // Static constructor to configure type
        static SorobanAddressCredentialsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SorobanAddressCredentials
            if (!model.IsDefined(typeof(Stellar.SorobanAddressCredentials)))
            {
                var metaType = model.Add(typeof(Stellar.SorobanAddressCredentials), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "address");
                metaType.Add(2, "nonce");
                metaType.Add(3, "signatureExpirationLedger");
                metaType.Add(4, "signature");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SorobanAddressCredentials</summary>
        public static readonly Marshaller<Stellar.SorobanAddressCredentials> SorobanAddressCredentialsMarshaller = Marshallers.Create<Stellar.SorobanAddressCredentials>(
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
                        return Serializer.Deserialize<Stellar.SorobanAddressCredentials>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
