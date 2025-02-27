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
    /// <summary>Custom marshaller for Stellar.Asset</summary>
    public static class AssetGrpcMarshaller
    {
        // Static constructor to configure type
        static AssetGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.Asset
            if (!model.IsDefined(typeof(Stellar.Asset)))
            {
                var metaType = model.Add(typeof(Stellar.Asset), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.Asset.AssetTypeNative));
                metaType.AddSubType(101, typeof(Stellar.Asset.AssetTypeCreditAlphanum4));
                metaType.AddSubType(102, typeof(Stellar.Asset.AssetTypeCreditAlphanum12));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Asset</summary>
        public static readonly Marshaller<Stellar.Asset> AssetMarshaller = Marshallers.Create<Stellar.Asset>(
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
                        return Serializer.Deserialize<Stellar.Asset>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
