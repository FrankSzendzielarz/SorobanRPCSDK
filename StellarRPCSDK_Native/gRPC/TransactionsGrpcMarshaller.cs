// Generated code - do not modify directly
using System;
using System.IO;
using System.Buffers;
using Grpc.Core;
using ProtoBuf;
using ProtoBuf.Meta;
using Stellar.RPC;

namespace Stellar.RPC.AOT
{
    /// <summary>Custom marshaller for Stellar.RPC.Transactions</summary>
    public static class TransactionsGrpcMarshaller
    {
        // Static constructor to configure type
        static TransactionsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.Transactions
            if (!model.IsDefined(typeof(Stellar.RPC.Transactions)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.Transactions), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Status");
                metaType.Add(2, "ApplicationOrder");
                metaType.Add(3, "FeeBump");
                metaType.Add(4, "EnvelopeXdr");
                metaType.Add(5, "ResultXdr");
                metaType.Add(6, "ResultMetaXdr");
                metaType.Add(7, "DiagnosticEventsXdr");
                metaType.Add(8, "Ledger");
                metaType.Add(9, "CreatedAt");
                metaType.Add(100, "TransactionResult");
                metaType.Add(101, "TransactionResultMeta");
                metaType.Add(102, "TransactionEnvelope");
                metaType.Add(103, "DiagnosticEvents");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Transactions</summary>
        public static readonly Marshaller<Stellar.RPC.Transactions> TransactionsMarshaller = Marshallers.Create<Stellar.RPC.Transactions>(
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
                        return Serializer.Deserialize<Stellar.RPC.Transactions>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
