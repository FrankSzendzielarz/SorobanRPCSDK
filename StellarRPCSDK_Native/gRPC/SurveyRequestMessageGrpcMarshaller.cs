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
    /// <summary>Custom marshaller for Stellar.SurveyRequestMessage</summary>
    public static class SurveyRequestMessageGrpcMarshaller
    {
        // Static constructor to configure type
        static SurveyRequestMessageGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SurveyRequestMessage
            if (!model.IsDefined(typeof(Stellar.SurveyRequestMessage)))
            {
                var metaType = model.Add(typeof(Stellar.SurveyRequestMessage), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "surveyorPeerID");
                metaType.Add(2, "surveyedPeerID");
                metaType.Add(3, "ledgerNum");
                metaType.Add(4, "encryptionKey");
                metaType.Add(5, "commandType");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SurveyRequestMessage</summary>
        public static readonly Marshaller<Stellar.SurveyRequestMessage> SurveyRequestMessageMarshaller = Marshallers.Create<Stellar.SurveyRequestMessage>(
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
                        return Serializer.Deserialize<Stellar.SurveyRequestMessage>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
