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
    /// <summary>Custom marshaller for Stellar.HostFunction+HostFunctionTypeUploadContractWasm</summary>
    public static class HostFunctionHostFunctionTypeUploadContractWasmGrpcMarshaller
    {
        // Static constructor to configure type
        static HostFunctionHostFunctionTypeUploadContractWasmGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.HostFunction.HostFunctionTypeUploadContractWasm
            if (!model.IsDefined(typeof(Stellar.HostFunction.HostFunctionTypeUploadContractWasm)))
            {
                var metaType = model.Add(typeof(Stellar.HostFunction.HostFunctionTypeUploadContractWasm), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(3, "wasm");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.HostFunction+HostFunctionTypeUploadContractWasm</summary>
        public static readonly Marshaller<Stellar.HostFunction.HostFunctionTypeUploadContractWasm> HostFunction_HostFunctionTypeUploadContractWasmMarshaller = Marshallers.Create<Stellar.HostFunction.HostFunctionTypeUploadContractWasm>(
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
                        return Serializer.Deserialize<Stellar.HostFunction.HostFunctionTypeUploadContractWasm>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
