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
    /// <summary>Custom marshaller for Stellar.TrustLineAsset</summary>
    public static class TrustLineAssetGrpcMarshaller
    {
        // Static constructor to configure type
        static TrustLineAssetGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TrustLineAsset
            if (!model.IsDefined(typeof(Stellar.TrustLineAsset)))
            {
                var metaType = model.Add(typeof(Stellar.TrustLineAsset), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.TrustLineAsset.AssetTypeNative));
                metaType.AddSubType(101, typeof(Stellar.TrustLineAsset.AssetTypeCreditAlphanum4));
                metaType.AddSubType(102, typeof(Stellar.TrustLineAsset.AssetTypeCreditAlphanum12));
                metaType.AddSubType(103, typeof(Stellar.TrustLineAsset.AssetTypePoolShare));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TrustLineAsset</summary>
        public static readonly Marshaller<Stellar.TrustLineAsset> TrustLineAssetMarshaller = Marshallers.Create<Stellar.TrustLineAsset>(
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
                        return Serializer.Deserialize<Stellar.TrustLineAsset>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
