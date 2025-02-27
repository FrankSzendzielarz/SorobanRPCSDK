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
    /// <summary>Custom marshaller for Stellar.PersistedSCPStateV0</summary>
    public static class PersistedSCPStateV0GrpcMarshaller
    {
        // Static constructor to configure type
        static PersistedSCPStateV0GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PersistedSCPStateV0
            if (!model.IsDefined(typeof(Stellar.PersistedSCPStateV0)))
            {
                var metaType = model.Add(typeof(Stellar.PersistedSCPStateV0), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "scpEnvelopes");
                metaType.Add(2, "quorumSets");
                metaType.Add(3, "txSets");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.PersistedSCPStateV0</summary>
        public static readonly Marshaller<Stellar.PersistedSCPStateV0> PersistedSCPStateV0Marshaller = Marshallers.Create<Stellar.PersistedSCPStateV0>(
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
                        return Serializer.Deserialize<Stellar.PersistedSCPStateV0>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
