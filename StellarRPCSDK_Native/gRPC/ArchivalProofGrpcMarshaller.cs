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
    /// <summary>Custom marshaller for Stellar.ArchivalProof</summary>
    public static class ArchivalProofGrpcMarshaller
    {
        // Static constructor to configure type
        static ArchivalProofGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ArchivalProof
            if (!model.IsDefined(typeof(Stellar.ArchivalProof)))
            {
                var metaType = model.Add(typeof(Stellar.ArchivalProof), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "epoch");
                metaType.Add(2, "body");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ArchivalProof</summary>
        public static readonly Marshaller<Stellar.ArchivalProof> ArchivalProofMarshaller = Marshallers.Create<Stellar.ArchivalProof>(
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
                        return Serializer.Deserialize<Stellar.ArchivalProof>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
