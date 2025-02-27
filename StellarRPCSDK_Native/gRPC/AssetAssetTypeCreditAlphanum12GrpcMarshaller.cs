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
    /// <summary>Custom marshaller for Stellar.Asset+AssetTypeCreditAlphanum12</summary>
    public static class AssetAssetTypeCreditAlphanum12GrpcMarshaller
    {
        // Static constructor to configure type
        static AssetAssetTypeCreditAlphanum12GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Asset.AssetTypeCreditAlphanum12
            if (!model.IsDefined(typeof(Stellar.Asset.AssetTypeCreditAlphanum12)))
            {
                var metaType = model.Add(typeof(Stellar.Asset.AssetTypeCreditAlphanum12), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(2, "alphaNum12");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.Asset+AssetTypeCreditAlphanum12</summary>
        public static readonly Marshaller<Stellar.Asset.AssetTypeCreditAlphanum12> Asset_AssetTypeCreditAlphanum12Marshaller = Marshallers.Create<Stellar.Asset.AssetTypeCreditAlphanum12>(
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
                        return Serializer.Deserialize<Stellar.Asset.AssetTypeCreditAlphanum12>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
