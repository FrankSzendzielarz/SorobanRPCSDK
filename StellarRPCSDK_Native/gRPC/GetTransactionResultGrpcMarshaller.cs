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
    /// <summary>Custom marshaller for Stellar.RPC.GetTransactionResult</summary>
    public static class GetTransactionResultGrpcMarshaller
    {
        // Static constructor to configure type
        static GetTransactionResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.GetTransactionResult
            if (!model.IsDefined(typeof(Stellar.RPC.GetTransactionResult)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.GetTransactionResult), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Status");
                metaType.Add(2, "LatestLedger");
                metaType.Add(3, "LatestLedgerCloseTime");
                metaType.Add(4, "OldestLedger");
                metaType.Add(5, "OldestLedgerCloseTime");
                metaType.Add(6, "Ledger");
                metaType.Add(7, "CreatedAt");
                metaType.Add(8, "ApplicationOrder");
                metaType.Add(9, "FeeBump");
                metaType.Add(10, "EnvelopeXdr");
                metaType.Add(11, "ResultXdr");
                metaType.Add(12, "ResultMetaXdr");
                metaType.Add(100, "TransactionResult");
                metaType.Add(101, "TransactionResultMeta");
                metaType.Add(102, "TransactionEnvelope");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for GetTransactionResult</summary>
        public static readonly Marshaller<Stellar.RPC.GetTransactionResult> GetTransactionResultMarshaller = Marshallers.Create<Stellar.RPC.GetTransactionResult>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetTransactionResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
