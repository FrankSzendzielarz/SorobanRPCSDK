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
    /// <summary>Custom marshaller for Stellar.LiquidityPoolDepositResult+LiquidityPoolDepositNoTrust</summary>
    public static class LiquidityPoolDepositResultLiquidityPoolDepositNoTrustGrpcMarshaller
    {
        // Static constructor to configure type
        static LiquidityPoolDepositResultLiquidityPoolDepositNoTrustGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositNoTrust
            if (!model.IsDefined(typeof(Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositNoTrust)))
            {
                var metaType = model.Add(typeof(Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositNoTrust), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LiquidityPoolDepositResult+LiquidityPoolDepositNoTrust</summary>
        public static readonly Marshaller<Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositNoTrust> LiquidityPoolDepositResult_LiquidityPoolDepositNoTrustMarshaller = Marshallers.Create<Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositNoTrust>(
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
                        return Serializer.Deserialize<Stellar.LiquidityPoolDepositResult.LiquidityPoolDepositNoTrust>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
