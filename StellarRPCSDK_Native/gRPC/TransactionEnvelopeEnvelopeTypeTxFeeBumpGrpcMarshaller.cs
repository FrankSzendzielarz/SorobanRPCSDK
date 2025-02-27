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
    /// <summary>Custom marshaller for Stellar.TransactionEnvelope+EnvelopeTypeTxFeeBump</summary>
    public static class TransactionEnvelopeEnvelopeTypeTxFeeBumpGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionEnvelopeEnvelopeTypeTxFeeBumpGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionEnvelope.EnvelopeTypeTxFeeBump
            if (!model.IsDefined(typeof(Stellar.TransactionEnvelope.EnvelopeTypeTxFeeBump)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionEnvelope.EnvelopeTypeTxFeeBump), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(3, "feeBump");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for EnvelopeTypeTxFeeBump</summary>
        public static readonly Marshaller<Stellar.TransactionEnvelope.EnvelopeTypeTxFeeBump> EnvelopeTypeTxFeeBumpMarshaller = Marshallers.Create<Stellar.TransactionEnvelope.EnvelopeTypeTxFeeBump>(
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
                        return Serializer.Deserialize<Stellar.TransactionEnvelope.EnvelopeTypeTxFeeBump>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
