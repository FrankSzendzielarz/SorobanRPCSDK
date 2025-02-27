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
    /// <summary>Custom marshaller for Stellar.OperationResult+trUnion+LiquidityPoolDeposit</summary>
    public static class OperationResulttrUnionLiquidityPoolDepositGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationResulttrUnionLiquidityPoolDepositGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.OperationResult.trUnion.LiquidityPoolDeposit
            if (!model.IsDefined(typeof(Stellar.OperationResult.trUnion.LiquidityPoolDeposit)))
            {
                var metaType = model.Add(typeof(Stellar.OperationResult.trUnion.LiquidityPoolDeposit), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(23, "liquidityPoolDepositResult");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.OperationResult+trUnion+LiquidityPoolDeposit</summary>
        public static readonly Marshaller<Stellar.OperationResult.trUnion.LiquidityPoolDeposit> OperationResult_trUnion_LiquidityPoolDepositMarshaller = Marshallers.Create<Stellar.OperationResult.trUnion.LiquidityPoolDeposit>(
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
                        return Serializer.Deserialize<Stellar.OperationResult.trUnion.LiquidityPoolDeposit>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
