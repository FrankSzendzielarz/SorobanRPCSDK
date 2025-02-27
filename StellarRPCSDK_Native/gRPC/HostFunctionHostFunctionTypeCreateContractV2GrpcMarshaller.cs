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
    /// <summary>Custom marshaller for Stellar.HostFunction+HostFunctionTypeCreateContractV2</summary>
    public static class HostFunctionHostFunctionTypeCreateContractV2GrpcMarshaller
    {
        // Static constructor to configure type
        static HostFunctionHostFunctionTypeCreateContractV2GrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.HostFunction.HostFunctionTypeCreateContractV2
            if (!model.IsDefined(typeof(Stellar.HostFunction.HostFunctionTypeCreateContractV2)))
            {
                var metaType = model.Add(typeof(Stellar.HostFunction.HostFunctionTypeCreateContractV2), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(4, "createContractV2");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for HostFunctionTypeCreateContractV2</summary>
        public static readonly Marshaller<Stellar.HostFunction.HostFunctionTypeCreateContractV2> HostFunctionTypeCreateContractV2Marshaller = Marshallers.Create<Stellar.HostFunction.HostFunctionTypeCreateContractV2>(
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
                        return Serializer.Deserialize<Stellar.HostFunction.HostFunctionTypeCreateContractV2>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
