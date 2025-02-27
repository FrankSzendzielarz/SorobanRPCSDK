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
    /// <summary>Custom marshaller for Stellar.TransactionSignaturePayload+taggedTransactionUnion+EnvelopeTypeTxFeeBump</summary>
    public static class TransactionSignaturePayloadtaggedTransactionUnionEnvelopeTypeTxFeeBumpGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionSignaturePayloadtaggedTransactionUnionEnvelopeTypeTxFeeBumpGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionSignaturePayload.taggedTransactionUnion.EnvelopeTypeTxFeeBump
            if (!model.IsDefined(typeof(Stellar.TransactionSignaturePayload.taggedTransactionUnion.EnvelopeTypeTxFeeBump)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionSignaturePayload.taggedTransactionUnion.EnvelopeTypeTxFeeBump), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(2, "feeBump");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.TransactionSignaturePayload+taggedTransactionUnion+EnvelopeTypeTxFeeBump</summary>
        public static readonly Marshaller<Stellar.TransactionSignaturePayload.taggedTransactionUnion.EnvelopeTypeTxFeeBump> TransactionSignaturePayload_taggedTransactionUnion_EnvelopeTypeTxFeeBumpMarshaller = Marshallers.Create<Stellar.TransactionSignaturePayload.taggedTransactionUnion.EnvelopeTypeTxFeeBump>(
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
                        return Serializer.Deserialize<Stellar.TransactionSignaturePayload.taggedTransactionUnion.EnvelopeTypeTxFeeBump>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
