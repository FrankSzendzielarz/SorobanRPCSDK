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
    /// <summary>Custom marshaller for Stellar.ContractCodeCostInputs</summary>
    public static class ContractCodeCostInputsGrpcMarshaller
    {
        // Static constructor to configure type
        static ContractCodeCostInputsGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ContractCodeCostInputs
            if (!model.IsDefined(typeof(Stellar.ContractCodeCostInputs)))
            {
                var metaType = model.Add(typeof(Stellar.ContractCodeCostInputs), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "ext");
                metaType.Add(2, "nInstructions");
                metaType.Add(3, "nFunctions");
                metaType.Add(4, "nGlobals");
                metaType.Add(5, "nTableEntries");
                metaType.Add(6, "nTypes");
                metaType.Add(7, "nDataSegments");
                metaType.Add(8, "nElemSegments");
                metaType.Add(9, "nImports");
                metaType.Add(10, "nExports");
                metaType.Add(11, "nDataSegmentBytes");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.ContractCodeCostInputs</summary>
        public static readonly Marshaller<Stellar.ContractCodeCostInputs> ContractCodeCostInputsMarshaller = Marshallers.Create<Stellar.ContractCodeCostInputs>(
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
                        return Serializer.Deserialize<Stellar.ContractCodeCostInputs>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
