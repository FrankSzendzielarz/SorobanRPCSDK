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
    /// <summary>Custom marshaller for Stellar.ContractEvent</summary>
    public static class ContractEventGrpcMarshaller
    {
        // Static constructor to configure type
        static ContractEventGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ContractEvent
            if (!model.IsDefined(typeof(Stellar.ContractEvent)))
            {
                var metaType = model.Add(typeof(Stellar.ContractEvent), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ext");
                metaType.Add(2, "contractID");
                metaType.Add(3, "type");
                metaType.Add(4, "body");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ContractEvent</summary>
        public static readonly Marshaller<Stellar.ContractEvent> ContractEventMarshaller = Marshallers.Create<Stellar.ContractEvent>(
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
                        return Serializer.Deserialize<Stellar.ContractEvent>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
