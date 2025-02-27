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
    /// <summary>Custom marshaller for Stellar.RestoreFootprintResult+RestoreFootprintSuccess</summary>
    public static class RestoreFootprintResultRestoreFootprintSuccessGrpcMarshaller
    {
        // Static constructor to configure type
        static RestoreFootprintResultRestoreFootprintSuccessGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RestoreFootprintResult.RestoreFootprintSuccess
            if (!model.IsDefined(typeof(Stellar.RestoreFootprintResult.RestoreFootprintSuccess)))
            {
                var metaType = model.Add(typeof(Stellar.RestoreFootprintResult.RestoreFootprintSuccess), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.RestoreFootprintResult+RestoreFootprintSuccess</summary>
        public static readonly Marshaller<Stellar.RestoreFootprintResult.RestoreFootprintSuccess> RestoreFootprintResult_RestoreFootprintSuccessMarshaller = Marshallers.Create<Stellar.RestoreFootprintResult.RestoreFootprintSuccess>(
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
                        return Serializer.Deserialize<Stellar.RestoreFootprintResult.RestoreFootprintSuccess>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
