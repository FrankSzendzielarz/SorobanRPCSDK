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
    /// <summary>Custom marshaller for Stellar.ClaimLiquidityAtom</summary>
    public static class ClaimLiquidityAtomGrpcMarshaller
    {
        // Static constructor to configure type
        static ClaimLiquidityAtomGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ClaimLiquidityAtom
            if (!model.IsDefined(typeof(Stellar.ClaimLiquidityAtom)))
            {
                var metaType = model.Add(typeof(Stellar.ClaimLiquidityAtom), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "liquidityPoolID");
                metaType.Add(2, "assetSold");
                metaType.Add(3, "amountSold");
                metaType.Add(4, "assetBought");
                metaType.Add(5, "amountBought");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ClaimLiquidityAtom</summary>
        public static readonly Marshaller<Stellar.ClaimLiquidityAtom> ClaimLiquidityAtomMarshaller = Marshallers.Create<Stellar.ClaimLiquidityAtom>(
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
                        return Serializer.Deserialize<Stellar.ClaimLiquidityAtom>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
