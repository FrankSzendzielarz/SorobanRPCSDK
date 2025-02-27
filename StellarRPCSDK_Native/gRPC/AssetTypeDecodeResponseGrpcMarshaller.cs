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
    /// <summary>Custom marshaller for Stellar.AssetTypeDecodeResponse</summary>
    public static class AssetTypeDecodeResponseGrpcMarshaller
    {
        // Static constructor to configure type
        static AssetTypeDecodeResponseGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.AssetTypeDecodeResponse
            if (!model.IsDefined(typeof(Stellar.AssetTypeDecodeResponse)))
            {
                var metaType = model.Add(typeof(Stellar.AssetTypeDecodeResponse), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Value");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for AssetTypeDecodeResponse</summary>
        public static readonly Marshaller<Stellar.AssetTypeDecodeResponse> AssetTypeDecodeResponseMarshaller = Marshallers.Create<Stellar.AssetTypeDecodeResponse>(
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
                        return Serializer.Deserialize<Stellar.AssetTypeDecodeResponse>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
