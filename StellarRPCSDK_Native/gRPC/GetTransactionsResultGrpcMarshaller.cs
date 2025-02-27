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
    /// <summary>Custom marshaller for Stellar.RPC.GetTransactionsResult</summary>
    public static class GetTransactionsResultGrpcMarshaller
    {
        // Static constructor to configure type
        static GetTransactionsResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.GetTransactionsResult
            if (!model.IsDefined(typeof(Stellar.RPC.GetTransactionsResult)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.GetTransactionsResult), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Transactions");
                metaType.Add(2, "LatestLedger");
                metaType.Add(3, "LatestLedgerCloseTimestamp");
                metaType.Add(4, "OldestLedger");
                metaType.Add(5, "OldestLedgerCloseTimestamp");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.RPC.GetTransactionsResult</summary>
        public static readonly Marshaller<Stellar.RPC.GetTransactionsResult> GetTransactionsResultMarshaller = Marshallers.Create<Stellar.RPC.GetTransactionsResult>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetTransactionsResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
