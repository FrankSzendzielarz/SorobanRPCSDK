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
    /// <summary>Custom marshaller for Stellar.StellarMessage+TimeSlicedSurveyResponse</summary>
    public static class StellarMessageTimeSlicedSurveyResponseGrpcMarshaller
    {
        // Static constructor to configure type
        static StellarMessageTimeSlicedSurveyResponseGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.StellarMessage.TimeSlicedSurveyResponse
            if (!model.IsDefined(typeof(Stellar.StellarMessage.TimeSlicedSurveyResponse)))
            {
                var metaType = model.Add(typeof(Stellar.StellarMessage.TimeSlicedSurveyResponse), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(13, "signedTimeSlicedSurveyResponseMessage");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.StellarMessage+TimeSlicedSurveyResponse</summary>
        public static readonly Marshaller<Stellar.StellarMessage.TimeSlicedSurveyResponse> StellarMessage_TimeSlicedSurveyResponseMarshaller = Marshallers.Create<Stellar.StellarMessage.TimeSlicedSurveyResponse>(
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
                        return Serializer.Deserialize<Stellar.StellarMessage.TimeSlicedSurveyResponse>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
