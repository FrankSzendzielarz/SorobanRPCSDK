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
    /// <summary>Custom marshaller for Stellar.ChangeTrustAsset</summary>
    public static class ChangeTrustAssetGrpcMarshaller
    {
        // Static constructor to configure type
        static ChangeTrustAssetGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ChangeTrustAsset
            if (!model.IsDefined(typeof(Stellar.ChangeTrustAsset)))
            {
                var metaType = model.Add(typeof(Stellar.ChangeTrustAsset), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.ChangeTrustAsset.AssetTypeNative));
                metaType.AddSubType(101, typeof(Stellar.ChangeTrustAsset.AssetTypeCreditAlphanum4));
                metaType.AddSubType(102, typeof(Stellar.ChangeTrustAsset.AssetTypeCreditAlphanum12));
                metaType.AddSubType(103, typeof(Stellar.ChangeTrustAsset.AssetTypePoolShare));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ChangeTrustAsset</summary>
        public static readonly Marshaller<Stellar.ChangeTrustAsset> ChangeTrustAssetMarshaller = Marshallers.Create<Stellar.ChangeTrustAsset>(
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
                        return Serializer.Deserialize<Stellar.ChangeTrustAsset>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
