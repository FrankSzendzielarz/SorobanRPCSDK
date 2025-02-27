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
    /// <summary>Custom marshaller for Stellar.TimeSlicedNodeData</summary>
    public static class TimeSlicedNodeDataGrpcMarshaller
    {
        // Static constructor to configure type
        static TimeSlicedNodeDataGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TimeSlicedNodeData
            if (!model.IsDefined(typeof(Stellar.TimeSlicedNodeData)))
            {
                var metaType = model.Add(typeof(Stellar.TimeSlicedNodeData), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "addedAuthenticatedPeers");
                metaType.Add(2, "droppedAuthenticatedPeers");
                metaType.Add(3, "totalInboundPeerCount");
                metaType.Add(4, "totalOutboundPeerCount");
                metaType.Add(5, "p75SCPFirstToSelfLatencyMs");
                metaType.Add(6, "p75SCPSelfToOtherLatencyMs");
                metaType.Add(7, "lostSyncCount");
                metaType.Add(8, "isValidator");
                metaType.Add(9, "maxInboundPeerCount");
                metaType.Add(10, "maxOutboundPeerCount");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TimeSlicedNodeData</summary>
        public static readonly Marshaller<Stellar.TimeSlicedNodeData> TimeSlicedNodeDataMarshaller = Marshallers.Create<Stellar.TimeSlicedNodeData>(
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
                        return Serializer.Deserialize<Stellar.TimeSlicedNodeData>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
