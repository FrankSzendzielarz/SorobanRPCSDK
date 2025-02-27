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
    /// <summary>Custom marshaller for Stellar.StellarMessage+TimeSlicedSurveyStopCollecting</summary>
    public static class StellarMessageTimeSlicedSurveyStopCollectingGrpcMarshaller
    {
        // Static constructor to configure type
        static StellarMessageTimeSlicedSurveyStopCollectingGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.StellarMessage.TimeSlicedSurveyStopCollecting
            if (!model.IsDefined(typeof(Stellar.StellarMessage.TimeSlicedSurveyStopCollecting)))
            {
                var metaType = model.Add(typeof(Stellar.StellarMessage.TimeSlicedSurveyStopCollecting), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(15, "signedTimeSlicedSurveyStopCollectingMessage");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.StellarMessage+TimeSlicedSurveyStopCollecting</summary>
        public static readonly Marshaller<Stellar.StellarMessage.TimeSlicedSurveyStopCollecting> StellarMessage_TimeSlicedSurveyStopCollectingMarshaller = Marshallers.Create<Stellar.StellarMessage.TimeSlicedSurveyStopCollecting>(
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
                        return Serializer.Deserialize<Stellar.StellarMessage.TimeSlicedSurveyStopCollecting>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
