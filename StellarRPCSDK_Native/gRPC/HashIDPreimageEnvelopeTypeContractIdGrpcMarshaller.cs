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
    /// <summary>Custom marshaller for Stellar.HashIDPreimage+EnvelopeTypeContractId</summary>
    public static class HashIDPreimageEnvelopeTypeContractIdGrpcMarshaller
    {
        // Static constructor to configure type
        static HashIDPreimageEnvelopeTypeContractIdGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.HashIDPreimage.EnvelopeTypeContractId
            if (!model.IsDefined(typeof(Stellar.HashIDPreimage.EnvelopeTypeContractId)))
            {
                var metaType = model.Add(typeof(Stellar.HashIDPreimage.EnvelopeTypeContractId), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(3, "contractID");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for EnvelopeTypeContractId</summary>
        public static readonly Marshaller<Stellar.HashIDPreimage.EnvelopeTypeContractId> EnvelopeTypeContractIdMarshaller = Marshallers.Create<Stellar.HashIDPreimage.EnvelopeTypeContractId>(
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
                        return Serializer.Deserialize<Stellar.HashIDPreimage.EnvelopeTypeContractId>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
