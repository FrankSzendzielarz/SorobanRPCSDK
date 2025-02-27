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
    /// <summary>Custom marshaller for Stellar.ArchivalProof+bodyUnion</summary>
    public static class ArchivalProofbodyUnionGrpcMarshaller
    {
        // Static constructor to configure type
        static ArchivalProofbodyUnionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ArchivalProof.bodyUnion
            if (!model.IsDefined(typeof(Stellar.ArchivalProof.bodyUnion)))
            {
                var metaType = model.Add(typeof(Stellar.ArchivalProof.bodyUnion), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.ArchivalProof.bodyUnion.Existence));
                metaType.AddSubType(101, typeof(Stellar.ArchivalProof.bodyUnion.Nonexistence));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for bodyUnion</summary>
        public static readonly Marshaller<Stellar.ArchivalProof.bodyUnion> bodyUnionMarshaller = Marshallers.Create<Stellar.ArchivalProof.bodyUnion>(
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
                        return Serializer.Deserialize<Stellar.ArchivalProof.bodyUnion>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
