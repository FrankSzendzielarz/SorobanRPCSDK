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
    /// <summary>Custom marshaller for Stellar.LiquidityPoolConstantProductParametersEncodeResponse</summary>
    public static class LiquidityPoolConstantProductParametersEncodeResponseGrpcMarshaller
    {
        // Static constructor to configure type
        static LiquidityPoolConstantProductParametersEncodeResponseGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LiquidityPoolConstantProductParametersEncodeResponse
            if (!model.IsDefined(typeof(Stellar.LiquidityPoolConstantProductParametersEncodeResponse)))
            {
                var metaType = model.Add(typeof(Stellar.LiquidityPoolConstantProductParametersEncodeResponse), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "EncodedValue");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for LiquidityPoolConstantProductParametersEncodeResponse</summary>
        public static readonly Marshaller<Stellar.LiquidityPoolConstantProductParametersEncodeResponse> LiquidityPoolConstantProductParametersEncodeResponseMarshaller = Marshallers.Create<Stellar.LiquidityPoolConstantProductParametersEncodeResponse>(
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
                        return Serializer.Deserialize<Stellar.LiquidityPoolConstantProductParametersEncodeResponse>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
