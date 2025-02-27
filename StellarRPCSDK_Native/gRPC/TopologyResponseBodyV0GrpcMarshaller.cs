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
    /// <summary>Custom marshaller for Stellar.TopologyResponseBodyV0</summary>
    public static class TopologyResponseBodyV0GrpcMarshaller
    {
        // Static constructor to configure type
        static TopologyResponseBodyV0GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TopologyResponseBodyV0
            if (!model.IsDefined(typeof(Stellar.TopologyResponseBodyV0)))
            {
                var metaType = model.Add(typeof(Stellar.TopologyResponseBodyV0), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "inboundPeers");
                metaType.Add(2, "outboundPeers");
                metaType.Add(3, "totalInboundPeerCount");
                metaType.Add(4, "totalOutboundPeerCount");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.TopologyResponseBodyV0</summary>
        public static readonly Marshaller<Stellar.TopologyResponseBodyV0> TopologyResponseBodyV0Marshaller = Marshallers.Create<Stellar.TopologyResponseBodyV0>(
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
                        return Serializer.Deserialize<Stellar.TopologyResponseBodyV0>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
