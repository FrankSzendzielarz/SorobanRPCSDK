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
    /// <summary>Custom marshaller for Stellar.SendMoreExtended</summary>
    public static class SendMoreExtendedGrpcMarshaller
    {
        // Static constructor to configure type
        static SendMoreExtendedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SendMoreExtended
            if (!model.IsDefined(typeof(Stellar.SendMoreExtended)))
            {
                var metaType = model.Add(typeof(Stellar.SendMoreExtended), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "numMessages");
                metaType.Add(2, "numBytes");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SendMoreExtended</summary>
        public static readonly Marshaller<Stellar.SendMoreExtended> SendMoreExtendedMarshaller = Marshallers.Create<Stellar.SendMoreExtended>(
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
                        return Serializer.Deserialize<Stellar.SendMoreExtended>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
