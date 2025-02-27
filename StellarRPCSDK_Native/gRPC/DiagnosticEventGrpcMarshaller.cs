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
    /// <summary>Custom marshaller for Stellar.DiagnosticEvent</summary>
    public static class DiagnosticEventGrpcMarshaller
    {
        // Static constructor to configure type
        static DiagnosticEventGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.DiagnosticEvent
            if (!model.IsDefined(typeof(Stellar.DiagnosticEvent)))
            {
                var metaType = model.Add(typeof(Stellar.DiagnosticEvent), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "inSuccessfulContractCall");
                metaType.Add(2, "_event");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for DiagnosticEvent</summary>
        public static readonly Marshaller<Stellar.DiagnosticEvent> DiagnosticEventMarshaller = Marshallers.Create<Stellar.DiagnosticEvent>(
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
                        return Serializer.Deserialize<Stellar.DiagnosticEvent>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
