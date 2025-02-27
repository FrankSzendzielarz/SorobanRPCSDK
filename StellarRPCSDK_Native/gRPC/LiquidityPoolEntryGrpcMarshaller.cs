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
    /// <summary>Custom marshaller for Stellar.LiquidityPoolEntry</summary>
    public static class LiquidityPoolEntryGrpcMarshaller
    {
        // Static constructor to configure type
        static LiquidityPoolEntryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LiquidityPoolEntry
            if (!model.IsDefined(typeof(Stellar.LiquidityPoolEntry)))
            {
                var metaType = model.Add(typeof(Stellar.LiquidityPoolEntry), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "liquidityPoolID");
                metaType.Add(2, "body");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for LiquidityPoolEntry</summary>
        public static readonly Marshaller<Stellar.LiquidityPoolEntry> LiquidityPoolEntryMarshaller = Marshallers.Create<Stellar.LiquidityPoolEntry>(
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
                        return Serializer.Deserialize<Stellar.LiquidityPoolEntry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
