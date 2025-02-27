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
    /// <summary>Custom marshaller for Stellar.AuthCert</summary>
    public static class AuthCertGrpcMarshaller
    {
        // Static constructor to configure type
        static AuthCertGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.AuthCert
            if (!model.IsDefined(typeof(Stellar.AuthCert)))
            {
                var metaType = model.Add(typeof(Stellar.AuthCert), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "pubkey");
                metaType.Add(2, "expiration");
                metaType.Add(3, "sig");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.AuthCert</summary>
        public static readonly Marshaller<Stellar.AuthCert> AuthCertMarshaller = Marshallers.Create<Stellar.AuthCert>(
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
                        return Serializer.Deserialize<Stellar.AuthCert>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
