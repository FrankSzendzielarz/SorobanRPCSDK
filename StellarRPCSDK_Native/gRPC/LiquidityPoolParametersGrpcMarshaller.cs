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
    /// <summary>Custom marshaller for Stellar.LiquidityPoolParameters</summary>
    public static class LiquidityPoolParametersGrpcMarshaller
    {
        // Static constructor to configure type
        static LiquidityPoolParametersGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LiquidityPoolParameters
            if (!model.IsDefined(typeof(Stellar.LiquidityPoolParameters)))
            {
                var metaType = model.Add(typeof(Stellar.LiquidityPoolParameters), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.LiquidityPoolParameters.LiquidityPoolConstantProduct));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for LiquidityPoolParameters</summary>
        public static readonly Marshaller<Stellar.LiquidityPoolParameters> LiquidityPoolParametersMarshaller = Marshallers.Create<Stellar.LiquidityPoolParameters>(
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
                        return Serializer.Deserialize<Stellar.LiquidityPoolParameters>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
