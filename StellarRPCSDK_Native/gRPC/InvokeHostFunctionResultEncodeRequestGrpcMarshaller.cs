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
    /// <summary>Custom marshaller for Stellar.InvokeHostFunctionResultEncodeRequest</summary>
    public static class InvokeHostFunctionResultEncodeRequestGrpcMarshaller
    {
        // Static constructor to configure type
        static InvokeHostFunctionResultEncodeRequestGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.InvokeHostFunctionResultEncodeRequest
            if (!model.IsDefined(typeof(Stellar.InvokeHostFunctionResultEncodeRequest)))
            {
                var metaType = model.Add(typeof(Stellar.InvokeHostFunctionResultEncodeRequest), false);

                // Add all properties with their original ProtoMember numbers
                metaType.Add(1, "Value");
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for InvokeHostFunctionResultEncodeRequest</summary>
        public static readonly Marshaller<Stellar.InvokeHostFunctionResultEncodeRequest> InvokeHostFunctionResultEncodeRequestMarshaller = Marshallers.Create<Stellar.InvokeHostFunctionResultEncodeRequest>(
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
                        return Serializer.Deserialize<Stellar.InvokeHostFunctionResultEncodeRequest>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
