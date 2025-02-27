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
    /// <summary>Custom marshaller for Stellar.AssetCode</summary>
    public static class AssetCodeGrpcMarshaller
    {
        // Static constructor to configure type
        static AssetCodeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.AssetCode
            if (!model.IsDefined(typeof(Stellar.AssetCode)))
            {
                var metaType = model.Add(typeof(Stellar.AssetCode), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.AssetCode.AssetTypeCreditAlphanum4));
                metaType.AddSubType(101, typeof(Stellar.AssetCode.AssetTypeCreditAlphanum12));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.AssetCode</summary>
        public static readonly Marshaller<Stellar.AssetCode> AssetCodeMarshaller = Marshallers.Create<Stellar.AssetCode>(
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
                        return Serializer.Deserialize<Stellar.AssetCode>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
