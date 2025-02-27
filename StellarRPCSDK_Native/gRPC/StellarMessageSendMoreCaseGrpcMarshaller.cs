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
    /// <summary>Custom marshaller for Stellar.StellarMessage+SendMoreCase</summary>
    public static class StellarMessageSendMoreCaseGrpcMarshaller
    {
        // Static constructor to configure type
        static StellarMessageSendMoreCaseGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.StellarMessage.SendMoreCase
            if (!model.IsDefined(typeof(Stellar.StellarMessage.SendMoreCase)))
            {
                var metaType = model.Add(typeof(Stellar.StellarMessage.SendMoreCase), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(20, "sendMoreMessage");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SendMoreCase</summary>
        public static readonly Marshaller<Stellar.StellarMessage.SendMoreCase> SendMoreCaseMarshaller = Marshallers.Create<Stellar.StellarMessage.SendMoreCase>(
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
                        return Serializer.Deserialize<Stellar.StellarMessage.SendMoreCase>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
