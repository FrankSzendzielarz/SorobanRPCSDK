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
    /// <summary>Custom marshaller for Stellar.HashIDPreimage+EnvelopeTypePoolRevokeOpId</summary>
    public static class HashIDPreimageEnvelopeTypePoolRevokeOpIdGrpcMarshaller
    {
        // Static constructor to configure type
        static HashIDPreimageEnvelopeTypePoolRevokeOpIdGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.HashIDPreimage.EnvelopeTypePoolRevokeOpId
            if (!model.IsDefined(typeof(Stellar.HashIDPreimage.EnvelopeTypePoolRevokeOpId)))
            {
                var metaType = model.Add(typeof(Stellar.HashIDPreimage.EnvelopeTypePoolRevokeOpId), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(2, "revokeID");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.HashIDPreimage+EnvelopeTypePoolRevokeOpId</summary>
        public static readonly Marshaller<Stellar.HashIDPreimage.EnvelopeTypePoolRevokeOpId> HashIDPreimage_EnvelopeTypePoolRevokeOpIdMarshaller = Marshallers.Create<Stellar.HashIDPreimage.EnvelopeTypePoolRevokeOpId>(
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
                        return Serializer.Deserialize<Stellar.HashIDPreimage.EnvelopeTypePoolRevokeOpId>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
