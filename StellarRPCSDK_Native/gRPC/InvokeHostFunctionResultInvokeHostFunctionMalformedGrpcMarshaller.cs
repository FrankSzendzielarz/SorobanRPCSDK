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
    /// <summary>Custom marshaller for Stellar.InvokeHostFunctionResult+InvokeHostFunctionMalformed</summary>
    public static class InvokeHostFunctionResultInvokeHostFunctionMalformedGrpcMarshaller
    {
        // Static constructor to configure type
        static InvokeHostFunctionResultInvokeHostFunctionMalformedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.InvokeHostFunctionResult.InvokeHostFunctionMalformed
            if (!model.IsDefined(typeof(Stellar.InvokeHostFunctionResult.InvokeHostFunctionMalformed)))
            {
                var metaType = model.Add(typeof(Stellar.InvokeHostFunctionResult.InvokeHostFunctionMalformed), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.InvokeHostFunctionResult+InvokeHostFunctionMalformed</summary>
        public static readonly Marshaller<Stellar.InvokeHostFunctionResult.InvokeHostFunctionMalformed> InvokeHostFunctionResult_InvokeHostFunctionMalformedMarshaller = Marshallers.Create<Stellar.InvokeHostFunctionResult.InvokeHostFunctionMalformed>(
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
                        return Serializer.Deserialize<Stellar.InvokeHostFunctionResult.InvokeHostFunctionMalformed>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
