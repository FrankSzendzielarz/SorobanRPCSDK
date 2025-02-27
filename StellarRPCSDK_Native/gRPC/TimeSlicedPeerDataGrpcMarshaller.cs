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
    /// <summary>Custom marshaller for Stellar.TimeSlicedPeerData</summary>
    public static class TimeSlicedPeerDataGrpcMarshaller
    {
        // Static constructor to configure type
        static TimeSlicedPeerDataGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TimeSlicedPeerData
            if (!model.IsDefined(typeof(Stellar.TimeSlicedPeerData)))
            {
                var metaType = model.Add(typeof(Stellar.TimeSlicedPeerData), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "peerStats");
                metaType.Add(2, "averageLatencyMs");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TimeSlicedPeerData</summary>
        public static readonly Marshaller<Stellar.TimeSlicedPeerData> TimeSlicedPeerDataMarshaller = Marshallers.Create<Stellar.TimeSlicedPeerData>(
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
                        return Serializer.Deserialize<Stellar.TimeSlicedPeerData>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
