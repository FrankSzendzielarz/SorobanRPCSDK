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
    /// <summary>Custom marshaller for Stellar.SCError+SceEvents</summary>
    public static class SCErrorSceEventsGrpcMarshaller
    {
        // Static constructor to configure type
        static SCErrorSceEventsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SCError.SceEvents
            if (!model.IsDefined(typeof(Stellar.SCError.SceEvents)))
            {
                var metaType = model.Add(typeof(Stellar.SCError.SceEvents), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(7, "code");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SCError+SceEvents</summary>
        public static readonly Marshaller<Stellar.SCError.SceEvents> SCError_SceEventsMarshaller = Marshallers.Create<Stellar.SCError.SceEvents>(
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
                        return Serializer.Deserialize<Stellar.SCError.SceEvents>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
