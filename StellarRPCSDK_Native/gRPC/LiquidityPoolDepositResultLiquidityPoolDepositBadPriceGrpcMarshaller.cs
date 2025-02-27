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
    /// <summary>Custom marshaller for Stellar.LiquidityPoolDepositResult+LiquidityPoolDepositBadPrice</summary>
    public static class LiquidityPoolDepositResultLiquidityPoolDepositBadPriceGrpcMarshaller
    {
        // Static constructor to configure type
        static LiquidityPoolDepositResultLiquidityPoolDepositBadPriceGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositBadPrice
            if (!model.IsDefined(typeof(Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositBadPrice)))
            {
                var metaType = model.Add(typeof(Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositBadPrice), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LiquidityPoolDepositResult+LiquidityPoolDepositBadPrice</summary>
        public static readonly Marshaller<Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositBadPrice> LiquidityPoolDepositResult_LiquidityPoolDepositBadPriceMarshaller = Marshallers.Create<Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositBadPrice>(
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
                        return Serializer.Deserialize<Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositBadPrice>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
