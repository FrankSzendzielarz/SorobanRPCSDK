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
    /// <summary>Custom marshaller for Stellar.HashIDPreimage+EnvelopeTypeOpId</summary>
    public static class HashIDPreimageEnvelopeTypeOpIdGrpcMarshaller
    {
        // Static constructor to configure type
        static HashIDPreimageEnvelopeTypeOpIdGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.HashIDPreimage.EnvelopeTypeOpId
            if (!model.IsDefined(typeof(Stellar.HashIDPreimage.EnvelopeTypeOpId)))
            {
                var metaType = model.Add(typeof(Stellar.HashIDPreimage.EnvelopeTypeOpId), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "operationID");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for EnvelopeTypeOpId</summary>
        public static readonly Marshaller<Stellar.HashIDPreimage.EnvelopeTypeOpId> EnvelopeTypeOpIdMarshaller = Marshallers.Create<Stellar.HashIDPreimage.EnvelopeTypeOpId>(
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
                        return Serializer.Deserialize<Stellar.HashIDPreimage.EnvelopeTypeOpId>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
