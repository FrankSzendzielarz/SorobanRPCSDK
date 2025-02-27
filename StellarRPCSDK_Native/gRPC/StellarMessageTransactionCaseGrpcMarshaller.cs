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
    /// <summary>Custom marshaller for Stellar.StellarMessage+TransactionCase</summary>
    public static class StellarMessageTransactionCaseGrpcMarshaller
    {
        // Static constructor to configure type
        static StellarMessageTransactionCaseGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.StellarMessage.TransactionCase
            if (!model.IsDefined(typeof(Stellar.StellarMessage.TransactionCase)))
            {
                var metaType = model.Add(typeof(Stellar.StellarMessage.TransactionCase), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(9, "transaction");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TransactionCase</summary>
        public static readonly Marshaller<Stellar.StellarMessage.TransactionCase> TransactionCaseMarshaller = Marshallers.Create<Stellar.StellarMessage.TransactionCase>(
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
                        return Serializer.Deserialize<Stellar.StellarMessage.TransactionCase>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
