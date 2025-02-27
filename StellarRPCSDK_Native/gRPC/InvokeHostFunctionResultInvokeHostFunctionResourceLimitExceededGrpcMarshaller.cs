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
    /// <summary>Custom marshaller for Stellar.InvokeHostFunctionResult+InvokeHostFunctionResourceLimitExceeded</summary>
    public static class InvokeHostFunctionResultInvokeHostFunctionResourceLimitExceededGrpcMarshaller
    {
        // Static constructor to configure type
        static InvokeHostFunctionResultInvokeHostFunctionResourceLimitExceededGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.InvokeHostFunctionResult.InvokeHostFunctionResourceLimitExceeded
            if (!model.IsDefined(typeof(Stellar.InvokeHostFunctionResult.InvokeHostFunctionResourceLimitExceeded)))
            {
                var metaType = model.Add(typeof(Stellar.InvokeHostFunctionResult.InvokeHostFunctionResourceLimitExceeded), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for InvokeHostFunctionResourceLimitExceeded</summary>
        public static readonly Marshaller<Stellar.InvokeHostFunctionResult.InvokeHostFunctionResourceLimitExceeded> InvokeHostFunctionResourceLimitExceededMarshaller = Marshallers.Create<Stellar.InvokeHostFunctionResult.InvokeHostFunctionResourceLimitExceeded>(
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
                        return Serializer.Deserialize<Stellar.InvokeHostFunctionResult.InvokeHostFunctionResourceLimitExceeded>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
