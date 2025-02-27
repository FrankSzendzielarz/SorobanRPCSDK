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
    /// <summary>Custom marshaller for Stellar.LiquidityPoolEntry+bodyUnion+constantProductStruct</summary>
    public static class LiquidityPoolEntrybodyUnionconstantProductStructGrpcMarshaller
    {
        // Static constructor to configure type
        static LiquidityPoolEntrybodyUnionconstantProductStructGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LiquidityPoolEntry.bodyUnion.constantProductStruct
            if (!model.IsDefined(typeof(Stellar.LiquidityPoolEntry.bodyUnion.constantProductStruct)))
            {
                var metaType = model.Add(typeof(Stellar.LiquidityPoolEntry.bodyUnion.constantProductStruct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "_params");
                metaType.Add(2, "reserveA");
                metaType.Add(3, "reserveB");
                metaType.Add(4, "totalPoolShares");
                metaType.Add(5, "poolSharesTrustLineCount");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.LiquidityPoolEntry+bodyUnion+constantProductStruct</summary>
        public static readonly Marshaller<Stellar.LiquidityPoolEntry.bodyUnion.constantProductStruct> LiquidityPoolEntry_bodyUnion_constantProductStructMarshaller = Marshallers.Create<Stellar.LiquidityPoolEntry.bodyUnion.constantProductStruct>(
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
                        return Serializer.Deserialize<Stellar.LiquidityPoolEntry.bodyUnion.constantProductStruct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
