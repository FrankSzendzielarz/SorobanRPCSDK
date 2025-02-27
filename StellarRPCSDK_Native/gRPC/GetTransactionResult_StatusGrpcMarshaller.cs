// Generated code - do not modify directly
using System;
using System.IO;
using System.Buffers;
using Grpc.Core;
using ProtoBuf;
using ProtoBuf.Meta;
using Stellar.RPC;

namespace Stellar.RPC.AOT
{
    /// <summary>Custom marshaller for Stellar.RPC.GetTransactionResult_Status</summary>
    public static class GetTransactionResult_StatusGrpcMarshaller
    {
        // Static constructor to configure type
        static GetTransactionResult_StatusGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.GetTransactionResult_Status
            if (!model.IsDefined(typeof(Stellar.RPC.GetTransactionResult_Status)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.GetTransactionResult_Status), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for GetTransactionResult_Status</summary>
        public static readonly Marshaller<Stellar.RPC.GetTransactionResult_Status> GetTransactionResult_StatusMarshaller = Marshallers.Create<Stellar.RPC.GetTransactionResult_Status>(
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
                        return Serializer.Deserialize<Stellar.RPC.GetTransactionResult_Status>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
