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
    /// <summary>Custom marshaller for Stellar.OperationResult+OpnotSupported</summary>
    public static class OperationResultOpnotSupportedGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationResultOpnotSupportedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.OperationResult.OpnotSupported
            if (!model.IsDefined(typeof(Stellar.OperationResult.OpnotSupported)))
            {
                var metaType = model.Add(typeof(Stellar.OperationResult.OpnotSupported), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for OpnotSupported</summary>
        public static readonly Marshaller<Stellar.OperationResult.OpnotSupported> OpnotSupportedMarshaller = Marshallers.Create<Stellar.OperationResult.OpnotSupported>(
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
                        return Serializer.Deserialize<Stellar.OperationResult.OpnotSupported>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
