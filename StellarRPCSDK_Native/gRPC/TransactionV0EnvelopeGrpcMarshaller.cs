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
    /// <summary>Custom marshaller for Stellar.TransactionV0Envelope</summary>
    public static class TransactionV0EnvelopeGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionV0EnvelopeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TransactionV0Envelope
            if (!model.IsDefined(typeof(Stellar.TransactionV0Envelope)))
            {
                var metaType = model.Add(typeof(Stellar.TransactionV0Envelope), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "tx");
                metaType.Add(2, "signatures");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TransactionV0Envelope</summary>
        public static readonly Marshaller<Stellar.TransactionV0Envelope> TransactionV0EnvelopeMarshaller = Marshallers.Create<Stellar.TransactionV0Envelope>(
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
                        return Serializer.Deserialize<Stellar.TransactionV0Envelope>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
