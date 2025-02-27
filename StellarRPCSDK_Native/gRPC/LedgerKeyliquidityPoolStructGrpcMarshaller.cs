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
    /// <summary>Custom marshaller for Stellar.LedgerKey+liquidityPoolStruct</summary>
    public static class LedgerKeyliquidityPoolStructGrpcMarshaller
    {
        // Static constructor to configure type
        static LedgerKeyliquidityPoolStructGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.LedgerKey.liquidityPoolStruct
            if (!model.IsDefined(typeof(Stellar.LedgerKey.liquidityPoolStruct)))
            {
                var metaType = model.Add(typeof(Stellar.LedgerKey.liquidityPoolStruct), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "liquidityPoolID");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for liquidityPoolStruct</summary>
        public static readonly Marshaller<Stellar.LedgerKey.liquidityPoolStruct> liquidityPoolStructMarshaller = Marshallers.Create<Stellar.LedgerKey.liquidityPoolStruct>(
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
                        return Serializer.Deserialize<Stellar.LedgerKey.liquidityPoolStruct>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
