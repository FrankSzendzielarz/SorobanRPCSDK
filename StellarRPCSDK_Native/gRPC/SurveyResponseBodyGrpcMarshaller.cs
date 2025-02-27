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
    /// <summary>Custom marshaller for Stellar.SurveyResponseBody</summary>
    public static class SurveyResponseBodyGrpcMarshaller
    {
        // Static constructor to configure type
        static SurveyResponseBodyGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SurveyResponseBody
            if (!model.IsDefined(typeof(Stellar.SurveyResponseBody)))
            {
                var metaType = model.Add(typeof(Stellar.SurveyResponseBody), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.SurveyResponseBody.SurveyTopologyResponseV0));
                metaType.AddSubType(101, typeof(Stellar.SurveyResponseBody.SurveyTopologyResponseV1));
                metaType.AddSubType(102, typeof(Stellar.SurveyResponseBody.SurveyTopologyResponseV2));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SurveyResponseBody</summary>
        public static readonly Marshaller<Stellar.SurveyResponseBody> SurveyResponseBodyMarshaller = Marshallers.Create<Stellar.SurveyResponseBody>(
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
                        return Serializer.Deserialize<Stellar.SurveyResponseBody>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
