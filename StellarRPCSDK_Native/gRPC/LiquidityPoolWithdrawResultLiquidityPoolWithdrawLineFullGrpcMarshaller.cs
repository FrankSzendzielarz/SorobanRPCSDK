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
    /// <summary>Custom marshaller for Stellar.LiquidityPoolWithdrawResult+LiquidityPoolWithdrawLineFull</summary>
    public static class LiquidityPoolWithdrawResultLiquidityPoolWithdrawLineFullGrpcMarshaller
    {
        // Static constructor to configure type
        static LiquidityPoolWithdrawResultLiquidityPoolWithdrawLineFullGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LiquidityPoolWithdrawResult.LiquidityPoolWithdrawLineFull
            if (!model.IsDefined(typeof(Stellar.LiquidityPoolWithdrawResult.LiquidityPoolWithdrawLineFull)))
            {
                var metaType = model.Add(typeof(Stellar.LiquidityPoolWithdrawResult.LiquidityPoolWithdrawLineFull), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for LiquidityPoolWithdrawLineFull</summary>
        public static readonly Marshaller<Stellar.LiquidityPoolWithdrawResult.LiquidityPoolWithdrawLineFull> LiquidityPoolWithdrawLineFullMarshaller = Marshallers.Create<Stellar.LiquidityPoolWithdrawResult.LiquidityPoolWithdrawLineFull>(
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
                        return Serializer.Deserialize<Stellar.LiquidityPoolWithdrawResult.LiquidityPoolWithdrawLineFull>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
