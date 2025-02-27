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
    /// <summary>Custom marshaller for Stellar.LiquidityPoolEntry+bodyUnion</summary>
    public static class LiquidityPoolEntrybodyUnionGrpcMarshaller
    {
        // Static constructor to configure type
        static LiquidityPoolEntrybodyUnionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LiquidityPoolEntry.bodyUnion
            if (!model.IsDefined(typeof(Stellar.LiquidityPoolEntry.bodyUnion)))
            {
                var metaType = model.Add(typeof(Stellar.LiquidityPoolEntry.bodyUnion), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.LiquidityPoolEntry.bodyUnion.LiquidityPoolConstantProduct));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LiquidityPoolEntry+bodyUnion</summary>
        public static readonly Marshaller<Stellar.LiquidityPoolEntry.bodyUnion> LiquidityPoolEntry_bodyUnionMarshaller = Marshallers.Create<Stellar.LiquidityPoolEntry.bodyUnion>(
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
                        return Serializer.Deserialize<Stellar.LiquidityPoolEntry.bodyUnion>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
