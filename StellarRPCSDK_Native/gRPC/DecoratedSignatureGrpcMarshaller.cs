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
    /// <summary>Custom marshaller for Stellar.DecoratedSignature</summary>
    public static class DecoratedSignatureGrpcMarshaller
    {
        // Static constructor to configure type
        static DecoratedSignatureGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.DecoratedSignature
            if (!model.IsDefined(typeof(Stellar.DecoratedSignature)))
            {
                var metaType = model.Add(typeof(Stellar.DecoratedSignature), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "hint");
                metaType.Add(2, "signature");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.DecoratedSignature</summary>
        public static readonly Marshaller<Stellar.DecoratedSignature> DecoratedSignatureMarshaller = Marshallers.Create<Stellar.DecoratedSignature>(
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
                        return Serializer.Deserialize<Stellar.DecoratedSignature>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
