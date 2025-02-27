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
    /// <summary>Custom marshaller for Stellar.LiquidityPoolWithdrawResult+LiquidityPoolWithdrawMalformed</summary>
    public static class LiquidityPoolWithdrawResultLiquidityPoolWithdrawMalformedGrpcMarshaller
    {
        // Static constructor to configure type
        static LiquidityPoolWithdrawResultLiquidityPoolWithdrawMalformedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LiquidityPoolWithdrawResult.LiquidityPoolWithdrawMalformed
            if (!model.IsDefined(typeof(Stellar.LiquidityPoolWithdrawResult.LiquidityPoolWithdrawMalformed)))
            {
                var metaType = model.Add(typeof(Stellar.LiquidityPoolWithdrawResult.LiquidityPoolWithdrawMalformed), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for LiquidityPoolWithdrawMalformed</summary>
        public static readonly Marshaller<Stellar.LiquidityPoolWithdrawResult.LiquidityPoolWithdrawMalformed> LiquidityPoolWithdrawMalformedMarshaller = Marshallers.Create<Stellar.LiquidityPoolWithdrawResult.LiquidityPoolWithdrawMalformed>(
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
                        return Serializer.Deserialize<Stellar.LiquidityPoolWithdrawResult.LiquidityPoolWithdrawMalformed>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
