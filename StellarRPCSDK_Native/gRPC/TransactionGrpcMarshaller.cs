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
    /// <summary>Custom marshaller for Stellar.Transaction</summary>
    public static class TransactionGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Transaction
            if (!model.IsDefined(typeof(Stellar.Transaction)))
            {
                var metaType = model.Add(typeof(Stellar.Transaction), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "sourceAccount");
                metaType.Add(2, "fee");
                metaType.Add(3, "seqNum");
                metaType.Add(4, "cond");
                metaType.Add(5, "memo");
                metaType.Add(6, "operations");
                metaType.Add(7, "ext");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Transaction</summary>
        public static readonly Marshaller<Stellar.Transaction> TransactionMarshaller = Marshallers.Create<Stellar.Transaction>(
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
                        return Serializer.Deserialize<Stellar.Transaction>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
