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
    /// <summary>Custom marshaller for Stellar.ChangeTrustAsset+AssetTypePoolShare</summary>
    public static class ChangeTrustAssetAssetTypePoolShareGrpcMarshaller
    {
        // Static constructor to configure type
        static ChangeTrustAssetAssetTypePoolShareGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ChangeTrustAsset.AssetTypePoolShare
            if (!model.IsDefined(typeof(Stellar.ChangeTrustAsset.AssetTypePoolShare)))
            {
                var metaType = model.Add(typeof(Stellar.ChangeTrustAsset.AssetTypePoolShare), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(3, "liquidityPool");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for AssetTypePoolShare</summary>
        public static readonly Marshaller<Stellar.ChangeTrustAsset.AssetTypePoolShare> AssetTypePoolShareMarshaller = Marshallers.Create<Stellar.ChangeTrustAsset.AssetTypePoolShare>(
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
                        return Serializer.Deserialize<Stellar.ChangeTrustAsset.AssetTypePoolShare>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
