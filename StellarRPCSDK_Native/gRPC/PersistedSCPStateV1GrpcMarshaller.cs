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
    /// <summary>Custom marshaller for Stellar.PersistedSCPStateV1</summary>
    public static class PersistedSCPStateV1GrpcMarshaller
    {
        // Static constructor to configure type
        static PersistedSCPStateV1GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PersistedSCPStateV1
            if (!model.IsDefined(typeof(Stellar.PersistedSCPStateV1)))
            {
                var metaType = model.Add(typeof(Stellar.PersistedSCPStateV1), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "scpEnvelopes");
                metaType.Add(2, "quorumSets");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.PersistedSCPStateV1</summary>
        public static readonly Marshaller<Stellar.PersistedSCPStateV1> PersistedSCPStateV1Marshaller = Marshallers.Create<Stellar.PersistedSCPStateV1>(
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
                        return Serializer.Deserialize<Stellar.PersistedSCPStateV1>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
