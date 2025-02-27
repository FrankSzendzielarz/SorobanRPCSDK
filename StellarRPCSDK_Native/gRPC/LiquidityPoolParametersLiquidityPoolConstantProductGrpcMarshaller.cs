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
    /// <summary>Custom marshaller for Stellar.LiquidityPoolParameters+LiquidityPoolConstantProduct</summary>
    public static class LiquidityPoolParametersLiquidityPoolConstantProductGrpcMarshaller
    {
        // Static constructor to configure type
        static LiquidityPoolParametersLiquidityPoolConstantProductGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LiquidityPoolParameters.LiquidityPoolConstantProduct
            if (!model.IsDefined(typeof(Stellar.LiquidityPoolParameters.LiquidityPoolConstantProduct)))
            {
                var metaType = model.Add(typeof(Stellar.LiquidityPoolParameters.LiquidityPoolConstantProduct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "constantProduct");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for LiquidityPoolConstantProduct</summary>
        public static readonly Marshaller<Stellar.LiquidityPoolParameters.LiquidityPoolConstantProduct> LiquidityPoolConstantProductMarshaller = Marshallers.Create<Stellar.LiquidityPoolParameters.LiquidityPoolConstantProduct>(
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
                        return Serializer.Deserialize<Stellar.LiquidityPoolParameters.LiquidityPoolConstantProduct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
