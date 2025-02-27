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
    /// <summary>Custom marshaller for Stellar.LiquidityPoolDepositResult+LiquidityPoolDepositMalformed</summary>
    public static class LiquidityPoolDepositResultLiquidityPoolDepositMalformedGrpcMarshaller
    {
        // Static constructor to configure type
        static LiquidityPoolDepositResultLiquidityPoolDepositMalformedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositMalformed
            if (!model.IsDefined(typeof(Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositMalformed)))
            {
                var metaType = model.Add(typeof(Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositMalformed), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for LiquidityPoolDepositMalformed</summary>
        public static readonly Marshaller<Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositMalformed> LiquidityPoolDepositMalformedMarshaller = Marshallers.Create<Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositMalformed>(
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
                        return Serializer.Deserialize<Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositMalformed>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
