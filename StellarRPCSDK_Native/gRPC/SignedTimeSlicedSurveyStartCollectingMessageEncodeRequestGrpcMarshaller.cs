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
    /// <summary>Custom marshaller for Stellar.SignedTimeSlicedSurveyStartCollectingMessageEncodeRequest</summary>
    public static class SignedTimeSlicedSurveyStartCollectingMessageEncodeRequestGrpcMarshaller
    {
        // Static constructor to configure type
        static SignedTimeSlicedSurveyStartCollectingMessageEncodeRequestGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SignedTimeSlicedSurveyStartCollectingMessageEncodeRequest
            if (!model.IsDefined(typeof(Stellar.SignedTimeSlicedSurveyStartCollectingMessageEncodeRequest)))
            {
                var metaType = model.Add(typeof(Stellar.SignedTimeSlicedSurveyStartCollectingMessageEncodeRequest), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Value");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SignedTimeSlicedSurveyStartCollectingMessageEncodeRequest</summary>
        public static readonly Marshaller<Stellar.SignedTimeSlicedSurveyStartCollectingMessageEncodeRequest> SignedTimeSlicedSurveyStartCollectingMessageEncodeRequestMarshaller = Marshallers.Create<Stellar.SignedTimeSlicedSurveyStartCollectingMessageEncodeRequest>(
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
                        return Serializer.Deserialize<Stellar.SignedTimeSlicedSurveyStartCollectingMessageEncodeRequest>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
