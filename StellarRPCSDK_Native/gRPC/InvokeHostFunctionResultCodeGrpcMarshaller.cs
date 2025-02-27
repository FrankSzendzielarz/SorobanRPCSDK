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
    /// <summary>Custom marshaller for Stellar.InvokeHostFunctionResultCode</summary>
    public static class InvokeHostFunctionResultCodeGrpcMarshaller
    {
        // Static constructor to configure type
        static InvokeHostFunctionResultCodeGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.InvokeHostFunctionResultCode
            if (!model.IsDefined(typeof(Stellar.InvokeHostFunctionResultCode)))
            {
                var metaType = model.Add(typeof(Stellar.InvokeHostFunctionResultCode), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for InvokeHostFunctionResultCode</summary>
        public static readonly Marshaller<Stellar.InvokeHostFunctionResultCode> InvokeHostFunctionResultCodeMarshaller = Marshallers.Create<Stellar.InvokeHostFunctionResultCode>(
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
                        return Serializer.Deserialize<Stellar.InvokeHostFunctionResultCode>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
