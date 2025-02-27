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
    /// <summary>Custom marshaller for Stellar.LedgerKey+LiquidityPool</summary>
    public static class LedgerKeyLiquidityPoolGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerKeyLiquidityPoolGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerKey.LiquidityPool
            if (!model.IsDefined(typeof(Stellar.LedgerKey.LiquidityPool)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerKey.LiquidityPool), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(6, "liquidityPool");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LedgerKey+LiquidityPool</summary>
        public static readonly Marshaller<Stellar.LedgerKey.LiquidityPool> LedgerKey_LiquidityPoolMarshaller = Marshallers.Create<Stellar.LedgerKey.LiquidityPool>(
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
                        return Serializer.Deserialize<Stellar.LedgerKey.LiquidityPool>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
