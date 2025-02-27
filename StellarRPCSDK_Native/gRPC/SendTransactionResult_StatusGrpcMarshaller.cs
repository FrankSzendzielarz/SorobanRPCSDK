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
    /// <summary>Custom marshaller for Stellar.RPC.SendTransactionResult_Status</summary>
    public static class SendTransactionResult_StatusGrpcMarshaller
    {
        // Static constructor to configure type
        static SendTransactionResult_StatusGrpcMarshaller()
        {
            ConfigureTypes();
        }

        /// <summary>Configure type serialization</summary>
        public static void ConfigureTypes()
        {
            // Get runtime type model

            var model = RuntimeTypeModel.Default;

            // Configure Stellar.RPC.SendTransactionResult_Status
            if (!model.IsDefined(typeof(Stellar.RPC.SendTransactionResult_Status)))
            {
                var metaType = model.Add(typeof(Stellar.RPC.SendTransactionResult_Status), false);
                metaType.UseConstructor = false;
            }
        }

        /// <summary>Marshaller for Stellar.RPC.SendTransactionResult_Status</summary>
        public static readonly Marshaller<Stellar.RPC.SendTransactionResult_Status> SendTransactionResult_StatusMarshaller = Marshallers.Create<Stellar.RPC.SendTransactionResult_Status>(
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
                        return Serializer.Deserialize<Stellar.RPC.SendTransactionResult_Status>(ms);
                    }
                }
                catch (Exception ex)
                {
                    throw new RpcException(new Status(StatusCode.Internal, $"Deserialization error: {ex.Message}"));
                }
            });

    }
}
