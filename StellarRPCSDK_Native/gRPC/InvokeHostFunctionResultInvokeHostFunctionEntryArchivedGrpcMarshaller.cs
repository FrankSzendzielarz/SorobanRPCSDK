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
    /// <summary>Custom marshaller for Stellar.InvokeHostFunctionResult+InvokeHostFunctionEntryArchived</summary>
    public static class InvokeHostFunctionResultInvokeHostFunctionEntryArchivedGrpcMarshaller
    {
        // Static constructor to configure type
        static InvokeHostFunctionResultInvokeHostFunctionEntryArchivedGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.InvokeHostFunctionResult.InvokeHostFunctionEntryArchived
            if (!model.IsDefined(typeof(Stellar.InvokeHostFunctionResult.InvokeHostFunctionEntryArchived)))
            {
                var metaType = model.Add(typeof(Stellar.InvokeHostFunctionResult.InvokeHostFunctionEntryArchived), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.InvokeHostFunctionResult+InvokeHostFunctionEntryArchived</summary>
        public static readonly Marshaller<Stellar.InvokeHostFunctionResult.InvokeHostFunctionEntryArchived> InvokeHostFunctionResult_InvokeHostFunctionEntryArchivedMarshaller = Marshallers.Create<Stellar.InvokeHostFunctionResult.InvokeHostFunctionEntryArchived>(
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
                        return Serializer.Deserialize<Stellar.InvokeHostFunctionResult.InvokeHostFunctionEntryArchived>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
