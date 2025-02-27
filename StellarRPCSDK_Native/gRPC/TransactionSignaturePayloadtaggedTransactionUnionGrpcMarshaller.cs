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
    /// <summary>Custom marshaller for Stellar.TransactionSignaturePayload+taggedTransactionUnion</summary>
    public static class TransactionSignaturePayloadtaggedTransactionUnionGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionSignaturePayloadtaggedTransactionUnionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionSignaturePayload.taggedTransactionUnion
            if (!model.IsDefined(typeof(Stellar.TransactionSignaturePayload.taggedTransactionUnion)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionSignaturePayload.taggedTransactionUnion), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.TransactionSignaturePayload.taggedTransactionUnion.EnvelopeTypeTx));
                metaType.AddSubType(101, typeof(Stellar.TransactionSignaturePayload.taggedTransactionUnion.EnvelopeTypeTxFeeBump));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for taggedTransactionUnion</summary>
        public static readonly Marshaller<Stellar.TransactionSignaturePayload.taggedTransactionUnion> taggedTransactionUnionMarshaller = Marshallers.Create<Stellar.TransactionSignaturePayload.taggedTransactionUnion>(
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
                        return Serializer.Deserialize<Stellar.TransactionSignaturePayload.taggedTransactionUnion>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
