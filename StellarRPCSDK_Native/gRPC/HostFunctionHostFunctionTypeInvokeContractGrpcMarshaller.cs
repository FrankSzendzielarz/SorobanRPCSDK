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
    /// <summary>Custom marshaller for Stellar.HostFunction+HostFunctionTypeInvokeContract</summary>
    public static class HostFunctionHostFunctionTypeInvokeContractGrpcMarshaller
    {
        // Static constructor to configure type
        static HostFunctionHostFunctionTypeInvokeContractGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.HostFunction.HostFunctionTypeInvokeContract
            if (!model.IsDefined(typeof(Stellar.HostFunction.HostFunctionTypeInvokeContract)))
            {
                var metaType = model.Add(typeof(Stellar.HostFunction.HostFunctionTypeInvokeContract), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "invokeContract");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.HostFunction+HostFunctionTypeInvokeContract</summary>
        public static readonly Marshaller<Stellar.HostFunction.HostFunctionTypeInvokeContract> HostFunction_HostFunctionTypeInvokeContractMarshaller = Marshallers.Create<Stellar.HostFunction.HostFunctionTypeInvokeContract>(
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
                        return Serializer.Deserialize<Stellar.HostFunction.HostFunctionTypeInvokeContract>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
