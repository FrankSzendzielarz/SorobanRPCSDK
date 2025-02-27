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
    /// <summary>Custom marshaller for Stellar.TimeSlicedPeerDataList</summary>
    public static class TimeSlicedPeerDataListGrpcMarshaller
    {
        // Static constructor to configure type
        static TimeSlicedPeerDataListGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TimeSlicedPeerDataList
            if (!model.IsDefined(typeof(Stellar.TimeSlicedPeerDataList)))
            {
                var metaType = model.Add(typeof(Stellar.TimeSlicedPeerDataList), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "InnerValue");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TimeSlicedPeerDataList</summary>
        public static readonly Marshaller<Stellar.TimeSlicedPeerDataList> TimeSlicedPeerDataListMarshaller = Marshallers.Create<Stellar.TimeSlicedPeerDataList>(
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
                        return Serializer.Deserialize<Stellar.TimeSlicedPeerDataList>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
