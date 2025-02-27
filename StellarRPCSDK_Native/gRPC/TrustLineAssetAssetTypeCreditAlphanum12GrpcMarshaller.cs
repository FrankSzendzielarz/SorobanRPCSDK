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
    /// <summary>Custom marshaller for Stellar.TrustLineAsset+AssetTypeCreditAlphanum12</summary>
    public static class TrustLineAssetAssetTypeCreditAlphanum12GrpcMarshaller
    {
        // Static constructor to configure type
        static TrustLineAssetAssetTypeCreditAlphanum12GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TrustLineAsset.AssetTypeCreditAlphanum12
            if (!model.IsDefined(typeof(Stellar.TrustLineAsset.AssetTypeCreditAlphanum12)))
            {
                var metaType = model.Add(typeof(Stellar.TrustLineAsset.AssetTypeCreditAlphanum12), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(2, "alphaNum12");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for AssetTypeCreditAlphanum12</summary>
        public static readonly Marshaller<Stellar.TrustLineAsset.AssetTypeCreditAlphanum12> AssetTypeCreditAlphanum12Marshaller = Marshallers.Create<Stellar.TrustLineAsset.AssetTypeCreditAlphanum12>(
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
                        return Serializer.Deserialize<Stellar.TrustLineAsset.AssetTypeCreditAlphanum12>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
