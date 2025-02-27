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
    /// <summary>Custom marshaller for Stellar.LiquidityPoolWithdrawResult</summary>
    public static class LiquidityPoolWithdrawResultGrpcMarshaller
    {
        // Static constructor to configure type
        static LiquidityPoolWithdrawResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LiquidityPoolWithdrawResult
            if (!model.IsDefined(typeof(Stellar.LiquidityPoolWithdrawResult)))
            {
                var metaType = model.Add(typeof(Stellar.LiquidityPoolWithdrawResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.LiquidityPoolWithdrawResult.LiquidityPoolWithdrawSuccess));
                metaType.AddSubType(101, typeof(Stellar.LiquidityPoolWithdrawResult.LiquidityPoolWithdrawMalformed));
                metaType.AddSubType(102, typeof(Stellar.LiquidityPoolWithdrawResult.LiquidityPoolWithdrawNoTrust));
                metaType.AddSubType(103, typeof(Stellar.LiquidityPoolWithdrawResult.LiquidityPoolWithdrawUnderfunded));
                metaType.AddSubType(104, typeof(Stellar.LiquidityPoolWithdrawResult.LiquidityPoolWithdrawLineFull));
                metaType.AddSubType(105, typeof(Stellar.LiquidityPoolWithdrawResult.LiquidityPoolWithdrawUnderMinimum));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for LiquidityPoolWithdrawResult</summary>
        public static readonly Marshaller<Stellar.LiquidityPoolWithdrawResult> LiquidityPoolWithdrawResultMarshaller = Marshallers.Create<Stellar.LiquidityPoolWithdrawResult>(
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
                        return Serializer.Deserialize<Stellar.LiquidityPoolWithdrawResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
