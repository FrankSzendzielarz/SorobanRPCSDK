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
    /// <summary>Custom marshaller for Stellar.LiquidityPoolDepositResult</summary>
    public static class LiquidityPoolDepositResultGrpcMarshaller
    {
        // Static constructor to configure type
        static LiquidityPoolDepositResultGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LiquidityPoolDepositResult
            if (!model.IsDefined(typeof(Stellar.LiquidityPoolDepositResult)))
            {
                var metaType = model.Add(typeof(Stellar.LiquidityPoolDepositResult), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositSuccess));
                metaType.AddSubType(101, typeof(Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositMalformed));
                metaType.AddSubType(102, typeof(Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositNoTrust));
                metaType.AddSubType(103, typeof(Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositNotAuthorized));
                metaType.AddSubType(104, typeof(Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositUnderfunded));
                metaType.AddSubType(105, typeof(Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositLineFull));
                metaType.AddSubType(106, typeof(Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositBadPrice));
                metaType.AddSubType(107, typeof(Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositPoolFull));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LiquidityPoolDepositResult</summary>
        public static readonly Marshaller<Stellar.LiquidityPoolDepositResult> LiquidityPoolDepositResultMarshaller = Marshallers.Create<Stellar.LiquidityPoolDepositResult>(
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
                        return Serializer.Deserialize<Stellar.LiquidityPoolDepositResult>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
