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
    /// <summary>Custom marshaller for Stellar.ContractExecutable+ContractExecutableWasm</summary>
    public static class ContractExecutableContractExecutableWasmGrpcMarshaller
    {
        // Static constructor to configure type
        static ContractExecutableContractExecutableWasmGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.ContractExecutable.ContractExecutableWasm
            if (!model.IsDefined(typeof(Stellar.ContractExecutable.ContractExecutableWasm)))
            {
                var metaType = model.Add(typeof(Stellar.ContractExecutable.ContractExecutableWasm), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "wasm_hash");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for ContractExecutableWasm</summary>
        public static readonly Marshaller<Stellar.ContractExecutable.ContractExecutableWasm> ContractExecutableWasmMarshaller = Marshallers.Create<Stellar.ContractExecutable.ContractExecutableWasm>(
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
                        return Serializer.Deserialize<Stellar.ContractExecutable.ContractExecutableWasm>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
