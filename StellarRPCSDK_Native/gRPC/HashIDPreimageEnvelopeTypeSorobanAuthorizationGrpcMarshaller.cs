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
    /// <summary>Custom marshaller for Stellar.HashIDPreimage+EnvelopeTypeSorobanAuthorization</summary>
    public static class HashIDPreimageEnvelopeTypeSorobanAuthorizationGrpcMarshaller
    {
        // Static constructor to configure type
        static HashIDPreimageEnvelopeTypeSorobanAuthorizationGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.HashIDPreimage.EnvelopeTypeSorobanAuthorization
            if (!model.IsDefined(typeof(Stellar.HashIDPreimage.EnvelopeTypeSorobanAuthorization)))
            {
                var metaType = model.Add(typeof(Stellar.HashIDPreimage.EnvelopeTypeSorobanAuthorization), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(4, "sorobanAuthorization");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.HashIDPreimage+EnvelopeTypeSorobanAuthorization</summary>
        public static readonly Marshaller<Stellar.HashIDPreimage.EnvelopeTypeSorobanAuthorization> HashIDPreimage_EnvelopeTypeSorobanAuthorizationMarshaller = Marshallers.Create<Stellar.HashIDPreimage.EnvelopeTypeSorobanAuthorization>(
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
                        return Serializer.Deserialize<Stellar.HashIDPreimage.EnvelopeTypeSorobanAuthorization>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
