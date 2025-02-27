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
    /// <summary>Custom marshaller for Stellar.SorobanAuthorizedFunction+SorobanAuthorizedFunctionTypeCreateContractHostFn</summary>
    public static class SorobanAuthorizedFunctionSorobanAuthorizedFunctionTypeCreateContractHostFnGrpcMarshaller
    {
        // Static constructor to configure type
        static SorobanAuthorizedFunctionSorobanAuthorizedFunctionTypeCreateContractHostFnGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeCreateContractHostFn
            if (!model.IsDefined(typeof(Stellar.SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeCreateContractHostFn)))
            {
                var metaType = model.Add(typeof(Stellar.SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeCreateContractHostFn), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(2, "createContractHostFn");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.SorobanAuthorizedFunction+SorobanAuthorizedFunctionTypeCreateContractHostFn</summary>
        public static readonly Marshaller<Stellar.SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeCreateContractHostFn> SorobanAuthorizedFunction_SorobanAuthorizedFunctionTypeCreateContractHostFnMarshaller = Marshallers.Create<Stellar.SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeCreateContractHostFn>(
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
                        return Serializer.Deserialize<Stellar.SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeCreateContractHostFn>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
