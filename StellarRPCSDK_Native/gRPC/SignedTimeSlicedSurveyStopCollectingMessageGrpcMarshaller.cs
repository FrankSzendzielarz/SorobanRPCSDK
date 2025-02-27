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
    /// <summary>Custom marshaller for Stellar.SignedTimeSlicedSurveyStopCollectingMessage</summary>
    public static class SignedTimeSlicedSurveyStopCollectingMessageGrpcMarshaller
    {
        // Static constructor to configure type
        static SignedTimeSlicedSurveyStopCollectingMessageGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SignedTimeSlicedSurveyStopCollectingMessage
            if (!model.IsDefined(typeof(Stellar.SignedTimeSlicedSurveyStopCollectingMessage)))
            {
                var metaType = model.Add(typeof(Stellar.SignedTimeSlicedSurveyStopCollectingMessage), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "signature");
                metaType.Add(2, "stopCollecting");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SignedTimeSlicedSurveyStopCollectingMessage</summary>
        public static readonly Marshaller<Stellar.SignedTimeSlicedSurveyStopCollectingMessage> SignedTimeSlicedSurveyStopCollectingMessageMarshaller = Marshallers.Create<Stellar.SignedTimeSlicedSurveyStopCollectingMessage>(
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
                        return Serializer.Deserialize<Stellar.SignedTimeSlicedSurveyStopCollectingMessage>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
