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
    /// <summary>Custom marshaller for Stellar.PublicKey+PublicKeyTypeEd25519</summary>
    public static class PublicKeyPublicKeyTypeEd25519GrpcMarshaller
    {
        // Static constructor to configure type
        static PublicKeyPublicKeyTypeEd25519GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PublicKey.PublicKeyTypeEd25519
            if (!model.IsDefined(typeof(Stellar.PublicKey.PublicKeyTypeEd25519)))
            {
                var metaType = model.Add(typeof(Stellar.PublicKey.PublicKeyTypeEd25519), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ed25519");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for PublicKeyTypeEd25519</summary>
        public static readonly Marshaller<Stellar.PublicKey.PublicKeyTypeEd25519> PublicKeyTypeEd25519Marshaller = Marshallers.Create<Stellar.PublicKey.PublicKeyTypeEd25519>(
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
                        return Serializer.Deserialize<Stellar.PublicKey.PublicKeyTypeEd25519>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
