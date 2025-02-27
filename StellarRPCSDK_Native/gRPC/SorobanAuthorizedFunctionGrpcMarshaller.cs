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
    /// <summary>Custom marshaller for Stellar.SorobanAuthorizedFunction</summary>
    public static class SorobanAuthorizedFunctionGrpcMarshaller
    {
        // Static constructor to configure type
        static SorobanAuthorizedFunctionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.SorobanAuthorizedFunction
            if (!model.IsDefined(typeof(Stellar.SorobanAuthorizedFunction)))
            {
                var metaType = model.Add(typeof(Stellar.SorobanAuthorizedFunction), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeContractFn));
                metaType.AddSubType(101, typeof(Stellar.SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeCreateContractHostFn));
                metaType.AddSubType(102, typeof(Stellar.SorobanAuthorizedFunction.SorobanAuthorizedFunctionTypeCreateContractV2HostFn));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for SorobanAuthorizedFunction</summary>
        public static readonly Marshaller<Stellar.SorobanAuthorizedFunction> SorobanAuthorizedFunctionMarshaller = Marshallers.Create<Stellar.SorobanAuthorizedFunction>(
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
                        return Serializer.Deserialize<Stellar.SorobanAuthorizedFunction>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
