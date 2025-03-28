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
    /// <summary>Custom marshaller for Stellar.ContractCostParamEntry</summary>
    public static class ContractCostParamEntryGrpcMarshaller
    {
        // Static constructor to configure type
        static ContractCostParamEntryGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ContractCostParamEntry
            if (!model.IsDefined(typeof(Stellar.ContractCostParamEntry)))
            {
                var metaType = model.Add(typeof(Stellar.ContractCostParamEntry), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ext");
                metaType.Add(2, "constTerm");
                metaType.Add(3, "linearTerm");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ContractCostParamEntry</summary>
        public static readonly Marshaller<Stellar.ContractCostParamEntry> ContractCostParamEntryMarshaller = Marshallers.Create<Stellar.ContractCostParamEntry>(
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
                        return Serializer.Deserialize<Stellar.ContractCostParamEntry>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
