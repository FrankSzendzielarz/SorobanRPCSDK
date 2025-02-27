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
    /// <summary>Custom marshaller for Stellar.TransactionV1Envelope</summary>
    public static class TransactionV1EnvelopeGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionV1EnvelopeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionV1Envelope
            if (!model.IsDefined(typeof(Stellar.TransactionV1Envelope)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionV1Envelope), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "tx");
                metaType.Add(2, "signatures");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TransactionV1Envelope</summary>
        public static readonly Marshaller<Stellar.TransactionV1Envelope> TransactionV1EnvelopeMarshaller = Marshallers.Create<Stellar.TransactionV1Envelope>(
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
                        return Serializer.Deserialize<Stellar.TransactionV1Envelope>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
