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
    /// <summary>Custom marshaller for Stellar.Curve25519Secret</summary>
    public static class Curve25519SecretGrpcMarshaller
    {
        // Static constructor to configure type
        static Curve25519SecretGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Curve25519Secret
            if (!model.IsDefined(typeof(Stellar.Curve25519Secret)))
            {
                var metaType = model.Add(typeof(Stellar.Curve25519Secret), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "key");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Curve25519Secret</summary>
        public static readonly Marshaller<Stellar.Curve25519Secret> Curve25519SecretMarshaller = Marshallers.Create<Stellar.Curve25519Secret>(
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
                        return Serializer.Deserialize<Stellar.Curve25519Secret>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
