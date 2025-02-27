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
    /// <summary>Custom marshaller for Stellar.LiquidityPoolDepositOp</summary>
    public static class LiquidityPoolDepositOpGrpcMarshaller
    {
        // Static constructor to configure type
        static LiquidityPoolDepositOpGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LiquidityPoolDepositOp
            if (!model.IsDefined(typeof(Stellar.LiquidityPoolDepositOp)))
            {
                var metaType = model.Add(typeof(Stellar.LiquidityPoolDepositOp), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "liquidityPoolID");
                metaType.Add(2, "maxAmountA");
                metaType.Add(3, "maxAmountB");
                metaType.Add(4, "minPrice");
                metaType.Add(5, "maxPrice");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for LiquidityPoolDepositOp</summary>
        public static readonly Marshaller<Stellar.LiquidityPoolDepositOp> LiquidityPoolDepositOpMarshaller = Marshallers.Create<Stellar.LiquidityPoolDepositOp>(
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
                        return Serializer.Deserialize<Stellar.LiquidityPoolDepositOp>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
