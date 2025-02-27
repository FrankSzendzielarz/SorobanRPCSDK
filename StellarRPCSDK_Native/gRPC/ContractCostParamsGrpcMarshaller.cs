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
    /// <summary>Custom marshaller for Stellar.ContractCostParams</summary>
    public static class ContractCostParamsGrpcMarshaller
    {
        // Static constructor to configure type
        static ContractCostParamsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ContractCostParams
            if (!model.IsDefined(typeof(Stellar.ContractCostParams)))
            {
                var metaType = model.Add(typeof(Stellar.ContractCostParams), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "InnerValue");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ContractCostParams</summary>
        public static readonly Marshaller<Stellar.ContractCostParams> ContractCostParamsMarshaller = Marshallers.Create<Stellar.ContractCostParams>(
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
                        return Serializer.Deserialize<Stellar.ContractCostParams>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
