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
    /// <summary>Custom marshaller for Stellar.TimeSlicedSurveyStopCollectingMessage</summary>
    public static class TimeSlicedSurveyStopCollectingMessageGrpcMarshaller
    {
        // Static constructor to configure type
        static TimeSlicedSurveyStopCollectingMessageGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TimeSlicedSurveyStopCollectingMessage
            if (!model.IsDefined(typeof(Stellar.TimeSlicedSurveyStopCollectingMessage)))
            {
                var metaType = model.Add(typeof(Stellar.TimeSlicedSurveyStopCollectingMessage), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "surveyorID");
                metaType.Add(2, "nonce");
                metaType.Add(3, "ledgerNum");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.TimeSlicedSurveyStopCollectingMessage</summary>
        public static readonly Marshaller<Stellar.TimeSlicedSurveyStopCollectingMessage> TimeSlicedSurveyStopCollectingMessageMarshaller = Marshallers.Create<Stellar.TimeSlicedSurveyStopCollectingMessage>(
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
                        return Serializer.Deserialize<Stellar.TimeSlicedSurveyStopCollectingMessage>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
