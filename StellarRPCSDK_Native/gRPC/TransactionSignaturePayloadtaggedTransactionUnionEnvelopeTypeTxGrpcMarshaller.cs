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
    /// <summary>Custom marshaller for Stellar.TransactionSignaturePayload+taggedTransactionUnion+EnvelopeTypeTx</summary>
    public static class TransactionSignaturePayloadtaggedTransactionUnionEnvelopeTypeTxGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionSignaturePayloadtaggedTransactionUnionEnvelopeTypeTxGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionSignaturePayload.taggedTransactionUnion.EnvelopeTypeTx
            if (!model.IsDefined(typeof(Stellar.TransactionSignaturePayload.taggedTransactionUnion.EnvelopeTypeTx)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionSignaturePayload.taggedTransactionUnion.EnvelopeTypeTx), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "tx");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for EnvelopeTypeTx</summary>
        public static readonly Marshaller<Stellar.TransactionSignaturePayload.taggedTransactionUnion.EnvelopeTypeTx> EnvelopeTypeTxMarshaller = Marshallers.Create<Stellar.TransactionSignaturePayload.taggedTransactionUnion.EnvelopeTypeTx>(
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
                        return Serializer.Deserialize<Stellar.TransactionSignaturePayload.taggedTransactionUnion.EnvelopeTypeTx>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
