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
    /// <summary>Custom marshaller for Stellar.SignerKey+ed25519SignedPayloadStruct</summary>
    public static class SignerKeyed25519SignedPayloadStructGrpcMarshaller
    {
        // Static constructor to configure type
        static SignerKeyed25519SignedPayloadStructGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SignerKey.ed25519SignedPayloadStruct
            if (!model.IsDefined(typeof(Stellar.SignerKey.ed25519SignedPayloadStruct)))
            {
                var metaType = model.Add(typeof(Stellar.SignerKey.ed25519SignedPayloadStruct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ed25519");
                metaType.Add(2, "payload");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ed25519SignedPayloadStruct</summary>
        public static readonly Marshaller<Stellar.SignerKey.ed25519SignedPayloadStruct> ed25519SignedPayloadStructMarshaller = Marshallers.Create<Stellar.SignerKey.ed25519SignedPayloadStruct>(
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
                        return Serializer.Deserialize<Stellar.SignerKey.ed25519SignedPayloadStruct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
