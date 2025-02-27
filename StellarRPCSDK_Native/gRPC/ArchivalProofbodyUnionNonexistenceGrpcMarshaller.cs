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
    /// <summary>Custom marshaller for Stellar.ArchivalProof+bodyUnion+Nonexistence</summary>
    public static class ArchivalProofbodyUnionNonexistenceGrpcMarshaller
    {
        // Static constructor to configure type
        static ArchivalProofbodyUnionNonexistenceGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ArchivalProof.bodyUnion.Nonexistence
            if (!model.IsDefined(typeof(Stellar.ArchivalProof.bodyUnion.Nonexistence)))
            {
                var metaType = model.Add(typeof(Stellar.ArchivalProof.bodyUnion.Nonexistence), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(2, "existenceProof");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Nonexistence</summary>
        public static readonly Marshaller<Stellar.ArchivalProof.bodyUnion.Nonexistence> NonexistenceMarshaller = Marshallers.Create<Stellar.ArchivalProof.bodyUnion.Nonexistence>(
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
                        return Serializer.Deserialize<Stellar.ArchivalProof.bodyUnion.Nonexistence>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
