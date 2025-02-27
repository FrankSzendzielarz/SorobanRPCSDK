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
    /// <summary>Custom marshaller for Stellar.TransactionSignaturePayload</summary>
    public static class TransactionSignaturePayloadGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionSignaturePayloadGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionSignaturePayload
            if (!model.IsDefined(typeof(Stellar.TransactionSignaturePayload)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionSignaturePayload), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "networkId");
                metaType.Add(2, "taggedTransaction");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.TransactionSignaturePayload</summary>
        public static readonly Marshaller<Stellar.TransactionSignaturePayload> TransactionSignaturePayloadMarshaller = Marshallers.Create<Stellar.TransactionSignaturePayload>(
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
                        return Serializer.Deserialize<Stellar.TransactionSignaturePayload>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
