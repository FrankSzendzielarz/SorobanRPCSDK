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
    /// <summary>Custom marshaller for Stellar.ContractDataEntry</summary>
    public static class ContractDataEntryGrpcMarshaller
    {
        // Static constructor to configure type
        static ContractDataEntryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ContractDataEntry
            if (!model.IsDefined(typeof(Stellar.ContractDataEntry)))
            {
                var metaType = model.Add(typeof(Stellar.ContractDataEntry), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ext");
                metaType.Add(2, "contract");
                metaType.Add(3, "key");
                metaType.Add(4, "durability");
                metaType.Add(5, "val");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ContractDataEntry</summary>
        public static readonly Marshaller<Stellar.ContractDataEntry> ContractDataEntryMarshaller = Marshallers.Create<Stellar.ContractDataEntry>(
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
                        return Serializer.Deserialize<Stellar.ContractDataEntry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
