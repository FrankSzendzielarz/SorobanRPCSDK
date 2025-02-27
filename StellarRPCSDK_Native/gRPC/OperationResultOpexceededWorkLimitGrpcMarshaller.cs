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
    /// <summary>Custom marshaller for Stellar.OperationResult+OpexceededWorkLimit</summary>
    public static class OperationResultOpexceededWorkLimitGrpcMarshaller
    {
        // Static constructor to configure type
        static OperationResultOpexceededWorkLimitGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.OperationResult.OpexceededWorkLimit
            if (!model.IsDefined(typeof(Stellar.OperationResult.OpexceededWorkLimit)))
            {
                var metaType = model.Add(typeof(Stellar.OperationResult.OpexceededWorkLimit), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.OperationResult+OpexceededWorkLimit</summary>
        public static readonly Marshaller<Stellar.OperationResult.OpexceededWorkLimit> OperationResult_OpexceededWorkLimitMarshaller = Marshallers.Create<Stellar.OperationResult.OpexceededWorkLimit>(
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
                        return Serializer.Deserialize<Stellar.OperationResult.OpexceededWorkLimit>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
