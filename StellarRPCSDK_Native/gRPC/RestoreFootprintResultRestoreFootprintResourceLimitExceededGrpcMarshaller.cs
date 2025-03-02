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
    /// <summary>Custom marshaller for Stellar.RestoreFootprintResult+RestoreFootprintResourceLimitExceeded</summary>
    public static class RestoreFootprintResultRestoreFootprintResourceLimitExceededGrpcMarshaller
    {
        // Static constructor to configure type
        static RestoreFootprintResultRestoreFootprintResourceLimitExceededGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RestoreFootprintResult.RestoreFootprintResourceLimitExceeded
            if (!model.IsDefined(typeof(Stellar.RestoreFootprintResult.RestoreFootprintResourceLimitExceeded)))
            {
                var metaType = model.Add(typeof(Stellar.RestoreFootprintResult.RestoreFootprintResourceLimitExceeded), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.RestoreFootprintResult+RestoreFootprintResourceLimitExceeded</summary>
        public static readonly Marshaller<Stellar.RestoreFootprintResult.RestoreFootprintResourceLimitExceeded> RestoreFootprintResult_RestoreFootprintResourceLimitExceededMarshaller = Marshallers.Create<Stellar.RestoreFootprintResult.RestoreFootprintResourceLimitExceeded>(
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
                        return Serializer.Deserialize<Stellar.RestoreFootprintResult.RestoreFootprintResourceLimitExceeded>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
