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
    /// <summary>Custom marshaller for Stellar.PeerStats</summary>
    public static class PeerStatsGrpcMarshaller
    {
        // Static constructor to configure type
        static PeerStatsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.PeerStats
            if (!model.IsDefined(typeof(Stellar.PeerStats)))
            {
                var metaType = model.Add(typeof(Stellar.PeerStats), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "id");
                metaType.Add(2, "versionStr");
                metaType.Add(3, "messagesRead");
                metaType.Add(4, "messagesWritten");
                metaType.Add(5, "bytesRead");
                metaType.Add(6, "bytesWritten");
                metaType.Add(7, "secondsConnected");
                metaType.Add(8, "uniqueFloodBytesRecv");
                metaType.Add(9, "duplicateFloodBytesRecv");
                metaType.Add(10, "uniqueFetchBytesRecv");
                metaType.Add(11, "duplicateFetchBytesRecv");
                metaType.Add(12, "uniqueFloodMessageRecv");
                metaType.Add(13, "duplicateFloodMessageRecv");
                metaType.Add(14, "uniqueFetchMessageRecv");
                metaType.Add(15, "duplicateFetchMessageRecv");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.PeerStats</summary>
        public static readonly Marshaller<Stellar.PeerStats> PeerStatsMarshaller = Marshallers.Create<Stellar.PeerStats>(
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
                        return Serializer.Deserialize<Stellar.PeerStats>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
