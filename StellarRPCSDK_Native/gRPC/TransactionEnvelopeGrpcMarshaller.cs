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
    /// <summary>Custom marshaller for Stellar.TransactionEnvelope</summary>
    public static class TransactionEnvelopeGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionEnvelopeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionEnvelope
            if (!model.IsDefined(typeof(Stellar.TransactionEnvelope)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionEnvelope), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.TransactionEnvelope.EnvelopeTypeTxV0));
                metaType.AddSubType(101, typeof(Stellar.TransactionEnvelope.EnvelopeTypeTx));
                metaType.AddSubType(102, typeof(Stellar.TransactionEnvelope.EnvelopeTypeTxFeeBump));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TransactionEnvelope</summary>
        public static readonly Marshaller<Stellar.TransactionEnvelope> TransactionEnvelopeMarshaller = Marshallers.Create<Stellar.TransactionEnvelope>(
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
                        return Serializer.Deserialize<Stellar.TransactionEnvelope>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
