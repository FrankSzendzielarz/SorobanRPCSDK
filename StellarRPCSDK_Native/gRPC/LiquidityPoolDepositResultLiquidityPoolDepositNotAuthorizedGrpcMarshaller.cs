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
    /// <summary>Custom marshaller for Stellar.LiquidityPoolDepositResult+LiquidityPoolDepositNotAuthorized</summary>
    public static class LiquidityPoolDepositResultLiquidityPoolDepositNotAuthorizedGrpcMarshaller
    {
        // Static constructor to configure type
        static LiquidityPoolDepositResultLiquidityPoolDepositNotAuthorizedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositNotAuthorized
            if (!model.IsDefined(typeof(Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositNotAuthorized)))
            {
                var metaType = model.Add(typeof(Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositNotAuthorized), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LiquidityPoolDepositResult+LiquidityPoolDepositNotAuthorized</summary>
        public static readonly Marshaller<Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositNotAuthorized> LiquidityPoolDepositResult_LiquidityPoolDepositNotAuthorizedMarshaller = Marshallers.Create<Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositNotAuthorized>(
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
                        return Serializer.Deserialize<Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositNotAuthorized>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
