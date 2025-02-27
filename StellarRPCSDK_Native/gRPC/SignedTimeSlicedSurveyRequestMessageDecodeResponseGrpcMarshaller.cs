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
    /// <summary>Custom marshaller for Stellar.SignedTimeSlicedSurveyRequestMessageDecodeResponse</summary>
    public static class SignedTimeSlicedSurveyRequestMessageDecodeResponseGrpcMarshaller
    {
        // Static constructor to configure type
        static SignedTimeSlicedSurveyRequestMessageDecodeResponseGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SignedTimeSlicedSurveyRequestMessageDecodeResponse
            if (!model.IsDefined(typeof(Stellar.SignedTimeSlicedSurveyRequestMessageDecodeResponse)))
            {
                var metaType = model.Add(typeof(Stellar.SignedTimeSlicedSurveyRequestMessageDecodeResponse), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Value");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SignedTimeSlicedSurveyRequestMessageDecodeResponse</summary>
        public static readonly Marshaller<Stellar.SignedTimeSlicedSurveyRequestMessageDecodeResponse> SignedTimeSlicedSurveyRequestMessageDecodeResponseMarshaller = Marshallers.Create<Stellar.SignedTimeSlicedSurveyRequestMessageDecodeResponse>(
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
                        return Serializer.Deserialize<Stellar.SignedTimeSlicedSurveyRequestMessageDecodeResponse>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
