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
    /// <summary>Custom marshaller for Stellar.LiquidityPoolDepositResult+LiquidityPoolDepositUnderfunded</summary>
    public static class LiquidityPoolDepositResultLiquidityPoolDepositUnderfundedGrpcMarshaller
    {
        // Static constructor to configure type
        static LiquidityPoolDepositResultLiquidityPoolDepositUnderfundedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositUnderfunded
            if (!model.IsDefined(typeof(Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositUnderfunded)))
            {
                var metaType = model.Add(typeof(Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositUnderfunded), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for LiquidityPoolDepositUnderfunded</summary>
        public static readonly Marshaller<Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositUnderfunded> LiquidityPoolDepositUnderfundedMarshaller = Marshallers.Create<Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositUnderfunded>(
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
                        return Serializer.Deserialize<Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositUnderfunded>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
