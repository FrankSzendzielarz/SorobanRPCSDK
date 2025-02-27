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
    /// <summary>Custom marshaller for Stellar.LiquidityPoolConstantProductParameters</summary>
    public static class LiquidityPoolConstantProductParametersGrpcMarshaller
    {
        // Static constructor to configure type
        static LiquidityPoolConstantProductParametersGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LiquidityPoolConstantProductParameters
            if (!model.IsDefined(typeof(Stellar.LiquidityPoolConstantProductParameters)))
            {
                var metaType = model.Add(typeof(Stellar.LiquidityPoolConstantProductParameters), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "assetA");
                metaType.Add(2, "assetB");
                metaType.Add(3, "fee");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LiquidityPoolConstantProductParameters</summary>
        public static readonly Marshaller<Stellar.LiquidityPoolConstantProductParameters> LiquidityPoolConstantProductParametersMarshaller = Marshallers.Create<Stellar.LiquidityPoolConstantProductParameters>(
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
                        return Serializer.Deserialize<Stellar.LiquidityPoolConstantProductParameters>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
