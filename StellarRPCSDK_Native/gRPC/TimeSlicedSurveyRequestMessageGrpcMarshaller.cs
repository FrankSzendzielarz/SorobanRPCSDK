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
    /// <summary>Custom marshaller for Stellar.TimeSlicedSurveyRequestMessage</summary>
    public static class TimeSlicedSurveyRequestMessageGrpcMarshaller
    {
        // Static constructor to configure type
        static TimeSlicedSurveyRequestMessageGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TimeSlicedSurveyRequestMessage
            if (!model.IsDefined(typeof(Stellar.TimeSlicedSurveyRequestMessage)))
            {
                var metaType = model.Add(typeof(Stellar.TimeSlicedSurveyRequestMessage), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "request");
                metaType.Add(2, "nonce");
                metaType.Add(3, "inboundPeersIndex");
                metaType.Add(4, "outboundPeersIndex");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TimeSlicedSurveyRequestMessage</summary>
        public static readonly Marshaller<Stellar.TimeSlicedSurveyRequestMessage> TimeSlicedSurveyRequestMessageMarshaller = Marshallers.Create<Stellar.TimeSlicedSurveyRequestMessage>(
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
                        return Serializer.Deserialize<Stellar.TimeSlicedSurveyRequestMessage>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
