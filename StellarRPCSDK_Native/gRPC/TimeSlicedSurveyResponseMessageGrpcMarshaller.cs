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
    /// <summary>Custom marshaller for Stellar.TimeSlicedSurveyResponseMessage</summary>
    public static class TimeSlicedSurveyResponseMessageGrpcMarshaller
    {
        // Static constructor to configure type
        static TimeSlicedSurveyResponseMessageGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.TimeSlicedSurveyResponseMessage
            if (!model.IsDefined(typeof(Stellar.TimeSlicedSurveyResponseMessage)))
            {
                var metaType = model.Add(typeof(Stellar.TimeSlicedSurveyResponseMessage), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "response");
                metaType.Add(2, "nonce");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for TimeSlicedSurveyResponseMessage</summary>
        public static readonly Marshaller<Stellar.TimeSlicedSurveyResponseMessage> TimeSlicedSurveyResponseMessageMarshaller = Marshallers.Create<Stellar.TimeSlicedSurveyResponseMessage>(
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
                        return Serializer.Deserialize<Stellar.TimeSlicedSurveyResponseMessage>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
