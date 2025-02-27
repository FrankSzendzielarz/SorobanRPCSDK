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
    /// <summary>Custom marshaller for Stellar.TrustLineAsset+AssetTypeNative</summary>
    public static class TrustLineAssetAssetTypeNativeGrpcMarshaller
    {
        // Static constructor to configure type
        static TrustLineAssetAssetTypeNativeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TrustLineAsset.AssetTypeNative
            if (!model.IsDefined(typeof(Stellar.TrustLineAsset.AssetTypeNative)))
            {
                var metaType = model.Add(typeof(Stellar.TrustLineAsset.AssetTypeNative), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.TrustLineAsset+AssetTypeNative</summary>
        public static readonly Marshaller<Stellar.TrustLineAsset.AssetTypeNative> TrustLineAsset_AssetTypeNativeMarshaller = Marshallers.Create<Stellar.TrustLineAsset.AssetTypeNative>(
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
                        return Serializer.Deserialize<Stellar.TrustLineAsset.AssetTypeNative>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
