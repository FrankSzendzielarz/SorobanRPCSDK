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
    /// <summary>Custom marshaller for Stellar.RPC.SimulateTransactionResult</summary>
    public static class SimulateTransactionResultGrpcMarshaller
    {
        // Static constructor to configure type
        static SimulateTransactionResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.SimulateTransactionResult
            if (!model.IsDefined(typeof(Stellar.RPC.SimulateTransactionResult)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.SimulateTransactionResult), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "LatestLedger");
                metaType.Add(2, "MinResourceFee");
                metaType.Add(3, "Cost");
                metaType.Add(4, "Results");
                metaType.Add(5, "TransactionData");
                metaType.Add(6, "Events");
                metaType.Add(7, "RestorePreamble");
                metaType.Add(8, "StateChanges");
                metaType.Add(9, "Error");
                metaType.Add(100, "SorobanTransactionData");
                metaType.Add(101, "DiagnosticEvents");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.RPC.SimulateTransactionResult</summary>
        public static readonly Marshaller<Stellar.RPC.SimulateTransactionResult> SimulateTransactionResultMarshaller = Marshallers.Create<Stellar.RPC.SimulateTransactionResult>(
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
                        return Serializer.Deserialize<Stellar.RPC.SimulateTransactionResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
