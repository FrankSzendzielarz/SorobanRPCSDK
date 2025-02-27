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
    /// <summary>Custom marshaller for Stellar.TopologyResponseBodyV1</summary>
    public static class TopologyResponseBodyV1GrpcMarshaller
    {
        // Static constructor to configure type
        static TopologyResponseBodyV1GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TopologyResponseBodyV1
            if (!model.IsDefined(typeof(Stellar.TopologyResponseBodyV1)))
            {
                var metaType = model.Add(typeof(Stellar.TopologyResponseBodyV1), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "inboundPeers");
                metaType.Add(2, "outboundPeers");
                metaType.Add(3, "totalInboundPeerCount");
                metaType.Add(4, "totalOutboundPeerCount");
                metaType.Add(5, "maxInboundPeerCount");
                metaType.Add(6, "maxOutboundPeerCount");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TopologyResponseBodyV1</summary>
        public static readonly Marshaller<Stellar.TopologyResponseBodyV1> TopologyResponseBodyV1Marshaller = Marshallers.Create<Stellar.TopologyResponseBodyV1>(
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
                        return Serializer.Deserialize<Stellar.TopologyResponseBodyV1>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
