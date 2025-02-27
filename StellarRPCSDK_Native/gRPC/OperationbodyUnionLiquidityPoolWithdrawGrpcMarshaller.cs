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
    /// <summary>Custom marshaller for Stellar.Operation+bodyUnion+LiquidityPoolWithdraw</summary>
    public static class OperationbodyUnionLiquidityPoolWithdrawGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationbodyUnionLiquidityPoolWithdrawGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Operation.bodyUnion.LiquidityPoolWithdraw
            if (!model.IsDefined(typeof(Stellar.Operation.bodyUnion.LiquidityPoolWithdraw)))
            {
                var metaType = model.Add(typeof(Stellar.Operation.bodyUnion.LiquidityPoolWithdraw), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(22, "liquidityPoolWithdrawOp");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for LiquidityPoolWithdraw</summary>
        public static readonly Marshaller<Stellar.Operation.bodyUnion.LiquidityPoolWithdraw> LiquidityPoolWithdrawMarshaller = Marshallers.Create<Stellar.Operation.bodyUnion.LiquidityPoolWithdraw>(
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
                        return Serializer.Deserialize<Stellar.Operation.bodyUnion.LiquidityPoolWithdraw>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
