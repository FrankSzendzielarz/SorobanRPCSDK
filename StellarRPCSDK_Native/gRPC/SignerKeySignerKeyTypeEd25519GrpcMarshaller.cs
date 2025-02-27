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
    /// <summary>Custom marshaller for Stellar.SignerKey+SignerKeyTypeEd25519</summary>
    public static class SignerKeySignerKeyTypeEd25519GrpcMarshaller
    {
        // Static constructor to configure type
        static SignerKeySignerKeyTypeEd25519GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SignerKey.SignerKeyTypeEd25519
            if (!model.IsDefined(typeof(Stellar.SignerKey.SignerKeyTypeEd25519)))
            {
                var metaType = model.Add(typeof(Stellar.SignerKey.SignerKeyTypeEd25519), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ed25519");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SignerKey+SignerKeyTypeEd25519</summary>
        public static readonly Marshaller<Stellar.SignerKey.SignerKeyTypeEd25519> SignerKey_SignerKeyTypeEd25519Marshaller = Marshallers.Create<Stellar.SignerKey.SignerKeyTypeEd25519>(
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
                        return Serializer.Deserialize<Stellar.SignerKey.SignerKeyTypeEd25519>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
