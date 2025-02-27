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
    /// <summary>Custom marshaller for Stellar.HostFunction</summary>
    public static class HostFunctionGrpcMarshaller
    {
        // Static constructor to configure type
        static HostFunctionGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.HostFunction
            if (!model.IsDefined(typeof(Stellar.HostFunction)))
            {
                var metaType = model.Add(typeof(Stellar.HostFunction), false);

                // Add all ProtoInclude references with their original tag numbers
                metaType.AddSubType(100, typeof(Stellar.HostFunction.HostFunctionTypeInvokeContract));
                metaType.AddSubType(101, typeof(Stellar.HostFunction.HostFunctionTypeCreateContract));
                metaType.AddSubType(102, typeof(Stellar.HostFunction.HostFunctionTypeUploadContractWasm));
                metaType.AddSubType(103, typeof(Stellar.HostFunction.HostFunctionTypeCreateContractV2));
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.HostFunction</summary>
        public static readonly Marshaller<Stellar.HostFunction> HostFunctionMarshaller = Marshallers.Create<Stellar.HostFunction>(
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
                        return Serializer.Deserialize<Stellar.HostFunction>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
