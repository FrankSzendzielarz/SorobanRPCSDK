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
    /// <summary>Custom marshaller for Stellar.SorobanAuthorizedFunction+SorobanAuthorizedFunctionTypeCreateContractV2HostFn</summary>
    public static class SorobanAuthorizedFunctionSorobanAuthorizedFunctionTypeCreateContractV2HostFnGrpcMarshaller
    {
        // Static constructor to configure type
        static SorobanAuthorizedFunctionSorobanAuthorizedFunctionTypeCreateContractV2HostFnGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeCreateContractV2HostFn
            if (!model.IsDefined(typeof(Stellar.SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeCreateContractV2HostFn)))
            {
                var metaType = model.Add(typeof(Stellar.SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeCreateContractV2HostFn), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(3, "createContractV2HostFn");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SorobanAuthorizedFunction+SorobanAuthorizedFunctionTypeCreateContractV2HostFn</summary>
        public static readonly Marshaller<Stellar.SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeCreateContractV2HostFn> SorobanAuthorizedFunction_SorobanAuthorizedFunctionTypeCreateContractV2HostFnMarshaller = Marshallers.Create<Stellar.SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeCreateContractV2HostFn>(
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
                        return Serializer.Deserialize<Stellar.SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeCreateContractV2HostFn>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
